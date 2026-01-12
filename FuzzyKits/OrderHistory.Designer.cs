namespace FuzzyKits
{
    partial class OrderHistory
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
            this.TabAll = new RoundedPanel();
            this.BtBackToAccount = new RoundedButton();
            this.BtSignOut = new RoundedButton();
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.TabShow = new RoundedPanel();
            this.flowOrderHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpMonthFilter = new System.Windows.Forms.DateTimePicker();
            this.HOrderHistory = new System.Windows.Forms.TextBox();
            this.TabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 4;
            this.TabAll.Controls.Add(this.BtBackToAccount);
            this.TabAll.Controls.Add(this.BtSignOut);
            this.TabAll.Location = new System.Drawing.Point(354, 24);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(1000, 60);
            this.TabAll.TabIndex = 22;
            // 
            // BtBackToAccount
            // 
            this.BtBackToAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtBackToAccount.BorderColor = System.Drawing.Color.Black;
            this.BtBackToAccount.BorderRadius = 25;
            this.BtBackToAccount.BorderThickness = 3;
            this.BtBackToAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBackToAccount.FlatAppearance.BorderSize = 0;
            this.BtBackToAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBackToAccount.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtBackToAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtBackToAccount.Location = new System.Drawing.Point(2, 3);
            this.BtBackToAccount.Name = "BtBackToAccount";
            this.BtBackToAccount.Size = new System.Drawing.Size(243, 55);
            this.BtBackToAccount.TabIndex = 0;
            this.BtBackToAccount.Text = "Back To Account";
            this.BtBackToAccount.UseVisualStyleBackColor = false;
            this.BtBackToAccount.Click += new System.EventHandler(this.BtBackToAccount_Click);
            // 
            // BtSignOut
            // 
            this.BtSignOut.BackColor = System.Drawing.Color.DarkGray;
            this.BtSignOut.BorderColor = System.Drawing.Color.Black;
            this.BtSignOut.BorderRadius = 25;
            this.BtSignOut.BorderThickness = 3;
            this.BtSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSignOut.FlatAppearance.BorderSize = 0;
            this.BtSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSignOut.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtSignOut.Location = new System.Drawing.Point(799, 3);
            this.BtSignOut.Name = "BtSignOut";
            this.BtSignOut.Size = new System.Drawing.Size(200, 55);
            this.BtSignOut.TabIndex = 0;
            this.BtSignOut.Text = "Sign Out";
            this.BtSignOut.UseVisualStyleBackColor = false;
            this.BtSignOut.Click += new System.EventHandler(this.BtSignOut_Click);
            // 
            // SmallLogo
            // 
            this.SmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.SmallLogo.Image = global::FuzzyKits.Properties.Resources.SmallLogo;
            this.SmallLogo.Location = new System.Drawing.Point(30, 30);
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.Size = new System.Drawing.Size(300, 60);
            this.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmallLogo.TabIndex = 23;
            this.SmallLogo.TabStop = false;
            // 
            // TabShow
            // 
            this.TabShow.BackColor = System.Drawing.Color.White;
            this.TabShow.BorderColor = System.Drawing.Color.Black;
            this.TabShow.BorderRadius = 25;
            this.TabShow.BorderThickness = 4;
            this.TabShow.Controls.Add(this.flowOrderHistory);
            this.TabShow.Controls.Add(this.dtpMonthFilter);
            this.TabShow.Controls.Add(this.HOrderHistory);
            this.TabShow.Location = new System.Drawing.Point(30, 109);
            this.TabShow.Name = "TabShow";
            this.TabShow.Size = new System.Drawing.Size(1324, 620);
            this.TabShow.TabIndex = 24;
            // 
            // flowOrderHistory
            // 
            this.flowOrderHistory.AutoScroll = true;
            this.flowOrderHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOrderHistory.Location = new System.Drawing.Point(20, 120);
            this.flowOrderHistory.Name = "flowOrderHistory";
            this.flowOrderHistory.Size = new System.Drawing.Size(1287, 479);
            this.flowOrderHistory.TabIndex = 54;
            this.flowOrderHistory.WrapContents = false;
            // 
            // dtpMonthFilter
            // 
            this.dtpMonthFilter.CustomFormat = "MMMM yyyy";
            this.dtpMonthFilter.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthFilter.Location = new System.Drawing.Point(1123, 85);
            this.dtpMonthFilter.Name = "dtpMonthFilter";
            this.dtpMonthFilter.ShowUpDown = true;
            this.dtpMonthFilter.Size = new System.Drawing.Size(184, 29);
            this.dtpMonthFilter.TabIndex = 53;
            // 
            // HOrderHistory
            // 
            this.HOrderHistory.BackColor = System.Drawing.Color.White;
            this.HOrderHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HOrderHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.HOrderHistory.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOrderHistory.Location = new System.Drawing.Point(20, 23);
            this.HOrderHistory.Name = "HOrderHistory";
            this.HOrderHistory.ReadOnly = true;
            this.HOrderHistory.Size = new System.Drawing.Size(1287, 56);
            this.HOrderHistory.TabIndex = 28;
            this.HOrderHistory.Text = "Order History";
            this.HOrderHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_ไม่มีกรอบ;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.TabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabShow.ResumeLayout(false);
            this.TabShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel TabAll;
        private RoundedButton BtBackToAccount;
        private RoundedButton BtSignOut;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabShow;
        private System.Windows.Forms.TextBox HOrderHistory;
        private System.Windows.Forms.DateTimePicker dtpMonthFilter;
        private System.Windows.Forms.FlowLayoutPanel flowOrderHistory;
    }
}