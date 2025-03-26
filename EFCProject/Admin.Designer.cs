namespace Sportify
{
    partial class Admin
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
            button1 = new RoundedButton();
            button2 = new RoundedButton();
            label1 = new Label();
            Name_TXT = new TextBox();
            Email_TXT = new TextBox();
            Location_TXT = new TextBox();
            ID_UP = new NumericUpDown();
            CB_Role = new ComboBox();
            button3 = new RoundedButton();
            LogOut = new RoundedButton();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ID_UP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(526, 225);
            dataGridView1.TabIndex = 7;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 255, 20);
            button1.BorderRadius = 20;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(587, 85);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Delete;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(57, 255, 20);
            button2.BorderRadius = 20;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(587, 152);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Update;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(70, 277);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // Name_TXT
            // 
            Name_TXT.Location = new Point(162, 366);
            Name_TXT.Name = "Name_TXT";
            Name_TXT.Size = new Size(150, 31);
            Name_TXT.TabIndex = 17;
            // 
            // Email_TXT
            // 
            Email_TXT.Location = new Point(431, 277);
            Email_TXT.Name = "Email_TXT";
            Email_TXT.Size = new Size(150, 31);
            Email_TXT.TabIndex = 18;
            // 
            // Location_TXT
            // 
            Location_TXT.Location = new Point(431, 366);
            Location_TXT.Name = "Location_TXT";
            Location_TXT.Size = new Size(150, 31);
            Location_TXT.TabIndex = 19;
            // 
            // ID_UP
            // 
            ID_UP.Location = new Point(132, 278);
            ID_UP.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            ID_UP.Name = "ID_UP";
            ID_UP.Size = new Size(180, 31);
            ID_UP.TabIndex = 21;
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Items.AddRange(new object[] { "Admin", "Owner", "User" });
            CB_Role.Location = new Point(716, 278);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(182, 33);
            CB_Role.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(57, 255, 20);
            button3.BorderRadius = 20;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(974, 404);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 23;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.FromArgb(57, 255, 20);
            LogOut.BorderRadius = 20;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.ForeColor = Color.Black;
            LogOut.Location = new Point(23, 404);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(112, 34);
            LogOut.TabIndex = 24;
            LogOut.Text = "LogOut";
            LogOut.UseVisualStyleBackColor = true;
            LogOut.Click += LogOut_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(739, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(526, 225);
            dataGridView2.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleGreen;
            label6.Location = new Point(191, 237);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 28;
            label6.Text = "Users";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.PaleGreen;
            label8.Location = new Point(854, 240);
            label8.Name = "label8";
            label8.Size = new Size(158, 20);
            label8.TabIndex = 30;
            label8.Text = "Owner's Centers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleGreen;
            label4.Location = new Point(358, 285);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 31;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleGreen;
            label5.Location = new Point(653, 284);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 32;
            label5.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleGreen;
            label2.Location = new Point(70, 373);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 33;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PaleGreen;
            label3.Location = new Point(340, 373);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 34;
            label3.Text = "Location";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1252, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(LogOut);
            Controls.Add(button3);
            Controls.Add(CB_Role);
            Controls.Add(ID_UP);
            Controls.Add(Location_TXT);
            Controls.Add(Email_TXT);
            Controls.Add(Name_TXT);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ID_UP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox Name_TXT;
        private TextBox Email_TXT;
        private TextBox Location_TXT;
        private NumericUpDown ID_UP;
        private ComboBox CB_Role;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label8;
        private RoundedButton button1;
        private RoundedButton button2;
        private RoundedButton button3;
        private RoundedButton LogOut;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}