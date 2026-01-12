namespace FuzzyKits
{
    partial class SignIn
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
            this.BtForgotPW = new RoundedButton();
            this.IconTogglePassword = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.IconPW = new System.Windows.Forms.PictureBox();
            this.IconUser = new System.Windows.Forms.PictureBox();
            this.txtPassword = new RoundTextBox();
            this.txtUsername = new RoundTextBox();
            this.BtContinue = new RoundedButton();
            this.HSignIn = new System.Windows.Forms.TextBox();
            this.TabAll = new RoundedPanel();
            this.BtRegister = new RoundedButton();
            this.BtAboutUs = new RoundedButton();
            this.BtSignIn = new RoundedButton();
            this.BtHome = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconTogglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPW)).BeginInit();
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
            this.SmallLogo.TabIndex = 6;
            this.SmallLogo.TabStop = false;
            // 
            // TabBoard
            // 
            this.TabBoard.BackColor = System.Drawing.Color.White;
            this.TabBoard.BorderColor = System.Drawing.Color.Black;
            this.TabBoard.BorderRadius = 30;
            this.TabBoard.BorderThickness = 4;
            this.TabBoard.Controls.Add(this.BtForgotPW);
            this.TabBoard.Controls.Add(this.IconTogglePassword);
            this.TabBoard.Controls.Add(this.Password);
            this.TabBoard.Controls.Add(this.Username);
            this.TabBoard.Controls.Add(this.IconPW);
            this.TabBoard.Controls.Add(this.IconUser);
            this.TabBoard.Controls.Add(this.txtPassword);
            this.TabBoard.Controls.Add(this.txtUsername);
            this.TabBoard.Controls.Add(this.BtContinue);
            this.TabBoard.Controls.Add(this.HSignIn);
            this.TabBoard.Location = new System.Drawing.Point(115, 160);
            this.TabBoard.Name = "TabBoard";
            this.TabBoard.Size = new System.Drawing.Size(1160, 505);
            this.TabBoard.TabIndex = 5;
            // 
            // BtForgotPW
            // 
            this.BtForgotPW.BackColor = System.Drawing.Color.White;
            this.BtForgotPW.BorderColor = System.Drawing.Color.White;
            this.BtForgotPW.BorderRadius = 20;
            this.BtForgotPW.BorderThickness = 3;
            this.BtForgotPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtForgotPW.FlatAppearance.BorderSize = 0;
            this.BtForgotPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtForgotPW.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtForgotPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtForgotPW.Location = new System.Drawing.Point(304, 430);
            this.BtForgotPW.Name = "BtForgotPW";
            this.BtForgotPW.Size = new System.Drawing.Size(276, 45);
            this.BtForgotPW.TabIndex = 20;
            this.BtForgotPW.Text = "Forgot Password ?";
            this.BtForgotPW.UseVisualStyleBackColor = false;
            this.BtForgotPW.Click += new System.EventHandler(this.BtForgotPW_Click);
            // 
            // IconTogglePassword
            // 
            this.IconTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.IconTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconTogglePassword.Image = global::FuzzyKits.Properties.Resources.Hide;
            this.IconTogglePassword.Location = new System.Drawing.Point(1080, 267);
            this.IconTogglePassword.Name = "IconTogglePassword";
            this.IconTogglePassword.Size = new System.Drawing.Size(61, 55);
            this.IconTogglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconTogglePassword.TabIndex = 19;
            this.IconTogglePassword.TabStop = false;
            this.IconTogglePassword.Click += new System.EventHandler(this.IconTogglePassword_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(89, 279);
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Size = new System.Drawing.Size(204, 30);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(89, 195);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(209, 30);
            this.Username.TabIndex = 14;
            this.Username.Text = "Username";
            // 
            // IconPW
            // 
            this.IconPW.BackColor = System.Drawing.Color.Transparent;
            this.IconPW.Image = global::FuzzyKits.Properties.Resources.Password;
            this.IconPW.Location = new System.Drawing.Point(22, 267);
            this.IconPW.Name = "IconPW";
            this.IconPW.Size = new System.Drawing.Size(61, 55);
            this.IconPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPW.TabIndex = 12;
            this.IconPW.TabStop = false;
            // 
            // IconUser
            // 
            this.IconUser.BackColor = System.Drawing.Color.Transparent;
            this.IconUser.Image = global::FuzzyKits.Properties.Resources.User;
            this.IconUser.Location = new System.Drawing.Point(22, 183);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(61, 55);
            this.IconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconUser.TabIndex = 10;
            this.IconUser.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 22;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtPassword.Location = new System.Drawing.Point(304, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.Size = new System.Drawing.Size(770, 55);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 22;
            this.txtUsername.BorderThickness = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtUsername.Location = new System.Drawing.Point(304, 183);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.Size = new System.Drawing.Size(770, 55);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // BtContinue
            // 
            this.BtContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtContinue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtContinue.BorderRadius = 20;
            this.BtContinue.BorderThickness = 3;
            this.BtContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtContinue.FlatAppearance.BorderSize = 0;
            this.BtContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtContinue.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtContinue.Location = new System.Drawing.Point(819, 430);
            this.BtContinue.Name = "BtContinue";
            this.BtContinue.Size = new System.Drawing.Size(255, 45);
            this.BtContinue.TabIndex = 5;
            this.BtContinue.Text = "Continue";
            this.BtContinue.UseVisualStyleBackColor = false;
            this.BtContinue.Click += new System.EventHandler(this.BtContinue_Click);
            // 
            // HSignIn
            // 
            this.HSignIn.BackColor = System.Drawing.Color.White;
            this.HSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.HSignIn.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSignIn.Location = new System.Drawing.Point(24, 23);
            this.HSignIn.Name = "HSignIn";
            this.HSignIn.ReadOnly = true;
            this.HSignIn.Size = new System.Drawing.Size(1110, 56);
            this.HSignIn.TabIndex = 0;
            this.HSignIn.Text = "Sign In";
            this.HSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TabAll.TabIndex = 3;
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
            this.BtRegister.Location = new System.Drawing.Point(290, 5);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(290, 50);
            this.BtRegister.TabIndex = 3;
            this.BtRegister.Text = "Register";
            this.BtRegister.UseVisualStyleBackColor = false;
            this.BtRegister.Click += new System.EventHandler(this.BtRegister_Click);
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
            this.BtSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtSignIn.BorderRadius = 25;
            this.BtSignIn.BorderThickness = 2;
            this.BtSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSignIn.FlatAppearance.BorderSize = 0;
            this.BtSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSignIn.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSignIn.ForeColor = System.Drawing.Color.White;
            this.BtSignIn.Location = new System.Drawing.Point(579, 3);
            this.BtSignIn.Name = "BtSignIn";
            this.BtSignIn.Size = new System.Drawing.Size(290, 55);
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
            this.BtHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // SignIn
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
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.Load += new System.EventHandler(this.SignIn_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabBoard.ResumeLayout(false);
            this.TabBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconTogglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel TabAll;
        private RoundedButton BtAboutUs;
        private RoundedButton BtSignIn;
        private RoundedButton BtHome;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabBoard;
        private System.Windows.Forms.PictureBox IconTogglePassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.PictureBox IconPW;
        private System.Windows.Forms.PictureBox IconUser;
        private RoundTextBox txtPassword;
        private RoundTextBox txtUsername;
        private RoundedButton BtContinue;
        private System.Windows.Forms.TextBox HSignIn;
        private RoundedButton BtForgotPW;
        private RoundedButton BtRegister;
    }
}