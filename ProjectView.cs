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
    public partial class ProjectView : UserControl
    {
        public ProjectView()
        {
            InitializeComponent();
        }
        public string PName { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string PDuration { get => lblDuration.Text; set => lblDuration.Text = value; }
        public double PBudget { get => Convert.ToDouble(lblBudget.Text); set => lblBudget.Text = value.ToString(); }
        public string PSkill { get => label5.Text; set => label5.Text = value; }
        public string PDescription { get => lblDescription.Text; set => lblDescription.Text = value; }

                                                                                                                                                                                
        private void btnBid_Click(object sender, EventArgs e)
        { 
            BidProject bid=new BidProject();
            bid.Show();
            
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {

        }

        private void btnBid_Click_1(object sender, EventArgs e)
        {
            BidProject bidProject=new BidProject();
            bidProject.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
