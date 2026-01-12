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

namespace FuzzyKits
{
    public partial class AdminOrder : Form
    {
        private int _currentOrderId = 0;

        public AdminOrder()
        {
            InitializeComponent();
        }

        private void AdminOrder_Load(object sender, EventArgs e)
        {
            cmbStatusAll.SelectedIndexChanged += (s, ev) => LoadOrderHistory();
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            // ป้องกัน Error หาก ComboBox ยังไม่ได้เลือกค่าใดๆ
            if (cmbStatusAll == null || cmbStatusAll.SelectedItem == null)
            {
                if (cmbStatusAll != null && cmbStatusAll.Items.Count > 0)
                    cmbStatusAll.SelectedIndex = 0;
                else return;
            }

            flowOrderList.Controls.Clear();
            string filter = cmbStatusAll.SelectedItem.ToString();
            string statusEN = "";

            switch (filter)
            {
                case "กำลังดำเนินการ": statusEN = "Pending"; break;
                case "ชำระเงินแล้ว": statusEN = "Paid"; break;
                case "กำลังจัดส่ง": statusEN = "Shipping"; break;
                case "เสร็จสมบูรณ์": statusEN = "Completed"; break;
                case "ยกเลิกออเดอร์": statusEN = "Cancelled"; break;
            }

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "SELECT order_id, total_amount, status FROM orders";
                if (filter != "ทั้งหมด")
                {
                    sql += " WHERE status = @status";
                }
                sql += " ORDER BY order_date DESC";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (filter != "ทั้งหมด")
                {
                    cmd.Parameters.AddWithValue("@status", statusEN);
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string currentStatus = reader["status"].ToString();
                        string statusTH = ""; // ตัวแปรสำหรับเก็บภาษาไทย
                        Color statusColor = Color.Gray;

                        // แปลงสถานะเป็นภาษาไทยและกำหนดสี
                        switch (currentStatus)
                        {
                            case "Pending":
                                statusTH = "กำลังดำเนินการ";
                                statusColor = Color.Orange;
                                break;
                            case "Paid":
                                statusTH = "ชำระเงินแล้ว";
                                statusColor = Color.DodgerBlue;
                                break;
                            case "Shipping":
                                statusTH = "กำลังจัดส่ง";
                                statusColor = Color.MediumPurple;
                                break;
                            case "Completed":
                                statusTH = "เสร็จสมบูรณ์";
                                statusColor = Color.SeaGreen;
                                break;
                            case "Cancelled":
                                statusTH = "ยกเลิกออเดอร์";
                                statusColor = Color.Crimson;
                                break;
                        }

                        Button btn = new Button
                        {
                            // เปลี่ยนตรงนี้ให้แสดง statusTH แทนครับ
                            Text = $"Order #{reader["order_id"]}\n฿{reader["total_amount"]:N2} ({statusTH})",
                            Size = new Size(260, 75),
                            BackColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            FlatAppearance = { BorderColor = statusColor, BorderSize = 2 },
                            Tag = reader["order_id"],
                            Margin = new Padding(10, 5, 0, 5)
                        };
                        btn.Click += OrderItem_Click;
                        flowOrderList.Controls.Add(btn);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void OrderItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int orderId = Convert.ToInt32(btn.Tag);
            ShowOrderDetail(orderId); // ฟังก์ชันนี้จะดึงที่อยู่มัดรวมและรูปสลิปมาโชว์
        }

        private void ShowOrderDetail(int orderId)
        {
            _currentOrderId = orderId;
            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                try
                {
                    string sql = "SELECT shipping_address, payment_proof_url, status FROM orders WHERE order_id = @oid";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // ส่วนจัดการที่อยู่คงเดิม
                        string rawAddress = reader["shipping_address"].ToString();
                        string[] parts = rawAddress.Split('|');
                        if (parts.Length >= 3)
                        {
                            string name = parts[0].Replace("คุณ", "").Trim();
                            string phone = parts[1].Replace("โทร:", "").Trim();
                            string addressFull = parts[2].Replace("ที่อยู่:", "").Trim();
                            int subIndex = addressFull.IndexOf("ต.");
                            string addr1 = addressFull;
                            string addr2 = "";
                            if (subIndex > 0)
                            {
                                addr1 = addressFull.Substring(0, subIndex).Trim();
                                addr2 = addressFull.Substring(subIndex).Trim();
                            }
                            lblAddress.Text = $"คุณ : {name}\nโทร : {phone}\nที่อยู่ : {addr1}\n         {addr2}";
                        }

                        // --- เพิ่มส่วนนี้เพื่ออัปเดต cmbStatus ตามข้อมูลจริงใน DB ---
                        string currentStatus = reader["status"].ToString();
                        switch (currentStatus)
                        {
                            case "Pending": cmbStatus.SelectedItem = "กำลังดำเนินการ"; break;
                            case "Paid": cmbStatus.SelectedItem = "ชำระเงินแล้ว"; break;
                            case "Shipping": cmbStatus.SelectedItem = "กำลังจัดส่ง"; break;
                            case "Completed": cmbStatus.SelectedItem = "เสร็จสมบูรณ์"; break;
                            case "Cancelled": cmbStatus.SelectedItem = "ยกเลิกออเดอร์"; break;
                        }

                        // ส่วนจัดการรูปสลิปคงเดิม
                        string slipPath = reader["payment_proof_url"].ToString();
                        if (File.Exists(slipPath))
                        {
                            picSlip.Image = Image.FromFile(slipPath);
                            picSlip.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else { picSlip.Image = null; }
                    }
                    reader.Close();
                    LoadOrderItems(orderId);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void LoadOrderItems(int orderId)
        {
            flowItems.Controls.Clear();
            flowTotalPrice.Controls.Clear();

            // [จุดที่ 1] บังคับให้เรียงจากบนลงล่าง และห้ามวางต่อแถวกันด้านข้าง
            flowItems.FlowDirection = FlowDirection.TopDown;
            flowItems.WrapContents = false;
            flowItems.AutoScroll = true;

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = @"SELECT p.name, oi.quantity, oi.price_per_unit, o.discount_amount, o.total_amount 
                       FROM order_items oi 
                       JOIN products p ON oi.product_id = p.product_id 
                       JOIN orders o ON oi.order_id = o.order_id
                       WHERE oi.order_id = @oid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@oid", orderId);
                MySqlDataReader reader = cmd.ExecuteReader();

                decimal discount = 0, netTotal = 0;

                // หัวข้อคอลัมน์
                flowItems.Controls.Add(CreateItemRow("รายการ", "จำนวน", "ราคา", true));

                try
                {
                    while (reader.Read())
                    {
                        discount = reader.GetDecimal("discount_amount");
                        netTotal = reader.GetDecimal("total_amount");
                        decimal subTotal = reader.GetDecimal("price_per_unit") * reader.GetInt32("quantity");

                        // เพิ่มสินค้า 1 รายการต่อ 1 บรรทัด
                        flowItems.Controls.Add(CreateItemRow(reader["name"].ToString(), "x" + reader["quantity"], subTotal.ToString("N2"), false));
                    }
                }
                finally { reader.Close(); }

                decimal vat7 = netTotal - (netTotal / 1.07m);
                flowTotalPrice.FlowDirection = FlowDirection.TopDown;
                flowTotalPrice.WrapContents = false;

                // [จุดที่ 2] ปรับเลื่อนราคาในช่องสรุปผล (Vat, ส่วนลด, สุทธิ)
                flowTotalPrice.Controls.Add(CreatePriceSummaryRow("ส่วนลด", $"-{discount:N2}", false));
                flowTotalPrice.Controls.Add(CreatePriceSummaryRow("Vat 7%", $"{vat7:N2}", false));
                flowTotalPrice.Controls.Add(CreatePriceSummaryRow("ราคาสุทธิ", $"{netTotal:N2}฿", true));
            }
        }

        // ฟังก์ชันสร้างแถวสินค้า (ใช้ TableLayoutPanel เพื่อให้คอลัมน์ตรงกันเป๊ะ)
        private Panel CreateItemRow(string name, string qty, string price, bool isHeader)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            // ปรับความกว้างให้เกือบเท่า flowItems (269) เพื่อให้มันกินพื้นที่เต็มบรรทัด
            tlp.Width = 200;
            tlp.Height = 30;
            tlp.ColumnCount = 3;
            tlp.Margin = new Padding(0);

            // แบ่งสัดส่วนช่อง รายการ(55%) | จำนวน(15%) | ราคา(30%)
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));

