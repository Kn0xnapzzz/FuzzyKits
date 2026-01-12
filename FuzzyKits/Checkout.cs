using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Printing; // สำหรับงานพิมพ์

namespace FuzzyKits
{
    public partial class Checkout : Form
    {
        private decimal _subtotal;
        private decimal _discount;
        private string _slipPath = ""; // เก็บที่อยู่ไฟล์รูปสลิป
        private string _appliedCode;
        private PrintDocument receiptDocument = new PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        private List<dynamic> _orderItemsForPrint = new List<dynamic>();

        // 1. Constructor รับค่าจากหน้าตะกร้า
        public Checkout(decimal subtotal, decimal discount, string appliedCode)
        {
            InitializeComponent();
            this._subtotal = subtotal;
            this._discount = discount;
            this._appliedCode = appliedCode;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            SetFieldsReadOnly(); 
            LoadUserInfo();      
            CalculatePayment(); 
            LoadOrderSummary();
            receiptDocument.PrintPage += new PrintPageEventHandler(DrawReceipt);
        }

        // ฟังก์ชันล็อคช่องกรอก (ใช้โค้ดล็อคเพราะใน Designer บางตัวไม่มีให้ตั้ง)
        private void SetFieldsReadOnly()
        {
            TxTFName.ReadOnly = TxTLName.ReadOnly = TxTPhone.ReadOnly = true;
            TxTAddress.ReadOnly = TxTSubDistrict.ReadOnly = true;
            TxTDistrict.ReadOnly = TxTProvince.ReadOnly = TxTZipCode.ReadOnly = true;
            TxTOrderTotal.Enabled = TxTDiscount.Enabled = TxTNetTotal.Enabled = false;
            Vat7.ReadOnly = true;
        }

        // 2. ฟังก์ชันคำนวณเงินตามโจทย์อาจารย์ (VAT 7%)
        private void CalculatePayment()
        {
            TxTOrderTotal.Text = _subtotal.ToString("N2");
            TxTDiscount.Text = "-" + _discount.ToString("N2");
            decimal netAfterDiscount = _subtotal - _discount;
            decimal vatAmount = netAfterDiscount * 0.07m;
            Vat7.Text = $"( VAT 7% )  ฿{vatAmount:N2}";
            decimal grandTotal = netAfterDiscount + vatAmount;
            TxTNetTotal.Text = grandTotal.ToString("N2");
        }

        // 3. ฟังก์ชันดึงข้อมูลที่อยู่ผู้ใช้มาโชว์อัตโนมัติ
        private void LoadUserInfo()
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    // ดึงชื่อจากตาราง users และที่อยู่จากตาราง user_addresses มา Join กัน
                    string sql = @"SELECT u.first_name, u.last_name, a.phone_number, a.address_detail, 
                                 a.sub_district, a.district, a.province, a.zip_code 
                          FROM users u
                          LEFT JOIN user_addresses a ON u.user_id = a.user_id
                          WHERE u.user_id = @uid AND (a.is_default = 1 OR a.is_default IS NULL)
                          LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // อัปเดตชื่อคอลัมน์ให้ตรงกับ phpMyAdmin
                        TxTFName.Text = reader.IsDBNull(0) ? "" : reader.GetString("first_name");
                        TxTLName.Text = reader.IsDBNull(1) ? "" : reader.GetString("last_name");

