namespace Sportify
{
    partial class OwnerShop
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
            dataGridView1 = new DataGridView();
            AddProduct_btn = new RoundedButton();
            UpdateProduct_btn = new RoundedButton();
            DeleteProduct = new RoundedButton();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            pName_txt = new TextBox();
            ShopID = new TextBox();
            PID_UP = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Price_Up = new NumericUpDown();
            label7 = new Label();
            Description_txt = new TextBox();
            roundedButton1 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PID_UP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Price_Up).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(458, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.BackColor = Color.FromArgb(57, 255, 20);
            AddProduct_btn.BorderRadius = 20;
            AddProduct_btn.FlatStyle = FlatStyle.Flat;
            AddProduct_btn.Font = new Font("Bauhaus 93", 9F);
            AddProduct_btn.ForeColor = Color.Black;
            AddProduct_btn.Location = new Point(502, 54);
            AddProduct_btn.Name = "AddProduct_btn";
            AddProduct_btn.Size = new Size(112, 34);
            AddProduct_btn.TabIndex = 1;
            AddProduct_btn.Text = "Add";
            AddProduct_btn.UseVisualStyleBackColor = true;
            AddProduct_btn.Click += AddProduct_btn_Click;
            // 
            // UpdateProduct_btn
            // 
            UpdateProduct_btn.BackColor = Color.FromArgb(57, 255, 20);
            UpdateProduct_btn.BorderRadius = 20;
            UpdateProduct_btn.FlatStyle = FlatStyle.Flat;
            UpdateProduct_btn.Font = new Font("Bauhaus 93", 9F);
            UpdateProduct_btn.ForeColor = Color.Black;
            UpdateProduct_btn.Location = new Point(502, 112);
            UpdateProduct_btn.Name = "UpdateProduct_btn";
            UpdateProduct_btn.Size = new Size(112, 34);
            UpdateProduct_btn.TabIndex = 2;
            UpdateProduct_btn.Text = "Update";
            UpdateProduct_btn.UseVisualStyleBackColor = true;
            UpdateProduct_btn.Click += UpdateProduct_btn_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.BackColor = Color.FromArgb(57, 255, 20);
            DeleteProduct.BorderRadius = 20;
            DeleteProduct.FlatStyle = FlatStyle.Flat;
            DeleteProduct.Font = new Font("Bauhaus 93", 9F);
            DeleteProduct.ForeColor = Color.Black;
            DeleteProduct.Location = new Point(502, 185);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(112, 34);
            DeleteProduct.TabIndex = 3;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 9F);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(139, 256);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "CrossFits Shop";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(679, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(394, 225);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 9F);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(852, 256);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 6;
            label2.Text = "CrossFits Reservations";
            // 
            // pName_txt
            // 
            pName_txt.Font = new Font("Bauhaus 93", 9F);
            pName_txt.ForeColor = SystemColors.ActiveCaptionText;
            pName_txt.Location = new Point(519, 315);
            pName_txt.Name = "pName_txt";
            pName_txt.Size = new Size(150, 34);
            pName_txt.TabIndex = 7;
            // 
            // ShopID
            // 
            ShopID.Font = new Font("Bauhaus 93", 9F);
            ShopID.ForeColor = SystemColors.ActiveCaptionText;
            ShopID.Location = new Point(809, 316);
            ShopID.Name = "ShopID";
            ShopID.Size = new Size(150, 34);
            ShopID.TabIndex = 8;
            // 
            // PID_UP
            // 
            PID_UP.Font = new Font("Bauhaus 93", 9F);
            PID_UP.ForeColor = Color.Black;
            PID_UP.Location = new Point(123, 318);
            PID_UP.Name = "PID_UP";
            PID_UP.Size = new Size(180, 34);
            PID_UP.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 9F);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(12, 316);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 10;
            label3.Text = "ProductID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(363, 318);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 11;
            label4.Text = "ProductName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(720, 318);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "ShopID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 9F);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(12, 393);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // Price_Up
            // 
            Price_Up.Font = new Font("Bauhaus 93", 9F);
            Price_Up.ForeColor = Color.Black;
            Price_Up.Location = new Point(123, 391);
            Price_Up.Name = "Price_Up";
            Price_Up.Size = new Size(180, 34);
            Price_Up.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 9F);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(363, 393);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 16;
            label7.Text = "Description";
            // 
            // Description_txt
            // 
            Description_txt.Font = new Font("Bauhaus 93", 9F);
            Description_txt.ForeColor = SystemColors.ActiveCaptionText;
            Description_txt.Location = new Point(519, 390);
            Description_txt.Name = "Description_txt";
            Description_txt.Size = new Size(150, 34);
            Description_txt.TabIndex = 15;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(57, 255, 20);
            roundedButton1.BorderRadius = 20;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Bauhaus 93", 9F);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(771, 393);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(112, 34);
            roundedButton1.TabIndex = 17;
            roundedButton1.Text = "<<";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // OwnerShop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1085, 450);
            Controls.Add(roundedButton1);
            Controls.Add(label7);
            Controls.Add(Description_txt);
            Controls.Add(label6);
            Controls.Add(Price_Up);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PID_UP);
            Controls.Add(ShopID);
            Controls.Add(pName_txt);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(DeleteProduct);
            Controls.Add(UpdateProduct_btn);
            Controls.Add(AddProduct_btn);
            Controls.Add(dataGridView1);
            Name = "OwnerShop";
            Text = "OwnerShop";
            Load += OwnerShop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PID_UP).EndInit();
            ((System.ComponentModel.ISupportInitialize)Price_Up).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RoundedButton AddProduct_btn;
        private RoundedButton UpdateProduct_btn;
        private RoundedButton DeleteProduct;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private TextBox pName_txt;
        private TextBox ShopID;
        private NumericUpDown PID_UP;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown Price_Up;
        private Label label7;
        private TextBox Description_txt;
        private RoundedButton roundedButton1;
    }
}