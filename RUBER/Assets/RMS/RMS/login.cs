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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Boolean x = false;
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            
            user newuser = new user();

            var check = (from a in databaseConnection.users
                        where a.email == loginEmailTextBox.Text && a.password == loginPasswordTextBox.Text
                        select a);

            

            if (check.Any())
            {
                x = true;
            }
            else { x = false; }
            if (x)
            {
                var luser = (from a in databaseConnection.users
                             where a.email == loginEmailTextBox.Text && a.password == loginPasswordTextBox.Text
                             select a).Single();

                Program.loggedin = luser.email;
                Program.userlevel = luser.usertype;
                Dashboard db = new Dashboard();
                db.Show();
            }
            else { MessageBox.Show("Invalid Username or Password!"); }
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup s = new signup();
            s.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginPasswordTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void loginEmailTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void signupRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
