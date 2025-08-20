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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbCharp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked C#");

        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login1 l = new Login1();
            l.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = Program.userName;
        }
    }
}
