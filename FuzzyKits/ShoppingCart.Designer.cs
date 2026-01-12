namespace FuzzyKits
{
    partial class ShoppingCart
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
            this.TabAll = new RoundedPanel();
            this.IconAccount = new System.Windows.Forms.PictureBox();
            this.BtBackToShop = new RoundedButton();
            this.BtSignOut = new RoundedButton();
            this.TabShow = new RoundedPanel();
            this.btApplyCode = new RoundedButton();
            this.txtPromoCode = new RoundTextBox();
            this.PromoCode = new System.Windows.Forms.TextBox();
            this.BtCheckout = new RoundedButton();
            this.ShowCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.Baht = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new RoundTextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.Items = new System.Windows.Forms.TextBox();
            this.HShoppingCart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconAccount)).BeginInit();
            this.TabShow.SuspendLayout();
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
            this.SmallLogo.TabIndex = 20;
            this.SmallLogo.TabStop = false;
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 4;
            this.TabAll.Controls.Add(this.IconAccount);
            this.TabAll.Controls.Add(this.BtBackToShop);
            this.TabAll.Controls.Add(this.BtSignOut);
            this.TabAll.Location = new System.Drawing.Point(354, 24);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(1000, 60);
            this.TabAll.TabIndex = 19;
            // 
            // IconAccount
            // 
            this.IconAccount.BackColor = System.Drawing.Color.Transparent;
            this.IconAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconAccount.Image = global::FuzzyKits.Properties.Resources.User;
            this.IconAccount.Location = new System.Drawing.Point(730, 8);
            this.IconAccount.Name = "IconAccount";
            this.IconAccount.Size = new System.Drawing.Size(45, 45);
            this.IconAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconAccount.TabIndex = 16;
            this.IconAccount.TabStop = false;
            this.IconAccount.Click += new System.EventHandler(this.IconAccount_Click);
            // 
            // BtBackToShop
            // 
            this.BtBackToShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtBackToShop.BorderColor = System.Drawing.Color.Black;
            this.BtBackToShop.BorderRadius = 25;
            this.BtBackToShop.BorderThickness = 3;
            this.BtBackToShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBackToShop.FlatAppearance.BorderSize = 0;
            this.BtBackToShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBackToShop.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtBackToShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtBackToShop.Location = new System.Drawing.Point(2, 3);
            this.BtBackToShop.Name = "BtBackToShop";
            this.BtBackToShop.Size = new System.Drawing.Size(243, 55);
            this.BtBackToShop.TabIndex = 0;
            this.BtBackToShop.Text = "Back To Shop";
            this.BtBackToShop.UseVisualStyleBackColor = false;
            this.BtBackToShop.Click += new System.EventHandler(this.BtBackToShop_Click);
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
            // TabShow
            // 
            this.TabShow.BackColor = System.Drawing.Color.White;
            this.TabShow.BorderColor = System.Drawing.Color.Black;
            this.TabShow.BorderRadius = 25;
            this.TabShow.BorderThickness = 4;
            this.TabShow.Controls.Add(this.btApplyCode);
            this.TabShow.Controls.Add(this.txtPromoCode);
            this.TabShow.Controls.Add(this.PromoCode);
            this.TabShow.Controls.Add(this.BtCheckout);
            this.TabShow.Controls.Add(this.ShowCartItems);
            this.TabShow.Controls.Add(this.Baht);
            this.TabShow.Controls.Add(this.txtTotalPrice);
            this.TabShow.Controls.Add(this.Total);
            this.TabShow.Controls.Add(this.Quantity);
            this.TabShow.Controls.Add(this.Subtotal);
            this.TabShow.Controls.Add(this.Items);
            this.TabShow.Controls.Add(this.HShoppingCart);
            this.TabShow.Location = new System.Drawing.Point(30, 109);
            this.TabShow.Name = "TabShow";
            this.TabShow.Size = new System.Drawing.Size(1324, 620);
            this.TabShow.TabIndex = 21;
            // 
            // btApplyCode
            // 
            this.btApplyCode.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btApplyCode.BorderColor = System.Drawing.Color.Black;
            this.btApplyCode.BorderRadius = 15;
            this.btApplyCode.BorderThickness = 2;
            this.btApplyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApplyCode.FlatAppearance.BorderSize = 0;
            this.btApplyCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btApplyCode.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplyCode.Location = new System.Drawing.Point(434, 565);
            this.btApplyCode.Name = "btApplyCode";
            this.btApplyCode.Size = new System.Drawing.Size(88, 38);
            this.btApplyCode.TabIndex = 54;
            this.btApplyCode.Text = "Apply";
            this.btApplyCode.UseVisualStyleBackColor = false;
            this.btApplyCode.Click += new System.EventHandler(this.btApplyCode_Click);
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPromoCode.BackColor = System.Drawing.Color.White;
            this.txtPromoCode.BorderColor = System.Drawing.Color.Black;
            this.txtPromoCode.BorderRadius = 20;
            this.txtPromoCode.BorderThickness = 2;
            this.txtPromoCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPromoCode.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoCode.Location = new System.Drawing.Point(166, 561);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPromoCode.Size = new System.Drawing.Size(262, 46);
            this.txtPromoCode.TabIndex = 52;
            this.txtPromoCode.UseSystemPasswordChar = false;
            // 
            // PromoCode
            // 
            this.PromoCode.BackColor = System.Drawing.Color.White;
            this.PromoCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PromoCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.PromoCode.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCode.Location = new System.Drawing.Point(20, 563);
            this.PromoCode.Name = "PromoCode";
            this.PromoCode.ReadOnly = true;
            this.PromoCode.Size = new System.Drawing.Size(140, 34);
            this.PromoCode.TabIndex = 53;
            this.PromoCode.Text = "โค้ดส่วนลด";
            this.PromoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtCheckout
            // 
            this.BtCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtCheckout.BorderColor = System.Drawing.Color.Black;
            this.BtCheckout.BorderRadius = 25;
            this.BtCheckout.BorderThickness = 3;
            this.BtCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCheckout.FlatAppearance.BorderSize = 0;
            this.BtCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCheckout.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCheckout.Location = new System.Drawing.Point(1123, 557);
            this.BtCheckout.Name = "BtCheckout";
            this.BtCheckout.Size = new System.Drawing.Size(182, 50);
            this.BtCheckout.TabIndex = 51;
            this.BtCheckout.Text = "Checkout";
            this.BtCheckout.UseVisualStyleBackColor = false;
            this.BtCheckout.Click += new System.EventHandler(this.BtCheckout_Click);
            // 
            // ShowCartItems
            // 
            this.ShowCartItems.AutoScroll = true;
            this.ShowCartItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShowCartItems.Location = new System.Drawing.Point(20, 135);
            this.ShowCartItems.Name = "ShowCartItems";
            this.ShowCartItems.Padding = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.ShowCartItems.Size = new System.Drawing.Size(1285, 410);
            this.ShowCartItems.TabIndex = 50;
            this.ShowCartItems.WrapContents = false;
            // 
            // Baht
            // 
            this.Baht.BackColor = System.Drawing.Color.White;
            this.Baht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Baht.Cursor = System.Windows.Forms.Cursors.Default;
            this.Baht.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Baht.Location = new System.Drawing.Point(1037, 563);
            this.Baht.Name = "Baht";
            this.Baht.ReadOnly = true;
            this.Baht.Size = new System.Drawing.Size(59, 34);
            this.Baht.TabIndex = 48;
            this.Baht.Text = "บาท";
            this.Baht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Black;
            this.txtTotalPrice.BorderRadius = 20;
            this.txtTotalPrice.BorderThickness = 2;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(768, 561);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalPrice.Size = new System.Drawing.Size(263, 46);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.UseSystemPasswordChar = false;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.White;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total.Cursor = System.Windows.Forms.Cursors.Default;
            this.Total.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(623, 563);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(139, 34);
            this.Total.TabIndex = 0;
            this.Total.Text = "รวมทั้งหมด";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.White;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.Quantity.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(575, 100);
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(404, 34);
            this.Quantity.TabIndex = 46;
            this.Quantity.Text = "จำนวน";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Subtotal
            // 
            this.Subtotal.BackColor = System.Drawing.Color.White;
            this.Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subtotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.Subtotal.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(985, 100);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Size = new System.Drawing.Size(320, 34);
            this.Subtotal.TabIndex = 38;
            this.Subtotal.Text = "รวมราคา";
            this.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.Color.White;
            this.Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Items.Cursor = System.Windows.Forms.Cursors.Default;
            this.Items.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.Location = new System.Drawing.Point(20, 100);
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Size = new System.Drawing.Size(549, 34);
            this.Items.TabIndex = 37;
            this.Items.Text = "รายการสินค้า";
            this.Items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HShoppingCart
            // 
            this.HShoppingCart.BackColor = System.Drawing.Color.White;
            this.HShoppingCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HShoppingCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.HShoppingCart.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HShoppingCart.Location = new System.Drawing.Point(20, 23);
            this.HShoppingCart.Name = "HShoppingCart";
            this.HShoppingCart.ReadOnly = true;
            this.HShoppingCart.Size = new System.Drawing.Size(1287, 56);
            this.HShoppingCart.TabIndex = 28;
            this.HShoppingCart.Text = "Shopping Cart";
            this.HShoppingCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShoppingCart
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
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconAccount)).EndInit();
            this.TabShow.ResumeLayout(false);
            this.TabShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton BtSignOut;
        private RoundTextBox txtTotalPrice;
        private RoundedPanel TabAll;
        private System.Windows.Forms.PictureBox IconAccount;
        private RoundedButton BtBackToShop;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.PictureBox SmallLogo;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.TextBox HShoppingCart;
        private System.Windows.Forms.TextBox Items;
        private RoundedPanel TabShow;
        private System.Windows.Forms.TextBox Baht;
        private System.Windows.Forms.FlowLayoutPanel ShowCartItems;
        private RoundedButton BtCheckout;
        private RoundTextBox txtPromoCode;
        private System.Windows.Forms.TextBox PromoCode;
        private RoundedButton btApplyCode;
    }
}