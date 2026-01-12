using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class UserAccount : Form
    {
        private string selectedImagePath = null;

        public UserAccount()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.UserAccount_Load);
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        // 1. ดึงข้อมูลผู้ใช้จาก DB มาแสดง
        private void LoadUserProfile()
        {
            int userId = UserSession.CurrentUserId;
            // เช็คว่า ID ถูกส่งมาจริงไหม
            if (userId <= 0)
            {
                MessageBox.Show("ไม่พบรหัสผู้ใช้ (ID = " + userId + ") กรุณาล็อกอินใหม่");
                return;
            }

            // Query นี้ถูกต้องตามโครงสร้างที่คุณให้มา (users JOIN user_addresses)
            string query = @"SELECT u.username, u.first_name, u.last_name, u.email, u.User_image, 
                            a.address_detail, a.sub_district, a.district, a.province, a.zip_code, a.phone_number 
                            FROM users u 
                            LEFT JOIN user_addresses a ON u.user_id = a.user_id 
                            WHERE u.user_id = @id";

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // แสดงข้อมูลในช่อง Textbox
                        txtUsername.Text = reader["username"].ToString();
                        txtFirstName.Text = reader["first_name"]?.ToString() ?? "";
                        txtLastName.Text = reader["last_name"]?.ToString() ?? "";
                        txtEmailAddress.Text = reader["email"]?.ToString() ?? "";

                        // ข้อมูลที่อยู่จาก user_addresses
                        txtAddress.Text = reader["address_detail"]?.ToString() ?? "";
                        txtSubDistrict.Text = reader["sub_district"]?.ToString() ?? "";
                        txtDistrict.Text = reader["district"]?.ToString() ?? "";
                        txtProvince.Text = reader["province"]?.ToString() ?? "";
                        txtZipCode.Text = reader["zip_code"]?.ToString() ?? "";
                        txtPhone.Text = reader["phone_number"]?.ToString() ?? "";

                        // แสดงรูปโปรไฟล์
                        DisplayProfileImage(reader["User_image"]?.ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("โหลดข้อมูลผิดพลาด: " + ex.Message); 
                }
            }
        }

        // 2. แสดงรูปภาพโปรไฟล์
        private void DisplayProfileImage(string imgUrl)
        {
            if (string.IsNullOrEmpty(imgUrl)) return;
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imgUrl);
                if (File.Exists(fullPath))
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        PicProfile.Image = Image.FromStream(fs);
                    }
                    PicProfile.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch 
            { 
                PicProfile.Image = null; 
            }
        }

        // 3. ปุ่มเปลี่ยนรูปโปรไฟล์
        private void BtChangePicProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFile.FileName;
                PicProfile.Image = new Bitmap(selectedImagePath);
                PicProfile.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // 4. ปุ่มแก้ไขข้อมูลโปรไฟล์
        private void BtEdit_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text.Trim();
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("รูปแบบอีเมลไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("กรุณากรอก Username", "แจ้งเตือน");
                return;
            }

            string userImageFileName = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    string extension = Path.GetExtension(selectedImagePath);
                    userImageFileName = "User_Images/user_" + UserSession.CurrentUserId + "_" + DateTime.Now.Ticks + extension;
                    File.Copy(selectedImagePath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, userImageFileName), true);
                }
                catch { /* ข้ามหากบันทึกรูปไม่ได้ */ }
            }

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    // 1. อัปเดตตาราง users
                    string sqlUser = "UPDATE users SET username=@un, first_name=@fname, last_name=@lname, email=@email " +
                                     (userImageFileName != null ? ", User_image=@img " : "") +
                                     "WHERE user_id=@id";

                    MySqlCommand cmdUser = new MySqlCommand(sqlUser, conn);
                    cmdUser.Parameters.AddWithValue("@un", txtUsername.Text.Trim());
                    cmdUser.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
                    cmdUser.Parameters.AddWithValue("@lname", txtLastName.Text.Trim());
                    cmdUser.Parameters.AddWithValue("@email", email);
                    cmdUser.Parameters.AddWithValue("@id", UserSession.CurrentUserId);
                    if (userImageFileName != null) cmdUser.Parameters.AddWithValue("@img", userImageFileName);
                    cmdUser.ExecuteNonQuery();

                    // 2. อัปเดตตาราง user_addresses
                    string sqlAddr = @"UPDATE user_addresses SET 
                                      address_detail=@addr, sub_district=@sub, district=@dist, 
                                      province=@prov, zip_code=@zip, phone_number=@phone 
                                      WHERE user_id=@id";

                    MySqlCommand cmdAddr = new MySqlCommand(sqlAddr, conn);
                    cmdAddr.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@sub", txtSubDistrict.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@dist", txtDistrict.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@prov", txtProvince.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@zip", txtZipCode.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@id", UserSession.CurrentUserId);
                    cmdAddr.ExecuteNonQuery();

                    MessageBox.Show("บันทึกการแก้ไขสำเร็จและอัปเดตฐานข้อมูลแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // โหลดข้อมูลใหม่เพื่อให้มั่นใจว่าดึงจาก DB ล่าสุดจริงๆ
                    LoadUserProfile();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) MessageBox.Show("Username หรือ Email นี้มีคนใช้แล้ว", "ข้อมูลซ้ำ");
                    else MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void IconOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory OrderHistoryForm = new OrderHistory();
            this.Hide();
            OrderHistoryForm.Show();
        }

        private void BtBackToShop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop();
            this.Hide();
            shopForm.Show();
        }

        private void IconShoppingCart_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCartForm = new ShoppingCart();
            this.Hide();
            shoppingCartForm.Show();
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }
    }
}
