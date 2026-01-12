namespace FuzzyKits
{
    partial class AdminOrder
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
            this.TabMenu = new RoundedPanel();
            this.BtSignOut = new RoundedButton();
            this.BtOrder = new RoundedButton();
            this.BtPromotion = new RoundedButton();
            this.BtProducts = new RoundedButton();
            this.BtDashboard = new RoundedButton();
            this.TabAll = new RoundedPanel();
            this.HProductAll = new System.Windows.Forms.TextBox();
            this.cmbStatusAll = new System.Windows.Forms.ComboBox();
            this.tabShoeProducts = new RoundedPanel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.flowTotalPrice = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateStatus = new RoundedButton();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.picSlip = new System.Windows.Forms.PictureBox();
            this.flowItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.flowOrderList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.TabAll.SuspendLayout();
            this.tabShoeProducts.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlip)).BeginInit();
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
            this.SmallLogo.TabIndex = 16;
            this.SmallLogo.TabStop = false;
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
            this.TabMenu.TabIndex = 15;
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
            this.BtSignOut.Click += new System.EventHandler(this.BtSignOut_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.BackColor = System.Drawing.Color.Black;
            this.BtOrder.BorderColor = System.Drawing.Color.Black;
            this.BtOrder.BorderRadius = 25;
            this.BtOrder.BorderThickness = 4;
            this.BtOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtOrder.FlatAppearance.BorderSize = 0;
            this.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtOrder.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtOrder.ForeColor = System.Drawing.Color.White;
            this.BtOrder.Location = new System.Drawing.Point(26, 276);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(250, 55);
            this.BtOrder.TabIndex = 0;
            this.BtOrder.Text = "Order";
            this.BtOrder.UseVisualStyleBackColor = false;
            // 
            // BtPromotion
            // 
            this.BtPromotion.BackColor = System.Drawing.Color.White;
            this.BtPromotion.BorderColor = System.Drawing.Color.Black;
            this.BtPromotion.BorderRadius = 25;
            this.BtPromotion.BorderThickness = 4;
            this.BtPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPromotion.FlatAppearance.BorderSize = 0;
            this.BtPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPromotion.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtPromotion.ForeColor = System.Drawing.Color.Black;
            this.BtPromotion.Location = new System.Drawing.Point(26, 201);
            this.BtPromotion.Name = "BtPromotion";
            this.BtPromotion.Size = new System.Drawing.Size(250, 55);
            this.BtPromotion.TabIndex = 0;
            this.BtPromotion.Text = "Promotion";
            this.BtPromotion.UseVisualStyleBackColor = false;
            this.BtPromotion.Click += new System.EventHandler(this.BtPromotion_Click);
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
            this.BtProducts.Click += new System.EventHandler(this.BtProducts_Click);
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
            this.BtDashboard.Click += new System.EventHandler(this.BtDashboard_Click);
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.Black;
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 5;
            this.TabAll.Controls.Add(this.HProductAll);
            this.TabAll.Controls.Add(this.cmbStatusAll);
            this.TabAll.Controls.Add(this.tabShoeProducts);
            this.TabAll.Location = new System.Drawing.Point(360, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(995, 695);
            this.TabAll.TabIndex = 17;
            // 
            // HProductAll
            // 
            this.HProductAll.AutoCompleteCustomSource.AddRange(new string[] {
            "ทั้งหมด",
            "กำลังดำเนินการ",
            "ชำระเงินแล้ว",
            "กำลังจัดส่ง",
            "เสร็จสมบูรณ์"});
            this.HProductAll.BackColor = System.Drawing.Color.White;
            this.HProductAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HProductAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.HProductAll.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HProductAll.Location = new System.Drawing.Point(21, 21);
            this.HProductAll.Name = "HProductAll";
            this.HProductAll.ReadOnly = true;
            this.HProductAll.Size = new System.Drawing.Size(416, 56);
            this.HProductAll.TabIndex = 27;
            this.HProductAll.Text = "Order";
            this.HProductAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbStatusAll
            // 
            this.cmbStatusAll.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.cmbStatusAll.FormattingEnabled = true;
            this.cmbStatusAll.Items.AddRange(new object[] {
            "ทั้งหมด",
            "กำลังดำเนินการ",
            "ชำระเงินแล้ว",
            "กำลังจัดส่ง",
            "เสร็จสมบูรณ์",
            "ยกเลิกออเดอร์"});
            this.cmbStatusAll.Location = new System.Drawing.Point(738, 30);
            this.cmbStatusAll.Name = "cmbStatusAll";
            this.cmbStatusAll.Size = new System.Drawing.Size(237, 38);
            this.cmbStatusAll.TabIndex = 24;
            this.cmbStatusAll.Text = "สถานะการจัดส่ง";
            // 
            // tabShoeProducts
            // 
            this.tabShoeProducts.BorderColor = System.Drawing.Color.Black;
            this.tabShoeProducts.BorderRadius = 25;
            this.tabShoeProducts.BorderThickness = 2;
            this.tabShoeProducts.Controls.Add(this.panelDetail);
            this.tabShoeProducts.Controls.Add(this.flowOrderList);
            this.tabShoeProducts.Location = new System.Drawing.Point(20, 90);
            this.tabShoeProducts.Name = "tabShoeProducts";
            this.tabShoeProducts.Size = new System.Drawing.Size(955, 590);
            this.tabShoeProducts.TabIndex = 4;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.flowTotalPrice);
            this.panelDetail.Controls.Add(this.btUpdateStatus);
            this.panelDetail.Controls.Add(this.cmbStatus);
            this.panelDetail.Controls.Add(this.picSlip);
            this.panelDetail.Controls.Add(this.flowItems);
            this.panelDetail.Controls.Add(this.lblAddress);
            this.panelDetail.Location = new System.Drawing.Point(423, 10);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(523, 570);
            this.panelDetail.TabIndex = 2;
            // 
            // flowTotalPrice
            // 
            this.flowTotalPrice.Location = new System.Drawing.Point(295, 176);
            this.flowTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.flowTotalPrice.Name = "flowTotalPrice";
            this.flowTotalPrice.Size = new System.Drawing.Size(208, 144);
            this.flowTotalPrice.TabIndex = 86;
            // 
            // btUpdateStatus
            // 
            this.btUpdateStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btUpdateStatus.BorderColor = System.Drawing.Color.Black;
            this.btUpdateStatus.BorderRadius = 15;
            this.btUpdateStatus.BorderThickness = 2;
            this.btUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUpdateStatus.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateStatus.Location = new System.Drawing.Point(328, 518);
            this.btUpdateStatus.Name = "btUpdateStatus";
            this.btUpdateStatus.Size = new System.Drawing.Size(143, 38);
            this.btUpdateStatus.TabIndex = 85;
            this.btUpdateStatus.Text = "Update";
            this.btUpdateStatus.UseVisualStyleBackColor = false;
            this.btUpdateStatus.Click += new System.EventHandler(this.btUpdateStatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "กำลังดำเนินการ",
            "ชำระเงินแล้ว",
            "กำลังจัดส่ง",
            "เสร็จสมบูรณ์",
            "ยกเลิกออเดอร์"});
            this.cmbStatus.Location = new System.Drawing.Point(20, 518);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(269, 38);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.Tag = "";
            this.cmbStatus.Text = "อัปเดตสถานะ";
            // 
            // picSlip
            // 
            this.picSlip.Location = new System.Drawing.Point(295, 323);
            this.picSlip.Name = "picSlip";
            this.picSlip.Size = new System.Drawing.Size(208, 173);
            this.picSlip.TabIndex = 2;
            this.picSlip.TabStop = false;
            this.picSlip.DoubleClick += new System.EventHandler(this.picSlip_DoubleClick);
            // 
            // flowItems
            // 
            this.flowItems.AutoScroll = true;
            this.flowItems.Location = new System.Drawing.Point(20, 176);
            this.flowItems.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowItems.Name = "flowItems";
            this.flowItems.Size = new System.Drawing.Size(269, 336);
            this.flowItems.TabIndex = 1;
            this.flowItems.WrapContents = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.lblAddress.Location = new System.Drawing.Point(20, 17);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(483, 139);
            this.lblAddress.TabIndex = 0;
            // 
            // flowOrderList
            // 
            this.flowOrderList.AutoScroll = true;
            this.flowOrderList.Location = new System.Drawing.Point(10, 10);
            this.flowOrderList.Name = "flowOrderList";
            this.flowOrderList.Size = new System.Drawing.Size(407, 570);
            this.flowOrderList.TabIndex = 1;
            // 
            // AdminOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.ไม่มีกรอบ_สีเทา;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOrder";
            this.Load += new System.EventHandler(this.AdminOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            this.tabShoeProducts.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSlip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedButton BtDashboard;
        private RoundedPanel TabMenu;
        private RoundedButton BtSignOut;
        private RoundedButton BtOrder;
        private RoundedButton BtPromotion;
        private RoundedButton BtProducts;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabAll;
        private RoundedPanel tabShoeProducts;
        private System.Windows.Forms.TextBox HProductAll;
        private System.Windows.Forms.FlowLayoutPanel flowOrderList;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.PictureBox picSlip;
        private System.Windows.Forms.FlowLayoutPanel flowItems;
        private System.Windows.Forms.Label lblAddress;
        private RoundedButton btUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatusAll;
        private System.Windows.Forms.FlowLayoutPanel flowTotalPrice;
    }
}