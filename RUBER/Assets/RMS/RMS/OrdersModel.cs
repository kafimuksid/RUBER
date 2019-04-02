using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class OrdersModel
    {
        public String selectedFood;
        public int foodQuantity;
        public int singleunitPrice;
        public int totalPrice;
        public String orderStatus = "pending";

        public void itemTotal() {

            this.totalPrice = foodQuantity * singleunitPrice;
            Program.totalbill = Program.totalbill + totalPrice;
        
        }


        public void addOrder()
        {

            DataClasses1DataContext databaseConnection = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\shadman\Desktop\RUBER\Assets\RMS\RMS\RMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            order singleorder = new order();

            singleorder.foodName = this.selectedFood;
            singleorder.orderId = Program.orderId;
            singleorder.foodQuantity = this.foodQuantity;
            singleorder.itemTotal = this.totalPrice;
            singleorder.orderStatus = this.orderStatus;
            singleorder.orderuser = Program.loggedin;
            Program.fooditems.Add(this.selectedFood + "( " + Convert.ToString(this.foodQuantity) + " ) ------>" + Convert.ToString(this.totalPrice));

            databaseConnection.orders.InsertOnSubmit(singleorder);

            // Save
            databaseConnection.SubmitChanges();

        }
        


    }
}
