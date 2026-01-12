namespace FuzzyKits
{
    partial class AdminProductsAdd
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
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.BtConfirm = new RoundedButton();
            this.BtChoosePicItem = new RoundedButton();
            this.tabShoeProducts = new RoundedPanel();
            this.PicItem = new System.Windows.Forms.PictureBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.ChooseCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new RoundTextBox();
            this.txtProductName = new RoundTextBox();
            this.BtEdit = new RoundedButton();
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.TabAll = new RoundedPanel();
            this.BtBack = new RoundedButton();
            this.HAddProduct = new System.Windows.Forms.TextBox();
            this.BtSignOut = new RoundedButton();
            this.BtOrder = new RoundedButton();
            this.BtPromotion = new RoundedButton();
            this.BtProducts = new RoundedButton();
            this.TabMenu = new RoundedPanel();
            this.BtDashboard = new RoundedButton();
            this.tabShoeProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(57, 304);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(158, 34);
            this.ProductName.TabIndex = 13;
            this.ProductName.Text = "ชื่อสินค้า";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.White;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Price.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Price.Location = new System.Drawing.Point(57, 357);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(158, 34);
            this.Price.TabIndex = 12;
            this.Price.Text = "ราคา";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.White;
            this.Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Category.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Category.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Category.Location = new System.Drawing.Point(57, 412);
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Size = new System.Drawing.Size(158, 34);
            this.Category.TabIndex = 11;
            this.Category.Text = "หมวดหมู่";
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.White;
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Stock.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.Stock.Location = new System.Drawing.Point(57, 465);
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Size = new System.Drawing.Size(158, 34);
            this.Stock.TabIndex = 10;
            this.Stock.Text = "จำนวน";
            // 
            // BtConfirm
            // 
            this.BtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtConfirm.BorderColor = System.Drawing.Color.Black;
            this.BtConfirm.BorderRadius = 20;
            this.BtConfirm.BorderThickness = 3;
            this.BtConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConfirm.FlatAppearance.BorderSize = 0;
            this.BtConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtConfirm.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtConfirm.Location = new System.Drawing.Point(776, 636);
            this.BtConfirm.Name = "BtConfirm";
            this.BtConfirm.Size = new System.Drawing.Size(200, 40);
            this.BtConfirm.TabIndex = 2;
            this.BtConfirm.Text = "Confirm";
            this.BtConfirm.UseVisualStyleBackColor = false;
            this.BtConfirm.Click += new System.EventHandler(this.BtConfirm_Click);
            // 
            // BtChoosePicItem
            // 
            this.BtChoosePicItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtChoosePicItem.BorderColor = System.Drawing.Color.Black;
            this.BtChoosePicItem.BorderRadius = 20;
            this.BtChoosePicItem.BorderThickness = 3;
            this.BtChoosePicItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtChoosePicItem.FlatAppearance.BorderSize = 0;
            this.BtChoosePicItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtChoosePicItem.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtChoosePicItem.Location = new System.Drawing.Point(351, 245);
            this.BtChoosePicItem.Name = "BtChoosePicItem";
            this.BtChoosePicItem.Size = new System.Drawing.Size(200, 40);
            this.BtChoosePicItem.TabIndex = 21;
            this.BtChoosePicItem.Text = "Choose";
            this.BtChoosePicItem.UseVisualStyleBackColor = false;
            this.BtChoosePicItem.Click += new System.EventHandler(this.BtChoosePicItem_Click_1);
            // 
            // tabShoeProducts
            // 
            this.tabShoeProducts.BorderColor = System.Drawing.Color.Black;
            this.tabShoeProducts.BorderRadius = 25;
            this.tabShoeProducts.BorderThickness = 2;
            this.tabShoeProducts.Controls.Add(this.PicItem);
            this.tabShoeProducts.Controls.Add(this.numStock);
            this.tabShoeProducts.Controls.Add(this.ChooseCategory);
            this.tabShoeProducts.Controls.Add(this.txtPrice);
            this.tabShoeProducts.Controls.Add(this.txtProductName);
            this.tabShoeProducts.Controls.Add(this.BtEdit);
            this.tabShoeProducts.Controls.Add(this.BtChoosePicItem);
            this.tabShoeProducts.Controls.Add(this.ProductName);
            this.tabShoeProducts.Controls.Add(this.Price);
            this.tabShoeProducts.Controls.Add(this.Category);
            this.tabShoeProducts.Controls.Add(this.Stock);
            this.tabShoeProducts.Location = new System.Drawing.Point(20, 90);
            this.tabShoeProducts.Name = "tabShoeProducts";
            this.tabShoeProducts.Size = new System.Drawing.Size(955, 529);
            this.tabShoeProducts.TabIndex = 4;
            // 
            // PicItem
            // 
            this.PicItem.Location = new System.Drawing.Point(351, 26);
            this.PicItem.Name = "PicItem";
            this.PicItem.Size = new System.Drawing.Size(200, 213);
            this.PicItem.TabIndex = 28;
            this.PicItem.TabStop = false;
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.numStock.Location = new System.Drawing.Point(245, 458);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(294, 37);
            this.numStock.TabIndex = 27;
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.ChooseCategory.FormattingEnabled = true;
            this.ChooseCategory.Location = new System.Drawing.Point(245, 408);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(557, 38);
            this.ChooseCategory.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.BorderRadius = 20;
            this.txtPrice.BorderThickness = 2;
            this.txtPrice.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtPrice.Location = new System.Drawing.Point(245, 355);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10);
            this.txtPrice.Size = new System.Drawing.Size(557, 45);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderColor = System.Drawing.Color.Black;
            this.txtProductName.BorderRadius = 20;
            this.txtProductName.BorderThickness = 2;
            this.txtProductName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtProductName.Location = new System.Drawing.Point(245, 304);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Padding = new System.Windows.Forms.Padding(10);
            this.txtProductName.Size = new System.Drawing.Size(557, 45);
            this.txtProductName.TabIndex = 24;
            this.txtProductName.UseSystemPasswordChar = false;
            // 
            // BtEdit
            // 
            this.BtEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtEdit.BorderColor = System.Drawing.Color.Black;
            this.BtEdit.BorderRadius = 15;
            this.BtEdit.BorderThickness = 2;
            this.BtEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEdit.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.Location = new System.Drawing.Point(808, 408);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(88, 38);
            this.BtEdit.TabIndex = 21;
            this.BtEdit.Text = "Edit";
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click_1);
            // 
            // SmallLogo
            // 
            this.SmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.SmallLogo.Image = global::FuzzyKits.Properties.Resources.SmallLogo;
            this.SmallLogo.Location = new System.Drawing.Point(30, 670);
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.Size = new System.Drawing.Size(300, 55);
            this.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallLogo.TabIndex = 19;
            this.SmallLogo.TabStop = false;
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.Black;
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 5;
            this.TabAll.Controls.Add(this.BtBack);
            this.TabAll.Controls.Add(this.HAddProduct);
            this.TabAll.Controls.Add(this.BtConfirm);
            this.TabAll.Controls.Add(this.tabShoeProducts);
            this.TabAll.Location = new System.Drawing.Point(360, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(995, 695);
            this.TabAll.TabIndex = 20;
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtBack.BorderColor = System.Drawing.Color.Black;
            this.BtBack.BorderRadius = 20;
            this.BtBack.BorderThickness = 3;
            this.BtBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBack.FlatAppearance.BorderSize = 0;
            this.BtBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtBack.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtBack.Location = new System.Drawing.Point(20, 636);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(200, 40);
            this.BtBack.TabIndex = 8;
            this.BtBack.Text = "Back";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // HAddProduct
            // 
            this.HAddProduct.BackColor = System.Drawing.Color.White;
            this.HAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HAddProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.HAddProduct.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HAddProduct.Location = new System.Drawing.Point(20, 20);
            this.HAddProduct.Name = "HAddProduct";
            this.HAddProduct.ReadOnly = true;
            this.HAddProduct.Size = new System.Drawing.Size(955, 56);
            this.HAddProduct.TabIndex = 7;
            this.HAddProduct.Text = "Add Product";
            this.HAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtSignOut.Location = new System.Drawing.Point(26, 516);
            this.BtSignOut.Name = "BtSignOut";
            this.BtSignOut.Size = new System.Drawing.Size(250, 55);
            this.BtSignOut.TabIndex = 0;
            this.BtSignOut.Text = "Sign Out";
            this.BtSignOut.UseVisualStyleBackColor = false;
            // 
            // BtOrder
            // 
            this.BtOrder.BorderColor = System.Drawing.Color.Black;
            this.BtOrder.BorderRadius = 25;
            this.BtOrder.BorderThickness = 4;
            this.BtOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtOrder.FlatAppearance.BorderSize = 0;
            this.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtOrder.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtOrder.Location = new System.Drawing.Point(26, 276);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(250, 55);
            this.BtOrder.TabIndex = 0;
            this.BtOrder.Text = "Order";
            this.BtOrder.UseVisualStyleBackColor = true;
            // 
            // BtPromotion
            // 
            this.BtPromotion.BorderColor = System.Drawing.Color.Black;
            this.BtPromotion.BorderRadius = 25;
            this.BtPromotion.BorderThickness = 4;
            this.BtPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPromotion.FlatAppearance.BorderSize = 0;
            this.BtPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPromotion.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtPromotion.Location = new System.Drawing.Point(26, 201);
            this.BtPromotion.Name = "BtPromotion";
            this.BtPromotion.Size = new System.Drawing.Size(250, 55);
            this.BtPromotion.TabIndex = 0;
            this.BtPromotion.Text = "Promotion";
            this.BtPromotion.UseVisualStyleBackColor = true;
            // 
            // BtProducts
            // 
            this.BtProducts.BackColor = System.Drawing.Color.White;
            this.BtProducts.BorderColor = System.Drawing.Color.Black;
            this.BtProducts.BorderRadius = 25;
            this.BtProducts.BorderThickness = 4;
            this.BtProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtProducts.FlatAppearance.BorderSize = 0;
            this.BtProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtProducts.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtProducts.ForeColor = System.Drawing.Color.Black;
            this.BtProducts.Location = new System.Drawing.Point(26, 126);
            this.BtProducts.Name = "BtProducts";
            this.BtProducts.Size = new System.Drawing.Size(250, 55);
            this.BtProducts.TabIndex = 0;
            this.BtProducts.Text = "Products";
            this.BtProducts.UseVisualStyleBackColor = false;
            // 
            // TabMenu
            // 
            this.TabMenu.BackColor = System.Drawing.Color.White;
            this.TabMenu.BorderColor = System.Drawing.Color.Black;
            this.TabMenu.BorderRadius = 25;
            this.TabMenu.BorderThickness = 5;
            this.TabMenu.Controls.Add(this.BtSignOut);
            this.TabMenu.Controls.Add(this.BtOrder);
            this.TabMenu.Controls.Add(this.BtPromotion);
            this.TabMenu.Controls.Add(this.BtProducts);
            this.TabMenu.Controls.Add(this.BtDashboard);
            this.TabMenu.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TabMenu.ForeColor = System.Drawing.Color.Black;
            this.TabMenu.Location = new System.Drawing.Point(30, 30);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Size = new System.Drawing.Size(300, 615);
            this.TabMenu.TabIndex = 18;
            // 
            // BtDashboard
            // 
            this.BtDashboard.BackColor = System.Drawing.Color.White;
            this.BtDashboard.BorderColor = System.Drawing.Color.Black;
            this.BtDashboard.BorderRadius = 25;
            this.BtDashboard.BorderThickness = 4;
            this.BtDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDashboard.FlatAppearance.BorderSize = 0;
            this.BtDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDashboard.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtDashboard.ForeColor = System.Drawing.Color.Black;
            this.BtDashboard.Location = new System.Drawing.Point(26, 51);
            this.BtDashboard.Name = "BtDashboard";
            this.BtDashboard.Size = new System.Drawing.Size(250, 55);
            this.BtDashboard.TabIndex = 0;
            this.BtDashboard.Text = "Dashboard";
            this.BtDashboard.UseVisualStyleBackColor = false;
            // 
            // AdminProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.ไม่มีกรอบ_สีเทา;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.TabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProductsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits for Admin";
            this.Load += new System.EventHandler(this.AdminProductsAdd_Load);
            this.tabShoeProducts.ResumeLayout(false);
            this.tabShoeProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Stock;
        private RoundedButton BtConfirm;
        private RoundedButton BtChoosePicItem;
        private RoundedPanel tabShoeProducts;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabAll;
        private RoundedButton BtSignOut;
        private RoundedButton BtOrder;
        private RoundedButton BtPromotion;
        private RoundedButton BtProducts;
        private RoundedPanel TabMenu;
        private RoundedButton BtDashboard;
        private RoundedButton BtEdit;
        private System.Windows.Forms.TextBox HAddProduct;
        private RoundTextBox txtProductName;
        private System.Windows.Forms.ComboBox ChooseCategory;
        private RoundTextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.PictureBox PicItem;
        private RoundedButton BtBack;
    }
}