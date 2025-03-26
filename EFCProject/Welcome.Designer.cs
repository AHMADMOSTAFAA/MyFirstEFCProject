namespace EFCProject
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private RoundedButton btnLogin;

        private System.Windows.Forms.Button btnRegister;

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
            lblTitle = new Label();
            btnLogin = new RoundedButton();
            btnRegister = new RoundedButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 36F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(250, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(355, 101);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sportify";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(300, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 50);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(300, 280);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 50);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sportify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

