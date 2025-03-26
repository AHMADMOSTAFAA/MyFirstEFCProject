using Sportify.BL;
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
    public partial class UserUI : Form
    {
        private int userid;
        UserUIService service = new UserUIService();
        UserService userService = new UserService();

        public UserUI(int userid)
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = true;
            this.userid = userid;
            dataGridView1.RowHeadersWidth = 60; // Set RowHeader width
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black; // Set RowHeader background color
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Lime; // Set RowHeader text color
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint; // Ensure event is linked
        }

        private void ViewReservations_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.ShowReservations(userid);
            dataGridView1.Refresh(); // Force redraw
            dataGridView1.Columns["PlaceId"].Visible = false;  // Hide PlaceId column
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.Lime)) // Set minus sign to neon green
            {
                Font boldFont = new Font(dataGridView1.Font.FontFamily, 18, FontStyle.Bold);
                SizeF textSize = e.Graphics.MeasureString("-", boldFont);
                float x = e.RowBounds.Left + (dataGridView1.RowHeadersWidth - textSize.Width) / 2;
                float y = e.RowBounds.Top + (e.RowBounds.Height - textSize.Height) / 2;
                e.Graphics.DrawString("-", boldFont, brush, x, y);
            }
            Console.WriteLine("RowPostPaint triggered"); // Debugging output
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportCategory uI2 = new SportCategory(userid);
            uI2.Show();
            this.Hide();
        }

        private void UserCart_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void UserUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                int placeId = (int)dataGridView1.Rows[e.RowIndex].Cells["PlaceId"].Value; // Retrieve hidden PlaceId
                userService.CancelReservation(placeId, userid);
                // Refresh the DataGridView
                dataGridView1.DataSource = service.ShowReservations(userid);
                dataGridView1.Refresh();
                CustomMessageBox.Show("Reservation cancelled !", "Success");
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

