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
    public partial class ProjectList : UserControl
    {
        public ProjectList()
        {
            InitializeComponent();
        }
        private string _projectName;
        private string _projectDescription;
        private double _projectBudget;
        private string _projectSkill;
        private string _projectDuration;
        


        private void ProjectList_Load(object sender, EventArgs e)
        {

            Project p = new Project();
            List<Project> project = p.GetProjects();

            //ViewProfile[] v1 = new ViewProfile[user.Count];

            for (int i = 0; i < project.Count; i++)
            {
                
                _projectName = project[i].PName;
                _projectDuration = project[i].Duration;
                _projectBudget = project[i].Budget;
                _projectSkill = project[i].Skill;
                _projectDescription = project[i].Description;
                
                AddProject(_projectName,_projectDuration, _projectBudget, _projectSkill,_projectDescription);

            }
        }

        private void AddProject(string projectName, string projectDuration, double projectBudget, string projectSkill, string projectDescription)
        {
            FLPanel.Controls.Add(new ProjectView()
            {
                PName = projectName,
                PDuration = projectDuration,
                PBudget = Convert.ToDouble(projectBudget),
                PSkill = projectSkill,
                PDescription = projectDescription,

                


            }) ;
        }

        private void FLPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
