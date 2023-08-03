namespace SP_IPChanger
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.programBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adapterBox = new System.Windows.Forms.ComboBox();
            this.profile = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.adapterMask = new System.Windows.Forms.Label();
            this.adapterIP = new System.Windows.Forms.Label();
            this.launchProgramBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.manual_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.manual_mask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manual_ip = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBoxChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.passInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.loginInput);
            this.groupBox1.Controls.Add(this.delBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.programBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ipInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Location = new System.Drawing.Point(217, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 129);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Pass";
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(314, 68);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(100, 20);
            this.passInput.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Login";
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(215, 68);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(93, 20);
            this.loginInput.TabIndex = 17;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.IndianRed;
            this.delBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.delBtn.Location = new System.Drawing.Point(216, 94);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(200, 23);
            this.delBtn.TabIndex = 23;
            this.delBtn.Text = "Delete Selected";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.DeleteSelected);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.addBtn.Location = new System.Drawing.Point(10, 94);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(200, 23);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add / Edit";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddEntry);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Program";
            // 
            // programBox
            // 
            this.programBox.FormattingEnabled = true;
            this.programBox.Items.AddRange(new object[] {
            "Browser",
            "Panasonic",
            "Slican",
            "Micra",
            "Optima",
            "Libra"});
            this.programBox.Location = new System.Drawing.Point(215, 29);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(199, 21);
            this.programBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "IP";
            // 
            // ipInput
            // 
            this.ipInput.Location = new System.Drawing.Point(10, 68);
            this.ipInput.Name = "ipInput";
            this.ipInput.Size = new System.Drawing.Size(199, 20);
            this.ipInput.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(10, 29);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(199, 20);
            this.nameInput.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.adapterBox);
            this.groupBox2.Location = new System.Drawing.Point(217, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adapter settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select adapter:";
            // 
            // adapterBox
            // 
            this.adapterBox.FormattingEnabled = true;
            this.adapterBox.Location = new System.Drawing.Point(6, 34);
            this.adapterBox.Name = "adapterBox";
            this.adapterBox.Size = new System.Drawing.Size(203, 21);
            this.adapterBox.TabIndex = 1;
            this.adapterBox.SelectedIndexChanged += new System.EventHandler(this.adapterChanged);
            // 
            // profile
            // 
            this.profile.AutoSize = true;
            this.profile.Location = new System.Drawing.Point(77, 104);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(33, 13);
            this.profile.TabIndex = 8;
            this.profile.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Current profile:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programPathsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // programPathsToolStripMenuItem
            // 
            this.programPathsToolStripMenuItem.Name = "programPathsToolStripMenuItem";
            this.programPathsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programPathsToolStripMenuItem.Text = "Program Paths";
            this.programPathsToolStripMenuItem.Click += new System.EventHandler(this.programPathsToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.adapterMask);
            this.groupBox3.Controls.Add(this.adapterIP);
            this.groupBox3.Controls.Add(this.profile);
            this.groupBox3.Controls.Add(this.launchProgramBtn);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(438, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 207);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // adapterMask
            // 
            this.adapterMask.AutoSize = true;
            this.adapterMask.Location = new System.Drawing.Point(6, 147);
            this.adapterMask.Name = "adapterMask";
            this.adapterMask.Size = new System.Drawing.Size(73, 13);
            this.adapterMask.TabIndex = 16;
            this.adapterMask.Text = "Adapter Mask";
            // 
            // adapterIP
            // 
            this.adapterIP.AutoSize = true;
            this.adapterIP.Location = new System.Drawing.Point(6, 125);
            this.adapterIP.Name = "adapterIP";
            this.adapterIP.Size = new System.Drawing.Size(98, 13);
            this.adapterIP.TabIndex = 15;
            this.adapterIP.Text = "Adapter IP Address";
            // 
            // launchProgramBtn
            // 
            this.launchProgramBtn.Location = new System.Drawing.Point(6, 77);
            this.launchProgramBtn.Name = "launchProgramBtn";
            this.launchProgramBtn.Size = new System.Drawing.Size(188, 23);
            this.launchProgramBtn.TabIndex = 14;
            this.launchProgramBtn.Text = "Launch Program";
            this.launchProgramBtn.UseVisualStyleBackColor = true;
            this.launchProgramBtn.Click += new System.EventHandler(this.launchProgramBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Set to DHCP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SetDHCP);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Set Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetSelectedIP);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.manual_btn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.manual_mask);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.manual_ip);
            this.groupBox4.Location = new System.Drawing.Point(217, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 130);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manual IP Setting";
            // 
            // manual_btn
            // 
            this.manual_btn.Location = new System.Drawing.Point(10, 101);
            this.manual_btn.Name = "manual_btn";
            this.manual_btn.Size = new System.Drawing.Size(199, 23);
            this.manual_btn.TabIndex = 17;
            this.manual_btn.Text = "Set Manually";
            this.manual_btn.UseVisualStyleBackColor = true;
            this.manual_btn.Click += new System.EventHandler(this.manual_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mask";
            // 
            // manual_mask
            // 
            this.manual_mask.Location = new System.Drawing.Point(10, 70);
            this.manual_mask.Name = "manual_mask";
            this.manual_mask.Size = new System.Drawing.Size(199, 20);
            this.manual_mask.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "IP Address";
            // 
            // manual_ip
            // 
            this.manual_ip.Location = new System.Drawing.Point(10, 34);
            this.manual_ip.Name = "manual_ip";
            this.manual_ip.Size = new System.Drawing.Size(199, 20);
            this.manual_ip.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 380);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBX IP Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnProcessExit);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox programBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox adapterBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label profile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programPathsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label adapterMask;
        private System.Windows.Forms.Label adapterIP;
        public System.Windows.Forms.Button launchProgramBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button manual_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox manual_mask;
        public System.Windows.Forms.TextBox manual_ip;
    }
}

