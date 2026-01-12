namespace FuzzyKits
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.TabAll = new RoundedPanel();
            this.BtRegister = new RoundedButton();
            this.BtAboutUs = new RoundedButton();
            this.BtSignIn = new RoundedButton();
            this.BtHome = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // BigLogo
            // 
            this.BigLogo.BackColor = System.Drawing.Color.Transparent;
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(114, 154);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(1160, 570);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigLogo.TabIndex = 0;
            this.BigLogo.TabStop = false;
            this.BigLogo.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.TabAll.TabIndex = 1;
            this.TabAll.Paint += new System.Windows.Forms.PaintEventHandler(this.TabAll_Paint);
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
            this.BtRegister.TabIndex = 2;
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
            this.BtHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.BtHome.BorderRadius = 25;
            this.BtHome.BorderThickness = 2;
            this.BtHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtHome.FlatAppearance.BorderSize = 0;
            this.BtHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHome.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHome.ForeColor = System.Drawing.Color.White;
            this.BtHome.Location = new System.Drawing.Point(1, 3);
            this.BtHome.Name = "BtHome";
            this.BtHome.Size = new System.Drawing.Size(290, 55);
            this.BtHome.TabIndex = 0;
            this.BtHome.Text = "Home";
            this.BtHome.UseVisualStyleBackColor = false;
            this.BtHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_มีกรอบ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.BigLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BigLogo;
        private RoundedPanel TabAll;
        private RoundedButton BtHome;
        private RoundedButton BtAboutUs;
        private RoundedButton BtSignIn;
        private RoundedButton BtRegister;
    }
}

