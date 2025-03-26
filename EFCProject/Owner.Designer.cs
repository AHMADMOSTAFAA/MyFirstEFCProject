namespace Sportify
{
    partial class Owner
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Center1 = new Label();
            Center2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            AddProduct_btn = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 209);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(377, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 209);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(747, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 209);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Center1
            // 
            Center1.AutoSize = true;
            Center1.Font = new Font("Bauhaus 93", 9F);
            Center1.ForeColor = Color.Lime;
            Center1.Location = new Point(47, 316);
            Center1.Name = "Center1";
            Center1.Size = new Size(78, 20);
            Center1.TabIndex = 3;
            Center1.Text = "Cross Fit";
            // 
            // Center2
            // 
            Center2.AutoSize = true;
            Center2.Font = new Font("Bauhaus 93", 9F);
            Center2.ForeColor = Color.Lime;
            Center2.Location = new Point(463, 316);
            Center2.Name = "Center2";
            Center2.Size = new Size(79, 20);
            Center2.TabIndex = 4;
            Center2.Text = "2Fit Gym";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 9F);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(775, 316);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 5;
            label3.Text = "Add A new place";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(377, 399);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(228, 209);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.BackColor = Color.FromArgb(57, 255, 20);
            AddProduct_btn.BorderRadius = 20;
            AddProduct_btn.FlatStyle = FlatStyle.Flat;
            AddProduct_btn.Font = new Font("Bauhaus 93", 9F);
            AddProduct_btn.ForeColor = Color.Black;
            AddProduct_btn.Location = new Point(73, 622);
            AddProduct_btn.Name = "AddProduct_btn";
            AddProduct_btn.Size = new Size(112, 34);
            AddProduct_btn.TabIndex = 7;
            AddProduct_btn.Text = "Logout";
            AddProduct_btn.UseVisualStyleBackColor = true;
            AddProduct_btn.Click += AddProduct_btn_Click;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1000, 703);
            Controls.Add(AddProduct_btn);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(Center2);
            Controls.Add(Center1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Owner";
            Text = "Owner";
            Load += Owner_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Center1;
        private Label Center2;
        private Label label3;
        private PictureBox pictureBox4;
        private RoundedButton AddProduct_btn;
    }
}
