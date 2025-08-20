using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Classes;
namespace FP
{
    public partial class ratingoverview : UserControl
    {
        DBConnection con = new DBConnection();
        overviewrating f = new overviewrating();
        public event EventHandler OnSelect = null;
        public ratingoverview()
        {
            InitializeComponent();
        }
        private string name;
        private string skill;
        public ratingoverview(string n, string s)
        {
            this.name = n;
            this.skill = s;
        }
        public string FName { get => lblName.Text; set => lblName.Text = value; }
        public string FSkill { get => lblSkill.Text; set => lblSkill.Text = value; }
        public string Completework { get => lblComplete.Text; set => lblComplete.Text = value; }
        private void ratingoverview_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                MessageBox.Show("Rating Successful");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void lblComplete_Click(object sender, EventArgs e)
        {

        }

        private void lblSkill_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
