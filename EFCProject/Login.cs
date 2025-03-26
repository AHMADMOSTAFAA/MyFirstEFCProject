using EFCProject;
using Sportify.DAL.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sportify
{
    public partial class Login : Form
    {
        DBContext dbContext = new DBContext();

        public Login()
        {
            InitializeComponent();

            // Create custom login button
            RoundedButton customLoginButton = new RoundedButton();
            customLoginButton.Text = "Login";
            customLoginButton.BorderRadius = 15;
            customLoginButton.Location = Login_btn.Location;  // assuming Login_btn is the original button from the designer
            customLoginButton.Size = Login_btn.Size;
            customLoginButton.Click += Login_btn_Click;

            // Create custom back button
            RoundedButton customBackButton = new RoundedButton();
            customBackButton.Text = "Back";
            customBackButton.BorderRadius = 15;
            customBackButton.Location = button1.Location;  // assuming button1 is the original back button
            customBackButton.Size = button1.Size;
            customBackButton.Click += button1_Click;

            // Remove the old buttons from the form and add the new ones
            this.Controls.Remove(Login_btn);
            this.Controls.Remove(button1);
            this.Controls.Add(customLoginButton);
            this.Controls.Add(customBackButton);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
  
            var log = dbContext.users.FirstOrDefault(u => u.Name == username.TextValue && u.Password == password.TextValue);
            if (log != null)
            {
                // Show welcome message using the custom message box
                CustomMessageBox.Show($"Welcome {username.Text}", "Welcome", MessageBoxType.Success);

                if (log.Role == "Admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
                else if (log.Role == "User")
                {
                    UserUI userUI = new UserUI(log.Id);
                    userUI.Show();
                    this.Close();
                }
                else if (log.Role == "Owner")
                {
                    Owner owner = new Owner(log.Id);
                    owner.Show();
                    this.Close();
                }
            }
            else
            {
                // Show error message using the custom message box
                CustomMessageBox.Show("Invalid username or password", "Error", MessageBoxType.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }
    }
}

