using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuzzyKits
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            // ตั้งค่าเริ่มต้นให้เรียกข้อมูลทันทีที่เปิดหน้า
            this.Load += (s, e) => LoadDashboardData();
            // เมื่อเปลี่ยนเดือนในตัวเลือก ให้โหลดข้อมูลใหม่
            dtpDashboard.ValueChanged += (s, e) => LoadDashboardData();
        }

        private System.Drawing.Printing.PrintDocument reportDocument = new System.Drawing.Printing.PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();

        private void LoadDashboardData()
        {
            DateTime selectedDate = dtpDashboard.Value;

            // DBConnector.GetConnection() มักจะเปิด Connection มาให้แล้ว
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    // 1. ดึงยอดรวม 4 กล่องบน (ใช้ IFNULL เพื่อกันค่าว่าง)
                    string sqlSummary = @"
                SELECT 
                    (SELECT IFNULL(SUM(total_amount), 0) FROM orders WHERE DATE(order_date) = CURDATE() AND status != 'Cancelled') as TodaySales,
                    (SELECT IFNULL(SUM(total_amount), 0) FROM orders WHERE MONTH(order_date) = @month AND YEAR(order_date) = @year AND status != 'Cancelled') as MonthSales,
                    (SELECT COUNT(*) FROM orders WHERE status IN ('Pending', 'Paid')) as NewOrders,
                    (SELECT COUNT(*) FROM orders WHERE status = 'Completed' AND MONTH(order_date) = @month AND YEAR(order_date) = @year) as CompletedOrders";

                    MySqlCommand cmdSum = new MySqlCommand(sqlSummary, conn);
                    cmdSum.Parameters.AddWithValue("@month", selectedDate.Month);
                    cmdSum.Parameters.AddWithValue("@year", selectedDate.Year);

                    // ใช้ ExecuteReader เพื่อดึงข้อมูลสรุป
                    using (MySqlDataReader reader = cmdSum.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // บรรทัดเหล่านี้จะทำให้ตัวเลขไปโชว์ในกรอบสีหน้า Dashboard
                            lblTodaySales.Text = string.Format("{0:N2} ฿", reader["TodaySales"]);
                            lblMonthSales.Text = string.Format("{0:N2} ฿", reader["MonthSales"]);
                            lblNewOrders.Text = reader["NewOrders"].ToString();
                            lblCompletedOrders.Text = reader["CompletedOrders"].ToString();
                        }
                    } // ปิด reader อัตโนมัติเมื่อพ้นบล็อกนี้

                    // 2. ดึงข้อมูลกราฟยอดขาย
                    string sqlChart = @"SELECT DATE(order_date) as Day, SUM(total_amount) as DailySales 
                                FROM orders 
                                WHERE MONTH(order_date) = @month AND YEAR(order_date) = @year AND status != 'Cancelled'
                                GROUP BY DATE(order_date) ORDER BY Day";

                    MySqlDataAdapter daChart = new MySqlDataAdapter(sqlChart, conn);
                    daChart.SelectCommand.Parameters.AddWithValue("@month", selectedDate.Month);
                    daChart.SelectCommand.Parameters.AddWithValue("@year", selectedDate.Year);

                    DataTable dtChart = new DataTable();
                    daChart.Fill(dtChart);

                    chartSalesTrend.Series["Sales"].Points.Clear();

                    // พื้นหลังสีขาว และเส้นตารางสีเทาอ่อน
                    chartSalesTrend.ChartAreas[0].BackColor = Color.White;
                    chartSalesTrend.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                    chartSalesTrend.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

                    // ปรับขนาดฟอนต์ของตัวเลขขอบข้าง (แกน X และ Y) ให้เล็กลง (สมมติจาก 16 เหลือ 14)
                    chartSalesTrend.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Leelawadee UI", 8f);
                    chartSalesTrend.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Leelawadee UI", 8f);

                    // ปรับแต่งตัวเลขบนแท่งกราฟ (Labels) ให้เป็นตัวหนาสีดำ ขนาด 16
                    chartSalesTrend.Series["Sales"].IsValueShownAsLabel = true;
                    chartSalesTrend.Series["Sales"].LabelForeColor = Color.Black;
                    chartSalesTrend.Series["Sales"].Font = new Font("Leelawadee UI", 10f, FontStyle.Bold);
                    chartSalesTrend.Series["Sales"].LabelFormat = "#,##0";

                    foreach (DataRow row in dtChart.Rows)
                    {
                        chartSalesTrend.Series["Sales"].Points.AddXY(((DateTime)row["Day"]).Day, row["DailySales"]);
                    }

                    // 3. ดึงสินค้าขายดี 10 อันดับ
                    string sqlTop = @"SELECT p.name as 'ชื่อสินค้า', SUM(oi.quantity) as 'จำนวน', SUM(oi.quantity * oi.price_per_unit) as 'ยอดรวม'
                                FROM order_items oi
                                JOIN products p ON oi.product_id = p.product_id
                                JOIN orders o ON oi.order_id = o.order_id
                                WHERE MONTH(o.order_date) = @month 
                                AND YEAR(o.order_date) = @year 
                                AND o.status != 'Cancelled'
                                GROUP BY p.product_id
                                ORDER BY SUM(oi.quantity) DESC LIMIT 10";

                    MySqlDataAdapter daTop = new MySqlDataAdapter(sqlTop, conn);
                    daTop.SelectCommand.Parameters.AddWithValue("@month", selectedDate.Month);
                    daTop.SelectCommand.Parameters.AddWithValue("@year", selectedDate.Year);

                    DataTable dtTop = new DataTable();
                    daTop.Fill(dtTop);
                    dgvTopSelling.DataSource = dtTop;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message, "Error");
                }
                // ไม่ต้องสั่ง conn.Close() เพราะ 'using' จะจัดการให้เองเมื่อจบการทำงานครับ
            }
        }

        private void BtExportPDF_Click(object sender, EventArgs e)
        {
            // ผูก Event การวาดหน้ากระดาษ
            reportDocument.PrintPage -= DrawReportPage; // ลบของเก่ากันซ้อน
            reportDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(DrawReportPage);

            // ตั้งค่าหน้ากระดาษ A4
            reportDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            // ตั้งค่าหน้าต่าง Preview
            previewDialog.Document = reportDocument;
            previewDialog.WindowState = FormWindowState.Maximized;
            previewDialog.ShowDialog();
        }

        private void DrawReportPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            // ปรับขนาดฟอนต์ให้ใหญ่ขึ้นเพื่อให้อ่านง่ายขึ้น
            Font fontTitle = new Font("TH Sarabun New", 32, FontStyle.Bold);
            Font fontHeader = new Font("TH Sarabun New", 22, FontStyle.Bold);
            Font fontBody = new Font("TH Sarabun New", 18, FontStyle.Regular);
            Font fontFooter = new Font("TH Sarabun New", 14, FontStyle.Italic);

            int y = 70; // เพิ่มระยะขอบบน
            int x = 60; // เพิ่มระยะขอบซ้าย
            int pageWidth = e.PageBounds.Width - 120; // คำนวณความกว้างพื้นที่ใช้งาน

            // 1. ส่วนหัวรายงาน
            g.DrawString("รายงานสรุปยอดขาย (Fuzzy Kits)", fontTitle, Brushes.Black, x, y);
            y += 50;
            g.DrawString($"ประจำเดือน : {dtpDashboard.Value.ToString("MMMM yyyy")}", fontHeader, Brushes.Gray, x, y);
            y += 70;

            // 2. กล่องสรุปภาพรวม (เพิ่มความสูงกล่องและระยะห่างข้อความ)
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), x, y, pageWidth, 120);
            g.DrawRectangle(new Pen(Color.Black, 2), x, y, pageWidth, 120);

            g.DrawString($"ยอดขายรวมเดือนนี้ : {lblMonthSales.Text}", fontHeader, Brushes.DarkGreen, x + 30, y + 20);
            g.DrawString($"ออเดอร์ที่สำเร็จ : {lblCompletedOrders.Text} รายการ", fontBody, Brushes.Black, x + 30, y + 65);
            g.DrawString($"ออเดอร์ใหม่ : {lblNewOrders.Text} รายการ", fontBody, Brushes.Black, x + 400, y + 65);
            y += 120;

            // 3. เพิ่มการวาดกราฟลงในเอกสาร
            g.DrawString("กราฟแสดงแนวโน้มยอดขายรายวัน", fontHeader, Brushes.Black, x, y);
            y += 40;

            // สร้างภาพจากตัว Chart Control
            using (MemoryStream ms = new MemoryStream())
            {
                chartSalesTrend.SaveImage(ms, ChartImageFormat.Png);
                Image chartImage = Image.FromStream(ms);
                // วาดกราฟลงในกระดาษ (ปรับขนาดให้พอดี)
                g.DrawImage(chartImage, x, y, pageWidth, 250);
            }
            y += 280;

            // 4. ตารางสินค้าขายดี
            g.DrawString("อันดับสินค้าขายดี 10 อันดับ", fontHeader, Brushes.Black, x, y);
            y += 40;

            // หัวตาราง (ปรับตำแหน่งและสีพื้นหลัง)
            g.FillRectangle(Brushes.LightSlateGray, x, y, pageWidth, 40);
            g.DrawRectangle(Pens.Black, x, y, pageWidth, 40);

            g.DrawString("ชื่อสินค้า", fontHeader, Brushes.White, x + 15, y + 5);
            g.DrawString("จำนวน", fontHeader, Brushes.White, x + 380, y + 5);
            g.DrawString("ยอดรวม (บาท)", fontHeader, Brushes.White, x + 530, y + 5);
            y += 40;

            // ข้อมูลสินค้าจาก dgvTopSelling
            foreach (DataGridViewRow row in dgvTopSelling.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    // ตรวจสอบพื้นที่กระดาษก่อนวาดบรรทัดใหม่
                    if (y > e.PageBounds.Height - 100) break;

                    g.DrawString(row.Cells[0].Value.ToString(), fontBody, Brushes.Black, x + 15, y + 5);
                    g.DrawString(row.Cells[1].Value.ToString(), fontBody, Brushes.Black, x + 400, y + 5);
                    g.DrawString(row.Cells[2].Value.ToString(), fontBody, Brushes.Black, x + 540, y + 5);

                    y += 35; // เพิ่มระยะห่างระหว่างบรรทัด
                    g.DrawLine(new Pen(Color.LightGray, 1), x, y, x + pageWidth, y);
                }
            }

            // 5. ส่วนท้ายรายงาน
            y += 40;
            g.DrawString($"เอกสารนี้ถูกจัดทำขึ้นเมื่อ : {DateTime.Now:dd/MM/yyyy HH:mm}", fontFooter, Brushes.DimGray, x, y);
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void BtProducts_Click(object sender, EventArgs e)
        {
            AdminProductsAll AdminProductsAllForm = new AdminProductsAll();
            this.Hide();
            AdminProductsAllForm.Show();
        }

        private void BtPromotion_Click(object sender, EventArgs e)
        {
            AdminPromotionAll AdminPromotionAllForm = new AdminPromotionAll();
            this.Hide();
            AdminPromotionAllForm.Show();
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
            AdminOrder AdminOrderForm = new AdminOrder();
            this.Hide();
            AdminOrderForm.Show();
        }

        private void BtDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}