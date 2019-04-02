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
    public partial class Orders_User : UserControl
    {


        public Orders_User()
        {
            InitializeComponent();
            timer1.Enabled=false;
        }

        private void Orders_User_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var orderlist = from orderentry in databaseConnection.orders
                            where orderentry.orderuser == Program.loggedin
                            select orderentry;

            bunifuCustomDataGrid1.DataSource = orderlist;


        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var orderlist = from orderentry in databaseConnection.orders
                            where orderentry.orderuser == Program.loggedin
                            select orderentry;

            bunifuCustomDataGrid1.DataSource = orderlist;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            var orderlist = from orderentry in databaseConnection.orders
                            where orderentry.orderuser == Program.loggedin
                            select orderentry;

            bunifuCustomDataGrid1.DataSource = null;
            bunifuCustomDataGrid1.DataSource = orderlist;
            

        }
    }
}
