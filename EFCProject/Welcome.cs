using Sportify;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EFCProject
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // Override OnPaint to add background stripes
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawStripes(e.Graphics);
        }

        private void DrawStripes(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int stripeWidth = 50;
            Color stripeColor = Color.FromArgb(57, 255, 20); // Neon green
            int extra = 100; // Extra offset for diagonal coverage

            // Total width: two stripes + one gap (equal to stripeWidth)
            int totalWidth = stripeWidth * 3;
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            // Left stripe polygon
            Point[] leftPoints = new Point[]
            {
                new Point(startX, 0),
                new Point(startX + stripeWidth, 0),
                new Point(startX + stripeWidth - extra, this.ClientSize.Height),
                new Point(startX - extra, this.ClientSize.Height)
            };

            // Right stripe polygon: positioned after a gap equal to stripeWidth
            int rightX = startX + 2 * stripeWidth;
            Point[] rightPoints = new Point[]
            {
                new Point(rightX, 0),
                new Point(rightX + stripeWidth, 0),
                new Point(rightX + stripeWidth - extra, this.ClientSize.Height),
                new Point(rightX - extra, this.ClientSize.Height)
            };

            using (SolidBrush brush = new SolidBrush(stripeColor))
            {
                g.FillPolygon(brush, leftPoints);
                g.FillPolygon(brush, rightPoints);
            }
        }
    }

    // RoundedButton class
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
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, Width, Height), borderRadius))
            {
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
}
