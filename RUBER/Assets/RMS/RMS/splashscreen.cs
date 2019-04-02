using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if (rectangleShape2.Width >= 288)
                {
                    timer1.Stop();
                    login l1 = new login();
                    l1.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                return;
            }

        }

        private void splashscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
