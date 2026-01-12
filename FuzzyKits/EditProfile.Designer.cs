namespace FuzzyKits
{
    partial class EditProfile
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
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.TabBoard = new RoundedPanel();
            this.txtSubDistrict = new RoundTextBox();
            this.txtDistrict = new RoundTextBox();
            this.txtPhone = new RoundTextBox();
            this.txtZipCode = new RoundTextBox();
            this.txtProvince = new RoundTextBox();
            this.txtAddress = new RoundTextBox();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.TextBox();
            this.HEditProfile = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.TextBox();
            this.SubDistrict = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.IconPhone = new System.Windows.Forms.PictureBox();
            this.IconAddress = new System.Windows.Forms.PictureBox();
            this.BtCreateAccount = new RoundedButton();
            this.TabAll = new RoundedPanel();
            this.BtRegister = new RoundedButton();
            this.BtAboutUs = new RoundedButton();
            this.BtSignIn = new RoundedButton();
            this.BtHome = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAddress)).BeginInit();
            this.TabAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // SmallLogo
            // 
            this.SmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.SmallLogo.Image = global::FuzzyKits.Properties.Resources.SmallLogo;
            this.SmallLogo.Location = new System.Drawing.Point(115, 680);
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.Size = new System.Drawing.Size(320, 58);
            this.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmallLogo.TabIndex = 7;
            this.SmallLogo.TabStop = false;
            // 
            // TabBoard
            // 
            this.TabBoard.BackColor = System.Drawing.Color.White;
            this.TabBoard.BorderColor = System.Drawing.Color.Black;
            this.TabBoard.BorderRadius = 30;
            this.TabBoard.BorderThickness = 4;
            this.TabBoard.Controls.Add(this.txtSubDistrict);
            this.TabBoard.Controls.Add(this.txtDistrict);
            this.TabBoard.Controls.Add(this.txtPhone);
            this.TabBoard.Controls.Add(this.txtZipCode);
            this.TabBoard.Controls.Add(this.txtProvince);
            this.TabBoard.Controls.Add(this.txtAddress);
            this.TabBoard.Controls.Add(this.ZipCode);
            this.TabBoard.Controls.Add(this.Province);
            this.TabBoard.Controls.Add(this.HEditProfile);
            this.TabBoard.Controls.Add(this.Phone);
            this.TabBoard.Controls.Add(this.District);
            this.TabBoard.Controls.Add(this.SubDistrict);
            this.TabBoard.Controls.Add(this.Address);
            this.TabBoard.Controls.Add(this.IconPhone);
            this.TabBoard.Controls.Add(this.IconAddress);
            this.TabBoard.Controls.Add(this.BtCreateAccount);
            this.TabBoard.Location = new System.Drawing.Point(115, 160);
            this.TabBoard.Name = "TabBoard";
            this.TabBoard.Size = new System.Drawing.Size(1160, 505);
            this.TabBoard.TabIndex = 6;
            // 
            // txtSubDistrict
            // 
            this.txtSubDistrict.BorderColor = System.Drawing.Color.Black;
            this.txtSubDistrict.BorderRadius = 20;
            this.txtSubDistrict.BorderThickness = 2;
            this.txtSubDistrict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubDistrict.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubDistrict.Location = new System.Drawing.Point(210, 180);
            this.txtSubDistrict.Name = "txtSubDistrict";
            this.txtSubDistrict.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubDistrict.Size = new System.Drawing.Size(365, 50);
            this.txtSubDistrict.TabIndex = 33;
            this.txtSubDistrict.UseSystemPasswordChar = false;
            // 
            // txtDistrict
            // 
            this.txtDistrict.BorderColor = System.Drawing.Color.Black;
            this.txtDistrict.BorderRadius = 20;
            this.txtDistrict.BorderThickness = 2;
            this.txtDistrict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDistrict.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.Location = new System.Drawing.Point(748, 180);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDistrict.Size = new System.Drawing.Size(365, 50);
            this.txtDistrict.TabIndex = 0;
            this.txtDistrict.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderRadius = 20;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(210, 340);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.Size = new System.Drawing.Size(450, 50);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtZipCode
            // 
            this.txtZipCode.BorderColor = System.Drawing.Color.Black;
            this.txtZipCode.BorderRadius = 20;
            this.txtZipCode.BorderThickness = 2;
            this.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZipCode.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtZipCode.Location = new System.Drawing.Point(748, 260);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtZipCode.Size = new System.Drawing.Size(365, 50);
            this.txtZipCode.TabIndex = 0;
            this.txtZipCode.UseSystemPasswordChar = false;
            // 
            // txtProvince
            // 
            this.txtProvince.BorderColor = System.Drawing.Color.Black;
            this.txtProvince.BorderRadius = 20;
            this.txtProvince.BorderThickness = 2;
            this.txtProvince.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvince.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtProvince.Location = new System.Drawing.Point(210, 260);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProvince.Size = new System.Drawing.Size(365, 50);
            this.txtProvince.TabIndex = 0;
            this.txtProvince.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.BorderRadius = 20;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(210, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.Size = new System.Drawing.Size(900, 50);
            this.txtAddress.TabIndex = 29;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // ZipCode
            // 
            this.ZipCode.BackColor = System.Drawing.Color.White;
            this.ZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZipCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZipCode.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.ZipCode.Location = new System.Drawing.Point(580, 267);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            this.ZipCode.Size = new System.Drawing.Size(162, 34);
            this.ZipCode.TabIndex = 23;
            this.ZipCode.Text = "รหัสไปรษณีย์";
            this.ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Province
            // 
            this.Province.BackColor = System.Drawing.Color.White;
            this.Province.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Province.Cursor = System.Windows.Forms.Cursors.Default;
            this.Province.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Province.Location = new System.Drawing.Point(96, 267);
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            this.Province.Size = new System.Drawing.Size(107, 34);
            this.Province.TabIndex = 22;
            this.Province.Text = "จังหวัด";
            this.Province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HEditProfile
            // 
            this.HEditProfile.BackColor = System.Drawing.Color.White;
            this.HEditProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HEditProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.HEditProfile.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEditProfile.Location = new System.Drawing.Point(24, 23);
            this.HEditProfile.Name = "HEditProfile";
            this.HEditProfile.ReadOnly = true;
            this.HEditProfile.Size = new System.Drawing.Size(1110, 56);
            this.HEditProfile.TabIndex = 0;
            this.HEditProfile.Text = "Edit Profile";
            this.HEditProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phone.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Phone.Location = new System.Drawing.Point(96, 347);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(107, 34);
            this.Phone.TabIndex = 17;
            this.Phone.Text = "เบอร์";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // District
            // 
            this.District.BackColor = System.Drawing.Color.White;
            this.District.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.District.Cursor = System.Windows.Forms.Cursors.Default;
            this.District.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.District.Location = new System.Drawing.Point(580, 187);
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Size = new System.Drawing.Size(162, 34);
            this.District.TabIndex = 16;
            this.District.Text = "อำเภอ";
            this.District.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubDistrict
            // 
            this.SubDistrict.BackColor = System.Drawing.Color.White;
            this.SubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubDistrict.Cursor = System.Windows.Forms.Cursors.Default;
            this.SubDistrict.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.SubDistrict.Location = new System.Drawing.Point(96, 187);
            this.SubDistrict.Name = "SubDistrict";
            this.SubDistrict.ReadOnly = true;
            this.SubDistrict.Size = new System.Drawing.Size(107, 34);
            this.SubDistrict.TabIndex = 15;
            this.SubDistrict.Text = "ตำบล";
            this.SubDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Cursor = System.Windows.Forms.Cursors.Default;
            this.Address.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(96, 107);
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(107, 34);
            this.Address.TabIndex = 14;
            this.Address.Text = "ชื่อที่อยู่";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IconPhone
            // 
            this.IconPhone.BackColor = System.Drawing.Color.Transparent;
            this.IconPhone.Image = global::FuzzyKits.Properties.Resources.Phone;
            this.IconPhone.Location = new System.Drawing.Point(37, 340);
            this.IconPhone.Name = "IconPhone";
            this.IconPhone.Size = new System.Drawing.Size(50, 50);
            this.IconPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPhone.TabIndex = 13;
            this.IconPhone.TabStop = false;
            // 
            // IconAddress
            // 
            this.IconAddress.BackColor = System.Drawing.Color.Transparent;
            this.IconAddress.Image = global::FuzzyKits.Properties.Resources.Address;
            this.IconAddress.Location = new System.Drawing.Point(37, 100);
            this.IconAddress.Name = "IconAddress";
            this.IconAddress.Size = new System.Drawing.Size(50, 50);
            this.IconAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconAddress.TabIndex = 10;
            this.IconAddress.TabStop = false;
            // 
            // BtCreateAccount
            // 
            this.BtCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtCreateAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtCreateAccount.BorderRadius = 20;
            this.BtCreateAccount.BorderThickness = 3;
            this.BtCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCreateAccount.FlatAppearance.BorderSize = 0;
            this.BtCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCreateAccount.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateAccount.Location = new System.Drawing.Point(819, 425);
            this.BtCreateAccount.Name = "BtCreateAccount";
            this.BtCreateAccount.Size = new System.Drawing.Size(288, 45);
            this.BtCreateAccount.TabIndex = 5;
            this.BtCreateAccount.Text = "Create Account";
            this.BtCreateAccount.UseVisualStyleBackColor = false;
            this.BtCreateAccount.Click += new System.EventHandler(this.BtCreateAccount_Click);
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 4;
            this.TabAll.Controls.Add(this.BtRegister);
            this.TabAll.Controls.Add(this.BtAboutUs);
            this.TabAll.Controls.Add(this.BtSignIn);
            this.TabAll.Controls.Add(this.BtHome);
            this.TabAll.Location = new System.Drawing.Point(115, 70);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(1160, 60);
            this.TabAll.TabIndex = 5;
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.Color.White;
            this.BtRegister.BorderColor = System.Drawing.Color.White;
            this.BtRegister.BorderRadius = 25;
            this.BtRegister.BorderThickness = 1;
            this.BtRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegister.FlatAppearance.BorderSize = 0;
            this.BtRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRegister.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtRegister.Location = new System.Drawing.Point(290, 6);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(290, 50);
            this.BtRegister.TabIndex = 0;
            this.BtRegister.Text = "Register";
            this.BtRegister.UseVisualStyleBackColor = false;
            // 
            // BtAboutUs
            // 
            this.BtAboutUs.BackColor = System.Drawing.Color.White;
            this.BtAboutUs.BorderColor = System.Drawing.Color.White;
            this.BtAboutUs.BorderRadius = 25;
            this.BtAboutUs.BorderThickness = 1;
            this.BtAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAboutUs.FlatAppearance.BorderSize = 0;
            this.BtAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAboutUs.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtAboutUs.Location = new System.Drawing.Point(867, 6);
            this.BtAboutUs.Name = "BtAboutUs";
            this.BtAboutUs.Size = new System.Drawing.Size(290, 50);
            this.BtAboutUs.TabIndex = 0;
            this.BtAboutUs.Text = "About Us";
            this.BtAboutUs.UseVisualStyleBackColor = false;
            // 
            // BtSignIn
            // 
            this.BtSignIn.BackColor = System.Drawing.Color.White;
            this.BtSignIn.BorderColor = System.Drawing.Color.White;
            this.BtSignIn.BorderRadius = 25;
            this.BtSignIn.BorderThickness = 1;
            this.BtSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSignIn.FlatAppearance.BorderSize = 0;
            this.BtSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSignIn.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtSignIn.Location = new System.Drawing.Point(579, 6);
            this.BtSignIn.Name = "BtSignIn";
            this.BtSignIn.Size = new System.Drawing.Size(290, 50);
            this.BtSignIn.TabIndex = 0;
            this.BtSignIn.Text = "Sign In";
            this.BtSignIn.UseVisualStyleBackColor = false;
            // 
            // BtHome
            // 
            this.BtHome.BackColor = System.Drawing.Color.White;
            this.BtHome.BorderColor = System.Drawing.Color.White;
            this.BtHome.BorderRadius = 25;
            this.BtHome.BorderThickness = 1;
            this.BtHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtHome.FlatAppearance.BorderSize = 0;
            this.BtHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHome.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtHome.Location = new System.Drawing.Point(3, 6);
            this.BtHome.Name = "BtHome";
            this.BtHome.Size = new System.Drawing.Size(290, 50);
            this.BtHome.TabIndex = 0;
            this.BtHome.Text = "Home";
            this.BtHome.UseVisualStyleBackColor = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_มีกรอบ;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabBoard);
            this.Controls.Add(this.TabAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabBoard.ResumeLayout(false);
            this.TabBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAddress)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabBoard;
        private System.Windows.Forms.TextBox HEditProfile;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox District;
        private System.Windows.Forms.TextBox SubDistrict;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.PictureBox IconPhone;
        private System.Windows.Forms.PictureBox IconAddress;
        private RoundedButton BtCreateAccount;
        private RoundedPanel TabAll;
        private RoundedButton BtRegister;
        private RoundedButton BtAboutUs;
        private RoundedButton BtSignIn;
        private RoundedButton BtHome;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox Province;
        private RoundTextBox txtSubDistrict;
        private RoundTextBox txtDistrict;
        private RoundTextBox txtPhone;
        private RoundTextBox txtZipCode;
        private RoundTextBox txtProvince;
        private RoundTextBox txtAddress;
    }
}