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

namespace FuzzyKits
{
    public partial class AdminCategoryManagement : Form
    {
        public AdminCategoryManagement()
        {
            InitializeComponent();
            LoadCategoriesData(); // 1. เรียกโหลดข้อมูลทันทีเมื่อ Form เริ่มต้น
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminCategoryManagement_Load(object sender, EventArgs e)
        {
            // 2. ตั้งค่า DataGridView เมื่อ Form โหลดเสร็จ
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.ReadOnly = true;

            // 3. ผูก Event CellClick เพื่อดึงข้อมูลมาใส่ช่องกรอก
            dgvCategories.CellClick += dgvCategories_CellClick;

            // 4. ผูก Event Click ของปุ่ม (ถ้ายังไม่ได้ผูกใน Designer)
            BtAdd.Click += BtAdd_Click;
            BtUpdate.Click += BtUpdate_Click; 
            BtDelete.Click += BtDelete_Click;
            BtClose.Click += BtClose_Click;
        }

        private void LoadCategoriesData()
        {
            string query = "SELECT category_id, category_name FROM categories ORDER BY category_id";
            MySqlConnection conn = DBConnector.GetConnection();
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCategories.DataSource = dt;

                    // ตั้งชื่อคอลัมน์และขนาด
                    dgvCategories.Columns["category_id"].Visible = false;
                    dgvCategories.Columns["category_name"].HeaderText = "ชื่อหมวดหมู่";
                    dgvCategories.Columns["category_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูลหมวดหมู่: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
                // ใช้ชื่อ Control ที่ถูกต้อง: txtCategory
                if (row.Cells["category_name"].Value != DBNull.Value)
                {
                    txtCategory.Text = row.Cells["category_name"].Value.ToString();
                }
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string newName = txtCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO categories (category_name) VALUES (@name)";
            ExecuteCategoryQuery(query, newName, 0, "เพิ่มหมวดหมู่สำเร็จ");
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newName = txtCategory.Text.Trim();
            // ดึง ID ของแถวที่ถูกเลือก
            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["category_id"].Value);

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE categories SET category_name = @name WHERE category_id = @id";
            ExecuteCategoryQuery(query, newName, id, "แก้ไขหมวดหมู่สำเร็จ");
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบหมวดหมู่นี้?\n(สินค้าในหมวดหมู่นี้อาจได้รับผลกระทบ)", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["category_id"].Value);
                string query = "DELETE FROM categories WHERE category_id = @id";
                ExecuteCategoryQuery(query, string.Empty, id, "ลบหมวดหมู่สำเร็จ");
            }
        }

        private void ExecuteCategoryQuery(string query, string name, int id, string successMessage)
        {
            MySqlConnection conn = DBConnector.GetConnection();
            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(name))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                    }
                    if (id > 0)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(successMessage, "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategory.Text = string.Empty;
                    LoadCategoriesData(); // โหลดข้อมูลใหม่
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Error code: Duplicate entry (ชื่อซ้ำ)
                    {
                        MessageBox.Show("ชื่อหมวดหมู่นี้มีอยู่แล้ว กรุณาตั้งชื่อใหม่", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 1451) // Foreign Key Constraint (มีสินค้าใช้งานอยู่)
                    {
                        MessageBox.Show("ไม่สามารถลบหมวดหมู่นี้ได้ เนื่องจากมีสินค้าใช้งานอยู่", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close(); // ปิดฟอร์ม
        }
    }
}
