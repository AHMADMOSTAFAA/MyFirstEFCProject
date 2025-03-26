using Sportify.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sportify
{
    public partial class UserCart : Form
    {
        UserUIService UserUIService = new UserUIService();
        UserService UserService = new UserService();
        private int _id;
        private int pid;

        public UserCart(int id, int pid)
        {
            _id = id;
            InitializeComponent();
            this.pid = pid;
            StyleDataGridViews();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UserUIService.ShowUserProducts(_id);
            dataGridView2.DataSource = UserUIService.ShowShop(pid);
            AddRowHeaderButtons();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                UserService.RemoveProductFromCart(_id, productId, quantity);

                dataGridView1.DataSource = UserUIService.ShowUserProducts(_id);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ProductId"].Value);
                int quantity = 1;

                UserService.AddProductToCart(_id, productId, quantity);

                dataGridView1.DataSource = UserUIService.ShowUserProducts(_id);
                dataGridView2.DataSource = UserUIService.ShowShop(pid);
            }
        }

        private void AddRowHeaderButtons()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.HeaderCell.Value = "\u2795"; // Larger plus symbol
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = "\u2796"; // Larger minus symbol
            }
        }

        private void StyleDataGridViews()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Lime;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.DefaultCellStyle.BackColor = Color.Black;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Cyan;
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}

