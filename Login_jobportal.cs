using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class Login1 : Form
    {
        User u=new User();
        public Login1()
        {
            InitializeComponent();
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void rbFreelancer_CheckedChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.userName = txtUserName.Text;
            if (u.Login(new User(txtUserName.Text, txtPw.Text)))
            {
                MessageBox.Show("Login Successsful");
                if (Program.status == "Freelancer")
                {
                    Freelancer f = new Freelancer();
                    f.Show();
                    this.Hide();
                }
                else if (Program.status == "Client")
                {
                    Client c = new Client();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Error");
                    MessageBox.Show("This status is not defined in System");
                }
            }
            else {
                MessageBox.Show("Login Fail: Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartUp s=new StartUp();
            s.Show();
            this.Hide();
        }

        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartUp s = new StartUp();
            s.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Program.userName = txtUserName.Text;
            if (u.Login(new User(txtUserName.Text, txtPw.Text)))
            {
                MessageBox.Show("Login Successsful");
                if (Program.status == "Freelancer")
                {
                    Freelancer f = new Freelancer();
                    f.Show();
                    this.Hide();
                }
                else if (Program.status == "Client")
                {
                    Client c = new Client();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Error");
                    MessageBox.Show("This status is not defined in System");
                }
            }
            else
            {
                MessageBox.Show("Login Fail: Try Again");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtPw.PasswordChar == '*')
            {
                button2.BringToFront();
                txtPw.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPw.PasswordChar == '\0')
            {
                btnOpen.BringToFront();
                txtPw.PasswordChar = '*';
            }
        }
    }
}
