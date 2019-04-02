namespace RMS
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.signupRightPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userType = new Bunifu.Framework.UI.BunifuDropdown();
            this.signupLeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.signupRightPanel.Controls.Add(this.passwordTextBox);
            this.signupRightPanel.Controls.Add(this.signupButton);
            this.signupRightPanel.Controls.Add(this.emailTextBox);
            this.signupRightPanel.Controls.Add(this.userType);
            this.signupRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.signupRightPanel.Location = new System.Drawing.Point(350, 0);
            this.signupRightPanel.Name = "signupRightPanel";
            this.signupRightPanel.Size = new System.Drawing.Size(350, 700);
            this.signupRightPanel.TabIndex = 1;
            this.signupRightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.HintText = "Password";
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordTextBox.isPassword = true;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.passwordTextBox.LineThickness = 5;
            this.passwordTextBox.Location = new System.Drawing.Point(21, 248);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(307, 60);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // signupButton
            // 
            this.signupButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupButton.BorderRadius = 0;
            this.signupButton.ButtonText = "SIGNUP";
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.DisabledColor = System.Drawing.Color.Gray;
            this.signupButton.Iconcolor = System.Drawing.Color.Transparent;
            this.signupButton.Iconimage = null;
            this.signupButton.Iconimage_right = null;
            this.signupButton.Iconimage_right_Selected = null;
            this.signupButton.Iconimage_Selected = null;
            this.signupButton.IconMarginLeft = 0;
            this.signupButton.IconMarginRight = 0;
            this.signupButton.IconRightVisible = true;
            this.signupButton.IconRightZoom = 0D;
            this.signupButton.IconVisible = true;
            this.signupButton.IconZoom = 90D;
            this.signupButton.IsTab = false;
            this.signupButton.Location = new System.Drawing.Point(21, 416);
            this.signupButton.Name = "signupButton";
            this.signupButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.signupButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.signupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.signupButton.selected = false;
            this.signupButton.Size = new System.Drawing.Size(307, 60);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "SIGNUP";
            this.signupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupButton.Textcolor = System.Drawing.Color.White;
            this.signupButton.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.HintText = "E-mail";
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.emailTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.emailTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.emailTextBox.LineThickness = 5;
            this.emailTextBox.Location = new System.Drawing.Point(21, 176);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(307, 60);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // userType
            // 
            this.userType.BackColor = System.Drawing.Color.Transparent;
            this.userType.BorderRadius = 3;
            this.userType.DisabledColor = System.Drawing.Color.Gray;
            this.userType.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userType.ForeColor = System.Drawing.Color.White;
            this.userType.Items = new string[] {
        "Admin",
        "Employee",
        "Customer"};
            this.userType.Location = new System.Drawing.Point(21, 331);
            this.userType.Margin = new System.Windows.Forms.Padding(6);
            this.userType.Name = "userType";
            this.userType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.userType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.userType.selectedIndex = 2;
            this.userType.Size = new System.Drawing.Size(307, 60);
            this.userType.TabIndex = 2;
            this.userType.Visible = false;
            this.userType.onItemSelected += new System.EventHandler(this.userType_onItemSelected);
            // 
            // signupLeftPanel
            // 
            this.signupLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.signupLeftPanel.Controls.Add(this.pictureBox1);
            this.signupLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.signupLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.signupLeftPanel.Name = "signupLeftPanel";
            this.signupLeftPanel.Size = new System.Drawing.Size(350, 700);
            this.signupLeftPanel.TabIndex = 2;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.linkLabel1.Location = new System.Drawing.Point(239, 509);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogIn";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Already have an account?";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.signupLeftPanel);
            this.Controls.Add(this.signupRightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.signupRightPanel.ResumeLayout(false);
            this.signupRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.signupLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupRightPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextBox;
        private Bunifu.Framework.UI.BunifuDropdown userType;
        private System.Windows.Forms.Panel signupLeftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton signupButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;

    }
}

