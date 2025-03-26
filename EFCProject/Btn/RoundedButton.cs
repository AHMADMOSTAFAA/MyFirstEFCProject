using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int borderRadius = 20;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; Invalidate(); }
    }

    public RoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        // Neon-green background
        BackColor = Color.FromArgb(57, 255, 20);
        ForeColor = Color.Black; // or Color.White, whichever you prefer
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, this.Width, this.Height), borderRadius))
        {
            // Fill the background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, path);
            }

            // Draw text in the center
            TextRenderer.DrawText(
                g,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Clip the control to the rounded shape
            this.Region = new Region(path);
        }
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}
