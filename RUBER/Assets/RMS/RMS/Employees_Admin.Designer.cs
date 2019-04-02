namespace RMS
{
    partial class Employees_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signupRightPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userType = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.signupRightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupRightPanel
            // 
            this.signupRightPanel.BackColor = System.Drawing.Color.White;
            this.signupRightPanel.Controls.Add(this.passwordTextBox);
            this.signupRightPanel.Controls.Add(this.signupButton);
            this.signupRightPanel.Controls.Add(this.emailTextBox);
            this.signupRightPanel.Controls.Add(this.userType);
            this.signupRightPanel.Location = new System.Drawing.Point(3, 0);
            this.signupRightPanel.Name = "signupRightPanel";
            this.signupRightPanel.Size = new System.Drawing.Size(510, 722);
            this.signupRightPanel.TabIndex = 2;
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
            this.passwordTextBox.Location = new System.Drawing.Point(38, 250);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(469, 60);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupButton
            // 
            this.signupButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupButton.BorderRadius = 0;
            this.signupButton.ButtonText = "Add New User";
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
            this.signupButton.Location = new System.Drawing.Point(38, 463);
            this.signupButton.Name = "signupButton";
            this.signupButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.signupButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.signupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.signupButton.selected = false;
            this.signupButton.Size = new System.Drawing.Size(469, 60);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Add New User";
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
            this.emailTextBox.Location = new System.Drawing.Point(38, 160);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(469, 60);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.userType.Location = new System.Drawing.Point(38, 358);
            this.userType.Margin = new System.Windows.Forms.Padding(6);
            this.userType.Name = "userType";
            this.userType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.userType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.userType.selectedIndex = 2;
            this.userType.Size = new System.Drawing.Size(469, 60);
            this.userType.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuDropdown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(519, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 753);
            this.panel1.TabIndex = 10;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Delete User";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(38, 272);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(469, 60);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Delete User";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(38, 160);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(228)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(469, 60);
            this.bunifuDropdown1.TabIndex = 0;
            // 
            // Employees_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupRightPanel);
            this.Name = "Employees_Admin";
            this.Size = new System.Drawing.Size(1088, 753);
            this.Load += new System.EventHandler(this.Employees_Admin_Load);
            this.signupRightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupRightPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton signupButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextBox;
        private Bunifu.Framework.UI.BunifuDropdown userType;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;

    }
}
