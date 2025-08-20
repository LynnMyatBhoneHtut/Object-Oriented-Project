using K4os.Compression.LZ4.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (client.Checked)
            {
                Program.status = "Client";
                ClientRegister cr = new ClientRegister();
                cr.Show();
                this.Hide();
            }
            else if (freelancer.Checked)
            {
                Program.status = "Freelancer";
                FRegister register = new FRegister();
                register.Show();
                this.Hide();
            }
           
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            
            btnSignUp.Enabled = false;
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client.Checked)
            {
                Program.status = "Client";
                Login1 login1 = new Login1();
                login1.Show();
                this.Hide();
            }
            else if (freelancer.Checked)
            {
                Program.status = "Freelancer";
                Login1 login1 = new Login1();
                login1.Show();
                this.Hide();
            }
            
        }

        private void client_CheckedChanged(object sender, EventArgs e)
        {
            
            btnSignUp.Enabled = true;
            lblLogin.Enabled = true;
        }

        private void freelancer_CheckedChanged(object sender, EventArgs e)
        {
            
            btnSignUp.Enabled = true;
            lblLogin.Enabled = true;

        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
