namespace Sportify
{
    partial class UserUI
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedButton ViewReservations;
        private RoundedButton button1;
        private System.Windows.Forms.DataGridView dataGridView1;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            ViewReservations = new RoundedButton();
            button1 = new RoundedButton();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            roundedButton1 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ViewReservations
            // 
            ViewReservations.BackColor = Color.FromArgb(57, 255, 20);
            ViewReservations.BorderRadius = 20;
            ViewReservations.FlatStyle = FlatStyle.Flat;
            ViewReservations.Font = new Font("Bauhaus 93", 9F);
            ViewReservations.ForeColor = Color.White;
            ViewReservations.Location = new Point(62, 31);
            ViewReservations.Margin = new Padding(4, 5, 4, 5);
            ViewReservations.Name = "ViewReservations";
            ViewReservations.Size = new Size(150, 47);
            ViewReservations.TabIndex = 0;
            ViewReservations.Text = "View Reservations";
            ViewReservations.UseVisualStyleBackColor = true;
            ViewReservations.Click += ViewReservations_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 255, 20);
            button1.BorderRadius = 20;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(465, 31);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 1;
            button1.Text = "Select Sport";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Lime;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Lime;
            dataGridView1.Location = new Point(62, 109);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(625, 469);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(742, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(57, 255, 20);
            roundedButton1.BorderRadius = 20;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(726, 518);
            roundedButton1.Margin = new Padding(4, 5, 4, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(150, 47);
            roundedButton1.TabIndex = 5;
            roundedButton1.Text = "Logout";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // UserUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(902, 625);
            Controls.Add(roundedButton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ViewReservations);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserUI";
            Text = "User Dashboard";
            Load += UserUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RoundedButton roundedButton1;
    }
}
