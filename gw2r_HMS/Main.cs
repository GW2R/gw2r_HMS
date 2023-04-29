using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace gw2r_HMS
{
    public partial class Main : Form
    {
        //event handlers
        Thread th;
        public static Main obj;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //disable menustrip items until user login
            tsPatients.Enabled = false;
            tsReports.Enabled = false;
            tsSettings.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            obj = this;
            //disable form max function
            MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd-MMMM-yy | HH:mm:ss");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //enable menustrip items after login
            try
            {
                Cursor = Cursors.WaitCursor;
                Login lg = new Login();
                lg.ShowDialog();
                tsPatients.Enabled = true;
                tsReports.Enabled = true;
                tsSettings.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;

            }
            catch (Exception)            
            { }
            Cursor.Current = Cursors.Default;
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //used to close current instance without terminating the program
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform (object obj)
        {
            Application.Run(new Main());
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void patiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatReg frm = new frmPatReg()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void consulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsul frm = new frmConsul()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}