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
    public partial class Orders_Admin : UserControl
    {
        public Orders_Admin()
        {
            InitializeComponent();
        }

        private void Orders_Admin_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var itemcount = (from Id in databaseConnection.orders
                             select Id.orderId).Count();

            if (itemcount > 0)
            {


                for (var i = 0; i < itemcount; i++)
                {

                    var selectItem = (from selectorder in databaseConnection.orders
                                      where selectorder.Id == i
                                      select selectorder.orderId).Single();

                    bunifuDropdown1.AddItem(Convert.ToString(selectItem));

                }

                bunifuDropdown1.selectedIndex = 0;
            }



            var orderlist = from orderentry in databaseConnection.orders
                            select orderentry;

            bunifuCustomDataGrid1.DataSource = orderlist;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {


                order selectedorder = databaseConnection.orders.FirstOrDefault(orders => orders.orderId == Convert.ToInt32(bunifuDropdown1.selectedValue));


                selectedorder.orderStatus = bunifuDropdown2.selectedValue;




            }
            finally
            {
                // Save
                databaseConnection.SubmitChanges();
                MessageBox.Show("Order Status Updated Successfully");
               

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var orderlist = from orderentry in databaseConnection.orders
                            select orderentry;

            bunifuCustomDataGrid1.DataSource = null;
            bunifuCustomDataGrid1.DataSource = orderlist;

        }
    }
}
