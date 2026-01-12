using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // เพิ่มสำหรับใช้ติดต่อฐานข้อมูล MySQL
using System.Security.Cryptography; // สำหรับ Hash รหัสผ่าน
using System.Text.RegularExpressions; // สำหรับตรวจสอบรหัสผ่าน

namespace FuzzyKits
{
    public partial class NewPassword : Form
    {
        private string userEmail;
        private string resetCode;

        // ฟังก์ชันสำหรับการ Hash รหัสผ่าน (คัดลอกมาจาก SignIn/Register)
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public NewPassword()
        {
            InitializeComponent();
        }

        public NewPassword(string email, string code)
        {
            InitializeComponent();
            this.userEmail = email;
            this.resetCode = code;
        }

        private void IconToggleNewPW_Click(object sender, EventArgs e)
        {
            if (txtNewPW.UseSystemPasswordChar == true)
            {
                txtNewPW.UseSystemPasswordChar = false;
                IconToggleNewPW.Image = Properties.Resources.Open;
            }
            else
            {
                txtNewPW.UseSystemPasswordChar = true;
                IconToggleNewPW.Image = Properties.Resources.Hide;
            }
        }

        private void IconToggleCnfNewPW_Click(object sender, EventArgs e)
        {
            if (txtCnfNewPW.UseSystemPasswordChar == true)
            {
                txtCnfNewPW.UseSystemPasswordChar = false;
                IconToggleCnfNewPW.Image = Properties.Resources.Open;
            }
            else
            {
                txtCnfNewPW.UseSystemPasswordChar = true;
                IconToggleCnfNewPW.Image = Properties.Resources.Hide;
            }
        }

        private void BtSetNewPW_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPW.Text;
            string confirmPassword = txtCnfNewPW.Text;

            // 1. ตรวจสอบข้อมูล
            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("กรุณากรอกรหัสผ่านใหม่ให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("รหัสผ่านใหม่ไม่ตรงกัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("รหัสผ่านต้องมีอย่างน้อย 8 ตัวอักษร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Regex.IsMatch(newPassword, @"[\u0E00-\u0E7F]"))
            {
                MessageBox.Show("รหัสผ่านต้องเป็นภาษาอังกฤษ ตัวเลข หรืออักขระพิเศษเท่านั้น (ห้ามใช้ภาษาไทย)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hash รหัสผ่านใหม่
            string hashedPassword = HashPassword(newPassword);

            // 3. UPDATE รหัสผ่านใน DB และลบ reset_token
            string query = "UPDATE users SET password = @hashed_pw, reset_token = NULL WHERE email = @email AND reset_token = @code";
            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hashed_pw", hashedPassword);
                    cmd.Parameters.AddWithValue("@email", this.userEmail);
                    cmd.Parameters.AddWithValue("@code", this.resetCode);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("เปลี่ยนรหัสผ่านสำเร็จแล้ว! กรุณาเข้าสู่ระบบด้วยรหัสผ่านใหม่", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. นำทางไปหน้า Sign In
                        SignIn SignInForm = new SignIn();
                        this.Hide();
                        SignInForm.Show();
                    }
                    else
                    {
                        // กรณีที่รหัส Code ถูกลบไปแล้ว หรือมีอะไรผิดพลาดระหว่างทาง
                        MessageBox.Show("เกิดข้อผิดพลาด: ไม่สามารถเปลี่ยนรหัสผ่านได้ อาจเป็นเพราะรหัส Code หมดอายุหรือไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการตั้งรหัสผ่านใหม่: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
