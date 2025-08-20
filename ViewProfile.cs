using FP.Classes;
using MySql.Data.MySqlClient;
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
    public partial class ViewProfile : UserControl
    {
        public event EventHandler OnSelect = null;

        public ViewProfile()
        {
            InitializeComponent();
        }

        private string name;
        private string skill;
        private string experience;
        private string backgroundProject;
        private string portfolio;

        // Properties for each field
        public string FName { get => lblName.Text; set => lblName.Text = value; }
        public string FSkill { get => lblSkill.Text; set => lblSkill.Text = value; }
        public string Experience { get => lblExp.Text; set => lblExp.Text = value; } // New property for experience
        public string BackgroundProject { get => lblBg.Text; set => lblBg.Text = value; } // New property for background project
        public string Portfolio { get => lblPort.Text; set => lblPort.Text = value; } // New property for portfolio

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            // You can initialize or load additional data here if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void lblName_Click(object sender, EventArgs e) { }

        private void lblComplete_Click(object sender, EventArgs e) { }
    }
}
