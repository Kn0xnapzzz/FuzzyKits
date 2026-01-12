namespace FuzzyKits
{
    partial class AdminPromotionAdd
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
            this.HPromotionAdd = new System.Windows.Forms.TextBox();
            this.BtConfirm = new RoundedButton();
            this.tabEdit = new RoundedPanel();
            this.txtNamePromotion = new RoundTextBox();
            this.NamePromotion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Bath = new System.Windows.Forms.TextBox();
            this.numMinAmount = new System.Windows.Forms.NumericUpDown();
            this.Min = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.numDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.cmbDiscountType = new System.Windows.Forms.ComboBox();
            this.txtCodePromotion = new RoundTextBox();
            this.CodePromotion = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Discount = new System.Windows.Forms.TextBox();
            this.TabAll.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // TabAll
            // 
            this.TabAll.BackColor = System.Drawing.Color.White;
            this.TabAll.BorderColor = System.Drawing.Color.Black;
            this.TabAll.BorderRadius = 25;
            this.TabAll.BorderThickness = 5;
            this.TabAll.Controls.Add(this.HPromotionAdd);
            this.TabAll.Controls.Add(this.BtConfirm);
            this.TabAll.Controls.Add(this.tabEdit);
            this.TabAll.Location = new System.Drawing.Point(12, 12);
            this.TabAll.Name = "TabAll";
            this.TabAll.Size = new System.Drawing.Size(495, 512);
            this.TabAll.TabIndex = 23;
            // 
            // HPromotionAdd
            // 
            this.HPromotionAdd.BackColor = System.Drawing.Color.White;
            this.HPromotionAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HPromotionAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.HPromotionAdd.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPromotionAdd.Location = new System.Drawing.Point(20, 20);
            this.HPromotionAdd.Name = "HPromotionAdd";
            this.HPromotionAdd.ReadOnly = true;
            this.HPromotionAdd.Size = new System.Drawing.Size(455, 56);
            this.HPromotionAdd.TabIndex = 27;
            this.HPromotionAdd.Text = "Promotion";
            this.HPromotionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtConfirm.Location = new System.Drawing.Point(315, 457);
            this.BtConfirm.Name = "BtConfirm";
            this.BtConfirm.Size = new System.Drawing.Size(160, 40);
            this.BtConfirm.TabIndex = 7;
            this.BtConfirm.Text = "Confirm";
            this.BtConfirm.UseVisualStyleBackColor = false;
            this.BtConfirm.Click += new System.EventHandler(this.BtConfirm_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.BorderColor = System.Drawing.Color.Black;
            this.tabEdit.BorderRadius = 25;
            this.tabEdit.BorderThickness = 2;
            this.tabEdit.Controls.Add(this.txtNamePromotion);
            this.tabEdit.Controls.Add(this.NamePromotion);
            this.tabEdit.Controls.Add(this.textBox3);
            this.tabEdit.Controls.Add(this.textBox2);
            this.tabEdit.Controls.Add(this.Bath);
            this.tabEdit.Controls.Add(this.numMinAmount);
            this.tabEdit.Controls.Add(this.Min);
            this.tabEdit.Controls.Add(this.StartDate);
            this.tabEdit.Controls.Add(this.textBox1);
            this.tabEdit.Controls.Add(this.chkIsActive);
            this.tabEdit.Controls.Add(this.EndDate);
            this.tabEdit.Controls.Add(this.numDiscountValue);
            this.tabEdit.Controls.Add(this.cmbDiscountType);
            this.tabEdit.Controls.Add(this.txtCodePromotion);
            this.tabEdit.Controls.Add(this.CodePromotion);
            this.tabEdit.Controls.Add(this.hScrollBar1);
            this.tabEdit.Controls.Add(this.Discount);
            this.tabEdit.Location = new System.Drawing.Point(20, 90);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(455, 361);
            this.tabEdit.TabIndex = 4;
            // 
            // txtNamePromotion
            // 
            this.txtNamePromotion.BorderColor = System.Drawing.Color.Black;
            this.txtNamePromotion.BorderRadius = 20;
            this.txtNamePromotion.BorderThickness = 2;
            this.txtNamePromotion.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePromotion.Location = new System.Drawing.Point(112, 15);
            this.txtNamePromotion.Name = "txtNamePromotion";
            this.txtNamePromotion.Padding = new System.Windows.Forms.Padding(10);
            this.txtNamePromotion.Size = new System.Drawing.Size(328, 40);
            this.txtNamePromotion.TabIndex = 56;
            this.txtNamePromotion.UseSystemPasswordChar = false;
            // 
            // NamePromotion
            // 
            this.NamePromotion.BackColor = System.Drawing.Color.White;
            this.NamePromotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamePromotion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold);
            this.NamePromotion.Location = new System.Drawing.Point(15, 16);
            this.NamePromotion.Name = "NamePromotion";
            this.NamePromotion.Size = new System.Drawing.Size(91, 31);
            this.NamePromotion.TabIndex = 55;
            this.NamePromotion.Text = "ชื่อ";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 31);
            this.textBox3.TabIndex = 54;
            this.textBox3.Text = "เริ่ม";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 31);
            this.textBox2.TabIndex = 53;
            this.textBox2.Text = "สิ้นสุด";
            // 
            // Bath
            // 
            this.Bath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bath.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bath.Location = new System.Drawing.Point(380, 168);
            this.Bath.Name = "Bath";
            this.Bath.Size = new System.Drawing.Size(60, 31);
            this.Bath.TabIndex = 52;
            this.Bath.Text = "บาท";
            // 
            // numMinAmount
            // 
            this.numMinAmount.DecimalPlaces = 2;
            this.numMinAmount.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F);
            this.numMinAmount.Location = new System.Drawing.Point(112, 168);
            this.numMinAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMinAmount.Name = "numMinAmount";
            this.numMinAmount.Size = new System.Drawing.Size(262, 33);
            this.numMinAmount.TabIndex = 51;
            // 
            // Min
            // 
            this.Min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Min.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(15, 168);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(91, 31);
            this.Min.TabIndex = 50;
            this.Min.Text = "ขั้นต่ำ";
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(112, 216);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(328, 33);
            this.StartDate.TabIndex = 49;
            this.StartDate.Value = new System.DateTime(2025, 12, 21, 4, 18, 59, 0);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 31);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = "สถานะ";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(112, 315);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(100, 30);
            this.chkIsActive.TabIndex = 47;
            this.chkIsActive.Text = "เปิดใช้งาน";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(112, 266);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(328, 33);
            this.EndDate.TabIndex = 46;
            this.EndDate.Value = new System.DateTime(2025, 12, 21, 4, 18, 59, 0);
            // 
            // numDiscountValue
            // 
            this.numDiscountValue.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F);
            this.numDiscountValue.Location = new System.Drawing.Point(112, 121);
            this.numDiscountValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDiscountValue.Name = "numDiscountValue";
            this.numDiscountValue.Size = new System.Drawing.Size(155, 33);
            this.numDiscountValue.TabIndex = 45;
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountType.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F);
            this.cmbDiscountType.FormattingEnabled = true;
            this.cmbDiscountType.Items.AddRange(new object[] {
            "จำนวนเต็ม",
            "เปอร์เซ็นต์"});
            this.cmbDiscountType.Location = new System.Drawing.Point(273, 121);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(167, 34);
            this.cmbDiscountType.TabIndex = 44;
            // 
            // txtCodePromotion
            // 
            this.txtCodePromotion.BorderColor = System.Drawing.Color.Black;
            this.txtCodePromotion.BorderRadius = 20;
            this.txtCodePromotion.BorderThickness = 2;
            this.txtCodePromotion.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePromotion.Location = new System.Drawing.Point(112, 66);
            this.txtCodePromotion.Name = "txtCodePromotion";
            this.txtCodePromotion.Padding = new System.Windows.Forms.Padding(10);
            this.txtCodePromotion.Size = new System.Drawing.Size(330, 40);
            this.txtCodePromotion.TabIndex = 42;
            this.txtCodePromotion.UseSystemPasswordChar = false;
            // 
            // CodePromotion
            // 
            this.CodePromotion.BackColor = System.Drawing.Color.White;
            this.CodePromotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodePromotion.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.CodePromotion.Location = new System.Drawing.Point(15, 66);
            this.CodePromotion.Name = "CodePromotion";
            this.CodePromotion.Size = new System.Drawing.Size(91, 30);
            this.CodePromotion.TabIndex = 41;
            this.CodePromotion.Text = "Code";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(923, 28);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(15, 485);
            this.hScrollBar1.TabIndex = 23;
            // 
            // Discount
            // 
            this.Discount.AcceptsReturn = true;
            this.Discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Discount.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(15, 118);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(91, 31);
            this.Discount.TabIndex = 12;
            this.Discount.Text = "ส่วนลด";
            // 
            // AdminPromotionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuzzyKits.Properties.Resources.ไม่มีกรอบ_สีเทา;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 536);
            this.Controls.Add(this.TabAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPromotionAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuzzyKits for Admin";
            this.TabAll.ResumeLayout(false);
            this.TabAll.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel TabAll;
        private RoundedButton BtConfirm;
        private RoundedPanel tabEdit;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.TextBox HPromotionAdd;
        private System.Windows.Forms.TextBox CodePromotion;
        private RoundTextBox txtCodePromotion;
        private System.Windows.Forms.ComboBox cmbDiscountType;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.NumericUpDown numDiscountValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.NumericUpDown numMinAmount;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Bath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private RoundTextBox txtNamePromotion;
        private System.Windows.Forms.TextBox NamePromotion;
    }
}