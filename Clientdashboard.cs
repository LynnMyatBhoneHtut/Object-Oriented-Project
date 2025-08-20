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
    public partial class Client : Form
    {
        User u = new User();
        public Client()
        {
            InitializeComponent();
        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new ClientProfile() { Dock = DockStyle.Fill };
            CLPanel1.Controls.Add(uc);
            CLPanel1.Visible = true;
            uc.BringToFront();
        }

        private void postProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new PostProject() { Dock = DockStyle.Fill };
            CLPanel1.Controls.Add(uc);
            CLPanel1.Visible = true;
                     
            uc.BringToFront();

        }

        private void viewFreelancerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new ListofFreelancer();
            CLPanel1.Controls.Add(uc);
            CLPanel1.Visible = true;
            uc.BringToFront();

        }

        private void reviewAndRatingProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new overviewrating()  { Dock = DockStyle.Fill};
            CLPanel1.Controls.Add(uc);
            CLPanel1.Visible = true;
            uc.BringToFront();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += " "+Program.userName;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void CLPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
