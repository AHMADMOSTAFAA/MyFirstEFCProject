namespace Sportify
{
    partial class UserCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCart));
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(423, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(624, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(412, 225);
            dataGridView2.TabIndex = 1;
         
            dataGridView2.RowHeaderMouseClick += dataGridView2_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(152, 297);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Your Cart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(780, 297);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 3;
            label2.Text = "CrossFit's Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 320);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 187);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1078, 506);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "UserCart";
            Text = "User";
            Load += UserCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}