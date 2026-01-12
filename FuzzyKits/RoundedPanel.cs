using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D; // ใช้สำหรับ GraphicsPath

public class RoundedPanel : Panel
{
    // 1. PROPERTIES (คุณสมบัติที่ตั้งค่าได้ใน Properties Window)

    // กำหนดรัศมีของขอบมน
    private int _borderRadius = 30;
    public int BorderRadius
    {
        get { return _borderRadius; }
        set { _borderRadius = value; this.Invalidate(); } // เมื่อเปลี่ยนค่า ให้วาดใหม่ทันที
    }

    // สีขอบ
    private Color _borderColor = Color.Black;
    public Color BorderColor
    {
        get { return _borderColor; }
        set { _borderColor = value; this.Invalidate(); }
    }

    // ความหนาของเส้นขอบ
    private int _borderThickness = 2;
    public int BorderThickness
    {
        get { return _borderThickness; }
        set { _borderThickness = value; this.Invalidate(); }
    }


    // 2. EVENT: OnPaint (ฟังก์ชันวาดรูปทรง)

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // ทำให้ขอบเรียบเนียน

        // กำหนดขนาดพื้นที่วาด (ลบความหนาขอบออก)
        int w = this.Width - _borderThickness;
        int h = this.Height - _borderThickness;
        int halfThickness = _borderThickness / 2;

        // 1. สร้าง Path (รูปทรงสี่เหลี่ยมผืนผ้าที่มีขอบมน)
        GraphicsPath path = new GraphicsPath();
        int radius = _borderRadius;

        // วาดส่วนโค้งและเส้นตรงเพื่อสร้างรูปทรง (ลบ halfThickness ออกไปเพื่อให้เส้นขอบถูกวาดอยู่กึ่งกลางขอบจริง)
        path.AddArc(new Rectangle(halfThickness, halfThickness, radius * 2, radius * 2), 180, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, halfThickness, radius * 2, radius * 2), 270, 90);
        path.AddArc(new Rectangle(w - radius * 2 + halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 0, 90);
        path.AddArc(new Rectangle(halfThickness, h - radius * 2 + halfThickness, radius * 2, radius * 2), 90, 90);
        path.CloseAllFigures();

        // 2. กำหนดให้ Panel ใช้รูปทรงนี้เป็นพื้นที่แสดงผล
        this.Region = new Region(path);

        // 3. วาดเส้นขอบ (Draw Border)
        if (_borderThickness > 0 && _borderColor != Color.Transparent)
        {
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}