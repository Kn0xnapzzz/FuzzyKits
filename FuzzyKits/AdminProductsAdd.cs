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
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace FuzzyKits
{
    public partial class AdminProductsAdd : Form
    {
        private string imagePath = null; // ตัวแปรสำหรับเก็บ path ของรูปภาพที่เลือก

        public AdminProductsAdd()
        {
            InitializeComponent();
            // ตั้งค่าเริ่มต้นให้กับ NumericUpDown
            numStock.Minimum = 0;
            numStock.Maximum = 99999;
            numStock.Value = 0;
            
            LoadCategories();
        }

        private void AdminProductsAdd_Load(object sender, EventArgs e)
        {

        }

        // โหลดหมวดหมู่สินค้า
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

                    // เพิ่มแถวว่างเพื่อให้เลือกเป็นค่า null ได้
                    DataRow newRow = dt.NewRow();
                    newRow["category_id"] = DBNull.Value;
                    newRow["category_name"] = "--- เลือกหมวดหมู่ ---";
                    dt.Rows.InsertAt(newRow, 0);

                    // ตั้งค่า ComboBox
                    ChooseCategory.DataSource = dt;
                    ChooseCategory.DisplayMember = "category_name";
                    ChooseCategory.ValueMember = "category_id";
                    ChooseCategory.SelectedIndex = 0;
                    ChooseCategory.MaxDropDownItems = 5;
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

        // ปุ่ม Manage Categories (นำทางไปหน้าจัดการหมวดหมู่)
        private void BtEdit_Click(object sender, EventArgs e)
        {

            // 1. เปิดหน้าจัดการหมวดหมู่ (AdminCategoryManagement)
            AdminCategoryManagement categoryManagementForm = new AdminCategoryManagement();

            // ใช้ ShowDialog() เพื่อให้ฟอร์มหลักรอจนกว่าฟอร์มจัดการหมวดหมู่จะถูกปิด
            categoryManagementForm.ShowDialog();

            // 2. โหลดหมวดหมู่ใหม่หลังจากปิดฟอร์มจัดการหมวดหมู่
            // ข้อมูลใหม่จะถูกดึงมาและแสดงใน ComboBox ทันที
            LoadCategories();
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            // 1. รับค่าและตรวจสอบเบื้องต้น
            string name = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            int stock = (int)numStock.Value;
            object selectedCategory = ChooseCategory.SelectedValue;

            // ตรวจสอบข้อมูลพื้นฐาน
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(priceText) || imagePath == null || stock < 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลสินค้า (ชื่อ/ราคา/รูปภาพ/สต็อก) ให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string imageUrl = "";

            // 3. จัดการรูปภาพ (คัดลอกรูปภาพไปยังโฟลเดอร์ในโปรเจค)
            try
            {
                string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product_Images");
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(imagePath)}";
                string destinationPath = Path.Combine(destinationFolder, fileName);

                File.Copy(imagePath, destinationPath);
                imageUrl = $"Product_Images/{fileName}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกรูปภาพ: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. บันทึกข้อมูลลง DB
            string query = @"INSERT INTO products (name, description, price, stock, image_url, category_id, is_active) 
                             VALUES (@name, @desc, @price, @stock, @imgUrl, @catId, 1);
                             SELECT LAST_INSERT_ID();";

            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", name); // ใช้ชื่อสินค้าเป็น Description ชั่วคราว
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@imgUrl", imageUrl);
                    cmd.Parameters.AddWithValue("@catId", categoryId);

                    object result = cmd.ExecuteScalar();
                    int newProductId = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;

                    if (newProductId > 0)
                    {
                        MessageBox.Show($"เพิ่มสินค้าสำเร็จ! ID สินค้า: {newProductId}", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. นำทางกลับไปหน้า AdminProductsAll
                        AdminProductsAll AdminProductsAllForm = new AdminProductsAll();
                        this.Hide();
                        AdminProductsAllForm.Show();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Logic สำหรับปุ่ม BtChoosePicItem (เลือกรูปภาพ) - เปลี่ยนชื่อเมธอดให้ตรง
        private void BtChoosePicItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PicItem.Image = new Bitmap(openFile.FileName);
                    PicItem.SizeMode = PictureBoxSizeMode.Zoom;
                    imagePath = openFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถโหลดรูปภาพได้: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            AdminProductsAll AdminProductsAll = new AdminProductsAll();
            this.Hide();
            AdminProductsAll.Show();
        }

        private void BtEdit_Click_1(object sender, EventArgs e)
        {
            AdminCategoryManagement categoryManagementForm = new AdminCategoryManagement();
            categoryManagementForm.ShowDialog();
            LoadCategories();
        }
    }
}
