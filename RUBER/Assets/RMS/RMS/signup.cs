using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace RMS
{
    public partial class signup : Form
    {

        

        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            if (Program.userlevel <= 2)
            {

                userType.Visible = true;

            }

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void userType_onItemSelected(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var userlevel = 4;

            if (userType.selectedValue == "Employee") { 
                userlevel = 3;
            }
            else if (userType.selectedValue == "Admin")
            {
                userlevel = 2;
            }
            
            user newuser = new user();

         
            newuser.email = emailTextBox.Text;
            newuser.password = passwordTextBox.Text;
            newuser.usertype = userlevel;

            databaseConnection.users.InsertOnSubmit(newuser);

            databaseConnection.SubmitChanges();

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("rmsproject04@gmail.com", "040404rms"),
                EnableSsl = true
            };

            client.Send("rmsproject04@gmail.com", emailTextBox.Text.TrimStart().TrimEnd(), "Registration Confirmation Email", "Username: " + emailTextBox.Text + "\nPassword: " + passwordTextBox.Text);


            MessageBox.Show("Your registration is successful. Please check your Email address for login credentials.",
                "Registration Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);




            this.Hide();
            login l1 = new login();
            l1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            login l = new login();
            l.Show();
        }
    }
}
