using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // สำหรับใช้ Linq ในการค้นหา Control
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Globalization;

namespace FuzzyKits
{
    public partial class AdminProductsAll : Form
    {
        // ตัวแปรสำหรับเก็บ ID สินค้าที่ถูกเลือกในปัจจุบัน
        private int selectedProductID = -1;

        public AdminProductsAll()
        {
            InitializeComponent();
            // เรียกตั้งค่าและโหลดข้อมูลเมื่อ Form ถูกสร้าง
            SetupControlsAndLoadData();
        }

        private void SetupControlsAndLoadData()
        {
            // 1. ตั้งค่า Controls
            // FlowLayoutPanel (ใช้ชื่อ flowLayoutPanel1 ที่คุณต้องเพิ่มใน Designer)
            ShowProducts = this.Controls.Find("ShowProducts", true).FirstOrDefault() as FlowLayoutPanel; if (ShowProducts != null)
            if (ShowProducts != null)
            {
                ShowProducts.AutoScroll = true;
            }

            // 2. โหลดหมวดหมู่สำหรับ ComboBox กรอง
            ComboBox cmbCategory = this.Controls.Find("cmbCategory", true).FirstOrDefault() as ComboBox;

            if (cmbCategory != null)
            {
                LoadFilterCategories(cmbCategory);
                cmbCategory.SelectedIndexChanged += FilterData_SelectedIndexChanged;
            }

            // 3. เรียกโหลดข้อมูลสินค้าเริ่มต้น
            LoadProductsData();
        }

