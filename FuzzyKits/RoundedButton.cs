using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class RoundedButton : Button
{
    // 1. PROPERTIES (คุณสมบัติเดียวกับ RoundedPanel)

    private int _borderRadius = 20; // รัศมีขอบมน (อาจน้อยกว่า Panel หลัก)
    public int BorderRadius
    {
        get { return _borderRadius; }
        set { _borderRadius = value; this.Invalidate(); }
    }

    private Color _borderColor = Color.Black;
    public Color BorderColor
    {
        get { return _borderColor; }
        set { _borderColor = value; this.Invalidate(); }
    }

    private int _borderThickness = 2;
    public int BorderThickness
    {
        get { return _borderThickness; }
        set { _borderThickness = value; this.Invalidate(); }
    }

    // 2. CONSTRUCTOR (ตั้งค่าเริ่มต้น)

    public RoundedButton()
    {
        // บังคับให้ปุ่มเป็น Flat Style เพื่อลบขอบนูนตามดีไซน์
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0; // ลบเส้นขอบเริ่มต้นของ FlatStyle
        this.Size = new Size(150, 40); // กำหนดขนาดเริ่มต้น
    }

    // 3. EVENT: OnPaint (ฟังก์ชันวาดรูปทรง)

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int w = this.Width - _borderThickness;
        int h = this.Height - _borderThickness;
        int halfThickness = _borderThickness / 2;

        GraphicsPath path = new GraphicsPath();
        int radius = _borderRadius;

        // วาดส่วนโค้งและเส้นตรง
        path.AddArc(new Rectangle(halfThickness, halfThickness, radius * 2, radius * 2), 180, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, halfThickness, radius * 2, radius * 2), 270, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 0, 90);
        path.AddArc(new Rectangle(halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 90, 90);
        path.CloseAllFigures();

        // 1. กำหนดให้ Button ใช้รูปทรงนี้
        this.Region = new Region(path);

        // 2. วาดเส้นขอบสีดำ (Draw Border)
        if (_borderThickness > 0 && _borderColor != Color.Transparent)
        {
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}