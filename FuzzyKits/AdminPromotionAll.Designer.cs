namespace FuzzyKits
{
    partial class AdminPromotionAll
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
            this.BtAdd = new RoundedButton();
            this.tabShow = new RoundedPanel();
            this.tabPromotionList = new System.Windows.Forms.FlowLayoutPanel();
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.TabAll = new RoundedPanel();
            this.HPromotionList = new System.Windows.Forms.TextBox();
            this.BtSignOut = new RoundedButton();
            this.BtOrder = new RoundedButton();
            this.BtPromotion = new RoundedButton();
            this.BtProducts = new RoundedButton();
            this.TabMenu = new RoundedPanel();
            this.BtDashboard = new RoundedButton();
            this.tabShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.BtAdd.Location = new System.Drawing.Point(776, 636);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(200, 40);
            this.BtAdd.TabIndex = 7;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // tabShow
            // 
            this.tabShow.BorderColor = System.Drawing.Color.Black;
            this.tabShow.BorderRadius = 25;
            this.tabShow.BorderThickness = 2;
            this.tabShow.Controls.Add(this.tabPromotionList);
            this.tabShow.Location = new System.Drawing.Point(21, 92);
            this.tabShow.Name = "tabShow";
            this.tabShow.Size = new System.Drawing.Size(955, 529);
            this.tabShow.TabIndex = 4;
            // 
            // tabPromotionList
            // 
            this.tabPromotionList.AutoScroll = true;
            this.tabPromotionList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tabPromotionList.Location = new System.Drawing.Point(14, 15);
            this.tabPromotionList.Name = "tabPromotionList";
            this.tabPromotionList.Size = new System.Drawing.Size(925, 499);
            this.tabPromotionList.TabIndex = 0;
            this.tabPromotionList.WrapContents = false;
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
            this.TabAll.Controls.Add(this.HPromotionList);
            this.TabAll.Controls.Add(this.BtAdd);
            this.TabAll.Controls.Add(this.tabShow);
            this.TabAll.Location = new System.Drawing.Point(360, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(995, 695);
            this.TabAll.TabIndex = 20;
            // 
            // HPromotionList
            // 
            this.HPromotionList.BackColor = System.Drawing.Color.White;
            this.HPromotionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HPromotionList.Cursor = System.Windows.Forms.Cursors.Default;
            this.HPromotionList.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPromotionList.Location = new System.Drawing.Point(20, 20);
            this.HPromotionList.Name = "HPromotionList";
            this.HPromotionList.ReadOnly = true;
            this.HPromotionList.Size = new System.Drawing.Size(955, 56);
            this.HPromotionList.TabIndex = 28;
            this.HPromotionList.Text = "Promotion List";
            this.HPromotionList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtPromotion.BackColor = System.Drawing.Color.Black;
            this.BtPromotion.BorderColor = System.Drawing.Color.Black;
            this.BtPromotion.BorderRadius = 20;
            this.BtPromotion.BorderThickness = 4;
            this.BtPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPromotion.FlatAppearance.BorderSize = 0;
            this.BtPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPromotion.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtPromotion.ForeColor = System.Drawing.Color.White;
            this.BtPromotion.Location = new System.Drawing.Point(26, 201);
            this.BtPromotion.Name = "BtPromotion";
            this.BtPromotion.Size = new System.Drawing.Size(250, 55);
            this.BtPromotion.TabIndex = 0;
            this.BtPromotion.Text = "Promotion";
            this.BtPromotion.UseVisualStyleBackColor = false;
            // 
            // BtProducts
            // 
            this.BtProducts.BackColor = System.Drawing.Color.White;
            this.BtProducts.BorderColor = System.Drawing.Color.Black;
            this.BtProducts.BorderRadius = 20;
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
            this.BtProducts.Click += new System.EventHandler(this.BtProducts_Click);
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
            // AdminPromotionAll
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
            this.Name = "AdminPromotionAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits for Admin";
            this.tabShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedButton BtAdd;
        private RoundedPanel tabShow;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabAll;
        private RoundedButton BtSignOut;
        private RoundedButton BtOrder;
        private RoundedButton BtPromotion;
        private RoundedButton BtProducts;
        private RoundedPanel TabMenu;
        private RoundedButton BtDashboard;
        private System.Windows.Forms.TextBox HPromotionList;
        private System.Windows.Forms.FlowLayoutPanel tabPromotionList;
    }
}