namespace FuzzyKits
{
    partial class Register
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
            this.BtBrowse = new RoundedButton();
            this.PicProfile = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new RoundTextBox();
            this.txtLastName = new RoundTextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.BtNext = new RoundedButton();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.IconToggleConfirm = new System.Windows.Forms.PictureBox();
            this.IconTogglePassword = new System.Windows.Forms.PictureBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.IconPW = new System.Windows.Forms.PictureBox();
            this.IconEmail = new System.Windows.Forms.PictureBox();
            this.IconUser = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new RoundTextBox();
            this.txtPassword = new RoundTextBox();
            this.txtEmailAddress = new RoundTextBox();
            this.txtUsername = new RoundTextBox();
            this.HRegister = new System.Windows.Forms.TextBox();
            this.TabAll = new RoundedPanel();
            this.BtRegister = new RoundedButton();
            this.BtAboutUs = new RoundedButton();
            this.BtSignIn = new RoundedButton();
            this.BtHome = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconToggleConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTogglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).BeginInit();
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
            this.SmallLogo.TabIndex = 4;
            this.SmallLogo.TabStop = false;
            // 
            // TabBoard
            // 
            this.TabBoard.BackColor = System.Drawing.Color.White;
            this.TabBoard.BorderColor = System.Drawing.Color.Black;
            this.TabBoard.BorderRadius = 30;
            this.TabBoard.BorderThickness = 4;
            this.TabBoard.Controls.Add(this.BtBrowse);
            this.TabBoard.Controls.Add(this.PicProfile);
            this.TabBoard.Controls.Add(this.txtFirstName);
            this.TabBoard.Controls.Add(this.txtLastName);
            this.TabBoard.Controls.Add(this.LastName);
            this.TabBoard.Controls.Add(this.BtNext);
            this.TabBoard.Controls.Add(this.FirstName);
            this.TabBoard.Controls.Add(this.IconToggleConfirm);
            this.TabBoard.Controls.Add(this.IconTogglePassword);
            this.TabBoard.Controls.Add(this.ConfirmPassword);
            this.TabBoard.Controls.Add(this.Password);
            this.TabBoard.Controls.Add(this.EmailAddress);
            this.TabBoard.Controls.Add(this.Username);
            this.TabBoard.Controls.Add(this.IconPW);
            this.TabBoard.Controls.Add(this.IconEmail);
            this.TabBoard.Controls.Add(this.IconUser);
            this.TabBoard.Controls.Add(this.txtConfirmPassword);
            this.TabBoard.Controls.Add(this.txtPassword);
            this.TabBoard.Controls.Add(this.txtEmailAddress);
            this.TabBoard.Controls.Add(this.txtUsername);
            this.TabBoard.Controls.Add(this.HRegister);
            this.TabBoard.Location = new System.Drawing.Point(115, 160);
            this.TabBoard.Name = "TabBoard";
            this.TabBoard.Size = new System.Drawing.Size(1160, 505);
            this.TabBoard.TabIndex = 3;
            // 
            // BtBrowse
            // 
            this.BtBrowse.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtBrowse.BorderRadius = 20;
            this.BtBrowse.BorderThickness = 3;
            this.BtBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBrowse.FlatAppearance.BorderSize = 0;
            this.BtBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtBrowse.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBrowse.Location = new System.Drawing.Point(953, 267);
            this.BtBrowse.Name = "BtBrowse";
            this.BtBrowse.Size = new System.Drawing.Size(160, 40);
            this.BtBrowse.TabIndex = 0;
            this.BtBrowse.Text = "Browse";
            this.BtBrowse.UseVisualStyleBackColor = false;
            this.BtBrowse.Click += new System.EventHandler(this.BtBrowse_Click);
            // 
            // PicProfile
            // 
            this.PicProfile.Location = new System.Drawing.Point(933, 68);
            this.PicProfile.Name = "PicProfile";
            this.PicProfile.Size = new System.Drawing.Size(201, 187);
            this.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProfile.TabIndex = 28;
            this.PicProfile.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtFirstName.BorderRadius = 20;
            this.txtFirstName.BorderThickness = 2;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(320, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFirstName.Size = new System.Drawing.Size(549, 45);
            this.txtFirstName.TabIndex = 27;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.Black;
            this.txtLastName.BorderRadius = 20;
            this.txtLastName.BorderThickness = 2;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(320, 210);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLastName.Size = new System.Drawing.Size(549, 45);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.White;
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LastName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(80, 220);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(232, 30);
            this.LastName.TabIndex = 25;
            this.LastName.Text = "LastName";
            // 
            // BtNext
            // 
            this.BtNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtNext.BorderRadius = 20;
            this.BtNext.BorderThickness = 3;
            this.BtNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtNext.FlatAppearance.BorderSize = 0;
            this.BtNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtNext.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNext.Location = new System.Drawing.Point(933, 445);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(201, 45);
            this.BtNext.TabIndex = 22;
            this.BtNext.Text = "Next";
            this.BtNext.UseVisualStyleBackColor = false;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.White;
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(80, 160);
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Size = new System.Drawing.Size(232, 30);
            this.FirstName.TabIndex = 24;
            this.FirstName.Text = "FirstName";
            // 
            // IconToggleConfirm
            // 
            this.IconToggleConfirm.BackColor = System.Drawing.Color.Transparent;
            this.IconToggleConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconToggleConfirm.Image = global::FuzzyKits.Properties.Resources.Hide;
            this.IconToggleConfirm.Location = new System.Drawing.Point(877, 390);
            this.IconToggleConfirm.Name = "IconToggleConfirm";
            this.IconToggleConfirm.Size = new System.Drawing.Size(45, 45);
            this.IconToggleConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconToggleConfirm.TabIndex = 21;
            this.IconToggleConfirm.TabStop = false;
            this.IconToggleConfirm.Click += new System.EventHandler(this.IconToggleConfirm_Click);
            // 
            // IconTogglePassword
            // 
            this.IconTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.IconTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconTogglePassword.Image = global::FuzzyKits.Properties.Resources.Hide;
            this.IconTogglePassword.Location = new System.Drawing.Point(877, 330);
            this.IconTogglePassword.Name = "IconTogglePassword";
            this.IconTogglePassword.Size = new System.Drawing.Size(45, 45);
            this.IconTogglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconTogglePassword.TabIndex = 20;
            this.IconTogglePassword.TabStop = false;
            this.IconTogglePassword.Click += new System.EventHandler(this.IconTogglePassword_Click);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BackColor = System.Drawing.Color.White;
            this.ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmPassword.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(80, 400);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(232, 30);
            this.ConfirmPassword.TabIndex = 17;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(80, 340);
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Size = new System.Drawing.Size(232, 30);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // EmailAddress
            // 
            this.EmailAddress.BackColor = System.Drawing.Color.White;
            this.EmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmailAddress.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress.Location = new System.Drawing.Point(80, 280);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Size = new System.Drawing.Size(232, 30);
            this.EmailAddress.TabIndex = 15;
            this.EmailAddress.Text = "Email Address";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(80, 95);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(232, 30);
            this.Username.TabIndex = 14;
            this.Username.Text = "Username";
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IconPW
            // 
            this.IconPW.BackColor = System.Drawing.Color.Transparent;
            this.IconPW.Image = global::FuzzyKits.Properties.Resources.Password;
            this.IconPW.Location = new System.Drawing.Point(22, 327);
            this.IconPW.Name = "IconPW";
            this.IconPW.Size = new System.Drawing.Size(50, 50);
            this.IconPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPW.TabIndex = 12;
            this.IconPW.TabStop = false;
            // 
            // IconEmail
            // 
            this.IconEmail.BackColor = System.Drawing.Color.Transparent;
            this.IconEmail.Image = global::FuzzyKits.Properties.Resources.Email;
            this.IconEmail.Location = new System.Drawing.Point(22, 267);
            this.IconEmail.Name = "IconEmail";
            this.IconEmail.Size = new System.Drawing.Size(50, 50);
            this.IconEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconEmail.TabIndex = 11;
            this.IconEmail.TabStop = false;
            // 
            // IconUser
            // 
            this.IconUser.BackColor = System.Drawing.Color.Transparent;
            this.IconUser.Image = global::FuzzyKits.Properties.Resources.User;
            this.IconUser.Location = new System.Drawing.Point(22, 87);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(50, 50);
            this.IconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconUser.TabIndex = 10;
            this.IconUser.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderRadius = 20;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(320, 390);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmPassword.Size = new System.Drawing.Size(549, 45);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.roundTextBox4_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtPassword.Location = new System.Drawing.Point(320, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.Size = new System.Drawing.Size(549, 45);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderColor = System.Drawing.Color.Black;
            this.txtEmailAddress.BorderRadius = 20;
            this.txtEmailAddress.BorderThickness = 2;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtEmailAddress.Location = new System.Drawing.Point(320, 270);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmailAddress.Size = new System.Drawing.Size(549, 45);
            this.txtEmailAddress.TabIndex = 0;
            this.txtEmailAddress.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(320, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.Size = new System.Drawing.Size(549, 45);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // HRegister
            // 
            this.HRegister.BackColor = System.Drawing.Color.White;
            this.HRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.HRegister.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRegister.Location = new System.Drawing.Point(24, 23);
            this.HRegister.Name = "HRegister";
            this.HRegister.ReadOnly = true;
            this.HRegister.Size = new System.Drawing.Size(1110, 56);
            this.HRegister.TabIndex = 0;
            this.HRegister.Text = "Register";
            this.HRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TabAll.TabIndex = 2;
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtRegister.BorderRadius = 25;
            this.BtRegister.BorderThickness = 2;
            this.BtRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegister.FlatAppearance.BorderSize = 0;
            this.BtRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRegister.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRegister.ForeColor = System.Drawing.Color.White;
            this.BtRegister.Location = new System.Drawing.Point(290, 3);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(290, 55);
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
            this.BtAboutUs.Click += new System.EventHandler(this.BtAboutUs_Click);
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
            this.BtSignIn.Click += new System.EventHandler(this.BtSignIn_Click);
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
            this.BtHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_มีกรอบ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabBoard);
            this.Controls.Add(this.TabAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabBoard.ResumeLayout(false);
            this.TabBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconToggleConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTogglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel TabAll;
        private RoundedButton BtAboutUs;
        private RoundedButton BtSignIn;
        private RoundedButton BtHome;
        private RoundedPanel TabBoard;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundTextBox txtConfirmPassword;
        private RoundTextBox txtPassword;
        private RoundTextBox txtEmailAddress;
        private System.Windows.Forms.PictureBox IconUser;
        private RoundTextBox txtUsername;
        private System.Windows.Forms.PictureBox IconPW;
        private System.Windows.Forms.PictureBox IconEmail;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.PictureBox IconTogglePassword;
        private System.Windows.Forms.PictureBox IconToggleConfirm;
        private RoundedButton BtRegister;
        private System.Windows.Forms.TextBox HRegister;
        private RoundedButton BtNext;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private RoundTextBox txtFirstName;
        private RoundTextBox txtLastName;
        private RoundedButton BtBrowse;
        private System.Windows.Forms.PictureBox PicProfile;
    }
}