using Sportify.TextBoxes;

namespace Sportify
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox username;
        private RoundedTextBox password;
        private System.Windows.Forms.Button Login_btn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new RoundedTextBox();
            password = new RoundedTextBox();
            Login_btn = new RoundedButton();
            button1 = new RoundedButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // username
            username.Font = new Font("Arial", 12F);
            username.Location = new Point(300, 216);
            username.Name = "username";
            username.Size = new Size(200, 35);
            username.TabIndex = 0;
            username.PlaceholderText = "Username";

            // password
            password.Font = new Font("Arial", 12F);
            password.Location = new Point(300, 296);
            password.Name = "password";
            password.Size = new Size(200, 35);
            password.TabIndex = 1;
            password.PlaceholderText = "Password";
            password.UseSystemPasswordChar = true;

            // Login_btn
            Login_btn.BackColor = Color.FromArgb(52, 152, 219);
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold);
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(342, 359);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(100, 40);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;

            // button1
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 398);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 3;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // pictureBox1
            pictureBox1.BackColor = Color.FromArgb(10, 26, 36);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 165);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;

            // Login
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(Login_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button button1;
        private PictureBox pictureBox1;
    }
}

