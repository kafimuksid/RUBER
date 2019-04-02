using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class Bills_User : UserControl
    {
        public Bills_User()
        {
            
            InitializeComponent();
        }

        private void Bills_User_Load(object sender, EventArgs e)
        {

          
            
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

           
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            label1.Text = Convert.ToString(Program.totalbill);

            for (int i = 0; i < Program.fooditems.Count; i++)
            {

                listBox1.Items.Insert(i, Program.fooditems[i]);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
