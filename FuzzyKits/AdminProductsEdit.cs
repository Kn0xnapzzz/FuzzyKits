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

namespace FuzzyKits
{
    public partial class AdminProductsEdit : Form
    {
        private int currentProductID = -1; // ตัวแปรสำหรับเก็บ ID สินค้าที่กำลังแก้ไข
        private string imagePath = null; // ตัวแปรสำหรับเก็บ path รูปภาพใหม่

        public AdminProductsEdit()
        {
            InitializeComponent();
        }

        public AdminProductsEdit(int productID)
        {
            InitializeComponent();
            this.currentProductID = productID;

            // ตั้งค่า NumericUpDown
            numStock.Minimum = 0;
            numStock.Maximum = 99999;

            // เรียกโหลดข้อมูลทั้งหมด
            LoadCategories();
            LoadProductDetails(productID);

        }

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
                    newRow["category_name"] = "--- เลือกหมวดหมู่ ---";
                    dt.Rows.InsertAt(newRow, 0);

                    ChooseCategory.DataSource = dt;
                    ChooseCategory.DisplayMember = "category_name";
                    ChooseCategory.ValueMember = "category_id";
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

        private void LoadProductDetails(int productID)
        {
            if (productID <= 0) return;

            // ดึงข้อมูลสินค้าที่จำเป็นจาก DB
            string query = "SELECT name, price, stock, image_url, category_id FROM products WHERE product_id = @id";
            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", productID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // 1. แสดง ID สินค้า (ReadOnly)
                        txtProductID.Text = productID.ToString();

                        // 2. โหลดข้อมูลเข้า Controls
                        txtProductName.Text = reader["name"].ToString();
                        txtPrice.Text = reader["price"].ToString();

                        // numStock
                        int stockValue = reader.GetInt32("stock");
                        numStock.Value = (stockValue >= numStock.Minimum && stockValue <= numStock.Maximum) ? stockValue : numStock.Minimum;

                        // 3. เก็บ URL รูปเดิม
                        imagePath = reader["image_url"].ToString();

                        // 4. เลือกหมวดหมู่ที่ถูกต้องใน ComboBox
                        if (reader["category_id"] != DBNull.Value)
                        {
                            ChooseCategory.SelectedValue = reader.GetInt32("category_id");
                        }

                        // 5. แสดงรูปภาพ
                        DisplayImage(imagePath);
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

        private void DisplayImage(string imgUrl)
        {
            // โค้ด DisplayImage เหมือนกับ AdminProductsAdd.cs 
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imgUrl);

                if (File.Exists(fullPath))
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        PicItem.Image = Image.FromStream(fs);
                    }
                    PicItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    PicItem.Image = null; // ไม่พบรูป
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถแสดงรูปภาพได้: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PicItem.Image = null;
            }
        }

        private void BtChoosePicItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PicItem.Image = new Bitmap(openFile.FileName);
                    PicItem.SizeMode = PictureBoxSizeMode.Zoom;
                    // imagePath จะถูกใช้เป็น Path ของไฟล์ชั่วคราวในการ UPDATE
                    imagePath = openFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถโหลดรูปภาพได้: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            AdminCategoryManagement categoryManagementForm = new AdminCategoryManagement();
            categoryManagementForm.ShowDialog();
            LoadCategories();
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            // 0. ตรวจสอบว่ามี ID สินค้าที่ถูกต้อง
            if (currentProductID <= 0)
            {
                MessageBox.Show("ข้อผิดพลาด: ไม่พบ ID สินค้าที่ต้องการแก้ไข", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. รับค่าและตรวจสอบเบื้องต้น
            string name = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            int stock = (int)numStock.Value;
            object selectedCategory = ChooseCategory.SelectedValue;
            string newImageUrl = imagePath; // Path ที่จะใช้ในการ UPDATE

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("กรุณากรอกชื่อสินค้าและราคา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedCategory == DBNull.Value || selectedCategory == null)
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่สินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ตรวจสอบรูปแบบข้อมูล (ราคาต้องเป็นตัวเลข)
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("กรุณากรอกราคาให้ถูกต้อง (ต้องเป็นตัวเลขบวก)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = Convert.ToInt32(selectedCategory);

            // 3. จัดการรูปภาพ (ถ้ามีการเลือกรูปภาพใหม่)
            // ถ้า imagePath ชี้ไปที่ไฟล์ในเครื่อง (ไม่ใช่ Path สัมพัทธ์ใน DB) แสดงว่ามีการเลือกรูปใหม่
            if (!imagePath.StartsWith("Product_Images"))
            {
                try
                {
                    string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product_Images");
                    if (!Directory.Exists(destinationFolder)) Directory.CreateDirectory(destinationFolder);

                    // สร้างชื่อไฟล์ใหม่ และคัดลอกไฟล์
                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(imagePath)}";
                    string destinationPath = Path.Combine(destinationFolder, fileName);
                    File.Copy(imagePath, destinationPath);
                    newImageUrl = $"Product_Images/{fileName}"; // อัปเดต Path ใหม่สำหรับ DB
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกรูปภาพใหม่: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 4. UPDATE ข้อมูลลง DB
            string query = @"UPDATE products SET 
                             name = @name, 
                             description = @desc, 
                             price = @price, 
                             stock = @stock, 
                             image_url = @imgUrl, 
                             category_id = @catId
                             WHERE product_id = @id";

            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@imgUrl", newImageUrl);
                    cmd.Parameters.AddWithValue("@catId", categoryId);
                    cmd.Parameters.AddWithValue("@id", currentProductID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"แก้ไขสินค้า ID: {currentProductID} สำเร็จ!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. นำทางกลับไปหน้า AdminProductsAll
                    AdminProductsAll AdminProductsAllForm = new AdminProductsAll();
                    this.Hide();
                    AdminProductsAllForm.Show();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการอัปเดตข้อมูล: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BtDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminProductsEdit_Load(object sender, EventArgs e)
        {

        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (currentProductID <= 0) return;

            DialogResult confirm = MessageBox.Show($"คุณแน่ใจหรือไม่ว่าต้องการลบสินค้า ID: {currentProductID}?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // Soft Delete: ตั้งค่า is_active = 0 (สินค้าจะถูกซ่อนจากหน้าร้านค้า)
                string query = "UPDATE products SET is_active = 0 WHERE product_id = @id";
                // ถ้าต้องการลบถาวร: string query = "DELETE FROM products WHERE product_id = @id";

                MySqlConnection conn = DBConnector.GetConnection();
                if (conn != null)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", currentProductID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ลบสินค้าสำเร็จ (สินค้าถูกซ่อน)", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // นำทางกลับไปหน้า AdminProductsAll
                        AdminProductsAll AdminProductsAllForm = new AdminProductsAll();
                        this.Hide();
                        AdminProductsAllForm.Show();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการลบสินค้า: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
