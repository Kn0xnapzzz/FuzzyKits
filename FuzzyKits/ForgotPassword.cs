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
using System.Text.RegularExpressions;

namespace FuzzyKits
{
    public partial class ForgotPassword : Form
    {
        // ตัวแปรสำหรับเก็บรหัส Code ที่ถูกสร้างขึ้น (เพื่อใช้เปรียบเทียบ)
        private string generatedResetCode = null;
        private string currentEmail = null; // เก็บ Email ที่ส่ง Code ไป

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BtBacktoSignIn_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void BtContinue_Click(object sender, EventArgs e)
        {
            string inputCode = txtPWResetCode.Text.Trim();

            // 1. ตรวจสอบว่า Code ถูกสร้างแล้วหรือยัง
            if (string.IsNullOrWhiteSpace(currentEmail) || generatedResetCode == null)
            {
                MessageBox.Show("กรุณากด 'Send Code' ก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ตรวจสอบว่ากรอก Code หรือยัง
            if (string.IsNullOrWhiteSpace(inputCode))
            {
                MessageBox.Show("กรุณากรอกรหัส Code ที่ได้รับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. ตรวจสอบ Code กับ DB โดยใช้ Email
            string checkCodeQuery = "SELECT COUNT(*) FROM users WHERE email = @email AND reset_token = @code";
            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(checkCodeQuery, conn);
                    cmd.Parameters.AddWithValue("@email", currentEmail);
                    cmd.Parameters.AddWithValue("@code", inputCode);

                    int codeMatchCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (codeMatchCount > 0)
                    {
                        MessageBox.Show("รหัส Code ถูกต้อง! โปรดตั้งรหัสผ่านใหม่", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. นำทางไปหน้า NewPassword พร้อมส่ง Email/Code ที่ถูกต้องไป
                        NewPassword NewPasswordForm = new NewPassword(currentEmail, inputCode);
                        this.Hide();
                        NewPasswordForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("รหัส Code ไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการตรวจสอบรหัส: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void BtSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text.Trim();

            // A. ตรวจสอบ Email Format
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("กรุณากรอกรูปแบบอีเมลให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. ตรวจสอบว่า Email นี้มีอยู่ในฐานข้อมูลหรือไม่
            string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(checkQuery, conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("ไม่พบอีเมลนี้ในระบบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // C. สร้าง Code สุ่ม (6 ตัวอักษร)
                    Random random = new Random();
                    // สร้างรหัส 6 หลัก (ตัวเลข)
                    generatedResetCode = random.Next(100000, 999999).ToString();
                    currentEmail = email;

                    // D. บันทึก Code ลงใน DB (ใช้ UPDATE)
                    string updateQuery = "UPDATE users SET reset_token = @code WHERE email = @email";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@code", generatedResetCode);
                    updateCmd.Parameters.AddWithValue("@email", email);
                    updateCmd.ExecuteNonQuery();

                    // E. แจ้งเตือน Code ให้ผู้ใช้ทราบ (จำลองการส่ง Email)
                    MessageBox.Show($"เราได้สร้างโค้ดสำหรับรีเซ็ตรหัสผ่านแล้ว\n\n[ รหัสของคุณคือ: {generatedResetCode} ]\n\nโปรดนำรหัสนี้ไปกรอกในช่อง 'Password reset code'", "Code ถูกส่งแล้ว", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // เปิดให้กรอกรหัสได้
                    txtPWResetCode.Enabled = true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการส่งรหัส: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
