using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class OrderHistory : Form
    {
        Font mainFont = new Font("Berlin Sans FB Demi", 16.2f, FontStyle.Bold);
        Font dataFont = new Font("Leelawadee UI", 11f, FontStyle.Regular);

        // ตัวแปรสำหรับเก็บข้อมูลที่จะพิมพ์
        private PrintDocument receiptDocument = new PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        private List<dynamic> _itemsToPrint = new List<dynamic>();
        private dynamic _orderSummaryToPrint;

        public OrderHistory()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadOrderHistory();
            dtpMonthFilter.ValueChanged += (s, e) => LoadOrderHistory();
            receiptDocument.PrintPage += new PrintPageEventHandler(DrawReceiptFromHistory);
        }

        private string FormatAddressSafe(string rawAddress)
        {
            if (string.IsNullOrEmpty(rawAddress)) return "ไม่มีข้อมูลที่อยู่";
            return rawAddress.Replace("|", "\r\n").Trim();
        }

        private void LoadOrderHistory()
        {
            if (flowOrderHistory == null) return;
            flowOrderHistory.Controls.Clear();
            AddHeaderRow();

            DateTime selectedDate = dtpMonthFilter.Value;

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();

                    // ดึงข้อมูลพื้นฐานจาก orders และชื่อสินค้ามารวมกัน
                    string sql = @"SELECT o.order_id, o.order_date, o.total_amount, o.status, o.shipping_address,
                                   GROUP_CONCAT(p.name SEPARATOR ', ') as product_names
                                   FROM orders o
                                   LEFT JOIN order_items oi ON o.order_id = oi.order_id
                                   LEFT JOIN products p ON oi.product_id = p.product_id
                                   WHERE o.user_id = @uid 
                                   AND MONTH(o.order_date) = @month 
                                   AND YEAR(o.order_date) = @year
                                   GROUP BY o.order_id
                                   ORDER BY o.order_date DESC";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", UserSession.CurrentUserId);
                    cmd.Parameters.AddWithValue("@month", selectedDate.Month);
                    cmd.Parameters.AddWithValue("@year", selectedDate.Year);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false;

                    while (reader.Read())
                    {
                        hasData = true;
                        Panel row = CreateOrderRow(
                            reader["order_id"].ToString(),
                            Convert.ToDateTime(reader["order_date"]).ToString("dd/MM/yyyy HH:mm"),
                            reader["product_names"].ToString(),
                            Convert.ToDecimal(reader["total_amount"]),
                            reader["status"].ToString(),
                            reader["shipping_address"].ToString()
                        );
                        flowOrderHistory.Controls.Add(row);
                    }

                    if (!hasData) ShowMessageOnFlow("--- ไม่พบประวัติการสั่งซื้อในเดือนนี้ ---");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void AddHeaderRow()
        {
            Panel header = new Panel { Size = new Size(1150, 50), BackColor = Color.LightGray, Margin = new Padding(0, 0, 0, 10) };

            // หัวข้อตามคอลัมน์ (ตัดลำดับออก)
            header.Controls.Add(new Label { Text = "วัน/เดือน/ปี", Location = new Point(20, 10), Width = 150, Font = mainFont });
            header.Controls.Add(new Label { Text = "รายการสินค้า", Location = new Point(200, 10), Width = 250, Font = mainFont });
            header.Controls.Add(new Label { Text = "ที่อยู่จัดส่ง", Location = new Point(500, 10), Width = 200, Font = mainFont });
            header.Controls.Add(new Label { Text = "สถานะ", Location = new Point(750, 10), Width = 150, Font = mainFont });
            header.Controls.Add(new Label { Text = "ราคารวมสุทธิ", Location = new Point(920, 10), Width = 150, Font = mainFont });

            flowOrderHistory.Controls.Add(header);
        }

        private Panel CreateOrderRow(string orderId, string date, string products, decimal total, string status, string address)
        {
            Panel p = new Panel { Size = new Size(1150, 110), BackColor = Color.White, Margin = new Padding(0, 5, 0, 5), BorderStyle = BorderStyle.FixedSingle };

            // แสดงที่อยู่โดยใช้ Format เดียวกับที่บันทึกมา เพื่อให้ข้อมูลไม่หาย
            Label lblAddr = new Label
            {
                Text = FormatAddressSafe(address),
                Location = new Point(500, 10),
                Size = new Size(230, 90),
                Font = new Font("Leelawadee UI", 9)
            };

            // แปลงสถานะเป็นไทย
            string statusTH = status == "Pending" ? "รอตรวจสอบ" : status == "Paid" ? "ชำระเงินแล้ว" :
                              status == "Shipping" ? "กำลังจัดส่ง" : status == "Completed" ? "สำเร็จ" : "ยกเลิก";

            p.Controls.Add(new Label { Text = date, Location = new Point(20, 40), Width = 150, Font = dataFont });
            p.Controls.Add(new Label { Text = products, Location = new Point(200, 20), Size = new Size(280, 70), Font = dataFont, ForeColor = Color.DimGray });
            p.Controls.Add(lblAddr);

            Label lblStat = new Label { Text = statusTH, Location = new Point(750, 40), Width = 150, Font = new Font("Leelawadee UI", 11, FontStyle.Bold) };
            lblStat.ForeColor = status == "Completed" ? Color.Green : (status == "Cancelled" ? Color.Crimson : Color.DarkOrange);
            p.Controls.Add(lblStat);

            p.Controls.Add(new Label { Text = $"฿{total:N2}", Location = new Point(900, 40), Width = 120, Font = new Font("Arial", 12, FontStyle.Bold), ForeColor = Color.Crimson, TextAlign = ContentAlignment.MiddleRight });

            Button btnDetail = new Button
            {
                Text = "รายละเอียด",
                Location = new Point(1030, 35),
                Size = new Size(100, 40),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Leelawadee UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnDetail.Click += (s, e) => {
                PrepareReceiptData(orderId);
                int totalHeight = 650 + (_itemsToPrint.Count * 30);
                receiptDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 350, totalHeight);
                previewDialog.Document = receiptDocument;
                previewDialog.WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            };
            p.Controls.Add(btnDetail);

            return p;
        }

        private void ShowMessageOnFlow(string msg)
        {
            Label lbl = new Label { Text = msg, Size = new Size(1100, 100), TextAlign = ContentAlignment.MiddleCenter, Font = dataFont };
            flowOrderHistory.Controls.Add(lbl);
        }

        // ฟังก์ชันดึงข้อมูลจาก Database เพื่อเตรียมพิมพ์
        private void PrepareReceiptData(string orderId)
        {
            _itemsToPrint.Clear();
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();

                    // 1. ดึงสรุปยอดออเดอร์
                    string sqlOrder = "SELECT * FROM orders WHERE order_id = @oid";
                    MySqlCommand cmdOrder = new MySqlCommand(sqlOrder, conn);
                    cmdOrder.Parameters.AddWithValue("@oid", orderId);
                    using (MySqlDataReader dr = cmdOrder.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            _orderSummaryToPrint = new
                            {
                                OrderId = dr["order_id"].ToString(),
                                Date = Convert.ToDateTime(dr["order_date"]),
                                Address = dr["shipping_address"].ToString(), // ที่อยู่มัดรวมจาก DB
                                Total = Convert.ToDecimal(dr["total_amount"]), // ยอดสุทธิ
                                Discount = Convert.ToDecimal(dr["discount_amount"]) // ส่วนลด
                            };
                        }
                    }

                    // 2. ดึงรายการสินค้ารายชิ้น
                    string sqlItems = @"SELECT p.name, oi.quantity, oi.price_per_unit 
                                       FROM order_items oi 
                                       JOIN products p ON oi.product_id = p.product_id 
                                       WHERE oi.order_id = @oid";
                    MySqlCommand cmdItems = new MySqlCommand(sqlItems, conn);
                    cmdItems.Parameters.AddWithValue("@oid", orderId);
                    using (MySqlDataReader dr = cmdItems.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _itemsToPrint.Add(new
                            {
                                Name = dr.GetString("name"),
                                Qty = dr.GetInt32("quantity"),
                                Price = dr.GetDecimal("price_per_unit")
                            });
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("โหลดข้อมูลใบเสร็จผิดพลาด: " + ex.Message); }
            }
        }

        // ฟังก์ชันวาดใบเสร็จ (ดัดแปลงจาก DrawReceipt ใน Checkout.cs ให้เข้ากับประวัติสั่งซื้อ)
        private void DrawReceiptFromHistory(object sender, PrintPageEventArgs e)
        {
            if (_orderSummaryToPrint == null) return;

            Graphics g = e.Graphics;
            Font fontTitle = new Font("Berlin Sans FB Demi", 18, FontStyle.Bold);
            Font fontHeader = new Font("Leelawadee UI", 10, FontStyle.Bold);
            Font fontBody = new Font("Leelawadee UI", 9, FontStyle.Regular);
            int y = 40, centerX = 175;
            StringFormat formatCenter = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat formatRight = new StringFormat { Alignment = StringAlignment.Far };

            // ส่วนหัว
            g.DrawString("FuzzyKits Shop", fontTitle, Brushes.Black, centerX, y, formatCenter);
            y += 50;
            g.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", fontHeader, Brushes.Black, centerX, y, formatCenter);
            y += 30;
            g.DrawString($"ออเดอร์: #{_orderSummaryToPrint.OrderId} | เวลา: {_orderSummaryToPrint.Date:dd-MM-yyyy HH:mm}", fontBody, Brushes.Black, centerX, y, formatCenter);
            y += 35;
            g.DrawLine(Pens.Black, 20, y, 330, y);
            y += 20;

            // ที่อยู่ (ดึงตรงจาก DB ไม่ตัดคำ)
            g.DrawString("ข้อมูลการจัดส่ง :", fontHeader, Brushes.Black, 20, y);
            y += 25;
            g.DrawString(FormatAddressSafe(_orderSummaryToPrint.Address), fontBody, Brushes.Black, new RectangleF(20, y, 310, 100));
            y += 105;
            g.DrawLine(Pens.Black, 20, y, 330, y);
            y += 20;

            // รายการสินค้า
            g.DrawString("รายการ", fontHeader, Brushes.Black, 20, y);
            g.DrawString("จำนวน", fontHeader, Brushes.Black, 200, y);
            g.DrawString("รวม", fontHeader, Brushes.Black, 330, y, formatRight);
            y += 30;

            foreach (var item in _itemsToPrint)
            {
                g.DrawString(item.Name, fontBody, Brushes.Black, 20, y);
                g.DrawString($"x{item.Qty}", fontBody, Brushes.Black, 210, y);
                g.DrawString($"{(item.Price * item.Qty):N2}", fontBody, Brushes.Black, 330, y, formatRight);
                y += 25;
            }
            y += 15;
            g.DrawLine(Pens.Black, 20, y, 330, y);
            y += 20;

            // ยอดเงิน (ดึง Total และ Discount จาก DB แล้วคำนวณ VAT ย้อนกลับให้ตรงหน้า Admin)
            decimal grandTotal = _orderSummaryToPrint.Total;
            decimal discount = _orderSummaryToPrint.Discount;
            decimal netTotal = grandTotal / 1.07m; // คำนวณแบบ VAT Inside ให้ตรงหน้า Admin
            decimal vat7 = grandTotal - netTotal;

            g.DrawString("ราคารวมสินค้า", fontBody, Brushes.Black, 20, y);
            g.DrawString($"{(netTotal + discount):N2}", fontBody, Brushes.Black, 330, y, formatRight);
            y += 25;
            if (discount > 0)
            {
                g.DrawString("ส่วนลด", fontBody, Brushes.Black, 20, y);
                g.DrawString($"-{discount:N2}", fontBody, Brushes.Black, 330, y, formatRight);
                y += 25;
            }
            g.DrawString("ภาษีมูลค่าเพิ่ม (VAT 7%)", fontBody, Brushes.Black, 20, y);
            g.DrawString($"{vat7:N2}", fontBody, Brushes.Black, 330, y, formatRight);
            y += 35;
            g.DrawLine(Pens.Black, 20, y, 330, y);
            y += 15;
            g.DrawString("ยอดชำระสุทธิ", new Font("Leelawadee UI", 12, FontStyle.Bold), Brushes.Black, 20, y);
            g.DrawString($"{grandTotal:N2} บาท", new Font("Leelawadee UI", 12, FontStyle.Bold), Brushes.Black, 330, y, formatRight);
            
            y += 50;
            g.DrawString("ขอบคุณที่ใช้บริการค่ะ", fontBody, Brushes.Black, centerX, y, formatCenter);
        }

        private void BtBackToAccount_Click(object sender, EventArgs e)
        {
            UserAccount userAccountForm = new UserAccount();
            this.Hide();
            userAccountForm.Show();
        }

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            UserSession.CurrentUserId = 0;
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.Show();
        }
    }
}
