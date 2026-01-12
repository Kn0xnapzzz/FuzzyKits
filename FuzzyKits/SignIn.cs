using MySql.Data.MySqlClient; // สำหรับใช้ติดต่อฐานข้อมูล MySQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class SignIn : Form
    {
        // ฟังก์ชันสำหรับการ Hash รหัสผ่าน
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // แปลงรหัสผ่านเป็น byte และคำนวณ Hash
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // แปลง byte กลับเป็น string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            this.Hide();
            HomeForm.Show();
        }

        private void IconTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                IconTogglePassword.Image = Properties.Resources.Open;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                IconTogglePassword.Image = Properties.Resources.Hide;
            }
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();
            RegisterForm.Show();
        }

        private void BtForgotPW_Click(object sender, EventArgs e)
        {
            ForgotPassword ForgotPasswordForm = new ForgotPassword();
            this.Hide();
            ForgotPasswordForm.Show();
        }

        private void BtAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs AboutUsForm = new AboutUs();
            this.Hide();
            AboutUsForm.Show();
        }

        private void BtContinue_Click(object sender, EventArgs e)
        {
            // 1. รับค่า
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hash รหัสผ่าน
            string hashedPassword = HashPassword(password);

            // 3. ตรวจสอบกับฐานข้อมูล
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    // ตรวจสอบสถานะการเชื่อมต่อ
                    if (conn.State != ConnectionState.Open) conn.Open();

                    string query = "SELECT user_id, username, role FROM users WHERE username = @user AND password = @hashed_pw";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@hashed_pw", hashedPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // *** จุดสำคัญ: บันทึกข้อมูลลง Session ***
                        UserSession.CurrentUserId = Convert.ToInt32(reader["user_id"]);
                        UserSession.Username = reader["username"].ToString();
                        string userRole = reader["role"].ToString();

                        MessageBox.Show($"เข้าสู่ระบบสำเร็จ! สวัสดีคุณ {UserSession.Username}", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        // นำทางตามสิทธิ์ (Admin หรือ Customer)
                        if (userRole.ToLower() == "admin")
                        {
                            AdminDashboard AdminDashboardForm = new AdminDashboard();
                            AdminDashboardForm.Show();
                        }
                        else
                        {
                            // คุณระบุว่าเป็นหน้า Shop หรือ Home ตามโครงสร้างโปรเจกต์คุณ
                            Shop shopForm = new Shop();
                            shopForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อ: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SignIn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