        private void LoadFilterCategories(ComboBox cmbCategory)
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
                    newRow["category_name"] = "--- ทุกหมวดหมู่ ---";
                    dt.Rows.InsertAt(newRow, 0);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "category_name";
                    cmbCategory.ValueMember = "category_id";
                    cmbCategory.SelectedIndex = 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดหมวดหมู่กรอง: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Event Gringing Data (เรียกเมื่อ ComboBox เปลี่ยนค่า)
        private void FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        public void LoadProductsData()
        {
            if (ShowProducts == null) return;

            ComboBox cmbCategory = this.Controls.Find("cmbCategory", true).FirstOrDefault() as ComboBox;

            // 1. กำหนดเงื่อนไขการกรอง
            string whereClause = "WHERE p.is_active = 1 AND p.stock > 0 ";

            if (cmbCategory != null && cmbCategory.SelectedValue != null && cmbCategory.SelectedValue != DBNull.Value)
            {
                whereClause += $"AND p.category_id = '{cmbCategory.SelectedValue}' ";
            }

            // 2. Query ดึงสินค้า
            string query = $@"
                SELECT 
                    p.product_id, 
                    p.name, 
                    p.price, 
                    p.stock,
                    p.image_url
                FROM products p
                LEFT JOIN categories c ON p.category_id = c.category_id
                {whereClause}
                ORDER BY p.product_id ASC";

            MySqlConnection conn = DBConnector.GetConnection();
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // 3. ล้าง FlowLayoutPanel ก่อนแสดงผลใหม่
                    ShowProducts.Controls.Clear();
                    selectedProductID = -1; // รีเซ็ตสถานะการเลือก

                    // 4. วนซ้ำสร้าง Panel/Card สินค้าแต่ละชิ้น
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("product_id");
                        string name = reader.GetString("name");
                        decimal price = reader.GetDecimal("price");
                        int stock = reader.GetInt32("stock");
                        string imgUrl = reader.GetString("image_url");

                        Panel productCard = CreateProductCard(id, name, price, stock, imgUrl);
                        ShowProducts.Controls.Add(productCard);
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูลสินค้า: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private Panel CreateProductCard(int id, string name, decimal price, int stock, string imgUrl)
        {
            // ใช้ RoundedPanel
            // Note: RoundedPanel ต้องมี Constructor ที่ไม่รับพารามิเตอร์
            RoundedPanel p = new RoundedPanel();
            p.Size = new Size(200, 300);
            p.BorderColor = Color.LightGray;
            p.BorderThickness = 1;
            p.BorderRadius = 10;
            p.Margin = new Padding(10);
            p.Tag = id; // เก็บ Product ID
            p.BackColor = Color.White;
            p.Cursor = Cursors.Hand;

            // ผูก Event คลิกที่ Card เพื่อเลือกสินค้า
            p.Click += ProductCard_Click;

            if (stock <= 10)
            {
                p.BorderColor = Color.Red;
                p.BorderThickness = 2; // หนาขึ้นเล็กน้อยเพื่อเป็นจุดสังเกต
            }
            else
            {
                p.BorderColor = Color.LightGray;
                p.BorderThickness = 1;
            }

            // กำหนดฟอนต์หลักตามที่คุณต้องการ
            Font mainFont = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold);
            Font subFont = new Font("Berlin Sans FB Demi", 12F);

            // 1. Picture Box
            PictureBox pic = new PictureBox();
            pic.Size = new Size(180, 150);
            pic.Location = new Point(10, 10);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = GetProductImage(imgUrl);
            pic.Tag = id;
            pic.Click += ProductCard_Click;
            p.Controls.Add(pic);

            // 2. Name Label
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Location = new Point(10, 170);
            lblName.AutoSize = false;
            lblName.Width = 180;
            lblName.Font = mainFont; // 16.2pt Bold
            lblName.Click += ProductCard_Click;
            p.Controls.Add(lblName);

            // 3. Price Label (แก้ไขการแสดงผลราคาให้มีทศนิยมและสัญลักษณ์เงิน)
            Label lblPrice = new Label();
            // ใช้ CultureInfo.GetCultureInfo("th-TH") เพื่อบังคับแสดงสกุลเงินไทย ฿ และทศนิยม 2 ตำแหน่ง
            lblPrice.Text = price.ToString("C2", CultureInfo.GetCultureInfo("th-TH"));
            lblPrice.Location = new Point(10, 205);
            lblPrice.Font = mainFont; // 16.2pt Bold
            lblPrice.ForeColor = Color.DarkRed;
            lblPrice.Click += ProductCard_Click;
            p.Controls.Add(lblPrice);

            // 4. Stock Label
            Label lblStock = new Label();
            lblStock.Text = $"คงเหลือ: {stock} ชิ้น";
            lblStock.Location = new Point(10, 240);
            lblStock.Font = subFont; // 12pt
            lblStock.Click += ProductCard_Click;
            p.Controls.Add(lblStock);

            lblStock.Tag = stock;

            if (stock <= 10)
            {
                lblStock.ForeColor = Color.Red; // ข้อความสีแดง
                lblStock.Font = new Font(subFont, FontStyle.Bold); // ตัวหนา
            }
            p.Controls.Add(lblStock);

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
                        // ต้องส่งคืน Image.FromStream(fs)
                        return Image.FromStream(fs);
                    }
                }
            }
            catch { }
            return null;
        }

        // F. Logic เมื่อคลิกที่ Card สินค้า (สำหรับการเลือก Edit)
        private void ProductCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            // วนหา Panel แม่ (Card)
            Panel parentCard = clickedControl.Parent as Panel;
            if (parentCard == null) parentCard = clickedControl as Panel;

            if (parentCard != null && parentCard.Tag != null)
            {
                int id = (int)parentCard.Tag;

                // 1. ล้างสถานะการเลือกเก่า
                selectedProductID = id;

                // 2. แสดงสถานะการเลือก (ปรับสีเส้นขอบ)
                foreach (Control control in ShowProducts.Controls)
                {
                    if (control is RoundedPanel card)
                    {
                        if ((int)card.Tag == id)
                        {
                            card.BorderColor = Color.Orange; // เน้น Card ที่เลือก
                            card.BorderThickness = 3;
                            // แสดงข้อความที่ textBox28
                            TextBox statusBox = this.Controls.Find("textBox28", true).FirstOrDefault() as TextBox;
                            if (statusBox != null)
                            {
                                statusBox.Text = $"สินค้า ID: {id} ถูกเลือกแล้ว";
                            }
                        }
                        else
                        {
                            Label stockLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("คงเหลือ:"));
                            int s = (stockLabel != null && stockLabel.Tag is int val) ? val : 100;

                            if (s <= 10)
                            {
                                card.BorderColor = Color.Red;
                                card.BorderThickness = 2;
                            }
                            else
                            {
                                card.BorderColor = Color.LightGray;
                                card.BorderThickness = 1;
                            }
                        }
                    }
                }
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductID > 0)
            {
                // ส่ง Product ID ไปยังหน้า AdminProductsEdit
                AdminProductsEdit AdminProductsEditForm = new AdminProductsEdit(selectedProductID);
                this.Hide();
                AdminProductsEditForm.Show();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            AdminProductsAdd AdminProductsAddForm = new AdminProductsAdd();
            this.Hide();
            AdminProductsAddForm.Show();
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void BtPromotion_Click(object sender, EventArgs e)
        {
            AdminPromotionAll AdminPromotionAllForm = new AdminPromotionAll();
            this.Hide();
            AdminPromotionAllForm.Show();
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
            AdminOrder AdminOrderForm = new AdminOrder();
            this.Hide();
            AdminOrderForm.Show();
        }

        private void BtDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }

        private void AdminProductsAll_Load(object sender, EventArgs e)
        {

        }

        private void tabShowProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabAll_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
