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
    public partial class CrossFit : Form
    {
        public int userid;
        public int placeid;
        UserUIService UserUIService = new UserUIService();
        UserService UserService = new UserService();
        public CrossFit(int id, int PID)
        {
            InitializeComponent();
            this.userid = id;
            placeid = PID;
        }

        private void CrossFit_Load(object sender, EventArgs e)
        {
            StartDate_txt.Text = DateTime.Now.ToShortDateString();
            StartDate_txt.Enabled = false;
            dataGridView1.DataSource = UserUIService.ShowShop(placeid);
            pictureBox1.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/Cart.PNG");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FitnessCat cat = new FitnessCat(userid);
            cat.Show();
            this.Close();
        }

        private void CB_Duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Duration.SelectedItem != null)
            {
                string selectedDuration = CB_Duration.SelectedItem.ToString();
                DateTime startDate = DateTime.Now;

                switch (selectedDuration)
                {
                    case "1 Month":
                        Price_TXT.Text = "750";
                        EndDate_txt.Text = startDate.AddDays(30).ToShortDateString();
                        StartDate_txt.Text = DateTime.Now.ToShortDateString();
                        break;
                    case "3 Months":
                        Price_TXT.Text = "2000";
                        EndDate_txt.Text = startDate.AddDays(90).ToShortDateString();
                        StartDate_txt.Text = DateTime.Now.ToShortDateString();
                        break;
                    case "6 Months":
                        Price_TXT.Text = "3500";
                        EndDate_txt.Text = startDate.AddDays(180).ToShortDateString();
                        StartDate_txt.Text = DateTime.Now.ToShortDateString();
                        break;
                    case "1 Year":
                        Price_TXT.Text = "6500";
                        EndDate_txt.Text = startDate.AddDays(365).ToShortDateString();
                        StartDate_txt.Text = DateTime.Now.ToShortDateString();
                        break;
                    default:
                        Price_TXT.Text = "";
                        EndDate_txt.Text = "";
                        StartDate_txt.Text = DateTime.Now.ToShortDateString();
                        break;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {
            UserService.Book(placeid, userid, DateTime.Parse(StartDate_txt.Text), DateTime.Parse(EndDate_txt.Text), decimal.Parse(Price_TXT.Text));
            dataGridView1.DataSource = UserUIService.ShowReservations(userid);
            CustomMessageBox.Show(" Resrvation Booked Successfully check " +
                "your reservations", "Success");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserCart userCart = new UserCart(userid, placeid);
            userCart.Show();
            this.Close();
        }

        private void Price_TXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
