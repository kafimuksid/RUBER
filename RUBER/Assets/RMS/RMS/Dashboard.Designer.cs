namespace RMS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employeesMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.orderMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billsMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.foodItemMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderAdminMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.foodsAdminMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employees_Admin1 = new RMS.Employees_Admin();
            this.bills_User1 = new RMS.Bills_User();
            this.orders_Admin1 = new RMS.Orders_Admin();
            this.orders_User1 = new RMS.Orders_User();
            this.food_Admin1 = new RMS.Food_Admin();
            this.food_Customer1 = new RMS.Food_Customer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.employeesMenu);
            this.panel1.Controls.Add(this.orderMenu);
            this.panel1.Controls.Add(this.billsMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.foodItemMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 793);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 10;
            this.bunifuFlatButton1.IconMarginRight = 20;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(13, 566);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(253, 48);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_3);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Logout";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 10;
            this.bunifuFlatButton6.IconMarginRight = 20;
            this.bunifuFlatButton6.IconRightVisible = false;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 70D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(13, 620);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(253, 48);
            this.bunifuFlatButton6.TabIndex = 12;
            this.bunifuFlatButton6.Text = "Logout";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // employeesMenu
            // 
            this.employeesMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.employeesMenu.BackColor = System.Drawing.Color.Transparent;
            this.employeesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeesMenu.BorderRadius = 0;
            this.employeesMenu.ButtonText = "Employees";
            this.employeesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeesMenu.DisabledColor = System.Drawing.Color.Gray;
            this.employeesMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.employeesMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("employeesMenu.Iconimage")));
            this.employeesMenu.Iconimage_right = null;
            this.employeesMenu.Iconimage_right_Selected = null;
            this.employeesMenu.Iconimage_Selected = null;
            this.employeesMenu.IconMarginLeft = 10;
            this.employeesMenu.IconMarginRight = 20;
            this.employeesMenu.IconRightVisible = false;
            this.employeesMenu.IconRightZoom = 0D;
            this.employeesMenu.IconVisible = true;
            this.employeesMenu.IconZoom = 70D;
            this.employeesMenu.IsTab = false;
            this.employeesMenu.Location = new System.Drawing.Point(9, 399);
            this.employeesMenu.Name = "employeesMenu";
            this.employeesMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.employeesMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.employeesMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.employeesMenu.selected = false;
            this.employeesMenu.Size = new System.Drawing.Size(253, 48);
            this.employeesMenu.TabIndex = 11;
            this.employeesMenu.Text = "Employees";
            this.employeesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesMenu.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.employeesMenu.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesMenu.Click += new System.EventHandler(this.employeesMenu_Click_1);
            // 
            // orderMenu
            // 
            this.orderMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.orderMenu.BackColor = System.Drawing.Color.Transparent;
            this.orderMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderMenu.BorderRadius = 0;
            this.orderMenu.ButtonText = "Orders";
            this.orderMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderMenu.DisabledColor = System.Drawing.Color.Gray;
            this.orderMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.orderMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("orderMenu.Iconimage")));
            this.orderMenu.Iconimage_right = null;
            this.orderMenu.Iconimage_right_Selected = null;
            this.orderMenu.Iconimage_Selected = null;
            this.orderMenu.IconMarginLeft = 10;
            this.orderMenu.IconMarginRight = 20;
            this.orderMenu.IconRightVisible = false;
            this.orderMenu.IconRightZoom = 0D;
            this.orderMenu.IconVisible = true;
            this.orderMenu.IconZoom = 70D;
            this.orderMenu.IsTab = false;
            this.orderMenu.Location = new System.Drawing.Point(12, 291);
            this.orderMenu.Name = "orderMenu";
            this.orderMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.orderMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.orderMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.orderMenu.selected = false;
            this.orderMenu.Size = new System.Drawing.Size(253, 48);
            this.orderMenu.TabIndex = 5;
            this.orderMenu.Text = "Orders";
            this.orderMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderMenu.Textcolor = System.Drawing.Color.White;
            this.orderMenu.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMenu.Click += new System.EventHandler(this.orderMenu_Click);
            // 
            // billsMenu
            // 
            this.billsMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.billsMenu.BackColor = System.Drawing.Color.Transparent;
            this.billsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.billsMenu.BorderRadius = 0;
            this.billsMenu.ButtonText = "Bills";
            this.billsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billsMenu.DisabledColor = System.Drawing.Color.Gray;
            this.billsMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.billsMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("billsMenu.Iconimage")));
            this.billsMenu.Iconimage_right = null;
            this.billsMenu.Iconimage_right_Selected = null;
            this.billsMenu.Iconimage_Selected = null;
            this.billsMenu.IconMarginLeft = 10;
            this.billsMenu.IconMarginRight = 20;
            this.billsMenu.IconRightVisible = false;
            this.billsMenu.IconRightZoom = 0D;
            this.billsMenu.IconVisible = true;
            this.billsMenu.IconZoom = 70D;
            this.billsMenu.IsTab = false;
            this.billsMenu.Location = new System.Drawing.Point(10, 345);
            this.billsMenu.Name = "billsMenu";
            this.billsMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.billsMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.billsMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.billsMenu.selected = false;
            this.billsMenu.Size = new System.Drawing.Size(253, 48);
            this.billsMenu.TabIndex = 3;
            this.billsMenu.Text = "Bills";
            this.billsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billsMenu.Textcolor = System.Drawing.Color.White;
            this.billsMenu.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsMenu.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.panel3.Location = new System.Drawing.Point(0, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 48);
            this.panel3.TabIndex = 2;
            // 
            // foodItemMenu
            // 
            this.foodItemMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.foodItemMenu.BackColor = System.Drawing.Color.Transparent;
            this.foodItemMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodItemMenu.BorderRadius = 0;
            this.foodItemMenu.ButtonText = "Foods";
            this.foodItemMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodItemMenu.DisabledColor = System.Drawing.Color.Gray;
            this.foodItemMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.foodItemMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("foodItemMenu.Iconimage")));
            this.foodItemMenu.Iconimage_right = null;
            this.foodItemMenu.Iconimage_right_Selected = null;
            this.foodItemMenu.Iconimage_Selected = null;
            this.foodItemMenu.IconMarginLeft = 10;
            this.foodItemMenu.IconMarginRight = 20;
            this.foodItemMenu.IconRightVisible = false;
            this.foodItemMenu.IconRightZoom = 0D;
            this.foodItemMenu.IconVisible = true;
            this.foodItemMenu.IconZoom = 70D;
            this.foodItemMenu.IsTab = false;
            this.foodItemMenu.Location = new System.Drawing.Point(13, 233);
            this.foodItemMenu.Name = "foodItemMenu";
            this.foodItemMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.foodItemMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.foodItemMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.foodItemMenu.selected = false;
            this.foodItemMenu.Size = new System.Drawing.Size(253, 48);
            this.foodItemMenu.TabIndex = 0;
            this.foodItemMenu.Text = "Foods";
            this.foodItemMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodItemMenu.Textcolor = System.Drawing.Color.White;
            this.foodItemMenu.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodItemMenu.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.orderAdminMenu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.foodsAdminMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 31);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // orderAdminMenu
            // 
            this.orderAdminMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.orderAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.orderAdminMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderAdminMenu.BorderRadius = 0;
            this.orderAdminMenu.ButtonText = "Edit Order";
            this.orderAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderAdminMenu.DisabledColor = System.Drawing.Color.Gray;
            this.orderAdminMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.orderAdminMenu.Iconimage = null;
            this.orderAdminMenu.Iconimage_right = null;
            this.orderAdminMenu.Iconimage_right_Selected = null;
            this.orderAdminMenu.Iconimage_Selected = null;
            this.orderAdminMenu.IconMarginLeft = 0;
            this.orderAdminMenu.IconMarginRight = 0;
            this.orderAdminMenu.IconRightVisible = true;
            this.orderAdminMenu.IconRightZoom = 0D;
            this.orderAdminMenu.IconVisible = true;
            this.orderAdminMenu.IconZoom = 90D;
            this.orderAdminMenu.IsTab = false;
            this.orderAdminMenu.Location = new System.Drawing.Point(119, 3);
            this.orderAdminMenu.Name = "orderAdminMenu";
            this.orderAdminMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.orderAdminMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.orderAdminMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.orderAdminMenu.selected = false;
            this.orderAdminMenu.Size = new System.Drawing.Size(101, 25);
            this.orderAdminMenu.TabIndex = 2;
            this.orderAdminMenu.Text = "Edit Order";
            this.orderAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderAdminMenu.Textcolor = System.Drawing.Color.White;
            this.orderAdminMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderAdminMenu.Click += new System.EventHandler(this.bunifuFlatButton1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(777, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, shadman.skb@gmail.com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // foodsAdminMenu
            // 
            this.foodsAdminMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.foodsAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.foodsAdminMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodsAdminMenu.BorderRadius = 0;
            this.foodsAdminMenu.ButtonText = "Edit Foods";
            this.foodsAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodsAdminMenu.DisabledColor = System.Drawing.Color.Gray;
            this.foodsAdminMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.foodsAdminMenu.Iconimage = null;
            this.foodsAdminMenu.Iconimage_right = null;
            this.foodsAdminMenu.Iconimage_right_Selected = null;
            this.foodsAdminMenu.Iconimage_Selected = null;
            this.foodsAdminMenu.IconMarginLeft = 0;
            this.foodsAdminMenu.IconMarginRight = 0;
            this.foodsAdminMenu.IconRightVisible = true;
            this.foodsAdminMenu.IconRightZoom = 0D;
            this.foodsAdminMenu.IconVisible = true;
            this.foodsAdminMenu.IconZoom = 90D;
            this.foodsAdminMenu.IsTab = false;
            this.foodsAdminMenu.Location = new System.Drawing.Point(12, 3);
            this.foodsAdminMenu.Name = "foodsAdminMenu";
            this.foodsAdminMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.foodsAdminMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.foodsAdminMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.foodsAdminMenu.selected = false;
            this.foodsAdminMenu.Size = new System.Drawing.Size(101, 25);
            this.foodsAdminMenu.TabIndex = 0;
            this.foodsAdminMenu.Text = "Edit Foods";
            this.foodsAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodsAdminMenu.Textcolor = System.Drawing.Color.White;
            this.foodsAdminMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodsAdminMenu.Click += new System.EventHandler(this.bunifuFlatButton7_Click_1);
            // 
            // employees_Admin1
            // 
            this.employees_Admin1.Location = new System.Drawing.Point(265, 29);
            this.employees_Admin1.Name = "employees_Admin1";
            this.employees_Admin1.Size = new System.Drawing.Size(1109, 764);
            this.employees_Admin1.TabIndex = 6;
            // 
            // bills_User1
            // 
            this.bills_User1.BackColor = System.Drawing.Color.White;
            this.bills_User1.Location = new System.Drawing.Point(276, 35);
            this.bills_User1.Name = "bills_User1";
            this.bills_User1.Size = new System.Drawing.Size(1088, 753);
            this.bills_User1.TabIndex = 5;
            // 
            // orders_Admin1
            // 
            this.orders_Admin1.Location = new System.Drawing.Point(276, 35);
            this.orders_Admin1.Name = "orders_Admin1";
            this.orders_Admin1.Size = new System.Drawing.Size(1088, 753);
            this.orders_Admin1.TabIndex = 4;
            // 
            // orders_User1
            // 
            this.orders_User1.Location = new System.Drawing.Point(274, 37);
            this.orders_User1.Name = "orders_User1";
            this.orders_User1.Size = new System.Drawing.Size(1088, 753);
            this.orders_User1.TabIndex = 3;
            // 
            // food_Admin1
            // 
            this.food_Admin1.BackColor = System.Drawing.Color.White;
            this.food_Admin1.Location = new System.Drawing.Point(274, 40);
            this.food_Admin1.Name = "food_Admin1";
            this.food_Admin1.Size = new System.Drawing.Size(1078, 753);
            this.food_Admin1.TabIndex = 2;
            this.food_Admin1.Load += new System.EventHandler(this.food_Admin1_Load_1);
            // 
            // food_Customer1
            // 
            this.food_Customer1.BackColor = System.Drawing.Color.White;
            this.food_Customer1.Location = new System.Drawing.Point(271, 37);
            this.food_Customer1.Name = "food_Customer1";
            this.food_Customer1.Size = new System.Drawing.Size(1081, 754);
            this.food_Customer1.TabIndex = 1;
            this.food_Customer1.Load += new System.EventHandler(this.food_Customer1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 793);
            this.Controls.Add(this.employees_Admin1);
            this.Controls.Add(this.bills_User1);
            this.Controls.Add(this.orders_Admin1);
            this.Controls.Add(this.orders_User1);
            this.Controls.Add(this.food_Admin1);
            this.Controls.Add(this.food_Customer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton foodItemMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton employeesMenu;
        private Bunifu.Framework.UI.BunifuFlatButton orderMenu;
        private Bunifu.Framework.UI.BunifuFlatButton billsMenu;
        private Food_Customer food_Customer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton foodsAdminMenu;
        private Food_Admin food_Admin1;
        private System.Windows.Forms.Label label1;
        private Orders_User orders_User1;
        private Bunifu.Framework.UI.BunifuFlatButton orderAdminMenu;
        private Orders_Admin orders_Admin1;
        private Bills_User bills_User1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Employees_Admin employees_Admin1;
    }
}