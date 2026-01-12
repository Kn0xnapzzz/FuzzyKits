using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FuzzyKits
{
    // คลาส Static สำหรับจัดการการเชื่อมต่อฐานข้อมูล
    public static class DBConnector // เปลี่ยนเป็น static เพื่อให้เรียกใช้ได้ทันทีโดยไม่ต้องสร้าง Instance
    {
        // Connection String: ต้องตรงกับชื่อ DB และ XAMPP ของคุณ
        private static string connectionString = "server=localhost;port=3306;database=fuzzykits_db;uid=root;password=;";

        // เมธอดสำหรับรับการเชื่อมต่อที่เปิดอยู่
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open(); // พยายามเปิดการเชื่อมต่อ
                }
                return connection;
            }
            catch (MySqlException ex)
            {
                // ถ้าเชื่อมต่อไม่ได้ ให้แสดง Error และส่งค่า null กลับไป
                MessageBox.Show("Database connection error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}