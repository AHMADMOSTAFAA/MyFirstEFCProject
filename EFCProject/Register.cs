using EFCProject;
using Sportify.BL;
using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sportify
{
    public partial class Register : Form
    {
        private DBContext dbContext = new DBContext();
        private UserService userService = new UserService();

        private List<Point> starPoints = new List<Point>();
        private Random starRandom = new Random();

        private Image overlayImage;

        public Register()
        {
            InitializeComponent();
            GenerateStarPositions(120);

            try
            {
                overlayImage = Image.FromFile("spaceIcon.gif");
            }
            catch
            {
                overlayImage = null;
            }

            StyleDataGridView();
        }

        private void GenerateStarPositions(int starCount)
        {
            starPoints.Clear();
            for (int i = 0; i < starCount; i++)
            {
                int x = starRandom.Next(this.ClientSize.Width);
                int y = starRandom.Next(this.ClientSize.Height);
                starPoints.Add(new Point(x, y));
            }
        }

        private void StyleDataGridView()
        {
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ForeColor = Color.White;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(57, 255, 20);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 255, 20);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Paint += DataGridView1_Paint;
        }

        private void DataGridView1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(57, 255, 20), 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, dataGridView1.Width - 1, dataGridView1.Height - 1);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            var Roles = dbContext.users.Select(u => u.Role).Distinct().ToList();
            CB_Role.DataSource = Roles;
            if (CB_Role.Items.Count > 0)
                CB_Role.SelectedIndex = 0;
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            // Check if email or username already exists.
            bool userExists = dbContext.users.Any(u => u.Email == Email.Text || u.Name == UName.Text);
            if (userExists)
            {
                // Show error message with red sloped stripes.
                CustomMessageBox.Show("Email or Username is already registered!", "Error", MessageBoxType.Error);
                return;
            }

            // Otherwise, register the user.
            userService.addUser(UName.Text, Password.Text, Location.Text, Email.Text, CB_Role.Text);
            dbContext.SaveChanges();

            // Show success message with green sloped stripes.
            CustomMessageBox.Show("User Registered Successfully!", "Success", MessageBoxType.Success);

            // Refresh the DataGridView.
            var Users = dbContext.users.Select(u => new
            {
                id = u.Id,
                name = u.Name,
                email = u.Email,
                location = u.Location,
                role = u.Role
            }).ToList();
            dataGridView1.DataSource = Users;
        }

        private void User_Click(object sender, EventArgs e)
        {
            var Users = dbContext.users.Select(u => new
            {
                id = u.Id,
                name = u.Name,
                email = u.Email,
                location = u.Location,
                role = u.Role
            }).ToList();
            dataGridView1.DataSource = Users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional: display an info message before returning.
            CustomMessageBox.Show("Returning to Welcome Screen.", "Info", MessageBoxType.Info);
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
