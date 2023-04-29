namespace gw2r_HMS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.PatRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReports = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHome,
            this.tsPatients,
            this.tsReports,
            this.tsSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1426, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHome
            // 
            this.tsHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHome.Image = global::gw2r_HMS.Properties.Resources.Home;
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(81, 24);
            this.tsHome.Text = "Home";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // tsPatients
            // 
            this.tsPatients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatRegToolStripMenuItem,
            this.consulToolStripMenuItem});
            this.tsPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPatients.Image = global::gw2r_HMS.Properties.Resources.Sharing_Overlay;
            this.tsPatients.Name = "tsPatients";
            this.tsPatients.Size = new System.Drawing.Size(93, 24);
            this.tsPatients.Text = "Patients";
            // 
            // PatRegToolStripMenuItem
            // 
            this.PatRegToolStripMenuItem.Name = "PatRegToolStripMenuItem";
            this.PatRegToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.PatRegToolStripMenuItem.Text = "Registration";
            this.PatRegToolStripMenuItem.Click += new System.EventHandler(this.patiToolStripMenuItem_Click);
            // 
            // consulToolStripMenuItem
            // 
            this.consulToolStripMenuItem.Name = "consulToolStripMenuItem";
            this.consulToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.consulToolStripMenuItem.Text = "Consultation";
            this.consulToolStripMenuItem.Click += new System.EventHandler(this.consulToolStripMenuItem_Click);
            // 
            // tsReports
            // 
            this.tsReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem1,
            this.medicalCertificateToolStripMenuItem,
            this.labTestToolStripMenuItem});
            this.tsReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReports.Image = global::gw2r_HMS.Properties.Resources.Printer;
            this.tsReports.Name = "tsReports";
            this.tsReports.Size = new System.Drawing.Size(93, 24);
            this.tsReports.Text = "Reports";
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.historyToolStripMenuItem1.Text = "Appointments";
            // 
            // medicalCertificateToolStripMenuItem
            // 
            this.medicalCertificateToolStripMenuItem.Name = "medicalCertificateToolStripMenuItem";
            this.medicalCertificateToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.medicalCertificateToolStripMenuItem.Text = "Medical Certificate";
            // 
            // labTestToolStripMenuItem
            // 
            this.labTestToolStripMenuItem.Name = "labTestToolStripMenuItem";
            this.labTestToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.labTestToolStripMenuItem.Text = "Lab Test";
            // 
            // tsSettings
            // 
            this.tsSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.tsSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSettings.Image = global::gw2r_HMS.Properties.Resources.Run;
            this.tsSettings.Name = "tsSettings";
            this.tsSettings.Size = new System.Drawing.Size(93, 24);
            this.tsSettings.Text = "Settings";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "date-time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(19, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 651);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::gw2r_HMS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicalCertificateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem tsPatients;
        public System.Windows.Forms.ToolStripMenuItem tsReports;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSettings;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatRegToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

