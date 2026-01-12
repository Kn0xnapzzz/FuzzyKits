namespace FuzzyKits
{
    partial class Checkout
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
            this.BtBackToCart = new RoundedButton();
            this.BtSignOut = new RoundedButton();
            this.TabShow = new RoundedPanel();
            this.PaymentMethod = new System.Windows.Forms.TextBox();
            this.PaymentInfo = new System.Windows.Forms.TextBox();
            this.ShippingAddress = new System.Windows.Forms.TextBox();
            this.ItemList = new System.Windows.Forms.TextBox();
            this.TabPaymentMethod = new RoundedPanel();
            this.BtUpReceipt = new RoundedButton();
            this.fileUpload = new System.Windows.Forms.TextBox();
            this.PicPayment = new System.Windows.Forms.PictureBox();
            this.TabPaymentInfo = new RoundedPanel();
            this.Vat7 = new System.Windows.Forms.TextBox();
            this.TxTNetTotal = new RoundTextBox();
            this.TxTDiscount = new RoundTextBox();
            this.TxTOrderTotal = new RoundTextBox();
            this.THB3 = new System.Windows.Forms.TextBox();
            this.THB2 = new System.Windows.Forms.TextBox();
            this.THB1 = new System.Windows.Forms.TextBox();
            this.NetTotal = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.OrderTotal = new System.Windows.Forms.TextBox();
            this.TabShippingAddress = new RoundedPanel();
            this.TxTProvince = new System.Windows.Forms.TextBox();
            this.TxTZipCode = new System.Windows.Forms.TextBox();
            this.TxTSubDistrict = new System.Windows.Forms.TextBox();
            this.TxTDistrict = new System.Windows.Forms.TextBox();
            this.TxTLName = new System.Windows.Forms.TextBox();
            this.TxTAddress = new System.Windows.Forms.TextBox();
            this.TxTFName = new System.Windows.Forms.TextBox();
            this.TxTPhone = new System.Windows.Forms.TextBox();
            this.TabItemList = new RoundedPanel();
            this.ShowOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.BtCnfPayment = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).BeginInit();
            this.TabAll.SuspendLayout();
            this.TabShow.SuspendLayout();
            this.TabPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPayment)).BeginInit();
            this.TabPaymentInfo.SuspendLayout();
            this.TabShippingAddress.SuspendLayout();
            this.TabItemList.SuspendLayout();
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
            this.SmallLogo.TabIndex = 23;
            this.SmallLogo.TabStop = false;
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(19)))));
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 4;
            this.TabAll.Controls.Add(this.BtBackToCart);
            this.TabAll.Controls.Add(this.BtSignOut);
            this.TabAll.Location = new System.Drawing.Point(354, 24);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(1000, 60);
            this.TabAll.TabIndex = 22;
            // 
            // BtBackToCart
            // 
            this.BtBackToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtBackToCart.BorderColor = System.Drawing.Color.Black;
            this.BtBackToCart.BorderRadius = 25;
            this.BtBackToCart.BorderThickness = 3;
            this.BtBackToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBackToCart.FlatAppearance.BorderSize = 0;
            this.BtBackToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBackToCart.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.BtBackToCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtBackToCart.Location = new System.Drawing.Point(2, 3);
            this.BtBackToCart.Name = "BtBackToCart";
            this.BtBackToCart.Size = new System.Drawing.Size(243, 55);
            this.BtBackToCart.TabIndex = 0;
            this.BtBackToCart.Text = "Back To Cart";
            this.BtBackToCart.UseVisualStyleBackColor = false;
            this.BtBackToCart.Click += new System.EventHandler(this.BtBackToCart_Click);
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
            this.TabShow.Controls.Add(this.PaymentMethod);
            this.TabShow.Controls.Add(this.PaymentInfo);
            this.TabShow.Controls.Add(this.ShippingAddress);
            this.TabShow.Controls.Add(this.ItemList);
            this.TabShow.Controls.Add(this.TabPaymentMethod);
            this.TabShow.Controls.Add(this.TabPaymentInfo);
            this.TabShow.Controls.Add(this.TabShippingAddress);
            this.TabShow.Controls.Add(this.TabItemList);
            this.TabShow.Controls.Add(this.BtCnfPayment);
            this.TabShow.Location = new System.Drawing.Point(30, 109);
            this.TabShow.Name = "TabShow";
            this.TabShow.Size = new System.Drawing.Size(1324, 620);
            this.TabShow.TabIndex = 24;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.BackColor = System.Drawing.Color.White;
            this.PaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentMethod.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaymentMethod.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(933, 15);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Size = new System.Drawing.Size(374, 34);
            this.PaymentMethod.TabIndex = 83;
            this.PaymentMethod.Text = "ช่องทางการชำระเงิน";
            this.PaymentMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaymentInfo
            // 
            this.PaymentInfo.BackColor = System.Drawing.Color.White;
            this.PaymentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaymentInfo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentInfo.Location = new System.Drawing.Point(463, 15);
            this.PaymentInfo.Name = "PaymentInfo";
            this.PaymentInfo.ReadOnly = true;
            this.PaymentInfo.Size = new System.Drawing.Size(453, 34);
            this.PaymentInfo.TabIndex = 82;
            this.PaymentInfo.Text = "ข้อมูลการชำระเงิน";
            this.PaymentInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShippingAddress
            // 
            this.ShippingAddress.BackColor = System.Drawing.Color.White;
            this.ShippingAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShippingAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShippingAddress.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingAddress.Location = new System.Drawing.Point(463, 309);
            this.ShippingAddress.Name = "ShippingAddress";
            this.ShippingAddress.ReadOnly = true;
            this.ShippingAddress.Size = new System.Drawing.Size(453, 34);
            this.ShippingAddress.TabIndex = 81;
            this.ShippingAddress.Text = "ที่อยู่จัดส่ง";
            this.ShippingAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemList
            // 
            this.ItemList.BackColor = System.Drawing.Color.White;
            this.ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemList.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.Location = new System.Drawing.Point(19, 15);
            this.ItemList.Name = "ItemList";
            this.ItemList.ReadOnly = true;
            this.ItemList.Size = new System.Drawing.Size(427, 34);
            this.ItemList.TabIndex = 80;
            this.ItemList.Text = "รายการสินค้า";
            this.ItemList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabPaymentMethod
            // 
            this.TabPaymentMethod.BorderColor = System.Drawing.Color.Black;
            this.TabPaymentMethod.BorderRadius = 30;
            this.TabPaymentMethod.BorderThickness = 2;
            this.TabPaymentMethod.Controls.Add(this.BtUpReceipt);
            this.TabPaymentMethod.Controls.Add(this.fileUpload);
            this.TabPaymentMethod.Controls.Add(this.PicPayment);
            this.TabPaymentMethod.Location = new System.Drawing.Point(933, 55);
            this.TabPaymentMethod.Name = "TabPaymentMethod";
            this.TabPaymentMethod.Size = new System.Drawing.Size(374, 491);
            this.TabPaymentMethod.TabIndex = 79;
            // 
            // BtUpReceipt
            // 
            this.BtUpReceipt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtUpReceipt.BorderColor = System.Drawing.Color.Black;
            this.BtUpReceipt.BorderRadius = 15;
            this.BtUpReceipt.BorderThickness = 2;
            this.BtUpReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtUpReceipt.FlatAppearance.BorderSize = 0;
            this.BtUpReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtUpReceipt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpReceipt.Location = new System.Drawing.Point(247, 436);
            this.BtUpReceipt.Name = "BtUpReceipt";
            this.BtUpReceipt.Size = new System.Drawing.Size(114, 38);
            this.BtUpReceipt.TabIndex = 84;
            this.BtUpReceipt.Text = "Receipt";
            this.BtUpReceipt.UseVisualStyleBackColor = false;
            this.BtUpReceipt.Click += new System.EventHandler(this.BtUpReceipt_Click);
            // 
            // fileUpload
            // 
            this.fileUpload.BackColor = System.Drawing.Color.White;
            this.fileUpload.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileUpload.Location = new System.Drawing.Point(15, 443);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.ReadOnly = true;
            this.fileUpload.Size = new System.Drawing.Size(226, 29);
            this.fileUpload.TabIndex = 78;
            // 
            // PicPayment
            // 
            this.PicPayment.Image = global::FuzzyKits.Properties.Resources.a35bf087_6deb_4f46_8881_9b5a134e0a41;
            this.PicPayment.Location = new System.Drawing.Point(15, 17);
            this.PicPayment.Name = "PicPayment";
            this.PicPayment.Size = new System.Drawing.Size(346, 413);
            this.PicPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPayment.TabIndex = 75;
            this.PicPayment.TabStop = false;
            // 
            // TabPaymentInfo
            // 
            this.TabPaymentInfo.BorderColor = System.Drawing.Color.Black;
            this.TabPaymentInfo.BorderRadius = 30;
            this.TabPaymentInfo.BorderThickness = 2;
            this.TabPaymentInfo.Controls.Add(this.Vat7);
            this.TabPaymentInfo.Controls.Add(this.TxTNetTotal);
            this.TabPaymentInfo.Controls.Add(this.TxTDiscount);
            this.TabPaymentInfo.Controls.Add(this.TxTOrderTotal);
            this.TabPaymentInfo.Controls.Add(this.THB3);
            this.TabPaymentInfo.Controls.Add(this.THB2);
            this.TabPaymentInfo.Controls.Add(this.THB1);
            this.TabPaymentInfo.Controls.Add(this.NetTotal);
            this.TabPaymentInfo.Controls.Add(this.Discount);
            this.TabPaymentInfo.Controls.Add(this.OrderTotal);
            this.TabPaymentInfo.Location = new System.Drawing.Point(463, 55);
            this.TabPaymentInfo.Name = "TabPaymentInfo";
            this.TabPaymentInfo.Size = new System.Drawing.Size(453, 235);
            this.TabPaymentInfo.TabIndex = 77;
            // 
            // Vat7
            // 
            this.Vat7.BackColor = System.Drawing.Color.White;
            this.Vat7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vat7.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vat7.ForeColor = System.Drawing.Color.Crimson;
            this.Vat7.Location = new System.Drawing.Point(161, 140);
            this.Vat7.Name = "Vat7";
            this.Vat7.ReadOnly = true;
            this.Vat7.Size = new System.Drawing.Size(234, 26);
            this.Vat7.TabIndex = 86;
            this.Vat7.Text = "( VAT 7 % )";
            // 
            // TxTNetTotal
            // 
            this.TxTNetTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxTNetTotal.BackColor = System.Drawing.Color.White;
            this.TxTNetTotal.BorderColor = System.Drawing.Color.Black;
            this.TxTNetTotal.BorderRadius = 20;
            this.TxTNetTotal.BorderThickness = 2;
            this.TxTNetTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTNetTotal.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTNetTotal.Location = new System.Drawing.Point(18, 178);
            this.TxTNetTotal.Name = "TxTNetTotal";
            this.TxTNetTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxTNetTotal.Size = new System.Drawing.Size(377, 40);
            this.TxTNetTotal.TabIndex = 85;
            this.TxTNetTotal.UseSystemPasswordChar = false;
            // 
            // TxTDiscount
            // 
            this.TxTDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxTDiscount.BackColor = System.Drawing.Color.White;
            this.TxTDiscount.BorderColor = System.Drawing.Color.Black;
            this.TxTDiscount.BorderRadius = 20;
            this.TxTDiscount.BorderThickness = 2;
            this.TxTDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTDiscount.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTDiscount.Location = new System.Drawing.Point(154, 75);
            this.TxTDiscount.Name = "TxTDiscount";
            this.TxTDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxTDiscount.Size = new System.Drawing.Size(241, 40);
            this.TxTDiscount.TabIndex = 85;
            this.TxTDiscount.UseSystemPasswordChar = false;
            // 
            // TxTOrderTotal
            // 
            this.TxTOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxTOrderTotal.BackColor = System.Drawing.Color.White;
            this.TxTOrderTotal.BorderColor = System.Drawing.Color.Black;
            this.TxTOrderTotal.BorderRadius = 20;
            this.TxTOrderTotal.BorderThickness = 2;
            this.TxTOrderTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTOrderTotal.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTOrderTotal.Location = new System.Drawing.Point(154, 21);
            this.TxTOrderTotal.Name = "TxTOrderTotal";
            this.TxTOrderTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxTOrderTotal.Size = new System.Drawing.Size(241, 40);
            this.TxTOrderTotal.TabIndex = 84;
            this.TxTOrderTotal.UseSystemPasswordChar = false;
            // 
            // THB3
            // 
            this.THB3.BackColor = System.Drawing.Color.White;
            this.THB3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.THB3.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.THB3.Location = new System.Drawing.Point(401, 182);
            this.THB3.Name = "THB3";
            this.THB3.ReadOnly = true;
            this.THB3.Size = new System.Drawing.Size(49, 30);
            this.THB3.TabIndex = 63;
            this.THB3.Text = "บาท";
            // 
            // THB2
            // 
            this.THB2.BackColor = System.Drawing.Color.White;
            this.THB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.THB2.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.THB2.Location = new System.Drawing.Point(401, 80);
            this.THB2.Name = "THB2";
            this.THB2.ReadOnly = true;
            this.THB2.Size = new System.Drawing.Size(49, 30);
            this.THB2.TabIndex = 61;
            this.THB2.Text = "บาท";
            // 
            // THB1
            // 
            this.THB1.BackColor = System.Drawing.Color.White;
            this.THB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.THB1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.THB1.Location = new System.Drawing.Point(401, 26);
            this.THB1.Name = "THB1";
            this.THB1.ReadOnly = true;
            this.THB1.Size = new System.Drawing.Size(49, 30);
            this.THB1.TabIndex = 59;
            this.THB1.Text = "บาท";
            // 
            // NetTotal
            // 
            this.NetTotal.BackColor = System.Drawing.Color.White;
            this.NetTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetTotal.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.NetTotal.Location = new System.Drawing.Point(18, 136);
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.ReadOnly = true;
            this.NetTotal.Size = new System.Drawing.Size(137, 30);
            this.NetTotal.TabIndex = 56;
            this.NetTotal.Text = "ยอดชำระสุทธิ";
            // 
            // Discount
            // 
            this.Discount.BackColor = System.Drawing.Color.White;
            this.Discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Discount.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.Discount.Location = new System.Drawing.Point(18, 80);
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Size = new System.Drawing.Size(130, 30);
            this.Discount.TabIndex = 55;
            this.Discount.Text = "ส่วนลด";
            // 
            // OrderTotal
            // 
            this.OrderTotal.BackColor = System.Drawing.Color.White;
            this.OrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderTotal.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.OrderTotal.Location = new System.Drawing.Point(18, 26);
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.ReadOnly = true;
            this.OrderTotal.Size = new System.Drawing.Size(130, 30);
            this.OrderTotal.TabIndex = 54;
            this.OrderTotal.Text = "ราคารวมสินค้า";
            // 
            // TabShippingAddress
            // 
            this.TabShippingAddress.BorderColor = System.Drawing.Color.Black;
            this.TabShippingAddress.BorderRadius = 30;
            this.TabShippingAddress.BorderThickness = 2;
            this.TabShippingAddress.Controls.Add(this.TxTProvince);
            this.TabShippingAddress.Controls.Add(this.TxTZipCode);
            this.TabShippingAddress.Controls.Add(this.TxTSubDistrict);
            this.TabShippingAddress.Controls.Add(this.TxTDistrict);
            this.TabShippingAddress.Controls.Add(this.TxTLName);
            this.TabShippingAddress.Controls.Add(this.TxTAddress);
            this.TabShippingAddress.Controls.Add(this.TxTFName);
            this.TabShippingAddress.Controls.Add(this.TxTPhone);
            this.TabShippingAddress.Location = new System.Drawing.Point(463, 349);
            this.TabShippingAddress.Name = "TabShippingAddress";
            this.TabShippingAddress.Size = new System.Drawing.Size(453, 253);
            this.TabShippingAddress.TabIndex = 73;
            // 
            // TxTProvince
            // 
            this.TxTProvince.BackColor = System.Drawing.Color.White;
            this.TxTProvince.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTProvince.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TxTProvince.Location = new System.Drawing.Point(18, 162);
            this.TxTProvince.Name = "TxTProvince";
            this.TxTProvince.ReadOnly = true;
            this.TxTProvince.Size = new System.Drawing.Size(201, 30);
            this.TxTProvince.TabIndex = 60;
            // 
            // TxTZipCode
            // 
            this.TxTZipCode.BackColor = System.Drawing.Color.White;
            this.TxTZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTZipCode.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTZipCode.Location = new System.Drawing.Point(225, 162);
            this.TxTZipCode.Name = "TxTZipCode";
            this.TxTZipCode.ReadOnly = true;
            this.TxTZipCode.Size = new System.Drawing.Size(213, 26);
            this.TxTZipCode.TabIndex = 59;
            // 
            // TxTSubDistrict
            // 
            this.TxTSubDistrict.BackColor = System.Drawing.Color.White;
            this.TxTSubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTSubDistrict.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TxTSubDistrict.Location = new System.Drawing.Point(18, 119);
            this.TxTSubDistrict.Name = "TxTSubDistrict";
            this.TxTSubDistrict.ReadOnly = true;
            this.TxTSubDistrict.Size = new System.Drawing.Size(201, 30);
            this.TxTSubDistrict.TabIndex = 58;
            // 
            // TxTDistrict
            // 
            this.TxTDistrict.BackColor = System.Drawing.Color.White;
            this.TxTDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTDistrict.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TxTDistrict.Location = new System.Drawing.Point(225, 119);
            this.TxTDistrict.Name = "TxTDistrict";
            this.TxTDistrict.ReadOnly = true;
            this.TxTDistrict.Size = new System.Drawing.Size(213, 30);
            this.TxTDistrict.TabIndex = 57;
            // 
            // TxTLName
            // 
            this.TxTLName.BackColor = System.Drawing.Color.White;
            this.TxTLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTLName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TxTLName.Location = new System.Drawing.Point(225, 19);
            this.TxTLName.Name = "TxTLName";
            this.TxTLName.ReadOnly = true;
            this.TxTLName.Size = new System.Drawing.Size(213, 30);
            this.TxTLName.TabIndex = 56;
            // 
            // TxTAddress
            // 
            this.TxTAddress.BackColor = System.Drawing.Color.White;
            this.TxTAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTAddress.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTAddress.Location = new System.Drawing.Point(18, 76);
            this.TxTAddress.Name = "TxTAddress";
            this.TxTAddress.ReadOnly = true;
            this.TxTAddress.Size = new System.Drawing.Size(420, 30);
            this.TxTAddress.TabIndex = 55;
            // 
            // TxTFName
            // 
            this.TxTFName.BackColor = System.Drawing.Color.White;
            this.TxTFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTFName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.TxTFName.Location = new System.Drawing.Point(18, 19);
            this.TxTFName.Name = "TxTFName";
            this.TxTFName.ReadOnly = true;
            this.TxTFName.Size = new System.Drawing.Size(201, 30);
            this.TxTFName.TabIndex = 54;
            // 
            // TxTPhone
            // 
            this.TxTPhone.BackColor = System.Drawing.Color.White;
            this.TxTPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTPhone.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTPhone.Location = new System.Drawing.Point(18, 215);
            this.TxTPhone.Name = "TxTPhone";
            this.TxTPhone.ReadOnly = true;
            this.TxTPhone.Size = new System.Drawing.Size(420, 26);
            this.TxTPhone.TabIndex = 2;
            // 
            // TabItemList
            // 
            this.TabItemList.BorderColor = System.Drawing.Color.Black;
            this.TabItemList.BorderRadius = 30;
            this.TabItemList.BorderThickness = 2;
            this.TabItemList.Controls.Add(this.ShowOrderItems);
            this.TabItemList.Location = new System.Drawing.Point(19, 55);
            this.TabItemList.Name = "TabItemList";
            this.TabItemList.Size = new System.Drawing.Size(427, 547);
            this.TabItemList.TabIndex = 48;
            // 
            // ShowOrderItems
            // 
            this.ShowOrderItems.AutoScroll = true;
            this.ShowOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShowOrderItems.Location = new System.Drawing.Point(13, 17);
            this.ShowOrderItems.Name = "ShowOrderItems";
            this.ShowOrderItems.Size = new System.Drawing.Size(400, 516);
            this.ShowOrderItems.TabIndex = 1;
            this.ShowOrderItems.WrapContents = false;
            // 
            // BtCnfPayment
            // 
            this.BtCnfPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(185)))), ((int)(((byte)(114)))));
            this.BtCnfPayment.BorderColor = System.Drawing.Color.Black;
            this.BtCnfPayment.BorderRadius = 25;
            this.BtCnfPayment.BorderThickness = 3;
            this.BtCnfPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCnfPayment.FlatAppearance.BorderSize = 0;
            this.BtCnfPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCnfPayment.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCnfPayment.Location = new System.Drawing.Point(1031, 559);
            this.BtCnfPayment.Name = "BtCnfPayment";
            this.BtCnfPayment.Size = new System.Drawing.Size(276, 50);
            this.BtCnfPayment.TabIndex = 1;
            this.BtCnfPayment.Text = "Confirm Payment";
            this.BtCnfPayment.UseVisualStyleBackColor = false;
            this.BtCnfPayment.Click += new System.EventHandler(this.BtCnfPayment_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.พื้นหลัง_ไม่มีกรอบ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.TabAll);
            this.Controls.Add(this.SmallLogo);
            this.Controls.Add(this.TabShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallLogo)).EndInit();
            this.TabAll.ResumeLayout(false);
            this.TabShow.ResumeLayout(false);
            this.TabShow.PerformLayout();
            this.TabPaymentMethod.ResumeLayout(false);
            this.TabPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPayment)).EndInit();
            this.TabPaymentInfo.ResumeLayout(false);
            this.TabPaymentInfo.PerformLayout();
            this.TabShippingAddress.ResumeLayout(false);
            this.TabShippingAddress.PerformLayout();
            this.TabItemList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel TabAll;
        private RoundedButton BtBackToCart;
        private RoundedButton BtSignOut;
        private System.Windows.Forms.PictureBox SmallLogo;
        private RoundedPanel TabShow;
        private RoundedButton BtCnfPayment;
        private RoundedPanel TabItemList;
        private RoundedPanel TabShippingAddress;
        private System.Windows.Forms.PictureBox PicPayment;
        private RoundedPanel TabPaymentInfo;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.TextBox OrderTotal;
        private System.Windows.Forms.TextBox NetTotal;
        private System.Windows.Forms.TextBox THB3;
        private System.Windows.Forms.TextBox THB2;
        private System.Windows.Forms.TextBox THB1;
        private RoundedPanel TabPaymentMethod;
        private System.Windows.Forms.TextBox fileUpload;
        private System.Windows.Forms.TextBox PaymentMethod;
        private System.Windows.Forms.TextBox PaymentInfo;
        private System.Windows.Forms.TextBox ShippingAddress;
        private System.Windows.Forms.TextBox ItemList;
        private RoundedButton BtUpReceipt;
        private System.Windows.Forms.FlowLayoutPanel ShowOrderItems;
        private RoundTextBox TxTNetTotal;
        private RoundTextBox TxTDiscount;
        private RoundTextBox TxTOrderTotal;
        private System.Windows.Forms.TextBox Vat7;
        private System.Windows.Forms.TextBox TxTLName;
        private System.Windows.Forms.TextBox TxTAddress;
        private System.Windows.Forms.TextBox TxTFName;
        private System.Windows.Forms.TextBox TxTPhone;
        private System.Windows.Forms.TextBox TxTSubDistrict;
        private System.Windows.Forms.TextBox TxTDistrict;
        private System.Windows.Forms.TextBox TxTProvince;
        private System.Windows.Forms.TextBox TxTZipCode;
    }
}