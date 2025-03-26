using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sportify
{
    public partial class LoadingForm : Form
    {
        private string textToDraw = "Sportify";
        private int animationProgress = 0;
        private int maxProgress = 120; // Increased to ensure full drawing of 'y'
        private System.Windows.Forms.Timer animationTimer;

        public LoadingForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(800, 400);
            this.DoubleBuffered = true; // To reduce flickering
            this.Paint += LoadingForm_Paint;

            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer { Interval = 30 };
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationProgress += 1; // Controls speed of effect
            this.Invalidate(); // Triggers a repaint of the form

            if (animationProgress >= maxProgress)
            {
                animationTimer.Stop();
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        private void LoadingForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.Black);

            Font font = new Font("Arial Black", 80, FontStyle.Bold);
            SizeF textSize = e.Graphics.MeasureString(textToDraw, font);
            PointF location = new PointF(ClientSize.Width / 4, (ClientSize.Height - textSize.Height) / 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddString(textToDraw, font.FontFamily, (int)font.Style, font.Size, location, StringFormat.GenericDefault);

                RectangleF bounds = path.GetBounds();
                float progressRatio = (float)animationProgress / maxProgress;
                RectangleF paintRect = new RectangleF(bounds.Left, bounds.Top, bounds.Width * progressRatio, bounds.Height);

                using (SolidBrush solidBrush = new SolidBrush(Color.White))
                {
                    using (Region region = new Region(path))
                    {
                        region.Intersect(paintRect);
                        e.Graphics.FillRegion(solidBrush, region);
                    }
                }

                // Draw the green dot moving with the word as part of the animation
                float dotSize = font.Size / 5;
                float dotX = bounds.Left + (bounds.Width * progressRatio);
                float dotY = bounds.Bottom - dotSize; // Adjust the Y position to align with the text baseline
                e.Graphics.FillEllipse(Brushes.LimeGreen, dotX, dotY, dotSize, dotSize);
            }
        }
    }
}