            Font rowFont = new Font("Leelawadee UI", 8f, isHeader ? FontStyle.Bold : FontStyle.Regular);

            tlp.Controls.Add(new Label { Text = name, Font = rowFont, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            tlp.Controls.Add(new Label { Text = qty, Font = rowFont, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, 0);

            // [จุดที่ 3] เลื่อนราคาของสินค้าเข้า (ปรับเลข 10 ด้านล่างเพื่อขยับซ้าย-ขวา)
            Label lblPrice = new Label { Text = price, Font = rowFont, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight };
            lblPrice.Padding = new Padding(0, 0, 10, 0); // เลข 10 คือระยะห่างจากขอบขวา ยิ่งเยอะยิ่งเลื่อนเข้าซ้าย
            tlp.Controls.Add(lblPrice, 2, 0);

            return tlp;
        }

        // ฟังก์ชันสร้างแถวสรุปราคาสำหรับ flowTotalPrice
        private Panel CreatePriceSummaryRow(string title, string value, bool isTotal)
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Width = 195;
            tlp.Height = 30;
            tlp.ColumnCount = 2;
            tlp.Margin = new Padding(0);

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            Font rowFont = new Font("Leelawadee UI", 8f, isTotal ? FontStyle.Bold : FontStyle.Regular);
            Color rowColor = isTotal ? Color.Crimson : Color.Black;

            tlp.Controls.Add(new Label { Text = title, Font = rowFont, ForeColor = rowColor, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);

            // [จุดที่ 4] เลื่อนราคาสรุปผลเข้า (ปรับเลข 20 ด้านล่างเพื่อขยับให้ตรงเส้นสีแดง)
            Label lblValue = new Label { Text = value, Font = rowFont, ForeColor = rowColor, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight };
            lblValue.Padding = new Padding(0, 0, 35, 0); // ลองปรับเลข 20 เพิ่มขึ้นถ้าอยากให้ราคาเลื่อนเข้ามาทางซ้ายอีก
            tlp.Controls.Add(lblValue, 1, 0);

            return tlp;
        }

        // ฟังก์ชันเสริมช่วยจัดข้อความชิดซ้าย-ขวาให้สวยงาม
        private Label CreateSummaryLabel(string title, string value, Font font)
        {
            // ปรับระยะ Format จาก 7,9 เป็น 10,10 เพื่อให้พอดีความกว้าง 208px
            return new Label
            {
                Text = string.Format("{0,-5} {1,10}", title, value),
                Font = font,
                Size = new Size(200, 25),
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private void picSlip_DoubleClick(object sender, EventArgs e)
        {
            if (picSlip.Image != null)
            {
                Form zoomForm = new Form
                {
                    Text = "หลักฐานการโอนเงิน",
                    Size = new Size(600, 800),
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.SizableToolWindow
                };
                PictureBox pb = new PictureBox
                {
                    Image = picSlip.Image,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                zoomForm.Controls.Add(pb);
                zoomForm.ShowDialog();
            }
        }

        private void btUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_currentOrderId == 0 || cmbStatus.SelectedItem == null) return;

            string statusTH = cmbStatus.SelectedItem.ToString();
            string statusEN = "";

            switch (statusTH)
            {
                case "กำลังดำเนินการ": statusEN = "Pending"; break;
                case "ชำระเงินแล้ว": statusEN = "Paid"; break;
                case "กำลังจัดส่ง": statusEN = "Shipping"; break;
                case "เสร็จสมบูรณ์": statusEN = "Completed"; break;
                case "ยกเลิกออเดอร์": statusEN = "Cancelled"; break;
            }

            // ถ้าเลือกยกเลิก ให้ถามยืนยันก่อน
            if (statusEN == "Cancelled")
            {
                DialogResult dr = MessageBox.Show("คุณต้องการยกเลิกออเดอร์นี้และคืนสต็อกสินค้าใช่หรือไม่?", "ยืนยันการยกเลิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;
            }

            using (MySqlConnection conn = DBConnector.GetConnection())
            {
                string sql = "UPDATE orders SET status = @status WHERE order_id = @oid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", statusEN);
                cmd.Parameters.AddWithValue("@oid", _currentOrderId);
                cmd.ExecuteNonQuery();

                if (statusEN == "Cancelled")
                {
                    // คืนสต็อกโดยใช้ชื่อคอลัมน์ 'stock'
                    string refundSql = @"UPDATE products p 
                                 JOIN order_items oi ON p.product_id = oi.product_id 
                                 SET p.stock = p.stock + oi.quantity 
                                 WHERE oi.order_id = @oid";
                    MySqlCommand refundCmd = new MySqlCommand(refundSql, conn);
                    refundCmd.Parameters.AddWithValue("@oid", _currentOrderId);
                    refundCmd.ExecuteNonQuery();
                    MessageBox.Show("ยกเลิกออเดอร์และคืนสต็อกเรียบร้อยแล้ว");
                }
                else
                {
                    MessageBox.Show("อัปเดตสถานะสำเร็จ");
                }
                LoadOrderHistory();
            }
        }

        private void BtDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            this.Hide();
            AdminDashboardForm.Show();
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

        private void BtSignOut_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        } 
    }
}
