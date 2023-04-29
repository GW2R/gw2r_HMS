using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gw2r_HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtloginun.Text == "HMS" && txtloginpw.Text == "admin123")
            {
                //page to be loaded after credential checks
                Main main = new Main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtloginun.Clear();
                txtloginpw.Clear();
                txtloginun.Focus();
            }
        }
    }
}