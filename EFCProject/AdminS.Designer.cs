namespace Sportify
{
    partial class AdminS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminS));
            CB_PID = new ComboBox();
            ID_UP = new NumericUpDown();
            Name_TXT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Update_Btn = new Button();
            Delete_Btn = new Button();
            dataGridView1 = new DataGridView();
            Add_Btn = new Button();
            lable = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ID_UP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CB_PID
            // 
            CB_PID.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            CB_PID.ForeColor = Color.LimeGreen;
            CB_PID.FormattingEnabled = true;
            CB_PID.Items.AddRange(new object[] { "Admin", "Owner", "User" });
            CB_PID.Location = new Point(670, 294);
            CB_PID.Name = "CB_PID";
            CB_PID.Size = new Size(182, 28);
            CB_PID.TabIndex = 33;
            // 
            // ID_UP
            // 
            ID_UP.Font = new Font("Bauhaus 93", 9F);
            ID_UP.ForeColor = Color.LimeGreen;
            ID_UP.Location = new Point(72, 297);
            ID_UP.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            ID_UP.Name = "ID_UP";
            ID_UP.Size = new Size(180, 34);
            ID_UP.TabIndex = 32;
            // 
            // Name_TXT
            // 
            Name_TXT.ForeColor = Color.LimeGreen;
            Name_TXT.Location = new Point(382, 296);
            Name_TXT.Name = "Name_TXT";
            Name_TXT.Size = new Size(150, 31);
            Name_TXT.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(567, 302);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 28;
            label5.Text = "PlaceID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(270, 299);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 27;
            label4.Text = "Shop Name";
            // 
            // Update_Btn
            // 
            Update_Btn.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Update_Btn.ForeColor = Color.LimeGreen;
            Update_Btn.Location = new Point(527, 174);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(112, 34);
            Update_Btn.TabIndex = 25;
            Update_Btn.Text = "Update";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Delete_Btn.ForeColor = Color.LimeGreen;
            Delete_Btn.Location = new Point(527, 107);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(112, 34);
            Delete_Btn.TabIndex = 24;
            Delete_Btn.Text = "Delete";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-37, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(526, 225);
            dataGridView1.TabIndex = 23;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Add_Btn
            // 
            Add_Btn.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            Add_Btn.ForeColor = Color.LimeGreen;
            Add_Btn.Location = new Point(527, 42);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(112, 34);
            Add_Btn.TabIndex = 34;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Bauhaus 93", 9F);
            lable.ForeColor = Color.LimeGreen;
            lable.Location = new Point(12, 302);
            lable.Name = "lable";
            lable.Size = new Size(28, 20);
            lable.TabIndex = 35;
            lable.Text = "ID";
            // 
            // button1
            // 
            button1.Font = new Font("Bauhaus 93", 9F);
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(72, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 36;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(741, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 185);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // AdminS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1071, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lable);
            Controls.Add(Add_Btn);
            Controls.Add(CB_PID);
            Controls.Add(ID_UP);
            Controls.Add(Name_TXT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Update_Btn);
            Controls.Add(Delete_Btn);
            Controls.Add(dataGridView1);
            Name = "AdminS";
            Text = "AdminS";
            Load += AdminS_Load;
            ((System.ComponentModel.ISupportInitialize)ID_UP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_PID;
        private NumericUpDown ID_UP;
        private TextBox Name_TXT;
        private Label label5;
        private Label label4;
        private Button Update_Btn;
        private Button Delete_Btn;
        private DataGridView dataGridView1;
        private Button Add_Btn;
        private Label lable;
        private Button button1;
        private PictureBox pictureBox1;
    }
}