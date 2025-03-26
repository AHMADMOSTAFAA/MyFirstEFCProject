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
    public partial class OwnerShop : Form
    {
        private int oid;
        private int placeid;
        private int shopId;
        OwnerUI OwnerUI = new OwnerUI();
        OwnerService OwnerService = new OwnerService();
        public OwnerShop(int oid, int pid, int shopId)
        {
            InitializeComponent();
            this.oid = oid;

            placeid = pid;
            this.shopId = shopId;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OwnerShop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OwnerUI.ShowProductsForOwner(oid, placeid, shopId);
            dataGridView2.DataSource = OwnerUI.ShowReservations(placeid);
            ShopID.Text = shopId.ToString();
            ShopID.ReadOnly = true;
        }



        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            OwnerService.AddProd(pName_txt.Text, Description_txt.Text, Convert.ToInt32(Price_Up.Value), int.Parse(ShopID.Text));
            dataGridView1.DataSource = OwnerUI.ShowProductsForOwner(oid, placeid, int.Parse(ShopID.Text));
        }


        private void UpdateProduct_btn_Click(object sender, EventArgs e)
        {
            OwnerService.UpdateProd(Convert.ToInt32(PID_UP.Value), pName_txt.Text, Description_txt.Text, Convert.ToInt32(Price_Up.Value), shopId);
            dataGridView1.DataSource = OwnerUI.ShowProductsForOwner(oid, placeid, int.Parse(ShopID.Text));
            dataGridView1.Refresh();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            OwnerService.DelProd(Convert.ToInt32(PID_UP.Value));
            dataGridView1.DataSource = OwnerUI.ShowProductsForOwner(oid, placeid, int.Parse(ShopID.Text));

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                // Assign values from the selected row to form controls
                PID_UP.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                pName_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["ProdName"].Value?.ToString();
                Description_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value?.ToString();
                Price_Up.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);
                ShopID.Text = dataGridView1.Rows[e.RowIndex].Cells["ShopiD"].Value?.ToString();
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Sportify.Owner owner = new Sportify.Owner(oid);
            owner.Show();
            this.Close();
        }
    }
}
