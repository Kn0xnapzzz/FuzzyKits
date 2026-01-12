using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel; // สำคัญสำหรับ Properties Window

public class RoundTextBox : Panel
{
    // 1. PROPERTIES สำหรับ DESIGN

    [Category("FuzzyKits Appearance")]
    public int BorderRadius { get; set; } = 20;

    [Category("FuzzyKits Appearance")]
    public Color BorderColor { get; set; } = Color.Black;

    [Category("FuzzyKits Appearance")]
    public int BorderThickness { get; set; } = 2;

    // 2. PROPERTIES สำหรับ TEXTBOX (ซ่อน TextBox จริงไว้ข้างใน)

    private TextBox innerTextBox;

    // สร้าง Property 'Text' ใหม่ เพื่อเข้าถึงข้อความภายใน TextBox จริง
    [Category("FuzzyKits Data")]
    public override string Text
    {
        get { return innerTextBox.Text; }
        set { innerTextBox.Text = value; }
    }

    // Property สำหรับการซ่อนรหัสผ่าน
    [Category("FuzzyKits Data")]
    public bool UseSystemPasswordChar
    {
        get { return innerTextBox.UseSystemPasswordChar; }
        set { innerTextBox.UseSystemPasswordChar = value; }
    }


    // 3. CONSTRUCTOR (การสร้าง Control ภายใน)

    public RoundTextBox()
    {
        // 1. สร้าง TextBox จริง และตั้งค่าให้มันไม่มีขอบ
        innerTextBox = new TextBox();
        innerTextBox.BorderStyle = BorderStyle.None;
        innerTextBox.Dock = DockStyle.Fill; // ให้ TextBox เต็ม Panel
        innerTextBox.TextChanged += (sender, e) => this.OnTextChanged(e); // ส่งต่อ Event TextChanged

        // 2. เพิ่ม TextBox เข้ามาใน Panel นี้
        this.Controls.Add(innerTextBox);

        // 3. กำหนดขนาดเริ่มต้นและ Style ของ Panel (เป็น Container หลัก)
        this.Size = new Size(250, 40);
        this.Padding = new Padding(10, 10, 10, 10); // กำหนดระยะห่างจากขอบมน
    }

    // 4. OnPaint (วาดขอบมน)

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // โค้ดการวาด Path (เหมือน RoundedPanel)
        GraphicsPath path = new GraphicsPath();
        int radius = BorderRadius;
        int w = this.Width - BorderThickness;
        int h = this.Height - BorderThickness;
        int halfThickness = BorderThickness / 2;

        path.AddArc(new Rectangle(halfThickness, halfThickness, radius * 2, radius * 2), 180, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, halfThickness, radius * 2, radius * 2), 270, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 0, 90);
        path.AddArc(new Rectangle(halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 90, 90);
        path.CloseAllFigures();

        // กำหนด Region และวาดเส้นขอบ
        this.Region = new Region(path);

        if (BorderThickness > 0 && BorderColor != Color.Transparent)
        {
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}