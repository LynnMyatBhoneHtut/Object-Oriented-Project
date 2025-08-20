using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FP
{
    public partial class Freelancer : Form
    {
        public Freelancer()
        {
            InitializeComponent();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new Dashboard() { Dock = DockStyle.Fill };
            flpanel.Controls.Add(uc);
            flpanel.Visible = true;
            uc.BringToFront();
        }

        private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new SetUpProfile() { Dock = DockStyle.Fill };
            flpanel.Controls.Add(uc);
            flpanel.Visible = true;
            uc.BringToFront();
        }

        private void Freelancer_Load(object sender, EventArgs e)
        {
            lblUser.Text = Program.userName;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {    
            Login1 l = new Login1();
            l.Show();
            this.Hide();
        }

        private void manageOngoingProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uc = new ProjectList() { Dock = DockStyle.Fill };
            flpanel.Controls.Add(uc);
            flpanel.Visible = true;
            uc.BringToFront();

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void flpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
