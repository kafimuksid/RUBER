using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace RMS
{
    public partial class Employees_Admin : UserControl
    {
        public Employees_Admin()
        {
            InitializeComponent();
        }

        private void Employees_Admin_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var userCount = (from Id in databaseConnection.users
                             select Id.email).Count();

            for (var i = 0; i < userCount; i++)
            {

                var selectUser = (from Name in databaseConnection.users
                                  select Name.email).Skip(i).FirstOrDefault();

                bunifuDropdown1.AddItem(Convert.ToString(selectUser));
                
            }

            bunifuDropdown1.selectedIndex = 0;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var userlevel = 4;

            if (userType.selectedValue == "Employee")
            {
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

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            user DeleteUser = databaseConnection.users.FirstOrDefault(emp => emp.email.Equals(bunifuDropdown1.selectedValue));

            databaseConnection.users.DeleteOnSubmit(DeleteUser);

            databaseConnection.SubmitChanges();

            MessageBox.Show("User Deleted");
        }
    }
}
