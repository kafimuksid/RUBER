namespace RMS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.signupRightPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginPasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginEmailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginUserType = new Bunifu.Framework.UI.BunifuDropdown();
            this.signupLeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.signupLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signupRightPanel
            // 
            this.signupRightPanel.BackColor = System.Drawing.Color.White;
            this.signupRightPanel.Controls.Add(this.linkLabel1);
            this.signupRightPanel.Controls.Add(this.label1);
            this.signupRightPanel.Controls.Add(this.pictureBox2);
            this.signupRightPanel.Controls.Add(this.loginPasswordTextBox);
            this.signupRightPanel.Controls.Add(this.loginButton);
            this.signupRightPanel.Controls.Add(this.loginEmailTextBox);
            this.signupRightPanel.Controls.Add(this.loginUserType);
            this.signupRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.signupRightPanel.Location = new System.Drawing.Point(334, 0);
            this.signupRightPanel.Name = "signupRightPanel";
            this.signupRightPanel.Size = new System.Drawing.Size(350, 661);
            this.signupRightPanel.TabIndex = 3;
            this.signupRightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signupRightPanel_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.linkLabel1.Location = new System.Drawing.Point(226, 517);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Signup";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an account?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.loginPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPasswordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.loginPasswordTextBox.HintText = "Password";
            this.loginPasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginPasswordTextBox.isPassword = true;
            this.loginPasswordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.loginPasswordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.loginPasswordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.loginPasswordTextBox.LineThickness = 5;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(21, 248);
            this.loginPasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(307, 60);
            this.loginPasswordTextBox.TabIndex = 9;
            this.loginPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginPasswordTextBox.OnValueChanged += new System.EventHandler(this.loginPasswordTextBox_OnValueChanged);
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "LOGIN";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(21, 416);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(307, 60);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "LOGIN";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.BackColor = System.Drawing.Color.White;
            this.loginEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginEmailTextBox.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginEmailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.loginEmailTextBox.HintText = "E-mail";
            this.loginEmailTextBox.isPassword = false;
            this.loginEmailTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.loginEmailTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.loginEmailTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.loginEmailTextBox.LineThickness = 5;
            this.loginEmailTextBox.Location = new System.Drawing.Point(21, 176);
            this.loginEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(307, 60);
            this.loginEmailTextBox.TabIndex = 6;
            this.loginEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginEmailTextBox.OnValueChanged += new System.EventHandler(this.loginEmailTextBox_OnValueChanged);
            // 
            // loginUserType
            // 
            this.loginUserType.BackColor = System.Drawing.Color.Transparent;
            this.loginUserType.BorderRadius = 3;
            this.loginUserType.DisabledColor = System.Drawing.Color.Gray;
            this.loginUserType.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserType.ForeColor = System.Drawing.Color.White;
            this.loginUserType.Items = new string[] {
        "Admin",
        "Employee",
        "Customer"};
            this.loginUserType.Location = new System.Drawing.Point(21, 331);
            this.loginUserType.Margin = new System.Windows.Forms.Padding(6);
            this.loginUserType.Name = "loginUserType";
            this.loginUserType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.loginUserType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.loginUserType.selectedIndex = 2;
            this.loginUserType.Size = new System.Drawing.Size(307, 60);
            this.loginUserType.TabIndex = 2;
            this.loginUserType.Visible = false;
            // 
            // signupLeftPanel
            // 
            this.signupLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.signupLeftPanel.Controls.Add(this.pictureBox1);
            this.signupLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.signupLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.signupLeftPanel.Name = "signupLeftPanel";
            this.signupLeftPanel.Size = new System.Drawing.Size(350, 661);
            this.signupLeftPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.signupRightPanel);
            this.Controls.Add(this.signupLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.signupRightPanel.ResumeLayout(false);
            this.signupRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.signupLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupRightPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginPasswordTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginEmailTextBox;
        private Bunifu.Framework.UI.BunifuDropdown loginUserType;
        private System.Windows.Forms.Panel signupLeftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}