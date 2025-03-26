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
    public partial class Owner : Form
    {
        public int OwnerID;
        DBContext dbContext = new DBContext();

        public Owner(int id)
        {

            InitializeComponent();
            OwnerID = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {
            var images = dbContext.placeOfInterests
                         .Where(p => p.ownerid == OwnerID)
                         .Select(p => p.ImgUrl)
                         .ToList(); // Convert to list to avoid multiple queries

            if (images.Count > 0 && !string.IsNullOrEmpty(images[0]))
            {
                pictureBox1.Image = Image.FromFile(images[0]);


            }

            if (images.Count > 1 && !string.IsNullOrEmpty(images[1]))
            {
                pictureBox2.Image = Image.FromFile(images[1]);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var place = dbContext.placeOfInterests
     .Where(p => p.PName == "Cross Fit")
     .Select(p => new { p.Id })
     .FirstOrDefault();

            if (place != null)
            {
                var shopId = dbContext.shops
                    .Where(s => s.PlaceId == place.Id)
                    .Select(s => s.Id)
                    .FirstOrDefault();

                OwnerShop ownerShop = new OwnerShop(OwnerID, place.Id, shopId);
                ownerShop.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Place not found.");
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
