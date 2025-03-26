using EFCProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Sportify.BL;
using Sportify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportify
{
    public partial class Admin : Form
    {
        DBContext dbContext = new DBContext();
        AdminService adminService = new AdminService();

        public Admin()
        {
            InitializeComponent();
            StyleDataGrids();
        }

        private void Admin_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            dataGridView2.DataSource = adminService.ShowPlaces(userId);

            ID_UP.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            Name_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Email_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            Location_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["Location"].Value.ToString();
            CB_Role.Text = dataGridView1.Rows[e.RowIndex].Cells["Role"].Value.ToString();
        }

        private void Delete(object sender, EventArgs e)
        {
            adminService.DeleteUser((int)ID_UP.Value);
            var Users = dbContext.users.Select(u => new
            {
                id = u.Id,
                name = u.Name,
                email = u.Email,
                location = u.Location,
                role = u.Role
            }).ToList();

            dataGridView1.DataSource = Users;
            dataGridView2.DataSource = adminService.ShowReservations((int)ID_UP.Value);
            CustomMessageBox.Show("User deleted successfully!", "Success");
        }

        private void Update(object sender, EventArgs e)
        {
            bool isUpdated = adminService.UpdateUser(
                (int)ID_UP.Value,
                Name_TXT.Text,
                Email_TXT.Text,
                Location_TXT.Text,
                CB_Role.Text
            );

            if (isUpdated)
            {
                CustomMessageBox.Show("User Updated successfully!", "Success"); var Users = dbContext.users.Select(u => new
                {
                    id = u.Id,
                    name = u.Name,
                    email = u.Email,
                    location = u.Location,
                    role = u.Role
                }).ToList();

                dataGridView1.DataSource = Users;
                dataGridView2.DataSource = adminService.ShowReservations((int)ID_UP.Value);
            }
            else
            {
CustomMessageBox.Show("User couldnt be updated!", "Error");            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP adminP = new AdminP();
            adminP.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void StyleDataGrids()
        {
            // Style for dataGridView1
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.GridColor = Color.FromArgb(0, 255, 0); // Neon green
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(0, 255, 0);
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 255, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            // Style for dataGridView2 (different styling)
            dataGridView2.BackgroundColor = Color.Black;
            dataGridView2.GridColor = Color.FromArgb(0, 255, 255); // Neon cyan
            dataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(0, 255, 255);
            dataGridView2.DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.DefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 255, 255);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 12, FontStyle.Bold);
            dataGridView2.EnableHeadersVisualStyles = false;
        }
    }
}

