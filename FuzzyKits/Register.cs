using MySql.Data.MySqlClient; // เพิ่มสำหรับใช้ติดต่อฐานข้อมูล MySQL
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; // เพิ่มสำหรับใช้ในการแปลง string เป็น byte
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FuzzyKits
{
    public partial class Register : Form
    {
        private string selectedImagePath = null; // เก็บ Path รูปที่เลือกจากเครื่อง

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

        public Register()
        {
            InitializeComponent();
        }

        private void BtBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedImagePath = openFile.FileName;
                    PicProfile.Image = new Bitmap(selectedImagePath);
                    PicProfile.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่สามารถโหลดรูปภาพได้: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void roundTextBox4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            this.Hide();
            HomeForm.Show();
        }

        private void BtSignIn_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void IconTogglePassword_Click(object sender, EventArgs e)
        {
            // ตรวจสอบสถานะปัจจุบัน: ถ้าซ่อนรหัสอยู่ (UseSystemPasswordChar เป็น True)
            if (txtPassword.UseSystemPasswordChar == true)
            {
                // 1. สลับไปเป็น 'แสดงรหัส'
                txtPassword.UseSystemPasswordChar = false;
                // 2. เปลี่ยนรูปไอคอนเป็น 'ตาเปิด'
                IconTogglePassword.Image = Properties.Resources.Open; // แทนที่ IconShow ด้วยชื่อ Resource จริง
            }
            else
            {
                // 1. สลับไปเป็น 'ซ่อนรหัส'
                txtPassword.UseSystemPasswordChar = true;
                // 2. เปลี่ยนรูปไอคอนเป็น 'ตาปิด'
                IconTogglePassword.Image = Properties.Resources.Hide; // แทนที่ IconHide ด้วยชื่อ Resource จริง
            }
        }

        private void IconToggleConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == true)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                IconToggleConfirm.Image = Properties.Resources.Open; 
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                IconToggleConfirm.Image = Properties.Resources.Hide; 
            }
        }

        private void BtAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs AboutUsForm = new AboutUs();
            this.Hide();
            AboutUsForm.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            // 1. รับค่า
            string username = txtUsername.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // 2. ตรวจสอบข้อมูลเบื้องต้น (โค้ดเดิม)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // A. ตรวจสอบ Username: (รหัสเดิม)
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9\u0E00-\u0E7F_-]+$"))
            {
                MessageBox.Show("ชื่อผู้ใช้ต้องไม่มีอักขระพิเศษ (เช่น !@#$%)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B1. ตรวจสอบ FirstName: อนุญาตเฉพาะภาษาไทย/อังกฤษ/วรรคเท่านั้น
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z\u0E00-\u0E7F ]+$"))
            {
                MessageBox.Show("ชื่อจริงต้องประกอบด้วยตัวอักษร (ไทย/อังกฤษ) หรือวรรคเท่านั้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B2. ตรวจสอบ LastName: อนุญาตเฉพาะภาษาไทย/อังกฤษ/วรรคเท่านั้น
            if (!Regex.IsMatch(lastName, @"^[a-zA-Z\u0E00-\u0E7F ]+$"))
            {
                MessageBox.Show("นามสกุลต้องประกอบด้วยตัวอักษร (ไทย/อังกฤษ) หรือวรรคเท่านั้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // C. ตรวจสอบ Email: ห้ามใช้ภาษาไทย AND ต้องเป็นรูปแบบที่ถูกต้อง (รหัสเดิม)
            if (Regex.IsMatch(email, @"[\u0E00-\u0E7F]") || !Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("รูปแบบอีเมลไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // D1. ตรวจสอบรหัสผ่าน: ความยาวขั้นต่ำ 8 ตัวอักษร (รหัสเดิม)
            if (password.Length < 8)
            {
                MessageBox.Show("รหัสผ่านต้องมีอย่างน้อย 8 ตัวอักษร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // D2. ตรวจสอบรหัสผ่าน: ห้ามใช้ภาษาไทย (รหัสเดิม)
            if (Regex.IsMatch(password, @"[\u0E00-\u0E7F]"))
            {
                MessageBox.Show("รหัสผ่านต้องเป็นภาษาอังกฤษ ตัวเลข หรืออักขระพิเศษเท่านั้น (ห้ามใช้ภาษาไทย)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // D3. รหัสผ่านและยืนยันรหัสต้องตรงกัน (รหัสเดิม)
            if (password != confirmPassword)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. เตรียมข้อมูลและ Hash
            string hashedPassword = HashPassword(password);
            string role = "customer";

            // จัดการเรื่องรูปภาพ
            string userImageFileName = "default_user.png"; // ค่าเริ่มต้นถ้าไม่เลือกรูป
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    // สร้างโฟลเดอร์ User_Images ถ้ายังไม่มี
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User_Images");
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                    // ตั้งชื่อไฟล์ใหม่โดยใช้ Username เพื่อไม่ให้ซ้ำ
                    string extension = Path.GetExtension(selectedImagePath);
                    userImageFileName = $"user_{username}{extension}";
                    string destinationPath = Path.Combine(folderPath, userImageFileName);

                    // คัดลอกไฟล์ไปยังโฟลเดอร์โปรเจค (ทับไฟล์เดิมถ้าชื่อซ้ำ)
                    File.Copy(selectedImagePath, destinationPath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกรูปภาพ: " + ex.Message);
                    return;
                }
            }

            // 4. บันทึกข้อมูลลง DB และดึง User ID ที่ถูกสร้างขึ้น
            string query = @"INSERT INTO users (username, first_name, last_name, email, password, role, User_image) 
                            VALUES (@user, @fname, @lname, @email, @hashed_pw, @role, @img); 
                            SELECT LAST_INSERT_ID();"; 
            MySqlConnection conn = DBConnector.GetConnection();
            int newUserId = -1; // ตัวแปรสำหรับเก็บ user_id

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@hashed_pw", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", "customer"); // กำหนดเป็นลูกค้า
                    cmd.Parameters.AddWithValue("@img", "User_Images/" + userImageFileName);

                    // ใช้ ExecuteScalar() เพราะเราต้องการค่าเดียว (LAST_INSERT_ID)
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        newUserId = Convert.ToInt32(result); // ได้ user_id ใหม่มาแล้ว
                    }

                    if (newUserId > 0)
                    {
                        MessageBox.Show("บันทึกข้อมูลส่วนตัวสำเร็จ! กรุณากรอกข้อมูลที่อยู่ต่อ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // ส่ง User ID 
                        EditProfile EditProfileForm = new EditProfile(newUserId);
                        this.Hide();
                        EditProfileForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("ลงทะเบียนสำเร็จ แต่ไม่สามารถดึง User ID ได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Error code: Duplicate entry (ชื่อซ้ำ)
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรืออีเมลนี้ถูกใช้ไปแล้ว", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการลงทะเบียน: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
