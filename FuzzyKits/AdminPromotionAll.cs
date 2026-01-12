using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class AdminPromotionAll : Form
    {
        public AdminPromotionAll()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadPromotions();
        }

        private void LoadPromotions()
        {
            // ตรวจสอบก่อนว่า tabPromotionList (FlowLayoutPanel) ถูกสร้างหรือยัง
            if (tabPromotionList == null) return;

            tabPromotionList.Controls.Clear(); // ล้างรายการเก่าออกให้หมดก่อนโหลดใหม่

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    // ดึงข้อมูลโปรโมชั่นเรียงจากใหม่ไปเก่า
                    string query = "SELECT * FROM promotions ORDER BY promotion_id DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // ดึงค่าแต่ละคอลัมน์มาเก็บในตัวแปร
                        int id = reader.GetInt32("promotion_id");
                        string code = reader.GetString("code");
                        string name = reader.GetString("name");
                        string type = reader.GetString("discount_type");
                        decimal val = reader.GetDecimal("discount_value");
                        decimal min = reader.IsDBNull(reader.GetOrdinal("min_amount")) ? 0 : reader.GetDecimal("min_amount");
                        DateTime end = reader.GetDateTime("end_date");
                        bool isActive = reader.GetInt32("is_active") == 1;

                        // สร้างแถวข้อมูล (Panel) แล้วแปะลงใน FlowLayoutPanel
                        Panel row = CreatePromotionRow(id, code, name, type, val, min, end, isActive);
                        tabPromotionList.Controls.Add(row);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถโหลดรายการโปรโมชั่นได้: " + ex.Message, "Error");
                }
            }
        }

        private Panel CreatePromotionRow(int id, string code, string name, string type, decimal val, decimal min, DateTime end, bool isActive)
        {
            // ปรับขนาดแผงแต่ละแถวให้พอดีกับ tabPromotionList
            Panel p = new Panel { Size = new Size(680, 100), BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(10), BackColor = Color.White };

            // แสดง Code และ Name (ฝั่งซ้าย)
            Label lblMain = new Label
            {
                Text = $"{code}\n{name}",
                Location = new Point(15, 15),
                Size = new Size(210, 70),
                Font = new Font("Berlin Sans FB Demi", 14, FontStyle.Bold)
            };

            // แสดงรายละเอียดส่วนลด (ตรงกลาง)
            string discDisplay = (type == "percent") ? $"{val:N0}%" : $"{val:N2} บาท";
            Label lblDisc = new Label
            {
                Text = $"ลด: {discDisplay}\nขั้นต่ำ: {min:N2}.-",
                Location = new Point(235, 20),
                Size = new Size(120, 60),
                Font = new Font("Berlin Sans FB", 12)
            };

            // แสดงสถานะและวันหมดอายุ (ฝั่งขวา)
            string statusStr = isActive ? "🟢 Active" : "🔴 Inactive";
            Label lblStatus = new Label
            {
                Text = $"{statusStr}\nExp: {end:dd/MM/yyyy}",
                Location = new Point(380, 20),
                Size = new Size(100, 60),
                Font = new Font("Berlin Sans FB", 11)
            };

            // ปุ่ม Delete (สีแดง)
            Button btnDel = new Button
            {
                Text = "Delete",
                Location = new Point(510, 30),
                Size = new Size(75, 40),
                BackColor = Color.MistyRose,
                FlatStyle = FlatStyle.Flat
            };
            btnDel.Click += (s, e) => {
                if (MessageBox.Show($"ยืนยันการลบ {code}?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeletePromotionFromDB(id);
                    LoadPromotions(); // รีโหลดลิสต์ทันที
                }
            };

            // ปุ่ม Edit (สีฟ้า)
            Button btnEdit = new Button
            {
                Text = "Edit",
                Location = new Point(595, 30),
                Size = new Size(70, 40),
                BackColor = Color.LightCyan,
                FlatStyle = FlatStyle.Flat
            };
            btnEdit.Click += (s, e) => {
                AdminPromotionAdd editForm = new AdminPromotionAdd(id);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPromotions(); // เรียกฟังก์ชันโหลดข้อมูลใหม่เพื่อแสดงค่าล่าสุดที่เพิ่งแก้
                }
            };

            // ใส่ทึกอย่างลงใน Panel
            p.Controls.AddRange(new Control[] { lblMain, lblDisc, lblStatus, btnDel, btnEdit });
            return p;
        }

        private void DeletePromotionFromDB(int id)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    string sql = "DELETE FROM promotions WHERE promotion_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show("ลบไม่สำเร็จ: " + ex.Message); }
            }
        }

        private void BtProducts_Click(object sender, EventArgs e)
        {
            AdminProductsAll AdminProductsAllForm = new AdminProductsAll();
            this.Hide();
            AdminProductsAllForm.Show();
        }

        private void BtDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            this.Hide();
            AdminDashboardForm.Show();
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
            AdminOrder AdminOrderForm = new AdminOrder();
            this.Hide();
            AdminOrderForm.Show();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            BtAdd.Enabled = false; // ป้องกันการกดซ้ำ
            AdminPromotionAdd AdminPromotionAddForm = new AdminPromotionAdd();
            if (AdminPromotionAddForm.ShowDialog() == DialogResult.OK)
            {
                LoadPromotions();
            }
            BtAdd.Enabled = true; // เปิดให้กดใหม่ได้เมื่อปิดหน้าต่าง Add ไปแล้ว
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        } 
    }
}
