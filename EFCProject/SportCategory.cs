using Sportify.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sportify
{
    public partial class SportCategory : Form
    {
        private int userid;
        UserUIService service = new UserUIService();
     

        public SportCategory(int id)
        {
            InitializeComponent();
            this.userid = id;
            StyleComponents();
            LoadImages();
        }

        private void StyleComponents()
        {
            // Set labels to light green (redundant if set in designer but ensuring consistency)
            label1.ForeColor = Color.LightGreen;
          
            label4.ForeColor = Color.LightGreen;
            label5.ForeColor = Color.LightGreen;

            // Apply rounded corners and a neon green border to PictureBoxes
            ApplyRoundedCorners(PowerLifting);
            ApplyRoundedCorners(SelfDefence);
            ApplyRoundedCorners(Atheletics);
            ApplyRoundedCorners(Fitness);
        }

        private void ApplyRoundedCorners(PictureBox pictureBox)
        {
            int radius = 20;
            // Create a GraphicsPath with rounded corners
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pictureBox.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pictureBox.Width - radius, pictureBox.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pictureBox.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pictureBox.Region = new Region(path);
            // Add a neon green border in the Paint event
            pictureBox.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.Lime, 3))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void LoadImages()
        {
            try
            {
                PowerLifting.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/powerlifting.jpeg");
                SelfDefence.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/Self Defence.jpeg");
                Atheletics.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/Athletics.jpeg");
                Fitness.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/Fitness.PNG");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }
        }

        private void Fitness_Click(object sender, EventArgs e)
        {
            FitnessCat fitness = new FitnessCat(userid);
            fitness.Show();
            this.Hide();
        }

        private void SportCategory_Load(object sender, EventArgs e)
        {
            // Additional load logic can go here if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserUI user = new UserUI(userid);

            user.Show();
            this.Close();
        }
    }
}
