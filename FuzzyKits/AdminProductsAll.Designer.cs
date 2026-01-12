namespace FuzzyKits
{
    partial class AdminProductsAll
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
            this.BtAdd = new RoundedButton();
            this.ShowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.HProductAll = new System.Windows.Forms.TextBox();
            this.BtEdit = new RoundedButton();
            this.TabMenu = new RoundedPanel();
            this.BtSignOut = new RoundedButton();
            this.BtOrder = new RoundedButton();
            this.BtPromotion = new RoundedButton();
            this.BtProducts = new RoundedButton();
            this.BtDashboard = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SmallLogo
            // 
            this.SmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.SmallLogo.Image = global::FuzzyKits.Properties.Resources.SmallLogo;
            this.SmallLogo.Location = new System.Drawing.Point(30, 670);
            this.SmallLogo.Name = "SmallLogo";
            this.SmallLogo.Size = new System.Drawing.Size(300, 55);
            this.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallLogo.TabIndex = 13;
            this.SmallLogo.TabStop = false;
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.Black;
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 5;
            this.TabAll.Controls.Add(this.BtAdd);
            this.TabAll.Controls.Add(this.ShowProducts);
            this.TabAll.Controls.Add(this.cmbCategory);
            this.TabAll.Controls.Add(this.HProductAll);
            this.TabAll.Controls.Add(this.BtEdit);
            this.TabAll.Location = new System.Drawing.Point(360, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(995, 695);
            this.TabAll.TabIndex = 14;
            this.TabAll.Paint += new System.Windows.Forms.PaintEventHandler(this.TabAll_Paint);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtAdd.BorderColor = System.Drawing.Color.Black;
            this.BtAdd.BorderRadius = 20;
            this.BtAdd.BorderThickness = 3;
            this.BtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAdd.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtAdd.Location = new System.Drawing.Point(570, 636);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(200, 40);
            this.BtAdd.TabIndex = 29;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // ShowProducts
            // 
            this.ShowProducts.Location = new System.Drawing.Point(20, 92);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(955, 529);
            this.ShowProducts.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(49, 636);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(392, 38);
            this.cmbCategory.TabIndex = 28;
            // 
            // HProductAll
            // 
            this.HProductAll.BackColor = System.Drawing.Color.White;
            this.HProductAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HProductAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.HProductAll.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HProductAll.Location = new System.Drawing.Point(20, 20);
            this.HProductAll.Name = "HProductAll";
            this.HProductAll.ReadOnly = true;
            this.HProductAll.Size = new System.Drawing.Size(955, 56);
            this.HProductAll.TabIndex = 26;
            this.HProductAll.Text = "Product All";
            this.HProductAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtEdit
            // 
            this.BtEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtEdit.BorderColor = System.Drawing.Color.Black;
            this.BtEdit.BorderRadius = 20;
            this.BtEdit.BorderThickness = 3;
            this.BtEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEdit.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtEdit.Location = new System.Drawing.Point(776, 636);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(200, 40);
            this.BtEdit.TabIndex = 2;
            this.BtEdit.Text = "Edit";
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
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
            this.TabMenu.TabIndex = 12;
            // 
            // BtSignOut
            // 
            this.BtSignOut.BackColor = System.Drawing.Color.DarkGray;
            this.BtSignOut.BorderColor = System.Drawing.Color.Black;
            this.BtSignOut.BorderRadius = 20;
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
            this.BtSignOut.Click += new System.EventHandler(this.BtSignOut_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.BorderColor = System.Drawing.Color.Black;
            this.BtOrder.BorderRadius = 20;
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
            this.BtOrder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtPromotion
            // 
            this.BtPromotion.BorderColor = System.Drawing.Color.Black;
            this.BtPromotion.BorderRadius = 20;
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
            this.BtPromotion.Click += new System.EventHandler(this.BtPromotion_Click);
            // 
            // BtProducts
            // 
            this.BtProducts.BackColor = System.Drawing.Color.Black;
            this.BtProducts.BorderColor = System.Drawing.Color.Black;
            this.BtProducts.BorderRadius = 20;
            this.BtProducts.BorderThickness = 4;
            this.BtProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtProducts.FlatAppearance.BorderSize = 0;
            this.BtProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtProducts.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtProducts.ForeColor = System.Drawing.Color.White;
            this.BtProducts.Location = new System.Drawing.Point(26, 126);
            this.BtProducts.Name = "BtProducts";
            this.BtProducts.Size = new System.Drawing.Size(250, 55);
            this.BtProducts.TabIndex = 0;
            this.BtProducts.Text = "Products";
            this.BtProducts.UseVisualStyleBackColor = false;
            // 
            // BtDashboard
            // 
            this.BtDashboard.BackColor = System.Drawing.Color.White;
            this.BtDashboard.BorderColor = System.Drawing.Color.Black;
            this.BtDashboard.BorderRadius = 20;
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
            this.BtDashboard.Click += new System.EventHandler(this.BtDashboard_Click);
            // 
            // AdminProductsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.ไม่มีกรอบ_สีเทา;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.SmallLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminProductsAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits for Admin";
            this.Load += new System.EventHandler(this.AdminProductsAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel TabAll;
        private RoundedButton BtEdit;
        private RoundedPanel TabMenu;
        private RoundedButton BtSignOut;
        private RoundedButton BtOrder;
        private RoundedButton BtPromotion;
        private RoundedButton BtProducts;
        private RoundedButton BtDashboard;
        private System.Windows.Forms.PictureBox SmallLogo;
        private System.Windows.Forms.TextBox HProductAll;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.FlowLayoutPanel ShowProducts;
        private RoundedButton BtAdd;
    }
}