                        // ข้อมูลจากตาราง user_addresses
                        TxTPhone.Text = reader.IsDBNull(2) ? "" : reader.GetString("phone_number");
                        TxTAddress.Text = reader.IsDBNull(3) ? "" : reader.GetString("address_detail");
                        TxTSubDistrict.Text = reader.IsDBNull(4) ? "" : reader.GetString("sub_district");
                        TxTDistrict.Text = reader.IsDBNull(5) ? "" : reader.GetString("district");
                        TxTProvince.Text = reader.IsDBNull(6) ? "" : reader.GetString("province");
                        TxTZipCode.Text = reader.IsDBNull(7) ? "" : reader.GetString("zip_code");
                    }
                }
                catch (Exception ex) { MessageBox.Show("โหลดที่อยู่ผิดพลาด: " + ex.Message); }
            }
        }

        private void BtUpReceipt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _slipPath = ofd.FileName;
                // แสดงแค่ชื่อไฟล์ในช่อง fileUpload โดยไม่เปลี่ยนรูป QR Code เดิม
                fileUpload.Text = Path.GetFileName(_slipPath);
                MessageBox.Show("เลือกไฟล์หลักฐานสำเร็จ!", "สำเร็จ");
            }
        }

        private void LoadOrderSummary()
        {
            ShowOrderItems.Controls.Clear();
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    string query = @"SELECT p.name, p.price, c.quantity, p.image_url 
                                    FROM cart c 
                                    JOIN products p ON c.product_id = p.product_id 
                                    WHERE c.user_id = @uid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Panel itemPanel = CreateOrderItemSummaryRow(
                            reader.GetString("name"),
                            reader.GetDecimal("price"),
                            reader.GetInt32("quantity"),
                            reader.GetString("image_url")
                        );
                        ShowOrderItems.Controls.Add(itemPanel);
                    }
                }
                catch (Exception ex) { MessageBox.Show("โหลดรายการสินค้าผิดพลาด: " + ex.Message); }
            }
        }

        // ฟังก์ชันสร้างแผงรายการสินค้า (รูป, ชื่อ, ราคา/หน่วย, จำนวน)
        private Panel CreateOrderItemSummaryRow(string name, decimal price, int qty, string imgUrl)
        {
            // ลดความกว้างของ Panel ลงเหลือ 350 (เผื่อที่ให้ Scrollbar) และเพิ่มความสูงเป็น 90
            Panel p = new Panel { Size = new Size(275, 90), Margin = new Padding(5, 0, 0, 5) };

            PictureBox pic = new PictureBox { Size = new Size(60, 60), Location = new Point(3, 15), SizeMode = PictureBoxSizeMode.Zoom };
            pic.Image = GetProductImage(imgUrl);

            // ปรับตำแหน่งข้อความให้อยู่ในขอบ 350
            Label lblName = new Label { Text = name, Location = new Point(70, 10), Size = new Size(120, 30), Font = new Font("Berlin Sans FB", 11, FontStyle.Bold) };
            Label lblQty = new Label { Text = $"x{qty}", Location = new Point(170, 10), Size = new Size(100, 25), TextAlign = ContentAlignment.MiddleRight, Font = new Font("Berlin Sans FB", 11) };
            Label lblSub = new Label { Text = $"฿{(price * qty):N2}", Location = new Point(170, 40), Size = new Size(100, 25), TextAlign = ContentAlignment.MiddleRight, Font = new Font("Berlin Sans FB Demi", 11, FontStyle.Bold) };

            p.Controls.AddRange(new Control[] { pic, lblName, lblQty, lblSub });
            return p;
        }

        private Image GetProductImage(string imgUrl)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imgUrl);
                if (File.Exists(fullPath))
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(fs);
                    }
                }
            }
            catch { }
            return null;
        }

        private void ProcessOrder()
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                // เริ่ม Transaction เพื่อความปลอดภัยสูงสุดของข้อมูล
                MySqlTransaction tr = conn.BeginTransaction();
                try
                {
                    // 1. เตรียมข้อมูลที่อยู่มัดรวม
                    string fullAddress = $"คุณ {TxTFName.Text} {TxTLName.Text} | " +
                                         $"โทร: {TxTPhone.Text} | " +
                                         $"ที่อยู่: {TxTAddress.Text} ต.{TxTSubDistrict.Text} " +
                                         $"อ.{TxTDistrict.Text} จ.{TxTProvince.Text} {TxTZipCode.Text}";

                    // คำนวณยอดสุทธิใหม่ให้เป็นตัวเลขที่แน่นอน (ป้องกัน Error จากเครื่องหมายคอมม่าบนหน้าจอ)
                    decimal netAfterDiscount = _subtotal - _discount;
                    decimal vatAmount = netAfterDiscount * 0.07m;
                    decimal grandTotal = netAfterDiscount + vatAmount;

                    // 2. บันทึกลงตาราง orders (หัวบิล)
                    string orderSql = @"INSERT INTO orders (user_id, total_amount, discount_amount, shipping_address, payment_proof_url, status, order_date) 
                                VALUES (@uid, @total, @dist, @addr, @proof, 'Pending', NOW());
                                SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(orderSql, conn, tr);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    cmd.Parameters.AddWithValue("@total", grandTotal);
                    cmd.Parameters.AddWithValue("@dist", _discount);
                    cmd.Parameters.AddWithValue("@addr", fullAddress);
                    cmd.Parameters.AddWithValue("@proof", _slipPath);

                    // ดึง Order ID ที่เพิ่งสร้างออกมาทันที
                    object result = cmd.ExecuteScalar();
                    if (result == null) throw new Exception("ไม่สามารถสร้างเลขออเดอร์ได้");
                    int orderId = Convert.ToInt32(result);

                    // 3. ย้ายสินค้าจาก cart ไป order_items โดยใช้ ID ที่เพิ่งได้มา
                    string itemsSql = @"INSERT INTO order_items (order_id, product_id, quantity, price_per_unit)
                               SELECT @oid, c.product_id, c.quantity, p.price
                               FROM cart c JOIN products p ON c.product_id = p.product_id
                               WHERE c.user_id = @uid";

                    MySqlCommand itemsCmd = new MySqlCommand(itemsSql, conn, tr);
                    itemsCmd.Parameters.AddWithValue("@oid", orderId);
                    itemsCmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    itemsCmd.ExecuteNonQuery();

                    // 4. ตัดสต็อกสินค้าในตาราง products
                    string stockSql = @"UPDATE products p 
                               JOIN cart c ON p.product_id = c.product_id 
                               SET p.stock = p.stock - c.quantity 
                               WHERE c.user_id = @uid";

                    MySqlCommand stockCmd = new MySqlCommand(stockSql, conn, tr);
                    stockCmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    stockCmd.ExecuteNonQuery();

                    // 5. ลบสินค้าออกจากตะกร้า
                    string clearCartSql = "DELETE FROM cart WHERE user_id = @uid";
                    MySqlCommand clearCmd = new MySqlCommand(clearCartSql, conn, tr);
                    clearCmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    clearCmd.ExecuteNonQuery();

                    // บันทึกการเปลี่ยนแปลงทั้งหมดลงฐานข้อมูลจริง
                    tr.Commit();

                    MessageBox.Show($"สั่งซื้อสำเร็จ! บันทึกรายการสินค้าลงฐานข้อมูลเรียบร้อย (Order #{orderId})", "สำเร็จ");
                }
                catch (Exception ex)
                {
                    tr.Rollback(); // หากพลาดแม้แต่จุดเดียว ให้ยกเลิกทั้งหมดเพื่อป้องกันสต็อกเพี้ยน
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " + ex.Message, "Error");
                }
            }
        }

        private void DrawReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Leelawadee UI", 16, FontStyle.Bold);
            Font fontHeader = new Font("Leelawadee UI", 10, FontStyle.Bold);
            Font fontBody = new Font("Leelawadee UI", 9, FontStyle.Regular);
            int y = 30;
            int centerX = 175;

            // 1. ส่วนหัว
            StringFormat formatCenter = new StringFormat { Alignment = StringAlignment.Center };
            g.DrawString("FuzzyKits Shop", fontTitle, Brushes.Black, centerX, y, formatCenter);
            y += 35;
            g.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", fontHeader, Brushes.Black, centerX, y, formatCenter);
            y += 25;
            g.DrawString($"เวลาสั่งซื้อ : {DateTime.Now: dd-MM-yyyy  HH:mm:ss}", fontBody, Brushes.Black, centerX, y, formatCenter);
            y += 25;
            g.DrawString("-------------------------------------------------------------", fontBody, Brushes.Black, 15, y);
            y += 25;

            // 2. ข้อมูลลูกค้า
            g.DrawString($"จัดส่งถึง : คุณ {TxTFName.Text} {TxTLName.Text}", fontHeader, Brushes.Black, 20, y);
            y += 25;
            string address = $"{TxTAddress.Text}  ต.{TxTSubDistrict.Text} \nอ.{TxTDistrict.Text}  จ.{TxTProvince.Text}  {TxTZipCode.Text}";
            RectangleF rectAddress = new RectangleF(20, y, 310, 50);
            g.DrawString(address, fontBody, Brushes.Black, rectAddress);
            y += 35;
            g.DrawString($"โทรศัพท์ : {TxTPhone.Text}", fontBody, Brushes.Black, 20, y);
            y += 25;
            g.DrawString("-------------------------------------------------------------", fontBody, Brushes.Black, 15, y);
            y += 25;

            // 3. รายการสินค้า
            g.DrawString("รายการ", fontHeader, Brushes.Black, 20, y);
            g.DrawString("จำนวน", fontHeader, Brushes.Black, 180, y);
            g.DrawString("รวม", fontHeader, Brushes.Black, 270, y);
            y += 25;

            foreach (var item in _orderItemsForPrint)
            {
                g.DrawString(item.Name, fontBody, Brushes.Black, 20, y);
                g.DrawString(item.Qty.ToString(), fontBody, Brushes.Black, 195, y);
                g.DrawString($"{(item.Price * item.Qty):N2}", fontBody, Brushes.Black, 270, y);
                y += 25;
            }

            // 4. สรุปเงิน และ ภาษี
            g.DrawString("-------------------------------------------------------------", fontBody, Brushes.Black, 15, y);
            y += 25;
            g.DrawString("ราคารวมสินค้า", fontBody, Brushes.Black, 20, y);
            g.DrawString($"{TxTOrderTotal.Text}", fontBody, Brushes.Black, 270, y);
            y += 25;
            g.DrawString("ส่วนลด", fontBody, Brushes.Black, 20, y);
            g.DrawString($"{TxTDiscount.Text}", fontBody, Brushes.Black, 270, y);
            y += 25;

            g.DrawString("ภาษีมูลค่าเพิ่ม (VAT 7%)", fontBody, Brushes.Black, 20, y);
            // สกัดเอาเฉพาะตัวเลขจากช่อง Vat7 (สมมติในช่องมีคำว่า ( VAT 7% )  ฿247.80)
            string vatValue = Vat7.Text.Replace("( VAT 7% )", "").Replace("฿", "").Trim();
            g.DrawString(vatValue, fontBody, Brushes.Black, 270, y);
            
            y += 25;
            g.DrawString("-------------------------------------------------------------", fontBody, Brushes.Black, 15, y);
            y += 15;
            g.DrawString("ยอดชำระสุทธิ", fontHeader, Brushes.Black, 20, y);
            g.DrawString($"{TxTNetTotal.Text} บาท", fontHeader, Brushes.Black, 240, y);
            y += 15;

            // 5. ส่วนท้ายบริษัท
            g.DrawString("-------------------------------------------------------------", fontBody, Brushes.Black, 15, y);
            y += 25;
            g.DrawString("สามารถติดต่อได้ที่", fontHeader, Brushes.Black, centerX, y, formatCenter);
            y += 25;
            string companyInfo = "123 หมู่ 16 ถ.มิตรภาพ ต.ในเมือง อ.เมือง จ.ขอนแก่น 40002\n" +
                                 "โทรศัพท์ : 094-772-5274\n" +
                                 "อีเมล : contact@fuzzykits.shop";
            RectangleF rectCompany = new RectangleF(20, y, 310, 60);
            g.DrawString(companyInfo, fontBody, Brushes.Black, rectCompany, formatCenter);
            y += 75;
            g.DrawString("โปรดเก็บใบเสร็จไว้เป็นหลักฐาน\nขอบคุณที่ใช้บริการค่ะ", fontBody, Brushes.Black, centerX, y, formatCenter);
        }

        private void BtCnfPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_slipPath))
            {
                MessageBox.Show("กรุณาอัปโหลดสลิปหลักฐานการโอนเงินก่อนยืนยัน", "แจ้งเตือน");
                return;
            }

            // 1. ดึงข้อมูลสินค้าใส่ List ไว้ก่อนพิมพ์
            FetchItemsForPrint();

            // 2. บันทึกลง Database
            ProcessOrder();

            // 3. ตั้งค่าขนาดกระดาษแบบไดนามิก (กว้าง 350px, ความสูงคำนวณตามรายการ)
            // ฐานความสูง (หัว+ท้าย) ประมาณ 500px + (จำนวนสินค้า * 25px)
            int itemRowsHeight = _orderItemsForPrint.Count * 25;
            int totalHeight = 600 + itemRowsHeight;

            receiptDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 350, totalHeight);

            // ตั้งชื่อฟอร์ม/ชื่อเอกสารที่จะแสดงด้านบนสุด
            receiptDocument.DocumentName = "FuzzyKits Receipt";

            // 4. ตั้งค่าหน้า Preview ให้ดูคลีน (ไม่มีแถบสี)
            previewDialog.Document = receiptDocument;
            previewDialog.PrintPreviewControl.Zoom = 1.0; // ตั้งค่าซูมเริ่มต้น 100%
            previewDialog.WindowState = FormWindowState.Maximized;

            // แสดงหน้า Preview
            previewDialog.ShowDialog();

            this.Hide();
            Shop shopForm = new Shop();
            shopForm.Show();
        }

        private void FetchItemsForPrint()
        {
            _orderItemsForPrint.Clear();
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string query = @"SELECT p.name, c.quantity, p.price 
                        FROM cart c JOIN products p ON c.product_id = p.product_id 
                        WHERE c.user_id = @uid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    _orderItemsForPrint.Add(new
                    {
                        Name = reader.GetString("name"),
                        Qty = reader.GetInt32("quantity"),
                        Price = reader.GetDecimal("price")
                    });
                }
            }
        }

        private void BtBackToCart_Click(object sender, EventArgs e)
        {
            // ส่งค่ากลับไปยัง ShoppingCart เพื่อให้ข้อมูลยังคงอยู่
            ShoppingCart shoppingCartForm = new ShoppingCart(_appliedCode, _discount);
            this.Hide();
            shoppingCartForm.Show();
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.Show();
        }
    }
}
