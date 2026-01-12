using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class ShoppingCart : Form
    {
        private decimal currentDiscount = 0;
        private bool isCodeChanged = false;
        private string currentAppliedCode = ""; // ตัวแปรคลาสสำหรับเก็บโค้ดที่ใช้อยู่
       
        public ShoppingCart()
        {
            InitializeComponent();
            SetupEvents();
        }

        public ShoppingCart(string appliedCode, decimal discount)
        {
            InitializeComponent();
            this.currentAppliedCode = appliedCode;
            this.currentDiscount = discount;
            SetupEvents();

            // นำโค้ดเดิมมาใส่ในช่องกรอก
            if (!string.IsNullOrEmpty(appliedCode))
            {
                txtPromoCode.Text = appliedCode;
                isCodeChanged = false; // ถือว่ากดยืนยันมาแล้วจากรอบก่อน
            }
        }

        private void SetupEvents()
        {
            this.Load += new EventHandler(ShoppingCart_Load);
            txtTotalPrice.Text = "0.00";
            txtTotalPrice.UseSystemPasswordChar = false;
            // ผูกเหตุการณ์พิมพ์ข้อความ
            this.txtPromoCode.TextChanged += new System.EventHandler(this.txtPromoCode_TextChanged);
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            LoadCartItems();
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

        private void LoadCartItems()
        {
            ShowCartItems.Controls.Clear();

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    string query = @"SELECT c.cart_id, p.name, p.price, c.quantity, p.image_url, p.stock 
                                    FROM cart c 
                                    JOIN products p ON c.product_id = p.product_id 
                                    WHERE c.user_id = @uid";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int cartId = reader.GetInt32("cart_id");
                        string name = reader.GetString("name");
                        decimal price = reader.GetDecimal("price");
                        int qty = reader.GetInt32("quantity");
                        string imgUrl = reader.GetString("image_url");
                        int maxStock = reader.GetInt32("stock");

                        Panel itemRow = CreateCartItemRow(cartId, name, price, qty, imgUrl, maxStock);
                        ShowCartItems.Controls.Add(itemRow);
                    }
                }
                catch (Exception ex) { MessageBox.Show("โหลดตะกร้าผิดพลาด: " + ex.Message); }
            }
            UpdateGrandTotal();
        }

        private Panel CreateCartItemRow(int cartId, string name, decimal price, int qty, string imgUrl, int maxStock)
        {
            Panel p = new Panel { Size = new Size(920, 100), BorderStyle = BorderStyle.None, Margin = new Padding(0, 0, 0, 10) };

            // รูปภาพสินค้า
            PictureBox pic = new PictureBox { Size = new Size(80, 80), Location = new Point(10, 10), SizeMode = PictureBoxSizeMode.Zoom };
            pic.Image = GetProductImage(imgUrl);

            // 2. ปรับตำแหน่งข้อความ "รายการสินค้า" (ขยับมาชิดรูป)
            Label lblInfo = new Label { Text = name, Location = new Point(100, 25), Size = new Size(200, 30), Font = new Font("Berlin Sans FB", 16) };
            Label lblPrice = new Label { Text = price.ToString("N2") + " บาท", Location = new Point(100, 55), Size = new Size(150, 25), ForeColor = Color.Gray };

            // 3. ปรับตำแหน่งส่วนจัดการ "จำนวน" ให้ตรงกับหัวข้อ 
            Button btnMinus = new Button { Text = "-", Location = new Point(500, 35), Size = new Size(30, 30) };
            Label lblQty = new Label { Text = qty.ToString(), Location = new Point(540, 35), Size = new Size(50, 30), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Berlin Sans FB", 12) };
            Button btnPlus = new Button { Text = "+", Location = new Point(600, 35), Size = new Size(30, 30) };

            // 4. ปรับตำแหน่ง "รวมราคา" ให้ตรงกับหัวข้อ
            Label lblSubTotal = new Label
            {
                Name = "subtotal",
                Text = (price * qty).ToString("N2"),
                Location = new Point(700, 35),
                Size = new Size(180, 35),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Bold)
            };

            // Logic ปุ่มบวกลบเหมือนเดิม แต่ไม่ต้องเช็ค Checked ของ CheckBox แล้ว
            btnPlus.Click += (s, e) => 
            {
                int currentQty = int.Parse(lblQty.Text);
                if (currentQty + 1 > maxStock)
                {
                    MessageBox.Show($"สินค้ามีในคลังสูงสุด {maxStock} ชิ้น");
                    return;
                }
                UpdateQtyInDB(cartId, currentQty + 1);
                lblQty.Text = (currentQty + 1).ToString();
                lblSubTotal.Text = (price * (currentQty + 1)).ToString("N2");
                UpdateGrandTotal(); // อัปเดตราคารวมทันที
            };

            btnMinus.Click += (s, e) => 
            {
                int currentQty = int.Parse(lblQty.Text);
                if (currentQty - 1 <= 0)
                {
                    if (MessageBox.Show("ต้องการลบสินค้านี้?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RemoveItemFromDB(cartId);
                        ShowCartItems.Controls.Remove(p);
                        UpdateGrandTotal();
                    }
                    return;
                }
                UpdateQtyInDB(cartId, currentQty - 1);
                lblQty.Text = (currentQty - 1).ToString();
                lblSubTotal.Text = (price * (currentQty - 1)).ToString("N2");
                UpdateGrandTotal();
            };

            p.Controls.AddRange(new Control[] { pic, lblInfo, lblPrice, btnMinus, lblQty, btnPlus, lblSubTotal });
            return p;
        }

        // เพิ่มเมธอดตัวช่วยสำหรับ DB
        private void UpdateQtyInDB(int cartId, int newQty)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "UPDATE cart SET quantity = @qty WHERE cart_id = @cid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty", newQty);
                cmd.Parameters.AddWithValue("@cid", cartId);
                cmd.ExecuteNonQuery();
            }
        }

        private void RemoveItemFromDB(int cartId)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "DELETE FROM cart WHERE cart_id = @cid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cid", cartId);
                cmd.ExecuteNonQuery();
            }
        }

        // เมธอดอัปเดตจำนวนใน DB
        private void UpdateCartQuantityInDB(int cartId, int newQty)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "UPDATE cart SET quantity = @qty WHERE cart_id = @cid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty", newQty);
                cmd.Parameters.AddWithValue("@cid", cartId);
                cmd.ExecuteNonQuery();
            }
        }

        // เมธอดลบสินค้าออกจากตะกร้า
        private void RemoveFromCart(int cartId)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "DELETE FROM cart WHERE cart_id = @cid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cid", cartId);
                cmd.ExecuteNonQuery();
            }
        }

        private void btApplyCode_Click(object sender, EventArgs e)
        {
            string promoCode = txtPromoCode.Text.Trim();
            decimal subtotal = CalculateCurrentSubtotal();

            // ถ้าลบโค้ดจนว่างแล้วกดยืนยัน ให้ล้างส่วนลดทิ้ง
            if (string.IsNullOrEmpty(promoCode))
            {
                currentDiscount = 0;
                currentAppliedCode = "";
                isCodeChanged = false;
                UpdatePriceDisplay(subtotal);
                MessageBox.Show("ยกเลิกการใช้โค้ดส่วนลดแล้ว", "แจ้งเตือน");
                return;
            }

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    string sql = "SELECT * FROM promotions WHERE code = @code AND is_active = 1 AND end_date >= CURDATE()";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@code", promoCode);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal minAmount = reader.GetDecimal("min_amount");
                        if (subtotal >= minAmount)
                        {
                            string type = reader.GetString("discount_type");
                            decimal val = reader.GetDecimal("discount_value");

                            if (type == "amount") currentDiscount = val;
                            else currentDiscount = subtotal * (val / 100);

                            currentAppliedCode = promoCode; // บันทึกว่าโค้ดนี้ใช้สำเร็จ
                            isCodeChanged = false;
                            UpdatePriceDisplay(subtotal);
                            MessageBox.Show("ใช้โค้ดสำเร็จ!", "สำเร็จ");
                        }
                        else
                        {
                            MessageBox.Show($"ยอดซื้อขั้นต่ำไม่ถึงเงื่อนไข (ขั้นต่ำ ฿{minAmount:N2})", "เงื่อนไขไม่ครบ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("รหัสส่วนลดไม่ถูกต้องหรือหมดอายุแล้ว", "ผิดพลาด");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private decimal CalculateCurrentSubtotal()
        {
            decimal subtotal = 0;
            foreach (Control row in ShowCartItems.Controls)
            {
                Label lblSub = row.Controls.Find("subtotal", true).FirstOrDefault() as Label;
                if (lblSub != null) { subtotal += decimal.Parse(lblSub.Text); }
            }
            return subtotal;
        }

        private void UpdateGrandTotal()
        {
            decimal subtotal = CalculateCurrentSubtotal();
            if (subtotal == 0) currentDiscount = 0;
            UpdatePriceDisplay(subtotal);
        }

        private void UpdatePriceDisplay(decimal subtotal)
        {
            decimal finalTotal = subtotal - currentDiscount;
            if (finalTotal < 0) finalTotal = 0;
            txtTotalPrice.Text = finalTotal.ToString("N2");
        }

        private void txtPromoCode_TextChanged(object sender, EventArgs e)
        {
            isCodeChanged = true;
        }

        private void BtCheckout_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPromoCode.Text) && isCodeChanged)
            {
                MessageBox.Show("คุณมีการเปลี่ยนแปลงโค้ด กรุณากดยืนยัน (Apply) ก่อนครับ", "แจ้งเตือน");
                return;
            }
            decimal subtotal = CalculateCurrentSubtotal();
            // ส่งราคารวม, ส่วนลด และชื่อโค้ดที่ใช้ปัจจุบันไปยังหน้า Checkout
            Checkout checkoutForm = new Checkout(subtotal, currentDiscount, currentAppliedCode);
            this.Hide();
            checkoutForm.Show();
        }

        private void BtBackToShop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop();
            this.Hide();
            shopForm.Show();
        }

        private void IconAccount_Click(object sender, EventArgs e)
        {
            UserAccount accountForm = new UserAccount();
            this.Hide();
            accountForm.Show();
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.Show();
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void ChkSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
