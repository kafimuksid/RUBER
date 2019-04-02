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
    public partial class Food_Customer : UserControl
    {
        public Food_Customer()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OrdersModel slot1Order = new OrdersModel();

            slot1Order.selectedFood = slotTitle1.Text;
            slot1Order.foodQuantity = Convert.ToInt32(numericUpDown1.Value);
            slot1Order.singleunitPrice = Convert.ToInt32(slotPrice1.Text);

            slot1Order.itemTotal();

            slot1Order.addOrder();

            

            MessageBox.Show("Order Added to Cart");
        }

        private void Food_Customer_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            PictureBox[] boxes = {  slotImg1, slotImg2, slotImg3, slotImg4, slotImg5, slotImg6 };
            Label[] title = { slotTitle1, slotTitle2, slotTitle3, slotTitle4, slotTitle5, slotTitle6 };
            Label[] price = { slotPrice1, slotPrice2, slotPrice3, slotPrice4, slotPrice5, slotPrice6 };
            RichTextBox[] desc = { slotDesc1, slotDesc2, slotDesc3, slotDesc4, slotDesc5, slotDesc6 };

            for (var i = 1; i <= 6; i++)
            {



                var simg = (from img in databaseConnection.selectedmenus
                            where img.Id == i
                            select img).Single();

                var stitle = (from Name in databaseConnection.selectedmenus
                            where Name.Id == i
                            select Name).Single();

                var sprice = (from Price in databaseConnection.selectedmenus
                              where Price.Id == i
                              select Price).Single();

                var sdesc = (from Desc in databaseConnection.selectedmenus
                              where Desc.Id == i
                              select Desc).Single();
                // Convert the byte[] to an System.Drawing.Image


               boxes[i - 1].Image = ByteArrayToImage(simg.img.ToArray());
               title[i - 1].Text = stitle.Name.ToString();
               price[i - 1].Text = sprice.Price.ToString();
               desc[i - 1].Text = sdesc.Desc.ToString();
            }

        }


        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void slotPrice2_Click(object sender, EventArgs e)
        {

        }

        private void slotPrice3_Click(object sender, EventArgs e)
        {

        }

        private void slotPrice6_Click(object sender, EventArgs e)
        {

        }

        private void slotPrice5_Click(object sender, EventArgs e)
        {

        }

        private void slotPrice4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void slotImg6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OrdersModel slot2Order = new OrdersModel();

            slot2Order.selectedFood = slotTitle2.Text;
            slot2Order.foodQuantity = Convert.ToInt32(numericUpDown2.Value);
            slot2Order.singleunitPrice = Convert.ToInt32(slotPrice2.Text);

            slot2Order.itemTotal();

            slot2Order.addOrder();

            MessageBox.Show("Order Added to Cart");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OrdersModel slot3Order = new OrdersModel();

            slot3Order.selectedFood = slotTitle3.Text;
            slot3Order.foodQuantity = Convert.ToInt32(numericUpDown3.Value);
            slot3Order.singleunitPrice = Convert.ToInt32(slotPrice3.Text);

            slot3Order.itemTotal();

            slot3Order.addOrder();

            MessageBox.Show("Order Added to Cart");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OrdersModel slot4Order = new OrdersModel();

            slot4Order.selectedFood = slotTitle4.Text;
            slot4Order.foodQuantity = Convert.ToInt32(numericUpDown4.Value);
            slot4Order.singleunitPrice = Convert.ToInt32(slotPrice4.Text);

            slot4Order.itemTotal();

            slot4Order.addOrder();

            MessageBox.Show("Order Added to Cart");
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OrdersModel slot5Order = new OrdersModel();

            slot5Order.selectedFood = slotTitle5.Text;
            slot5Order.foodQuantity = Convert.ToInt32(numericUpDown5.Value);
            slot5Order.singleunitPrice = Convert.ToInt32(slotPrice5.Text);

            slot5Order.itemTotal();

            slot5Order.addOrder();

            MessageBox.Show("Order Added to Cart");
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            OrdersModel slot6Order = new OrdersModel();

            slot6Order.selectedFood = slotTitle6.Text;
            slot6Order.foodQuantity = Convert.ToInt32(numericUpDown6.Value);
            slot6Order.singleunitPrice = Convert.ToInt32(slotPrice6.Text);

            slot6Order.itemTotal();

            slot6Order.addOrder();

            MessageBox.Show("Order Added to Cart");

        }

    }
}
