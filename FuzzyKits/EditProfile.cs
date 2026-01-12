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
    public partial class EditProfile : Form
    {
        private int currentUserId; // ตัวแปรเก็บ User ID ของผู้ใช้ปัจจุบัน

        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
        public EditProfile(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId; // เก็บ User ID ไว้ใช้งาน
        }

        private void BtCreateAccount_Click(object sender, EventArgs e)
        {
            // 1. ตรวจสอบว่ามี User ID หรือไม่ (เพื่อป้องกันการเรียกใช้โดยไม่มีข้อมูล)
            if (currentUserId <= 0)
            {
                MessageBox.Show("ข้อผิดพลาด: ไม่พบ User ID ที่ถูกต้องสำหรับการบันทึกข้อมูล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // อาจจะนำกลับไปหน้า Sign In
                SignIn SignInForm = new SignIn();
                this.Hide();
                SignInForm.Show();
                return;
            }

            // 2. รับค่าจาก RoundTextBox
            string addressDetail = txtAddress.Text.Trim();
            string subDistrict = txtSubDistrict.Text.Trim();
            string district = txtDistrict.Text.Trim();
            string province = txtProvince.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // 3. ตรวจสอบข้อมูล

            // A. ตรวจสอบว่ากรอกข้อมูลครบถ้วนหรือไม่ (เหมือนเดิม)
            if (string.IsNullOrWhiteSpace(addressDetail) || string.IsNullOrWhiteSpace(subDistrict) ||
                string.IsNullOrWhiteSpace(district) || string.IsNullOrWhiteSpace(province) ||
                string.IsNullOrWhiteSpace(zipCode) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่อยู่และเบอร์โทรศัพท์ให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. ตรวจสอบ ตำบล, อำเภอ, จังหวัด: อนุญาตเฉพาะภาษาไทย/อังกฤษ/วรรค
            // ใช้รูปแบบเดียวกับการตรวจสอบชื่อใน Register.cs: ^[a-zA-Z\u0E00-\u0E7F ]+$
            string namePattern = @"^[a-zA-Z\u0E00-\u0E7F ]+$";

            if (!Regex.IsMatch(subDistrict, namePattern))
            {
                MessageBox.Show("ชื่อตำบลไม่ถูกต้อง ต้องประกอบด้วยตัวอักษร (ไทย/อังกฤษ) หรือวรรคเท่านั้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(district, namePattern))
            {
                MessageBox.Show("ชื่ออำเภอไม่ถูกต้อง ต้องประกอบด้วยตัวอักษร (ไทย/อังกฤษ) หรือวรรคเท่านั้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(province, namePattern))
            {
                MessageBox.Show("ชื่อจังหวัดไม่ถูกต้อง ต้องประกอบด้วยตัวอักษร (ไทย/อังกฤษ) หรือวรรคเท่านั้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // C. ตรวจสอบรหัสไปรษณีย์: ตัวเลข 5 หลักเท่านั้น
            if (!Regex.IsMatch(zipCode, @"^\d{5}$"))
            {
                MessageBox.Show("รูปแบบรหัสไปรษณีย์ไม่ถูกต้อง (ต้องเป็นตัวเลข 5 หลักเท่านั้น)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // D. ตรวจสอบเบอร์โทรศัพท์: ตัวเลข 9 หรือ 10 หลักเท่านั้น
            if (!Regex.IsMatch(phone, @"^\d{9,10}$"))
            {
                MessageBox.Show("รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง (ต้องเป็นตัวเลข 9 หรือ 10 หลักเท่านั้น)", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. INSERT ข้อมูลลงในตาราง user_addresses
            // ตาราง user_addresses: user_id, address_detail, sub_district, district, province, zip_code, phone_number, is_default
            string query = @"INSERT INTO user_addresses (user_id, address_detail, sub_district, district, province, zip_code, phone_number, is_default) 
                             VALUES (@userId, @addrDetail, @subDist, @dist, @prov, @zipCode, @phoneNum, 1)";

            MySqlConnection conn = DBConnector.GetConnection();

            if (conn != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", this.currentUserId);
                    cmd.Parameters.AddWithValue("@addrDetail", addressDetail);
                    cmd.Parameters.AddWithValue("@subDist", subDistrict);
                    cmd.Parameters.AddWithValue("@dist", district);
                    cmd.Parameters.AddWithValue("@prov", province);
                    cmd.Parameters.AddWithValue("@zipCode", zipCode);
                    cmd.Parameters.AddWithValue("@phoneNum", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลที่อยู่สำเร็จ! การลงทะเบียนเสร็จสมบูรณ์", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. นำทางไปหน้า Sign In ตามที่กำหนด
                    SignIn SignInForm = new SignIn();
                    this.Hide();
                    SignInForm.Show();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกที่อยู่: " + ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
