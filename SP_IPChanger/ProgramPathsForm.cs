using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_IPChanger
{
    public partial class ProgramPathsForm : Form
    {
        public ProgramPathsForm()
        {
            InitializeComponent();
            foreach(Settings.ProgramPath p in Form1.settings.programPaths)
            {
                switch(p.Name)
                {
                    case "Browser":
                        browser_Path.Text = p.Path;
                        break;
                    case "Panasonic":
                        panasonic_Path.Text = p.Path;
                        break;
                    case "Slican":
                        slican_Path.Text = p.Path;
                        break;
                    case "Micra":
                        micra_Path.Text = p.Path;
                        break;
                    case "Optima":
                        optima_Path.Text = p.Path;
                        break;
                    case "Libra":
                        libra_Path.Text = p.Path;
                        break;
                }
            }
        }


        public void populatePath(TextBox tb)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Application (*.exe)|*.*";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = ofd.FileName;
            }
        }

        private void browser_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(browser_Path);
        }

        private void slican_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(slican_Path);
        }

        private void panasonic_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(panasonic_Path);
        }

        private void micra_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(micra_Path);
        }

        private void optima_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(optima_Path);
        }

        private void libra_BrowseBtn_Click(object sender, EventArgs e)
        {
            populatePath(libra_Path);
        }

        private void programPaths_SaveBtn_Click(object sender, EventArgs e)
        {
            // Save and close form
            foreach(Settings.ProgramPath path in Form1.settings.programPaths)
            {
                switch(path.Name)
                {
                    case "Browser":
                        path.Path = browser_Path.Text;
                        break;
                    case "Panasonic":
                        path.Path = panasonic_Path.Text;
                        break;
                    case "Slican":
                        path.Path = slican_Path.Text;
                        break;
                    case "Micra":
                        path.Path = micra_Path.Text;
                        break;
                    case "Optima":
                        path.Path = optima_Path.Text;
                        break;
                    case "Libra":
                        path.Path = libra_Path.Text;
                        break;
                }
            }
            Form1.instance.SaveSettings();
            this.Close();
        }
    }
}
