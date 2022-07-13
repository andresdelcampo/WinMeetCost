﻿using System.Drawing.Drawing2D;

// Reference from StackOverflow by King King and Ryan Lundy
// https://stackoverflow.com/questions/19842722/setting-a-font-with-outline-color-in-c-sharp
public class CustomLabel : Label
{
    public CustomLabel()
    {
        OutlineForeColor = Color.Black;
        OutlineWidth = 2;
    }
    public Color OutlineForeColor { get; set; }
    public float OutlineWidth { get; set; }
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
        using (GraphicsPath gp = new GraphicsPath())
        using (Pen outline = new Pen(OutlineForeColor, OutlineWidth)
        { LineJoin = LineJoin.Round })
        using (StringFormat sf = new StringFormat())
        using (Brush foreBrush = new SolidBrush(ForeColor))
        {
            sf.Alignment = StringAlignment.Center;
            gp.AddString(Text, Font.FontFamily, (int)Font.Style,
                Font.Size, ClientRectangle, sf);
            e.Graphics.ScaleTransform(1.3f, 1.35f);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawPath(outline, gp);
            e.Graphics.FillPath(foreBrush, gp);
        }
    }
}