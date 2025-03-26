using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sportify
{
    public enum MessageBoxType
    {
        Success,
        Error,
        Info
    }

    public class CustomMessageBox : Form
    {
        // Timers for fade‑in, auto‑close, and fade‑out.
        private System.Windows.Forms.Timer fadeInTimer;
        private System.Windows.Forms.Timer autoCloseTimer;
        private System.Windows.Forms.Timer fadeOutTimer;

        // Fade increments and auto‑close delay.
        private double fadeInIncrement = 0.05;
        private double fadeOutIncrement = 0.1;
        private int autoCloseDelay = 2000; // milliseconds
        private int slideIncrement = 2;

        // Target vertical position for the slide animation.
        private int targetTop;

        // Color for the decorative stripes.
        private Color stripeColor;

        // Label to display the message.
        private Label lblMessage;

        public CustomMessageBox(string message, string title = "Message", MessageBoxType type = MessageBoxType.Success)
        {
            // Set the form size slightly wider and taller.
            this.ClientSize = new Size(320, 170);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.Black;
            this.Text = title;

            // Create and add the message label.
            lblMessage = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                Text = message
            };
            this.Controls.Add(lblMessage);

            // Map the MessageBoxType to the stripe color.
            switch (type)
            {
                case MessageBoxType.Success:
                    stripeColor = Color.MediumSeaGreen;
                    break;
                case MessageBoxType.Error:
                    stripeColor = Color.Red;
                    break;
                case MessageBoxType.Info:
                    stripeColor = Color.Blue;
                    break;
                default:
                    stripeColor = Color.Gray;
                    break;
            }

            // Set a custom start position.
            this.StartPosition = FormStartPosition.Manual;
            int targetLeft = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            targetTop = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            // Start 50 pixels above the target position.
            this.Location = new Point(targetLeft, targetTop - 50);

            // Start fully transparent.
            this.Opacity = 0;

            // Attach the Paint event to draw the stripes.
            this.Paint += CustomMessageBox_Paint;

            // Set up and start the fade‑in timer.
            fadeInTimer = new System.Windows.Forms.Timer { Interval = 50 };
            fadeInTimer.Tick += FadeInTimer_Tick;
            fadeInTimer.Start();
        }

        private void CustomMessageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(stripeColor))
            {
                int stripeWidth = 50;       // width of each stripe
                int extra = 100;            // extra offset for the diagonal effect
                int totalWidth = stripeWidth * 3;  // two stripes and one gap
                // Shift the startX slightly to the right by 10 pixels
                int startX = ((this.ClientSize.Width - totalWidth) / 2) + 10;

                // Left stripe polygon (diagonally sloped)
                Point[] leftPoints = new Point[]
                {
                    new Point(startX, 0),
                    new Point(startX + stripeWidth, 0),
                    new Point(startX + stripeWidth - extra, this.ClientSize.Height),
                    new Point(startX - extra, this.ClientSize.Height)
                };

                // Right stripe polygon, positioned after a gap equal to stripeWidth
                int rightX = startX + 2 * stripeWidth;
                Point[] rightPoints = new Point[]
                {
                    new Point(rightX, 0),
                    new Point(rightX + stripeWidth, 0),
                    new Point(rightX + stripeWidth - extra, this.ClientSize.Height),
                    new Point(rightX - extra, this.ClientSize.Height)
                };

                e.Graphics.FillPolygon(brush, leftPoints);
                e.Graphics.FillPolygon(brush, rightPoints);
            }
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            bool needUpdate = false;
            if (this.Opacity < 1)
            {
                this.Opacity += fadeInIncrement;
                needUpdate = true;
            }
            if (this.Top < targetTop)
            {
                this.Top = Math.Min(this.Top + slideIncrement, targetTop);
                needUpdate = true;
            }
            if (!needUpdate)
            {
                fadeInTimer.Stop();
                autoCloseTimer = new System.Windows.Forms.Timer { Interval = autoCloseDelay };
                autoCloseTimer.Tick += AutoCloseTimer_Tick;
                autoCloseTimer.Start();
            }
        }

        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            autoCloseTimer.Stop();
            fadeOutTimer = new System.Windows.Forms.Timer { Interval = 30 };
            fadeOutTimer.Tick += FadeOutTimer_Tick;
            fadeOutTimer.Start();
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= fadeOutIncrement;
                this.Top -= slideIncrement;
            }
            else
            {
                fadeOutTimer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public static DialogResult Show(string message, string title = "Message", MessageBoxType type = MessageBoxType.Success)
        {
            using (CustomMessageBox msgBox = new CustomMessageBox(message, title, type))
            {
                return msgBox.ShowDialog();
            }
        }
    }
}

