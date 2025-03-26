namespace Sportify
{
    partial class CrossFit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox StartDate_txt;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox EndDate_txt;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox Price_TXT;
        private System.Windows.Forms.ComboBox CB_Duration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button backButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossFit));
            labelStartDate = new Label();
            StartDate_txt = new TextBox();
            labelEndDate = new Label();
            EndDate_txt = new TextBox();
            labelPrice = new Label();
            Price_TXT = new TextBox();
            CB_Duration = new ComboBox();
            dataGridView1 = new DataGridView();
            Book = new Button();
            backButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelStartDate
            // 
            labelStartDate.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            labelStartDate.ForeColor = Color.Lime;
            labelStartDate.Location = new Point(12, 28);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(100, 23);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Start Date:";
            // 
            // StartDate_txt
            // 
            StartDate_txt.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            StartDate_txt.ForeColor = Color.Lime;
            StartDate_txt.Location = new Point(156, 28);
            StartDate_txt.Name = "StartDate_txt";
            StartDate_txt.ReadOnly = true;
            StartDate_txt.Size = new Size(129, 34);
            StartDate_txt.TabIndex = 1;
            // 
            // labelEndDate
            // 
            labelEndDate.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            labelEndDate.ForeColor = Color.Lime;
            labelEndDate.Location = new Point(12, 80);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(100, 23);
            labelEndDate.TabIndex = 2;
            labelEndDate.Text = "End Date:";
            // 
            // EndDate_txt
            // 
            EndDate_txt.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            EndDate_txt.ForeColor = Color.Lime;
            EndDate_txt.Location = new Point(156, 80);
            EndDate_txt.Name = "EndDate_txt";
            EndDate_txt.Size = new Size(100, 34);
            EndDate_txt.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            labelPrice.ForeColor = Color.Lime;
            labelPrice.Location = new Point(12, 137);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(100, 23);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Price:";
            // 
            // Price_TXT
            // 
            Price_TXT.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Price_TXT.ForeColor = Color.Lime;
            Price_TXT.Location = new Point(156, 137);
            Price_TXT.Name = "Price_TXT";
            Price_TXT.Size = new Size(147, 34);
            Price_TXT.TabIndex = 5;
            Price_TXT.TextChanged += Price_TXT_TextChanged;
            // 
            // CB_Duration
            // 
            CB_Duration.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            CB_Duration.ForeColor = Color.Lime;
            CB_Duration.Items.AddRange(new object[] { "1 Month", "3 Months", "6 Months", "1 Year" });
            CB_Duration.Location = new Point(135, 189);
            CB_Duration.Name = "CB_Duration";
            CB_Duration.Size = new Size(168, 28);
            CB_Duration.TabIndex = 6;
            CB_Duration.SelectedIndexChanged += CB_Duration_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(383, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(400, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Book
            // 
            Book.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Book.ForeColor = Color.Lime;
            Book.Location = new Point(181, 284);
            Book.Name = "Book";
            Book.Size = new Size(75, 43);
            Book.TabIndex = 8;
            Book.Text = "Book";
            Book.Click += Book_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            backButton.ForeColor = Color.Lime;
            backButton.Location = new Point(37, 287);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 40);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            label1.Text = "Duration";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CrossFit
            // 
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(851, 400);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelStartDate);
            Controls.Add(StartDate_txt);
            Controls.Add(labelEndDate);
            Controls.Add(EndDate_txt);
            Controls.Add(labelPrice);
            Controls.Add(Price_TXT);
            Controls.Add(CB_Duration);
            Controls.Add(dataGridView1);
            Controls.Add(Book);
            Controls.Add(backButton);
            Name = "CrossFit";
            Text = "CrossFit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private PictureBox pictureBox1;
    }
}
