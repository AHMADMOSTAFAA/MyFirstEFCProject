namespace Sportify
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedButton User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.ComboBox CB_Role;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private RoundedButton Register_btn;
        private RoundedButton Back;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            dataGridView1 = new DataGridView();
            User = new RoundedButton();
            label5 = new Label();
            UName = new TextBox();
            Password = new TextBox();
            Location = new TextBox();
            CB_Role = new ComboBox();
            Email = new TextBox();
            label1 = new Label();
            Register_btn = new RoundedButton();
            Back = new RoundedButton();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(603, 225);
            dataGridView1.TabIndex = 0;
            // 
            // User
            // 
            User.BackColor = Color.DodgerBlue;
            User.BorderRadius = 20;
            User.FlatStyle = FlatStyle.Flat;
            User.ForeColor = Color.White;
            User.Location = new Point(48, 274);
            User.Name = "User";
            User.Size = new Size(112, 34);
            User.TabIndex = 1;
            User.Text = "User";
            User.UseVisualStyleBackColor = true;
            User.Click += User_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(697, 300);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Role";
            // 
            // UName
            // 
            UName.Location = new Point(825, 27);
            UName.Name = "UName";
            UName.Size = new Size(150, 31);
            UName.TabIndex = 7;
            // 
            // Password
            // 
            Password.Location = new Point(825, 94);
            Password.Name = "Password";
            Password.Size = new Size(150, 31);
            Password.TabIndex = 8;
            Password.TextChanged += textBox2_TextChanged;
            // 
            // Location
            // 
            Location.Location = new Point(825, 159);
            Location.Name = "Location";
            Location.Size = new Size(150, 31);
            Location.TabIndex = 9;
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Items.AddRange(new object[] { "User", "Admin", "Owner" });
            CB_Role.Location = new Point(825, 292);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(182, 33);
            CB_Role.TabIndex = 10;
            CB_Role.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Email
            // 
            Email.Location = new Point(825, 228);
            Email.Name = "Email";
            Email.Size = new Size(150, 31);
            Email.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(689, 234);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.DodgerBlue;
            Register_btn.BorderRadius = 20;
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(814, 381);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(112, 34);
            Register_btn.TabIndex = 13;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.DodgerBlue;
            Back.BorderRadius = 20;
            Back.FlatStyle = FlatStyle.Flat;
            Back.ForeColor = Color.White;
            Back.Location = new Point(57, 424);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 14;
            Back.Text = "<<";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 202);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(697, 170);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 16;
            label6.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(689, 101);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(697, 27);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 18;
            label3.Text = "Name";
            // 
            // Register
            // 
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1299, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(Back);
            Controls.Add(Register_btn);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(CB_Role);
            Controls.Add(Location);
            Controls.Add(Password);
            Controls.Add(UName);
            Controls.Add(label5);
            Controls.Add(User);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label6;
        private Label label2;
        private Label label3;
    }
}
