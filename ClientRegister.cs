using System;
using System.Windows.Forms;

namespace FP
{
    public partial class ClientRegister : Form
    {
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User(txtUserName.Text, txtPassword.Text, txtEmail.Text, "Client");

            // Check if the required fields are filled
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Username, Password, and Email", "Warning");
            }
            else
            {
                // Check if the user already exists
                if (u.DuplicateUser(txtUserName.Text))
                {
                    MessageBox.Show("User already exists");
                }
                // Check if passwords match
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                // Validate password
                else if (!User.ValidatePassword(txtPassword.Text))
                {
                    MessageBox.Show("Password must be 8 to 12 characters long and contain at least one uppercase letter and one lowercase letter!");
                }
                else
                {
                    // Register the user
                    u.Register(u);
                    MessageBox.Show("User registered successfully!");

                    // Redirect to login page
                    Login1 l = new Login1();
                    l.Show();
                    this.Hide();
                }
            }
        }

        // Code to toggle password visibility
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnClose.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnOpen.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
            {
                button2.BringToFront();
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        // Password validation as user types
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!User.ValidatePassword(txtPassword.Text)) // Call the static method from User class
            {
                lblCheck.Visible = true;
                lblCheck.Text = "At least one upper and lower case letter\n between 8 and 12 characters";
            }
            else
            {
                lblCheck.Visible = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientRegister_Load(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            StartUp s = new StartUp();
            s.Show();
            this.Hide();
        }
    }
}
