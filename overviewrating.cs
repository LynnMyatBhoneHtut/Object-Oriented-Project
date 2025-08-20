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
    public partial class overviewrating : UserControl
    {
        DBConnection con = new DBConnection();
        public overviewrating()
        {
            InitializeComponent();
        }
        private string _name;
        private string _skill;
        public void AddFreelancer(string name, string skill)
        {


            over_panel.Controls.Add(new ratingoverview()
            {
                FName = name,
                FSkill = skill

            });
        }
        private void overviewrating_Load(object sender, EventArgs e)
        {
            User u = new User();
            List<User> user = u.GetFreeList();
            for (int i = 0; i < user.Count; i++)
            {
                _name = user[i].Name;
                _skill = user[i].Password;
                AddFreelancer(_name, _skill);
            }
        }
    

        private void over_panel_Paint(object sender, PaintEventArgs e)
        {
       
        }
    }
}
