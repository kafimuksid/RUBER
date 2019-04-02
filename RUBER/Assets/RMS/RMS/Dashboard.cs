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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            Random rnd = new Random();

            InitializeComponent();
            food_Customer1.BringToFront();
            label1.Text = "Welcome, " + Program.loggedin;
            Program.orderId = rnd.Next(10000,99999);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (Program.userlevel > 3) {

               
                employeesMenu.Visible = false;
                foodsAdminMenu.Visible = false;
                orderAdminMenu.Visible = false;
            
            }


          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            food_Customer1.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            bills_User1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void food_Customer1_Load(object sender, EventArgs e)
        {

        }

        private void food_Admin1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            food_Admin1.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void food_Admin1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderMenu_Click(object sender, EventArgs e)
        {
            orders_User1.BringToFront();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            orders_Admin1.BringToFront();
        }

        private void bunifuFlatButton1_Click_3(object sender, EventArgs e)
        {
            Dashboard ss = new Dashboard();

            ss.Show();
            this.Hide();
        }

        private void employeesMenu_Click(object sender, EventArgs e)
        {
            employees_Admin1.BringToFront();
        }

        private void employeesMenu_Click_1(object sender, EventArgs e)
        {
            employees_Admin1.BringToFront();
        }

        

      
    }
}
