using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Sportify.TextBoxes
{
    public partial class RoundedTextBox : UserControl
    {
        private int _borderRadius = 15;
        private Color _borderColor = Color.LimeGreen;
        private Color _backgroundColor = Color.FromArgb(20, 20, 20);
        private int _borderSize = 2;
        private bool _useSystemPasswordChar = false;

        private readonly TextBox textBox = new TextBox();

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                BackColor = value;
                textBox.BackColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextValue
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UseSystemPasswordChar
        {
            get => _useSystemPasswordChar;
            set
            {
                _useSystemPasswordChar = value;
                textBox.UseSystemPasswordChar = value;
            }
        }

        public RoundedTextBox()
        {
            textBox.Parent = this;
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = _backgroundColor;
            textBox.ForeColor = Color.White;
            textBox.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox.Multiline = false;

            Controls.Add(textBox);
            Resize += RoundedTextBox_Resize;
        }

        private void RoundedTextBox_Resize(object sender, EventArgs e)
        {
            textBox.Location = new Point(_borderSize, _borderSize);
            textBox.Width = Width - (_borderSize * 2);
            textBox.Height = Height - (_borderSize * 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
                    path.AddArc(Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
                    path.AddArc(Width - _borderRadius, Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
                    path.AddArc(0, Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush brush = new SolidBrush(_backgroundColor))
                        g.FillPath(brush, path);

                    using (Pen pen = new Pen(_borderColor, _borderSize))
                        g.DrawPath(pen, path);
                }
            }
        }
    }
}
