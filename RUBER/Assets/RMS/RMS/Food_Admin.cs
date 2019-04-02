using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RMS
{
    public partial class Food_Admin : UserControl
    {
        public Food_Admin()
        {
            InitializeComponent();
        }

        private void Food_Admin_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var itemcount = (from Id in databaseConnection.menus
                             select Id.Id).Count();

            if (itemcount > 0)
            {


                for (var i = 0; i < itemcount; i++)
                {

                    var selectItem = (from Name in databaseConnection.menus
                                      where Name.Id == i + 1
                                      select Name.Name).Single();

                    bunifuDropdown1.AddItem(Convert.ToString(selectItem));
                    bunifuDropdown2.AddItem(Convert.ToString(selectItem));
                    bunifuDropdown5.AddItem(Convert.ToString(selectItem));
                }

                bunifuDropdown1.selectedIndex = 0;
                bunifuDropdown2.selectedIndex = 0;
                bunifuDropdown5.selectedIndex = 0;
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);

            }  
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                // Convert System.Drawing.Image to a byte[]
                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                // Create a System.Data.Linq.Binary - this is what an "image" column is mapped to
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                menu newmenu = new menu()
                {
                    img = file_binary,


                };

                newmenu.Name = bunifuMaterialTextbox1.Text;
                newmenu.Price = int.Parse(bunifuMaterialTextbox2.Text);
                newmenu.Desc = richTextBox1.Text;

                databaseConnection.menus.InsertOnSubmit(newmenu);
            }
            finally
            {
                // Save
                databaseConnection.SubmitChanges();
                MessageBox.Show("Menu Item Added Successfully");
            }




            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var simg = (from img in databaseConnection.menus
                       where img.Id == bunifuDropdown1.selectedIndex + 1
                        select img).Single();

            var stitle = (from Name in databaseConnection.menus
                          where Name.Id == bunifuDropdown1.selectedIndex + 1
                          select Name).Single();

            var sprice = (from Price in databaseConnection.menus
                          where Price.Id == bunifuDropdown1.selectedIndex + 1
                          select Price).Single();

            var sdesc = (from Desc in databaseConnection.menus
                         where Desc.Id == bunifuDropdown1.selectedIndex + 1
                         select Desc).Single();

            var sid = (from Id in databaseConnection.menus
                       where Id.Id == bunifuDropdown1.selectedIndex + 1
                       select Id).Single();

            
            editPicture.Image = ByteArrayToImage(simg.img.ToArray());
            editName.Text = stitle.Name.ToString();
            editPrice.Text = sprice.Price.ToString();
            editDesc.Text = sdesc.Desc.ToString();
            label9.Text = sid.Id.ToString();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                // Convert System.Drawing.Image to a byte[]
                byte[] file_byte = ImageToByteArray(editPicture.Image);
                // Create a System.Data.Linq.Binary - this is what an "image" column is mapped to
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);

                //selectedmenu newmenu = new selectedmenu()
                //{
                //    img = file_binary,


                //};

                menu newmenu = databaseConnection.menus.Single(menus => menus.Id == Convert.ToInt32(label9.Text));

                newmenu.img = file_binary;

                
            

                newmenu.Name = editName.Text;
                newmenu.Price = Convert.ToInt32(editPrice.Text);
                newmenu.Desc = editDesc.Text;
               
                

                
            }
            finally
            {
                // Save
                databaseConnection.SubmitChanges();
                MessageBox.Show("Menu Item Added Successfully");
            }


        }

    

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                editPicture.Image = new Bitmap(open.FileName);

            }  
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void editDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void editPicture_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                var simg = (from img in databaseConnection.menus
                            where img.Id == bunifuDropdown2.selectedIndex + 1
                            select img).Single();

                var stitle = (from Name in databaseConnection.menus
                              where Name.Id == bunifuDropdown2.selectedIndex + 1
                              select Name).Single();

                var sprice = (from Price in databaseConnection.menus
                              where Price.Id == bunifuDropdown2.selectedIndex + 1
                              select Price).Single();

                var sdesc = (from Desc in databaseConnection.menus
                             where Desc.Id == bunifuDropdown2.selectedIndex + 1
                             select Desc).Single();


                selectedmenu newmenu = databaseConnection.selectedmenus.Single(selectedmenus => selectedmenus.Id == Convert.ToInt32(bunifuDropdown3.selectedIndex + 1));

                newmenu.img = simg.img;
                newmenu.Name = stitle.Name;
                newmenu.Price = Convert.ToString(sprice.Price);
                newmenu.Desc = sdesc.Desc;
            }
            finally
            {
                // Save
                databaseConnection.SubmitChanges();
                MessageBox.Show("Menu Item is Featured Now");
            }

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            //menu menuitem = databaseConnection.menus.Single(menus => menus.Id == Convert.ToInt32(bunifuDropdown5.selectedIndex + 1));

            //databaseConnection.menus.DeleteOnSubmit(menuitem);

            //databaseConnection.SubmitChanges();

            var deletedMenu = bunifuDropdown5.selectedValue.ToString();


            bunifuDropdown5.RemoveItem(deletedMenu);
            bunifuDropdown1.RemoveItem(deletedMenu);
            bunifuDropdown2.RemoveItem(deletedMenu);

            MessageBox.Show("Menu Item Deleted");


        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }


        
    }
}
