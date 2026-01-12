using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; // สำหรับจัดรูปแบบสกุลเงิน
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // เรียกตั้งค่าเริ่มต้นใน Form_Load เพื่อให้ Controls ถูกสร้างเสร็จก่อน
            LoadCategories(); // โหลดหมวดหมู่สำหรับ ComboBox
            LoadShopContent(); // เรียกโหลดสินค้าหลัก
            LoadPromotions();

            ChooseCategory.SelectedIndexChanged += new EventHandler(FilterByCategory_SelectedIndexChanged);
        }

        private void LoadPromotions()
        {
            // 1. ตั้งค่าพื้นที่แสดงผลให้เลื่อนขึ้นลงได้
            ShowPromotion.Controls.Clear();
            ShowPromotion.AutoScroll = true;
            ShowPromotion.FlowDirection = FlowDirection.TopDown; // เรียงจากบนลงล่าง
            ShowPromotion.WrapContents = false; // บังคับไม่ให้ขึ้นแถวใหม่ด้านข้าง

            // 2. ปรับขนาดหัวข้อให้พอดีกับกรอบ 680
            Label lblTitle = new Label
            {
                Text = "🎁 โค้ดส่วนลดพิเศษสำหรับคุณ",
                Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Bold),
                Size = new Size(640, 30),
                Margin = new Padding(10, 5, 0, 0)
            };
            ShowPromotion.Controls.Add(lblTitle);

            Label lblNote = new Label
            {
                Text = "หมายเหตุ : คัดลอกโค้ดเพื่อรับส่วนลดในหน้าตะกร้าสินค้า (จำกัด 1 โค้ดต่อรายการ)",
                Font = new Font("Leelawadee UI", 10, FontStyle.Regular),
                ForeColor = Color.DimGray,
                Size = new Size(640, 25),
                Margin = new Padding(15, 0, 0, 10)
            };
            ShowPromotion.Controls.Add(lblNote);

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    // ดึงข้อมูลเฉพาะที่ยังไม่หมดอายุและสถานะ Active
                    string query = "SELECT * FROM promotions WHERE is_active = 1 AND end_date >= CURDATE() ORDER BY promotion_id DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // ส่งข้อมูลไปสร้างแผ่นคูปอง
                        Panel promoTicket = CreatePromoTicket(
                            reader.GetString("code"),
                            reader.GetString("name"),
                            reader.GetString("discount_type"),
                            reader.GetDecimal("discount_value"),
                            reader.GetDecimal("min_amount")
                        );
                        ShowPromotion.Controls.Add(promoTicket);
                    }
                }
                catch (Exception ex) { MessageBox.Show("โหลดโปรโมชั่นล้มเหลว: " + ex.Message); }
            }
        }

        private Panel CreatePromoTicket(string code, string name, string type, decimal val, decimal min)
        {
            Panel p = new Panel { Size = new Size(680, 130), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.FromArgb(255, 240, 225), Margin = new Padding(10, 5, 10, 5) };

            // 1. ชื่อโปรโมชั่น: ขยับ Size ให้กว้างเกือบเต็มกรอบ (ประมาณ 640) เพื่อให้รองรับชื่อยาวๆ
            Label lblName = new Label
            {
                Text = "🎟️ " + name,
                Location = new Point(20, 15),
                Size = new Size(640, 30),
                Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Bold),
                ForeColor = Color.DarkOrange
            };

            // 2. รายละเอียดส่วนลด: ปรับฟอนต์ให้เล็กลงนิดหน่อยเพื่อให้ดูสะอาดตา
            string discText = (type == "percent") ? $"ลด {val:N0}%" : $"ลด {val:N0} บาท";
            Label lblDetail = new Label
            {
                Text = $"{discText} (ขั้นต่ำ {min:N0}.-)",
                Location = new Point(20, 45),
                Size = new Size(640, 25),
                Font = new Font("Berlin Sans FB", 12)
            };

            // 3. ส่วนของ Code: ปรับช่องกรอกให้กว้างขึ้นแต่ไม่เบียดปุ่ม Copy
            Label lblCodeTag = new Label { Text = "Code:", Location = new Point(20, 85), Size = new Size(60, 30), Font = new Font("Berlin Sans FB Demi", 12) };

            TextBox txtCode = new TextBox
            {
                Text = code,
                Location = new Point(85, 82),
                Size = new Size(400, 35), // ความกว้าง 400 จะพอดีกับพื้นที่ฝั่งซ้าย
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Left,
                Font = new Font("Consolas", 14, FontStyle.Bold),
                BackColor = Color.White
            };

            // 4. ปุ่มก๊อปปี้: วางไว้ริมขวาของกรอบ 680
            Button btnCopy = new Button
            {
                Text = "Copy Code",
                Location = new Point(500, 80), // ขยับมาที่ตำแหน่ง 500 เพื่อให้พอดีกับกรอบ 680
                Size = new Size(150, 35),
                BackColor = Color.FromArgb(249, 185, 114),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Berlin Sans FB", 12)
            };

            btnCopy.Click += (s, e) => {
                Clipboard.SetText(code);
                MessageBox.Show($"คัดลอกโค้ด {code} เรียบร้อย!", "สำเร็จ");
            };

            p.Controls.AddRange(new Control[] { lblName, lblDetail, lblCodeTag, txtCode, btnCopy });
            return p;
        }

        // A. โหลดหมวดหมู่สำหรับ ComboBox
        private void LoadCategories()
        {
            string query = "SELECT category_id, category_name FROM categories ORDER BY category_name";
            MySqlConnection conn = DBConnector.GetConnection();
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow newRow = dt.NewRow();
                    newRow["category_id"] = DBNull.Value;
                    newRow["category_name"] = "--- สินค้าทั้งหมด ---"; // ข้อความสำหรับลูกค้า
                    dt.Rows.InsertAt(newRow, 0);

                    ChooseCategory.DataSource = dt;
                    ChooseCategory.DisplayMember = "category_name";
                    ChooseCategory.ValueMember = "category_id";
                    ChooseCategory.SelectedIndex = 0;
                    ChooseCategory.MaxDropDownItems = 8;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดหมวดหมู่: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // B. Event กรองเมื่อเลือกหมวดหมู่
        private void FilterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShopContent(); // โหลดสินค้าใหม่ตามหมวดหมู่ที่เลือก
        }

        // C. โหลดและแสดงสินค้าใน FlowLayoutPanel
        private void LoadShopContent()
        {
            // 1. ตรวจสอบ FlowLayoutPanel
            if (ShowProducts == null) return;
            // รับ Keyword จากช่องค้นหา (ใช้ชื่อ Control ที่ถูกต้อง: txtSearch)
            RoundTextBox txtSearchControl = this.Controls.Find("txtSearch", true).FirstOrDefault() as RoundTextBox;
            string searchKeyword = (txtSearchControl != null) ? txtSearchControl.Text.Trim() : "";

            // 2. กำหนดเงื่อนไขการกรอง
            string whereClause = "WHERE p.is_active = 1 AND p.stock > 0 "; // แสดงเฉพาะสินค้าที่ Active และมีสต็อก
            string orderBy = "p.product_id ASC";

            // กรองตามหมวดหมู่ที่เลือก (ใช้ชื่อ ComboBox: ChooseCategory)
            if (ChooseCategory.SelectedValue != null && ChooseCategory.SelectedValue != DBNull.Value)
            {
                // ตรวจสอบว่าเป็น string ก่อนใช้ใน query และใช้ EscapeString เพื่อความปลอดภัย
                string selectedCatId = MySql.Data.MySqlClient.MySqlHelper.EscapeString(ChooseCategory.SelectedValue.ToString());
                whereClause += $"AND p.category_id = '{selectedCatId}' ";
            }

            // เพิ่มเงื่อนไขค้นหาตามชื่อสินค้า
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // ใช้ LIKE %keyword% เพื่อค้นหาสินค้าที่มี Keyword อยู่ในชื่อ
                string escapedKeyword = MySql.Data.MySqlClient.MySqlHelper.EscapeString(searchKeyword);
                whereClause += $"AND p.name LIKE '%{escapedKeyword}%' ";
            }

            // 3. Query ดึงสินค้า
            string query = $@"
                SELECT 
                    p.product_id, 
                    p.name, 
                    p.price,
                    p.stock,
                    p.image_url
                FROM products p
                {whereClause}
                ORDER BY {orderBy}";

            MySqlConnection conn = DBConnector.GetConnection();
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // 4. ล้าง FlowLayoutPanel ก่อนแสดงผลใหม่
                    ShowProducts.Controls.Clear();

                    // 5. วนซ้ำสร้าง Panel/Card สินค้าแต่ละชิ้น
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("product_id");
                        string name = reader.GetString("name");
                        decimal price = reader.GetDecimal("price");
                        int stock = reader.GetInt32("stock"); // ดึงค่าสต็อกออกมา
                        string imgUrl = reader.GetString("image_url");

                        // ส่งค่า stock เข้าไปในพารามิเตอร์ที่ 4
                        Panel productCard = CreateProductCard(id, name, price, stock, imgUrl);
                        ShowProducts.Controls.Add(productCard);
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูลร้านค้า: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // D. เมธอดช่วยสร้าง Product Card (สำหรับลูกค้า)
        private Panel CreateProductCard(int id, string name, decimal price, int stock, string imgUrl)
        {
            RoundedPanel p = new RoundedPanel();
            p.Size = new Size(180, 310); // ปรับความสูงเพิ่มเพื่อใส่สต็อกและช่องจำนวน
            p.BorderColor = Color.Black;
            p.BorderThickness = 2;
            p.BorderRadius = 10;
            p.Margin = new Padding(25, 10, 5, 10);
            p.Tag = id;
            p.BackColor = Color.White;

            Font mainFont = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold);
            Font subFont = new Font("Berlin Sans FB Demi", 10F);

            // 1. Picture Box
            PictureBox pic = new PictureBox();
            pic.Size = new Size(160, 140);
            pic.Location = new Point(10, 10);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = GetProductImage(imgUrl);
            p.Controls.Add(pic);

            // 2. Name Label
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Location = new Point(10, 160);
            lblName.AutoSize = false;
            lblName.Width = 160;
            lblName.Font = mainFont;
            p.Controls.Add(lblName);

            // 3. Price Label
            Label lblPrice = new Label();
            lblPrice.Text = price.ToString("C2", CultureInfo.GetCultureInfo("th-TH"));
            lblPrice.Location = new Point(10, 185);
            lblPrice.Font = mainFont;
            lblPrice.ForeColor = Color.DarkRed;
            p.Controls.Add(lblPrice);

            // 4. Stock Label (แสดงจำนวนคงเหลือ)
            Label lblStock = new Label();
            lblStock.Text = $"คงเหลือ: {stock} ชิ้น"; // ใช้ตัวแปร stock ที่รับเข้ามา
            lblStock.Location = new Point(10, 210);
            lblStock.Font = subFont;
            lblStock.ForeColor = Color.Gray;
            p.Controls.Add(lblStock);

            // 5. NumericUpDown เลือกจำนวน
            NumericUpDown numQty = new NumericUpDown();
            numQty.Name = "numQty_" + id;
            numQty.Location = new Point(10, 235);
            numQty.Size = new Size(160, 25);
            numQty.Minimum = 1;
            numQty.Maximum = stock; // จำกัดไม่ให้เลือกเกินสต็อก
            numQty.Value = 1;
            p.Controls.Add(numQty);

            // 6. ปุ่ม Add to Cart
            RoundedButton btnCart = new RoundedButton();
            btnCart.Text = "Add to Cart";
            btnCart.Size = new Size(160, 30);
            btnCart.Location = new Point(10, 270);
            btnCart.Cursor = Cursors.Hand;
            // เก็บ ID และ ชื่อสินค้าไว้ใน Tag เพื่อใช้ตอนแจ้งเตือน
            btnCart.Tag = new { ID = id, Name = name };
            btnCart.Click += AddToCart_Click;
            p.Controls.Add(btnCart);

            return p;
        }

        // E. เมธอดช่วยโหลดรูปภาพ
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

        // F. Logic ปุ่ม Add to Cart (จำลอง)
        private void AddToCart_Click(object sender, EventArgs e)
        {
            RoundedButton btn = sender as RoundedButton;
            if (btn == null || UserSession.CurrentUserId <= 0) return;

            dynamic productInfo = btn.Tag;
            int productId = productInfo.ID;
            string productName = productInfo.Name;

            Control card = btn.Parent;
            NumericUpDown numQty = card.Controls.Find("numQty_" + productId, true).FirstOrDefault() as NumericUpDown;
            int inputQuantity = (numQty != null) ? (int)numQty.Value : 1;

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    // 1. เช็คสต็อกจริงในคลัง และจำนวนที่มีอยู่ในตะกร้าปัจจุบัน
                    string checkSql = @"SELECT p.stock, IFNULL(c.quantity, 0) as cart_qty 
                               FROM products p 
                               LEFT JOIN cart c ON p.product_id = c.product_id AND c.user_id = @uid 
                               WHERE p.product_id = @pid";

                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    checkCmd.Parameters.AddWithValue("@pid", productId);

                    int dbStock = 0;
                    int existingInCart = 0;

                    using (MySqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dbStock = reader.GetInt32("stock");
                            existingInCart = reader.GetInt32("cart_qty");
                        }
                    }

                    // 2. ตรวจสอบเงื่อนไขสต็อก
                    if (existingInCart + inputQuantity > dbStock)
                    {
                        int canAddMore = dbStock - existingInCart;
                        if (canAddMore <= 0)
                        {
                            MessageBox.Show($"ขออภัย! สินค้า '{productName}' ในคลังมีทั้งหมด {dbStock} ชิ้น \nคุณมีในตะกร้าครบตามจำนวนคลังแล้ว ไม่สามารถเพิ่มได้อีก",
                                            "สินค้าเกินจำนวนในคลัง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"คุณมีในตะกร้าแล้ว {existingInCart} ชิ้น \nในคลังเหลือให้เพิ่มได้อีกเพียง {canAddMore} ชิ้นเท่านั้น",
                                            "สินค้าในคลังไม่พอ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return; // หยุดการทำงาน ไม่บันทึกลง DB
                    }

                    // 3. ถ้าผ่านเงื่อนไข ให้บันทึกลงตะกร้า (ใช้ SQL ตัวเดิมที่คุณมี)
                    // ในไฟล์ Shop.cs ส่วน SQL ของปุ่ม AddToCart
                    string sql = @"INSERT INTO cart (user_id, product_id, quantity) 
                                    VALUES (@uid, @pid, @qty) 
                                    ON DUPLICATE KEY UPDATE quantity = quantity + @qty";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    cmd.Parameters.AddWithValue("@pid", productId);
                    cmd.Parameters.AddWithValue("@qty", inputQuantity);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"เพิ่ม '{productName}' ลงตะกร้า {inputQuantity} ชิ้น เรียบร้อยแล้ว!", "สำเร็จ");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {
            // เรียกโหลดเนื้อหาใหม่ ซึ่งจะดึง Keyword จาก txtSearch ไปใช้
            LoadShopContent();
        }

        // G. Logic การนำทาง
        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.Show();
        }

        private void IconShoppingCart_Click(object sender, EventArgs e)
        {
            ShoppingCart ShoppingCartForm = new ShoppingCart();
            this.Hide();
            ShoppingCartForm.Show();
        }

        private void IconAccount_Click(object sender, EventArgs e)
        {
            UserAccount UserAccountForm = new UserAccount();
            this.Hide();
            UserAccountForm.Show();

        }
    }
}
