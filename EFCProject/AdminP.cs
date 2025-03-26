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
    public partial class AdminP : Form
    {
        DBContext dbContext = new DBContext();
        AdminService adminService = new AdminService();
        public AdminP()
        {
            InitializeComponent();
        }





        private void AdminP_Load(object sender, EventArgs e)
        {
            var Places = dbContext.placeOfInterests.Select(p => new
            {
                id = p.Id,
                name = p.PName,
                ownerid = p.ownerid,
                co_ordinates = p.Coordinates,
                Address = p.Address,
                SportType=p.SportType,
                Img=p.ImgUrl

            }
                         ).ToList();
            dataGridView1.DataSource = Places;
            var Owner = dbContext.users.Select(o => new { id = o.Id, Name = o.Name, role = o.Role }).Where(o => o.role == "Owner").ToList();
            CB_Owner.DataSource = Owner;
            CB_Owner.DisplayMember = "Name";
            CB_Owner.ValueMember = "Id";
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int PlaceId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            dataGridView2.DataSource = adminService.ShowReservationsInplace(PlaceId);

            ID_UP.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            Name_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Co_Txt.Text = dataGridView1.Rows[e.RowIndex].Cells["co_ordinates"].Value?.ToString();
            Ad_TXT.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            CB_Owner.Text = dataGridView1.Rows[e.RowIndex].Cells["ownerid"].Value.ToString();
            CB_Category.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["SportType"].Value.ToString();
            CB_Category.Text = dataGridView1.Rows[e.RowIndex].Cells["SportType"].Value.ToString();
            Img_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["img"].Value?.ToString() ?? "";

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            adminService.AddPlace(Name_TXT.Text, Co_Txt.Text, CB_Category.Text, Ad_TXT.Text, (int)CB_Owner.SelectedValue,Img_txt.Text);
            var Places = dbContext.placeOfInterests.Select(p => new
            {
                id = p.Id,
                name = p.PName,
                ownerid = p.ownerid,
                co_ordinates = p.Coordinates,
                Address = p.Address,
                SportType=p.SportType,
                img= p.ImgUrl

            }
                   ).ToList();
            dataGridView1.DataSource = Places;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminS admin = new AdminS();
            admin.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            adminService.DelPlace((int)ID_UP.Value);
            var Places = dbContext.placeOfInterests.Select(p => new
            {
                id = p.Id,
                name = p.PName,
                ownerid = p.ownerid,
                co_ordinates = p.Coordinates,
                Address = p.Address,
                SportType = p.SportType,
                img = p.ImgUrl

            }
                        ).ToList();
            dataGridView1.DataSource = Places;


        }

        private void Update_Click(object sender, EventArgs e)
        {
            adminService.UpdatePlace((int)ID_UP.Value,Name_TXT.Text,Co_Txt.Text,CB_Category.Text,Ad_TXT.Text,(int)CB_Owner.SelectedValue,Img_txt.Text);
            var Places = dbContext.placeOfInterests.Select(p => new
            {
                id = p.Id,
                name = p.PName,
                ownerid = p.ownerid,
                co_ordinates = p.Coordinates,
                Address = p.Address,
                SportType = p.SportType,
                img=p.ImgUrl

            }
                            ).ToList();
            dataGridView1.DataSource = Places;
        }
    }
}
