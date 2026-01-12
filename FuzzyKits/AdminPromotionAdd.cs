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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace FuzzyKits
{
    public partial class AdminPromotionAdd : Form
    {
        private int? _editingPromoId = null;

        public AdminPromotionAdd()
        {
            InitializeComponent();
        }

        // Constructor ใหม่ (สำหรับแก้ไข - รับ ID เข้ามา)
        public AdminPromotionAdd(int promoId)
        {
            InitializeComponent();
            this._editingPromoId = promoId; // เก็บ ID ที่ส่งมาจากหน้าลิสต์ไว้
            this.HPromotionAdd.Text = "Edit Promotion"; // เปลี่ยนหัวข้อ
            LoadDataToEdit(promoId); // ดึงข้อมูลเดิมมาแปะในช่องกรอก
        }

        private void LoadDataToEdit(int id)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "SELECT * FROM promotions WHERE promotion_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodePromotion.Text = reader.GetString("code");
                    txtNamePromotion.Text = reader.GetString("name");
                    numDiscountValue.Value = reader.GetDecimal("discount_value");
                    numMinAmount.Value = reader.GetDecimal("min_amount");
                    StartDate.Value = reader.GetDateTime("start_date");
                    EndDate.Value = reader.GetDateTime("end_date");
                    chkIsActive.Checked = (reader.GetInt32("is_active") == 1);

                    string dbType = reader.GetString("discount_type");
                    cmbDiscountType.SelectedItem = (dbType == "amount") ? "จำนวนเต็ม" : "เปอร์เซ็นต์";
                }
            }
        }

        private void LoadPromoDataToEdit(int id)
        {
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "SELECT * FROM promotions WHERE promotion_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodePromotion.Text = reader.GetString("code");
                    txtNamePromotion.Text = reader.GetString("name");
                    numDiscountValue.Value = reader.GetDecimal("discount_value");
                    numMinAmount.Value = reader.GetDecimal("min_amount");
                    StartDate.Value = reader.GetDateTime("start_date");
                    EndDate.Value = reader.GetDateTime("end_date");
                    chkIsActive.Checked = (reader.GetInt32("is_active") == 1);

                    string dbType = reader.GetString("discount_type");
                    cmbDiscountType.SelectedItem = (dbType == "amount") ? "จำนวนเต็ม" : "เปอร์เซ็นต์";
                }
            }
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            // 1. ตรวจสอบว่ากรอกข้อมูลสำคัญครบถ้วนหรือไม่
            if (string.IsNullOrWhiteSpace(txtCodePromotion.Text) || string.IsNullOrWhiteSpace(txtNamePromotion.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสโปรโมชั่นและชื่อโปรโมชั่นให้ครบถ้วน", "แจ้งเตือน");
                return;
            }

            if (cmbDiscountType.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกประเภทส่วนลด", "แจ้งเตือน");
                return;
            }

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                if (conn == null) return;
                try
                {
                    string sql;
                    // 2. แยกคำสั่ง SQL ระหว่าง UPDATE (แก้ไข) และ INSERT (เพิ่มใหม่)
                    if (_editingPromoId.HasValue)
                    {
                        // โหมดแก้ไข: ต้องระบุ WHERE promotion_id = @id เพื่อให้ทับแถวเดิม
                        sql = @"UPDATE promotions SET 
                        code = @code, 
                        name = @name, 
                        discount_type = @type, 
                        discount_value = @val, 
                        min_amount = @min, 
                        start_date = @start, 
                        end_date = @end, 
                        is_active = @active 
                        WHERE promotion_id = @id";
                    }
                    else
                    {
                        // โหมดเพิ่มใหม่: สร้างแถวใหม่ในดาต้าเบส
                        sql = @"INSERT INTO promotions (code, name, discount_type, discount_value, min_amount, start_date, end_date, is_active) 
                        VALUES (@code, @name, @type, @val, @min, @start, @end, @active)";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // 3. ผูกค่าพารามิเตอร์ (Parameters) ให้ตรงกับชื่อใน SQL
                    cmd.Parameters.AddWithValue("@code", txtCodePromotion.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@name", txtNamePromotion.Text.Trim());

                    // แปลงค่าจาก ComboBox ภาษาไทยเป็นภาษาอังกฤษสำหรับ Database
                    string dbType = (cmbDiscountType.SelectedItem.ToString() == "จำนวนเต็ม") ? "amount" : "percent";
                    cmd.Parameters.AddWithValue("@type", dbType);

                    cmd.Parameters.AddWithValue("@val", numDiscountValue.Value);
                    cmd.Parameters.AddWithValue("@min", numMinAmount.Value);
                    cmd.Parameters.AddWithValue("@start", StartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@end", EndDate.Value.Date);
                    cmd.Parameters.AddWithValue("@active", chkIsActive.Checked ? 1 : 0);

                    // 4. สำคัญมาก: ถ้าเป็นโหมดแก้ไข ต้องส่ง ID ของโปรโมชั่นนั้นไปด้วย
                    if (_editingPromoId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@id", _editingPromoId.Value);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(_editingPromoId.HasValue ? "อัปเดตข้อมูลสำเร็จ!" : "บันทึกข้อมูลสำเร็จ!", "สำเร็จ");

                    this.DialogResult = DialogResult.OK; // ส่งสถานะกลับไปหน้าลิสต์เพื่อสั่งรีโหลดข้อมูล
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error");
                }
            }
        }
    }
}
