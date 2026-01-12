namespace FuzzyKits
{
    partial class Shop
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
            this.TabShow = new RoundedPanel();
            this.ShowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPromotion = new System.Windows.Forms.FlowLayoutPanel();
            this.TabMenu = new RoundedPanel();
            this.HCategory = new System.Windows.Forms.TextBox();
            this.ChooseCategory = new System.Windows.Forms.ComboBox();
            this.BtSignOut = new RoundedButton();
            this.TabAll = new RoundedPanel();
            this.Search = new System.Windows.Forms.TextBox();
            this.txtSearch = new RoundTextBox();
            this.IconSearch = new System.Windows.Forms.PictureBox();
            this.IconShoppingCart = new System.Windows.Forms.PictureBox();
            this.IconAccount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabShow.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.TabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // SmallLogo
            // 
            this.SmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.SmallLogo.Image = global::FuzzyKits.Properties.Resources.SmallLogo;
            this.SmallLogo.Location = new System.Drawing.Point(30, 30);
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.Size = new System.Drawing.Size(300, 60);
            this.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmallLogo.TabIndex = 13;
            this.SmallLogo.TabStop = false;
            // 
            // TabShow
            // 
            this.TabShow.BackColor = System.Drawing.Color.White;
            this.TabShow.BorderColor = System.Drawing.Color.Black;
            this.TabShow.BorderRadius = 25;
            this.TabShow.BorderThickness = 4;
            this.TabShow.Controls.Add(this.ShowProducts);
            this.TabShow.Controls.Add(this.ShowPromotion);
            this.TabShow.Location = new System.Drawing.Point(355, 105);
            this.TabShow.Name = "TabShow";
            this.TabShow.Size = new System.Drawing.Size(1000, 620);
            this.TabShow.TabIndex = 14;
            // 
            // ShowProducts
            // 
            this.ShowProducts.AutoScroll = true;
            this.ShowProducts.Location = new System.Drawing.Point(20, 217);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(958, 382);
            this.ShowProducts.TabIndex = 1;
            // 
            // ShowPromotion
            // 
            this.ShowPromotion.AutoScroll = true;
            this.ShowPromotion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShowPromotion.Location = new System.Drawing.Point(20, 19);
            this.ShowPromotion.Name = "ShowPromotion";
            this.ShowPromotion.Size = new System.Drawing.Size(958, 192);
            this.ShowPromotion.TabIndex = 0;
            this.ShowPromotion.WrapContents = false;
            // 
            // TabMenu
            // 
            this.TabMenu.BackColor = System.Drawing.Color.White;
            this.TabMenu.BorderColor = System.Drawing.Color.Black;
            this.TabMenu.BorderRadius = 25;
            this.TabMenu.BorderThickness = 4;
            this.TabMenu.Controls.Add(this.HCategory);
            this.TabMenu.Controls.Add(this.ChooseCategory);
            this.TabMenu.Controls.Add(this.BtSignOut);
            this.TabMenu.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TabMenu.ForeColor = System.Drawing.Color.Black;
            this.TabMenu.Location = new System.Drawing.Point(30, 105);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Size = new System.Drawing.Size(300, 620);
            this.TabMenu.TabIndex = 12;
            // 
            // HCategory
            // 
            this.HCategory.BackColor = System.Drawing.Color.White;
            this.HCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HCategory.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.HCategory.Location = new System.Drawing.Point(25, 25);
            this.HCategory.Name = "HCategory";
            this.HCategory.ReadOnly = true;
            this.HCategory.Size = new System.Drawing.Size(250, 41);
            this.HCategory.TabIndex = 31;
            this.HCategory.Text = "หมวดหมู่สินค้า";
            this.HCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.FormattingEnabled = true;
            this.ChooseCategory.Location = new System.Drawing.Point(25, 72);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(250, 38);
            this.ChooseCategory.TabIndex = 30;
            this.ChooseCategory.Text = "เลือกหมวดหมู่";
            // 
            // BtSignOut
            // 
            this.BtSignOut.BackColor = System.Drawing.Color.DarkGray;
            this.BtSignOut.BorderColor = System.Drawing.Color.Black;
            this.BtSignOut.BorderRadius = 25;
            this.BtSignOut.BorderThickness = 4;
            this.BtSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSignOut.FlatAppearance.BorderSize = 0;
            this.BtSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtSignOut.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtSignOut.ForeColor = System.Drawing.Color.Black;
            this.BtSignOut.Location = new System.Drawing.Point(25, 550);
            this.BtSignOut.Name = "BtSignOut";
            this.BtSignOut.Size = new System.Drawing.Size(250, 50);
            this.BtSignOut.TabIndex = 0;
            this.BtSignOut.Text = "Sign Out";
            this.BtSignOut.UseVisualStyleBackColor = false;
            this.BtSignOut.Click += new System.EventHandler(this.BtSignOut_Click);
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 4;
            this.TabAll.Controls.Add(this.Search);
            this.TabAll.Controls.Add(this.txtSearch);
            this.TabAll.Controls.Add(this.IconSearch);
            this.TabAll.Controls.Add(this.IconShoppingCart);
            this.TabAll.Controls.Add(this.IconAccount);
            this.TabAll.Location = new System.Drawing.Point(355, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(1000, 60);
            this.TabAll.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(30, 11);
            this.Search.Name = "Search";
            this.Search.ReadOnly = true;
            this.Search.Size = new System.Drawing.Size(100, 38);
            this.Search.TabIndex = 18;
            this.Search.Text = "ค้นหา";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtSearch.Location = new System.Drawing.Point(140, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10);
            this.txtSearch.Size = new System.Drawing.Size(600, 45);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // IconSearch
            // 
            this.IconSearch.BackColor = System.Drawing.Color.Transparent;
            this.IconSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconSearch.Image = global::FuzzyKits.Properties.Resources.Search;
            this.IconSearch.Location = new System.Drawing.Point(750, 8);
            this.IconSearch.Name = "IconSearch";
            this.IconSearch.Size = new System.Drawing.Size(45, 45);
            this.IconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconSearch.TabIndex = 16;
            this.IconSearch.TabStop = false;
            this.IconSearch.Click += new System.EventHandler(this.IconSearch_Click);
            // 
            // IconShoppingCart
            // 
            this.IconShoppingCart.BackColor = System.Drawing.Color.Transparent;
            this.IconShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconShoppingCart.Image = global::FuzzyKits.Properties.Resources.Cart;
            this.IconShoppingCart.Location = new System.Drawing.Point(860, 8);
            this.IconShoppingCart.Name = "IconShoppingCart";
            this.IconShoppingCart.Size = new System.Drawing.Size(45, 45);
            this.IconShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconShoppingCart.TabIndex = 15;
            this.IconShoppingCart.TabStop = false;
            this.IconShoppingCart.Click += new System.EventHandler(this.IconShoppingCart_Click);
            // 
            // IconAccount
            // 
            this.IconAccount.BackColor = System.Drawing.Color.Transparent;
            this.IconAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconAccount.Image = global::FuzzyKits.Properties.Resources.User;
            this.IconAccount.Location = new System.Drawing.Point(920, 8);
            this.IconAccount.Name = "IconAccount";
            this.IconAccount.Size = new System.Drawing.Size(45, 45);
            this.IconAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconAccount.TabIndex = 14;
            this.IconAccount.TabStop = false;
            this.IconAccount.Click += new System.EventHandler(this.IconAccount_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_ไม่มีกรอบ;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabShow);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabShow.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.TabMenu.PerformLayout();
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel TabAll;
        private RoundedPanel TabShow;
        private RoundedPanel TabMenu;
        private RoundedButton BtSignOut;
        private System.Windows.Forms.PictureBox SmallLogo;
        private System.Windows.Forms.PictureBox IconShoppingCart;
        private System.Windows.Forms.PictureBox IconAccount;
        private System.Windows.Forms.PictureBox IconSearch;
        private System.Windows.Forms.TextBox Search;
        private RoundTextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel ShowPromotion;
        private System.Windows.Forms.FlowLayoutPanel ShowProducts;
        private System.Windows.Forms.ComboBox ChooseCategory;
        private System.Windows.Forms.TextBox HCategory;
    }
}