namespace Sportify
{
    partial class AdminP
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
            CB_Owner = new ComboBox();
            ID_UP = new NumericUpDown();
            Name_TXT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Label2 = new Label();
            label1 = new Label();
            Update = new RoundedButton();
            Delete = new RoundedButton();
            dataGridView1 = new DataGridView();
            Add_Btn = new RoundedButton();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            Co_Txt = new TextBox();
            label7 = new Label();
            CB_Category = new ComboBox();
            C = new Label();
            Ad_TXT = new TextBox();
            label3 = new Label();
            RoundedButton3 = new RoundedButton();
            RoundedButton4 = new RoundedButton();
            Img_txt = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)ID_UP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // CB_Owner
            // 
            CB_Owner.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            CB_Owner.ForeColor = Color.LawnGreen;
            CB_Owner.FormattingEnabled = true;
            CB_Owner.Location = new Point(693, 286);
            CB_Owner.Name = "CB_Owner";
            CB_Owner.Size = new Size(182, 28);
            CB_Owner.TabIndex = 36;
            // 
            // ID_UP
            // 
            ID_UP.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            ID_UP.ForeColor = Color.LawnGreen;
            ID_UP.Location = new Point(81, 293);
            ID_UP.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            ID_UP.Name = "ID_UP";
            ID_UP.Size = new Size(180, 34);
            ID_UP.TabIndex = 35;
            // 
            // Name_TXT
            // 
            Name_TXT.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Name_TXT.ForeColor = Color.LawnGreen;
            Name_TXT.Location = new Point(399, 293);
            Name_TXT.Name = "Name_TXT";
            Name_TXT.Size = new Size(150, 34);
            Name_TXT.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label5.ForeColor = Color.LawnGreen;
            label5.Location = new Point(588, 291);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 31;
            label5.Text = "Owner";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label4.ForeColor = Color.LawnGreen;
            label4.Location = new Point(305, 296);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 30;
            label4.Text = "Name";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(-158, 388);
            Label2.Name = "Label2";
            Label2.Size = new Size(59, 25);
            Label2.TabIndex = 28;
            Label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-144, 299);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(57, 255, 20);
            Update.BorderRadius = 20;
            Update.FlatStyle = FlatStyle.Flat;
            Update.ForeColor = Color.Black;
            Update.Location = new Point(607, 212);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 26;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(57, 255, 20);
            Delete.BorderRadius = 20;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.ForeColor = Color.Black;
            Delete.Location = new Point(607, 113);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 25;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(526, 225);
            dataGridView1.TabIndex = 23;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Add_Btn
            // 
            Add_Btn.BackColor = Color.FromArgb(57, 255, 20);
            Add_Btn.BorderRadius = 20;
            Add_Btn.FlatStyle = FlatStyle.Flat;
            Add_Btn.ForeColor = Color.Black;
            Add_Btn.Location = new Point(607, 31);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(112, 34);
            Add_Btn.TabIndex = 37;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(770, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(478, 225);
            dataGridView2.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label6.ForeColor = Color.LawnGreen;
            label6.Location = new Point(12, 294);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 39;
            label6.Text = "Id";
            // 
            // Co_Txt
            // 
            Co_Txt.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Co_Txt.ForeColor = Color.LawnGreen;
            Co_Txt.Location = new Point(132, 361);
            Co_Txt.Name = "Co_Txt";
            Co_Txt.Size = new Size(150, 34);
            Co_Txt.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label7.ForeColor = Color.LawnGreen;
            label7.Location = new Point(3, 364);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 40;
            label7.Text = "Coordinates";
            // 
            // CB_Category
            // 
            CB_Category.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            CB_Category.ForeColor = Color.LawnGreen;
            CB_Category.FormattingEnabled = true;
            CB_Category.Items.AddRange(new object[] { "Self Defence", "Fitness", "Power Lifting", "Athelitics" });
            CB_Category.Location = new Point(417, 361);
            CB_Category.Name = "CB_Category";
            CB_Category.Size = new Size(182, 28);
            CB_Category.TabIndex = 42;
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            C.ForeColor = Color.LawnGreen;
            C.Location = new Point(315, 367);
            C.Name = "C";
            C.Size = new Size(94, 20);
            C.TabIndex = 43;
            C.Text = "Category";
            // 
            // Ad_TXT
            // 
            Ad_TXT.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Ad_TXT.ForeColor = Color.LawnGreen;
            Ad_TXT.Location = new Point(756, 361);
            Ad_TXT.Name = "Ad_TXT";
            Ad_TXT.Size = new Size(150, 34);
            Ad_TXT.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label3.ForeColor = Color.LawnGreen;
            label3.Location = new Point(627, 364);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 44;
            label3.Text = "Address";
            // 
            // RoundedButton3
            // 
            RoundedButton3.BackColor = Color.FromArgb(57, 255, 20);
            RoundedButton3.BorderRadius = 20;
            RoundedButton3.FlatStyle = FlatStyle.Flat;
            RoundedButton3.ForeColor = Color.Black;
            RoundedButton3.Location = new Point(964, 404);
            RoundedButton3.Name = "RoundedButton3";
            RoundedButton3.Size = new Size(112, 34);
            RoundedButton3.TabIndex = 46;
            RoundedButton3.Text = ">>";
            RoundedButton3.UseVisualStyleBackColor = true;
            RoundedButton3.Click += button3_Click;
            // 
            // RoundedButton4
            // 
            RoundedButton4.BackColor = Color.FromArgb(57, 255, 20);
            RoundedButton4.BorderRadius = 20;
            RoundedButton4.FlatStyle = FlatStyle.Flat;
            RoundedButton4.ForeColor = Color.Black;
            RoundedButton4.Location = new Point(40, 404);
            RoundedButton4.Name = "RoundedButton4";
            RoundedButton4.Size = new Size(112, 34);
            RoundedButton4.TabIndex = 47;
            RoundedButton4.Text = "<<";
            RoundedButton4.UseVisualStyleBackColor = true;
            RoundedButton4.Click += button4_Click;
            // 
            // Img_txt
            // 
            Img_txt.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Img_txt.ForeColor = Color.LawnGreen;
            Img_txt.Location = new Point(1018, 294);
            Img_txt.Name = "Img_txt";
            Img_txt.Size = new Size(150, 34);
            Img_txt.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label8.ForeColor = Color.LawnGreen;
            label8.Location = new Point(898, 294);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 48;
            label8.Text = "Img Url";
            // 
            // AdminP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1412, 450);
            Controls.Add(Img_txt);
            Controls.Add(label8);
            Controls.Add(RoundedButton4);
            Controls.Add(RoundedButton3);
            Controls.Add(Ad_TXT);
            Controls.Add(label3);
            Controls.Add(C);
            Controls.Add(CB_Category);
            Controls.Add(Co_Txt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(Add_Btn);
            Controls.Add(CB_Owner);
            Controls.Add(ID_UP);
            Controls.Add(Name_TXT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Label2);
            Controls.Add(label1);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(dataGridView1);
            Name = "AdminP";
            Text = "AdminP";
            Load += AdminP_Load;
            ((System.ComponentModel.ISupportInitialize)ID_UP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Owner;
        private NumericUpDown ID_UP;
        private TextBox Name_TXT;
        private Label label5;
        private Label label4;
        private Label Label2;
        private Label label1;
        private RoundedButton Update;
        private RoundedButton Delete;
        private DataGridView dataGridView1;
        private RoundedButton Add_Btn;
        private DataGridView dataGridView2;
        private Label label6;
        private TextBox Co_Txt;
        private Label label7;
        private ComboBox CB_Category;
        private Label C;
        private TextBox Ad_TXT;
        private Label label3;
        private RoundedButton RoundedButton3;
        private RoundedButton RoundedButton4;
        private TextBox Img_txt;
        private Label label8;
    }
}