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
    public partial class FitnessCat : Form
    {
        public int userid;
        public int placeid;
        DBContext dbContext = new DBContext();
        public FitnessCat(int id)
        {
            var pid = dbContext.placeOfInterests.Where(p => p.PName == "Cross Fit").Select(p => p.Id).FirstOrDefault();
            InitializeComponent();
            userid = id;
            placeid = pid;
        }

        private void CrossFit_Click_Click(object sender, EventArgs e)
        {
            CrossFit crossFit = new CrossFit(userid, placeid);
            crossFit.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportCategory cat = new SportCategory(userid);
            cat.Show();
            this.Close();
        }

        private void FitnessCat_Load(object sender, EventArgs e)
        {
            CrossFit.Image=Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/CrossFit.PNG");
            FitGym.Image = Image.FromFile("C:/Users/DR/Desktop/ITI/EFC/EFCProject/EFCProject/Resources/2fit.JPG");

        }
    }
}
