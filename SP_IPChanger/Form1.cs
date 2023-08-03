using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SP_IPChanger
{
    public partial class Form1 : Form
    {

        public static string settingsFile = Directory.GetCurrentDirectory() + "/data.xml";
        public static Settings settings = new Settings();
        public Timer adapterTimer = new Timer();
        public Settings.PBXEntry currentProfile = null;
        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
            GetAdapters();
            LoadSettings();
            adapterTimer.Tick += new EventHandler(adapterTimer_Tick);
            adapterTimer.Interval = 10 * 1000;
            adapterTimer.Start();
            adapterTimer_Tick(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void SetSelectedIP(object sender, EventArgs e)
        {
            Settings.PBXEntry selected = GetSelectedEntry();
            String fullIp = selected.IP;
            String[] ipDb = fullIp.Split('.');
            if (ipDb.Length < 1) return;
            String newIp = ipDb[0] + "." + ipDb[1] + "." + ipDb[2];
            int ipEnd = new Random().Next(1, 255);
            newIp += "." + ipEnd;
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.FileName = "netsh";
            info.Arguments = "interface ip set address \"" + settings.adapter + "\" static " + newIp + " 255.255.255.0 none 1";
            info.Verb = "runas";
            p.StartInfo = info;
            p.Start();
            profile.Text = selected.Name;
            currentProfile = selected;
            adapterTimer_Tick(this, EventArgs.Empty);
        }

        public void SetDHCP(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + settings.adapter + "\" dhcp");
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;
            p.Start();
            profile.Text = "DHCP";
            currentProfile = null;
            adapterTimer_Tick(this, EventArgs.Empty);
        }

        public void GetAdapters()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            adapterBox.Items.Clear();
            foreach (NetworkInterface adapter in adapters)
            {
                adapterBox.Items.Add(adapter.Name);
            }
        }

        public Settings.PBXEntry GetSelectedEntry()
        {
            String selectedName = listBox1.SelectedItem.ToString();
            foreach(Settings.PBXEntry entry in settings.entries)
            {
                if (entry.Name == selectedName) return entry;
            }
            return null;
        }

        private void AddEntry(object sender, EventArgs e)
        {
            if (HasInList(nameInput.Text))
            {
                foreach(Settings.PBXEntry entry in settings.entries)
                {
                    if (entry.Name == nameInput.Text)
                    {
                        entry.IP = ipInput.Text;
                        entry.Program = programBox.Text;
                        entry.login = loginInput.Text;
                        entry.password = passInput.Text;
                    }
                }
            } else
            {
                Settings.PBXEntry newEntry = new Settings.PBXEntry()
                {
                    Name = nameInput.Text,
                    IP = ipInput.Text,
                    Program = programBox.Text,
                    login = loginInput.Text,
                    password = passInput.Text
                };
                settings.entries.Add(newEntry);
            }
            UpdateList();
            SaveSettings();
        }

        public void UpdateList()
        {
            listBox1.Items.Clear();
            foreach(Settings.PBXEntry entry in settings.entries)
            {
                listBox1.Items.Add(entry.Name);
            }
        }

        public bool HasInList(String name)
        {
            foreach (Settings.PBXEntry entry in settings.entries)
            {
                if (entry.Name.Equals(name)) return true;
            }
            return false;
        }

        private void DeleteSelected(object sender, EventArgs e)
        {
            String selectedName = listBox1.SelectedItem.ToString();
            foreach(Settings.PBXEntry entry in settings.entries)
            {
                if (entry.Name == selectedName)
                {
                    settings.entries.Remove(entry);
                }
            }
            SaveSettings();
        }

        public void LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                Console.WriteLine("Opening settings file");
                settings = GetSettings();
                if (settings != null)
                {
                    if (settings.adapter != null && settings.adapter.Length > 0)
                    {
                        adapterBox.SelectedIndex = adapterBox.FindStringExact(settings.adapter);
                    }
                    
                }
                UpdateList();
            } else
            {
                Console.WriteLine("Could not find settings file");
                settings = new Settings();
            }
        }


        public Settings GetSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (Stream reader = new FileStream(settingsFile, FileMode.OpenOrCreate))
            {
                return (Settings)serializer.Deserialize(reader);
            }
        }

        public void SaveSettings()
        {
            Console.WriteLine("Saving settings");
            settings.adapter = adapterBox.SelectedItem.ToString();
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            FileStream file = System.IO.File.Create(settingsFile);
            serializer.Serialize(file, settings);
            file.Close();
            Console.WriteLine("Saved");
        }


        public void adapterTimer_Tick(object sender, EventArgs e)
        {
            foreach(NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (settings != null && settings.adapter != null && adapter.Name != null && adapter.Name == settings.adapter)
                {
                    foreach(UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            adapterIP.Text = "Adapter IP Address: " + ip.Address.ToString();
                            adapterMask.Text = "Adapter Mask: " + ip.IPv4Mask.ToString();
                            if (manual_ip.Text.Length < 1) manual_ip.Text = ip.Address.ToString();
                            if (manual_mask.Text.Length < 1) manual_mask.Text = ip.IPv4Mask.ToString();
                        }
                    }
                    
                }
            }
        }


        public void ListBoxChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Settings.PBXEntry selectedEntry = GetSelectedEntry();
                if (selectedEntry != null)
                {
                    nameInput.Text = selectedEntry.Name;
                    ipInput.Text = selectedEntry.IP;
                    programBox.SelectedIndex = programBox.FindStringExact(selectedEntry.Program);
                    loginInput.Text = selectedEntry.login;
                    passInput.Text = selectedEntry.password;
                }
            }
        }

        public String GetProgramPath(String programName)
        {
            foreach(Settings.ProgramPath p in settings.programPaths)
            {
                if (p.Path != null)
                {
                    Console.WriteLine("Current program " + p.Name + ", Path: " + p.Path);
                    if (p.Name.Equals(programName)) return p.Path.ToString();
                }
            }
            return "";
        }

        private void OnProcessExit(object sender, FormClosingEventArgs e)
        {
            //SaveSettings();
        }

        private void adapterChanged(object sender, EventArgs e)
        {
            settings.adapter = adapterBox.SelectedItem.ToString();
            adapterTimer_Tick(this, EventArgs.Empty);
        }

        private void programPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramPathsForm programPathsForm = new ProgramPathsForm();
            programPathsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void launchProgramBtn_Click(object sender, EventArgs e)
        {
            if (currentProfile != null)
            {
                String appPath = GetProgramPath(currentProfile.Program);
                if (appPath == "") { Console.WriteLine("AppPath for " + currentProfile.Program + " is empty"); return; }
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                switch (currentProfile.Program)
                {
                    case "Browser":
                        info.Arguments = "http://" + currentProfile.IP + "/";
                        break;
                    default:
                        break;
                }
                info.FileName = appPath;
                p.StartInfo = info;
                p.Start();
            }
        }

        private void manual_btn_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.FileName = "netsh";
            info.Arguments = "interface ip set address \"" + settings.adapter + "\" static " + manual_ip.Text + " " + manual_mask.Text + " none 1";
            info.Verb = "runas";
            p.StartInfo = info;
            p.Start();
            profile.Text = "Manual";
            currentProfile = null;
            adapterTimer_Tick(this, EventArgs.Empty);
        }
    }
}
