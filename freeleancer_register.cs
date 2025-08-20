using System;
using System.Windows.Forms;

namespace FP
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void FSignUp_Click(object sender, EventArgs e)
        {
            User u1 = new User(txtUserName.Text, txtPW.Text, txtEmail.Text, "Freelancer");

            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPW.Text) ||
                string.IsNullOrWhiteSpace(txtCPW.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Username and Password", "Warning");
            }
            else
            {
                if (u1.DuplicateUser(txtUserName.Text))
                {
                    MessageBox.Show("User already exists");
                }
                else if (txtPW.Text != txtCPW.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else if (!User.ValidatePassword(txtPW.Text)) // Call the static method from User class
                {
                    MessageBox.Show("Password must be 8 to 12 characters long and contain at least one uppercase letter and one lowercase letter!");
                }
                else
                {
                    u1.Register(u1); // Register the user
                    Login1 l = new Login1();
                    l.Show();
                    this.Hide();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtPW.PasswordChar == '*')
            {
                btnClose.BringToFront();
                txtPW.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtPW.PasswordChar == '\0')
            {
                btnOpen.BringToFront();
                txtPW.PasswordChar = '*';
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (txtCPW.PasswordChar == '*')
            {
                btn_close1.BringToFront();
                txtCPW.PasswordChar = '\0';
            }
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            if (txtCPW.PasswordChar == '\0')
            {
                btn_open.BringToFront();
                txtCPW.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartUp s = new StartUp();
            s.Show();
            this.Hide();
        }

        private void FRegister_Load(object sender, EventArgs e) { }
    }
}
