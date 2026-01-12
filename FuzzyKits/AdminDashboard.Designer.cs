namespace FuzzyKits
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SmallLogo = new System.Windows.Forms.PictureBox();
            this.TabAll = new RoundedPanel();
            this.lblHeaderChart = new System.Windows.Forms.Label();
            this.lblHeaderTable = new System.Windows.Forms.Label();
            this.chartSalesTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopSelling = new System.Windows.Forms.DataGridView();
            this.dtpDashboard = new System.Windows.Forms.DateTimePicker();
            this.PanelCompletedOrders = new System.Windows.Forms.Panel();
            this.lblTitleComplete = new System.Windows.Forms.Label();
            this.lblCompletedOrders = new System.Windows.Forms.Label();
            this.PanelNewOrders = new System.Windows.Forms.Panel();
            this.lblTitleNew = new System.Windows.Forms.Label();
            this.lblNewOrders = new System.Windows.Forms.Label();
            this.PanelMonthSales = new System.Windows.Forms.Panel();
            this.lblTitleMonth = new System.Windows.Forms.Label();
            this.lblMonthSales = new System.Windows.Forms.Label();
            this.PanelTodaySales = new System.Windows.Forms.Panel();
            this.lblTitleToday = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.BtExportPDF = new RoundedButton();
            this.TabMenu = new RoundedPanel();
            this.BtSignOut = new RoundedButton();
            this.BtOrder = new RoundedButton();
            this.BtPromotion = new RoundedButton();
            this.BtProducts = new RoundedButton();
            this.BtDashboard = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSelling)).BeginInit();
            this.PanelCompletedOrders.SuspendLayout();
            this.PanelNewOrders.SuspendLayout();
            this.PanelMonthSales.SuspendLayout();
            this.PanelTodaySales.SuspendLayout();
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
            this.SmallLogo.TabIndex = 9;
            this.SmallLogo.TabStop = false;
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.Black;
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 5;
            this.TabAll.Controls.Add(this.lblHeaderChart);
            this.TabAll.Controls.Add(this.lblHeaderTable);
            this.TabAll.Controls.Add(this.chartSalesTrend);
            this.TabAll.Controls.Add(this.dgvTopSelling);
            this.TabAll.Controls.Add(this.dtpDashboard);
            this.TabAll.Controls.Add(this.PanelCompletedOrders);
            this.TabAll.Controls.Add(this.PanelNewOrders);
            this.TabAll.Controls.Add(this.PanelMonthSales);
            this.TabAll.Controls.Add(this.PanelTodaySales);
            this.TabAll.Controls.Add(this.BtExportPDF);
            this.TabAll.Location = new System.Drawing.Point(360, 30);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(995, 695);
            this.TabAll.TabIndex = 11;
            // 
            // lblHeaderChart
            // 
            this.lblHeaderChart.AutoSize = true;
            this.lblHeaderChart.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderChart.Location = new System.Drawing.Point(23, 165);
            this.lblHeaderChart.Name = "lblHeaderChart";
            this.lblHeaderChart.Size = new System.Drawing.Size(174, 33);
            this.lblHeaderChart.TabIndex = 14;
            this.lblHeaderChart.Text = "ยอดขายทั้งหมด";
            // 
            // lblHeaderTable
            // 
            this.lblHeaderTable.AutoSize = true;
            this.lblHeaderTable.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTable.Location = new System.Drawing.Point(23, 439);
            this.lblHeaderTable.Name = "lblHeaderTable";
            this.lblHeaderTable.Size = new System.Drawing.Size(206, 33);
            this.lblHeaderTable.TabIndex = 13;
            this.lblHeaderTable.Text = "รายการสินค้าขายดี";
            // 
            // chartSalesTrend
            // 
            this.chartSalesTrend.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartSalesTrend.ChartAreas.Add(chartArea1);
            this.chartSalesTrend.Location = new System.Drawing.Point(20, 200);
            this.chartSalesTrend.Name = "chartSalesTrend";
            this.chartSalesTrend.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Sales";
            this.chartSalesTrend.Series.Add(series1);
            this.chartSalesTrend.Size = new System.Drawing.Size(952, 236);
            this.chartSalesTrend.TabIndex = 10;
            // 
            // dgvTopSelling
            // 
            this.dgvTopSelling.AllowUserToAddRows = false;
            this.dgvTopSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSelling.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSelling.Location = new System.Drawing.Point(20, 475);
            this.dgvTopSelling.Name = "dgvTopSelling";
            this.dgvTopSelling.ReadOnly = true;
            this.dgvTopSelling.RowHeadersVisible = false;
            this.dgvTopSelling.RowHeadersWidth = 51;
            this.dgvTopSelling.RowTemplate.Height = 24;
            this.dgvTopSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSelling.Size = new System.Drawing.Size(952, 154);
            this.dgvTopSelling.TabIndex = 11;
            // 
            // dtpDashboard
            // 
            this.dtpDashboard.CustomFormat = "MMMM yyyy";
            this.dtpDashboard.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDashboard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDashboard.Location = new System.Drawing.Point(741, 165);
            this.dtpDashboard.Name = "dtpDashboard";
            this.dtpDashboard.ShowUpDown = true;
            this.dtpDashboard.Size = new System.Drawing.Size(234, 29);
            this.dtpDashboard.TabIndex = 12;
            // 
            // PanelCompletedOrders
            // 
            this.PanelCompletedOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelCompletedOrders.Controls.Add(this.lblTitleComplete);
            this.PanelCompletedOrders.Controls.Add(this.lblCompletedOrders);
            this.PanelCompletedOrders.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.PanelCompletedOrders.Location = new System.Drawing.Point(500, 20);
            this.PanelCompletedOrders.Name = "PanelCompletedOrders";
            this.PanelCompletedOrders.Size = new System.Drawing.Size(234, 125);
            this.PanelCompletedOrders.TabIndex = 9;
            // 
            // lblTitleComplete
            // 
            this.lblTitleComplete.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleComplete.Location = new System.Drawing.Point(3, 11);
            this.lblTitleComplete.Name = "lblTitleComplete";
            this.lblTitleComplete.Size = new System.Drawing.Size(228, 33);
            this.lblTitleComplete.TabIndex = 5;
            this.lblTitleComplete.Text = "จัดส่งเสร็จสิ้น";
            this.lblTitleComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompletedOrders
            // 
            this.lblCompletedOrders.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCompletedOrders.Location = new System.Drawing.Point(3, 49);
            this.lblCompletedOrders.Name = "lblCompletedOrders";
            this.lblCompletedOrders.Size = new System.Drawing.Size(228, 65);
            this.lblCompletedOrders.TabIndex = 3;
            this.lblCompletedOrders.Text = "0";
            this.lblCompletedOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelNewOrders
            // 
            this.PanelNewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelNewOrders.Controls.Add(this.lblTitleNew);
            this.PanelNewOrders.Controls.Add(this.lblNewOrders);
            this.PanelNewOrders.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.PanelNewOrders.Location = new System.Drawing.Point(741, 20);
            this.PanelNewOrders.Name = "PanelNewOrders";
            this.PanelNewOrders.Size = new System.Drawing.Size(234, 125);
            this.PanelNewOrders.TabIndex = 8;
            // 
            // lblTitleNew
            // 
            this.lblTitleNew.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNew.Location = new System.Drawing.Point(3, 11);
            this.lblTitleNew.Name = "lblTitleNew";
            this.lblTitleNew.Size = new System.Drawing.Size(228, 33);
            this.lblTitleNew.TabIndex = 5;
            this.lblTitleNew.Text = "จำนวนคำสั่งซื้อใหม่";
            this.lblTitleNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewOrders
            // 
            this.lblNewOrders.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblNewOrders.Location = new System.Drawing.Point(3, 49);
            this.lblNewOrders.Name = "lblNewOrders";
            this.lblNewOrders.Size = new System.Drawing.Size(228, 65);
            this.lblNewOrders.TabIndex = 3;
            this.lblNewOrders.Text = "0";
            this.lblNewOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMonthSales
            // 
            this.PanelMonthSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelMonthSales.Controls.Add(this.lblTitleMonth);
            this.PanelMonthSales.Controls.Add(this.lblMonthSales);
            this.PanelMonthSales.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.PanelMonthSales.Location = new System.Drawing.Point(260, 20);
            this.PanelMonthSales.Name = "PanelMonthSales";
            this.PanelMonthSales.Size = new System.Drawing.Size(234, 125);
            this.PanelMonthSales.TabIndex = 7;
            // 
            // lblTitleMonth
            // 
            this.lblTitleMonth.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMonth.Location = new System.Drawing.Point(3, 11);
            this.lblTitleMonth.Name = "lblTitleMonth";
            this.lblTitleMonth.Size = new System.Drawing.Size(228, 33);
            this.lblTitleMonth.TabIndex = 5;
            this.lblTitleMonth.Text = "ยอดขายเดือนนี้";
            this.lblTitleMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthSales
            // 
            this.lblMonthSales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMonthSales.Location = new System.Drawing.Point(3, 49);
            this.lblMonthSales.Name = "lblMonthSales";
            this.lblMonthSales.Size = new System.Drawing.Size(228, 65);
            this.lblMonthSales.TabIndex = 3;
            this.lblMonthSales.Text = "0.00 ฿";
            this.lblMonthSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTodaySales
            // 
            this.PanelTodaySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelTodaySales.Controls.Add(this.lblTitleToday);
            this.PanelTodaySales.Controls.Add(this.lblTodaySales);
            this.PanelTodaySales.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.PanelTodaySales.Location = new System.Drawing.Point(20, 20);
            this.PanelTodaySales.Name = "PanelTodaySales";
            this.PanelTodaySales.Size = new System.Drawing.Size(234, 125);
            this.PanelTodaySales.TabIndex = 1;
            // 
            // lblTitleToday
            // 
            this.lblTitleToday.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleToday.Location = new System.Drawing.Point(3, 11);
            this.lblTitleToday.Name = "lblTitleToday";
            this.lblTitleToday.Size = new System.Drawing.Size(228, 33);
            this.lblTitleToday.TabIndex = 4;
            this.lblTitleToday.Text = "ยอดขายวันนี้";
            this.lblTitleToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.Location = new System.Drawing.Point(6, 49);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(225, 65);
            this.lblTodaySales.TabIndex = 3;
            this.lblTodaySales.Text = "0.00 ฿";
            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtExportPDF
            // 
            this.BtExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtExportPDF.BorderColor = System.Drawing.Color.Black;
            this.BtExportPDF.BorderRadius = 20;
            this.BtExportPDF.BorderThickness = 3;
            this.BtExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtExportPDF.FlatAppearance.BorderSize = 0;
            this.BtExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtExportPDF.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtExportPDF.Location = new System.Drawing.Point(801, 640);
            this.BtExportPDF.Name = "BtExportPDF";
            this.BtExportPDF.Size = new System.Drawing.Size(174, 40);
            this.BtExportPDF.TabIndex = 2;
            this.BtExportPDF.Text = "Export";
            this.BtExportPDF.UseVisualStyleBackColor = false;
            this.BtExportPDF.Click += new System.EventHandler(this.BtExportPDF_Click);
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
            this.TabMenu.TabIndex = 0;
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
            this.BtSignOut.Location = new System.Drawing.Point(25, 515);
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
            this.BtOrder.BorderRadius = 25;
            this.BtOrder.BorderThickness = 4;
            this.BtOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtOrder.FlatAppearance.BorderSize = 0;
            this.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtOrder.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtOrder.Location = new System.Drawing.Point(25, 275);
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
            this.BtPromotion.BorderRadius = 25;
            this.BtPromotion.BorderThickness = 4;
            this.BtPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPromotion.FlatAppearance.BorderSize = 0;
            this.BtPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtPromotion.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtPromotion.Location = new System.Drawing.Point(25, 200);
            this.BtPromotion.Name = "BtPromotion";
            this.BtPromotion.Size = new System.Drawing.Size(250, 55);
            this.BtPromotion.TabIndex = 0;
            this.BtPromotion.Text = "Promotion";
            this.BtPromotion.UseVisualStyleBackColor = true;
            this.BtPromotion.Click += new System.EventHandler(this.BtPromotion_Click);
            // 
            // BtProducts
            // 
            this.BtProducts.BorderColor = System.Drawing.Color.Black;
            this.BtProducts.BorderRadius = 25;
            this.BtProducts.BorderThickness = 4;
            this.BtProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtProducts.FlatAppearance.BorderSize = 0;
            this.BtProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtProducts.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtProducts.Location = new System.Drawing.Point(25, 125);
            this.BtProducts.Name = "BtProducts";
            this.BtProducts.Size = new System.Drawing.Size(250, 55);
            this.BtProducts.TabIndex = 0;
            this.BtProducts.Text = "Products";
            this.BtProducts.UseVisualStyleBackColor = true;
            this.BtProducts.Click += new System.EventHandler(this.BtProducts_Click);
            // 
            // BtDashboard
            // 
            this.BtDashboard.BackColor = System.Drawing.Color.Black;
            this.BtDashboard.BorderColor = System.Drawing.Color.Black;
            this.BtDashboard.BorderRadius = 25;
            this.BtDashboard.BorderThickness = 4;
            this.BtDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDashboard.FlatAppearance.BorderSize = 0;
            this.BtDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDashboard.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtDashboard.ForeColor = System.Drawing.Color.White;
            this.BtDashboard.Location = new System.Drawing.Point(25, 50);
            this.BtDashboard.Name = "BtDashboard";
            this.BtDashboard.Size = new System.Drawing.Size(250, 55);
            this.BtDashboard.TabIndex = 0;
            this.BtDashboard.Text = "Dashboard";
            this.BtDashboard.UseVisualStyleBackColor = false;
            this.BtDashboard.Click += new System.EventHandler(this.BtDashboard_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.ไม่มีกรอบ_สีเทา;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.SmallLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits for Admin";
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSelling)).EndInit();
            this.PanelCompletedOrders.ResumeLayout(false);
            this.PanelNewOrders.ResumeLayout(false);
            this.PanelMonthSales.ResumeLayout(false);
            this.PanelTodaySales.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabMenu;
        private RoundedButton BtOrder;
        private RoundedButton BtPromotion;
        private RoundedButton BtProducts;
        private RoundedButton BtDashboard;
        private RoundedPanel TabAll;
        private RoundedButton BtSignOut;
        private RoundedButton BtExportPDF;
        private System.Windows.Forms.Panel PanelTodaySales;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Panel PanelNewOrders;
        private System.Windows.Forms.Label lblNewOrders;
        private System.Windows.Forms.Panel PanelMonthSales;
        private System.Windows.Forms.Label lblMonthSales;
        private System.Windows.Forms.Panel PanelCompletedOrders;
        private System.Windows.Forms.Label lblCompletedOrders;
        private System.Windows.Forms.Label lblTitleToday;
        private System.Windows.Forms.Label lblTitleComplete;
        private System.Windows.Forms.Label lblTitleNew;
        private System.Windows.Forms.Label lblTitleMonth;
        private System.Windows.Forms.Label lblHeaderChart;
        private System.Windows.Forms.Label lblHeaderTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesTrend;
        private System.Windows.Forms.DataGridView dgvTopSelling;
        private System.Windows.Forms.DateTimePicker dtpDashboard;
    }
}