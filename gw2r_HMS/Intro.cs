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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent(); 
            //set progress position to 0%
            circularProgressBar1.Value = 0;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //create counting effect as progress bar moves
            circularProgressBar1.Value += 1;
            label4.Text = circularProgressBar1.Value.ToString() + "%";
            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Main Main = new Main();
                Main.Show();
                this.Hide();
            }
        }
    }
}
