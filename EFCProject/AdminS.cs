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
    public partial class AdminS : Form
    {
        DBContext dbContext = new DBContext();
        AdminService adminService = new AdminService();
        public AdminS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminP adminP = new AdminP();
            adminP.Show();
            this.Hide();
        }

        private void AdminS_Load(object sender, EventArgs e)
        {
            var Shops = dbContext.shops.Select(s => new
            {
                id = s.Id,
                name = s.ShopName,
                placeId = s.PlaceId,


            }
                        ).ToList();
            dataGridView1.DataSource = Shops;
            var PlaceOfshop = dbContext.placeOfInterests.Select(p => new { name = p.PName, id = p.Id })
                    .ToList();

            // Bind to ComboBox
            CB_PID.DataSource = PlaceOfshop;
            CB_PID.DisplayMember = "name"; // Show place name
            CB_PID.ValueMember = "id";     // Store place ID


        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            adminService.AddShop(Name_TXT.Text, (int)CB_PID.SelectedValue);

            var Shops = dbContext.shops.Select(s => new
            {
                id = s.Id,
                name = s.ShopName,
                placeId = s.PlaceId,


            }
                       ).ToList();
            dataGridView1.DataSource = Shops;

        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            adminService.DeleteShop((int)ID_UP.Value);
            var Shops = dbContext.shops.Select(s => new
            {
                id = s.Id,
                name = s.ShopName,
                placeId = s.PlaceId,


            }
                      ).ToList();
            dataGridView1.DataSource = Shops;
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            adminService.UpdateShop((int)ID_UP.Value, Name_TXT.Text, (int)CB_PID.SelectedValue);
            var Shops = dbContext.shops.Select(s => new
            {
                id = s.Id,
                name = s.ShopName,
                placeId = s.PlaceId,


            }
                ).ToList();
            dataGridView1.DataSource = Shops;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_UP.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            Name_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
         
        
            CB_PID.Text = dataGridView1.Rows[e.RowIndex].Cells["placeId"].Value.ToString();
        }
    }
}
