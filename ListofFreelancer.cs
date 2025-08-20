using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FP.Classes; // Ensure this is included

namespace FP
{
    public partial class ListofFreelancer : UserControl
    {
        public ListofFreelancer()
        {
            InitializeComponent();
        }

        private void FlPanel1_Paint(object sender, PaintEventArgs e) { }

        public void AddFreelancer(string name, string skill, string experience, string backgroundProject, string portfolio)
        {
            FlPanel1.Controls.Add(new ViewProfile()
            {
                FName = name,
                FSkill = skill,
                Experience = experience,
                BackgroundProject = backgroundProject,
                Portfolio = portfolio
            });
        }

        private void ListofFreelancer_Load(object sender, EventArgs e)
        {
            List<FreelancerProfile> profiles = GetFreelancerProfiles();

            foreach (var profile in profiles)
            {
                AddFreelancer(profile.ProfileName, profile.ProfileSkill, profile.Experience, profile.BackgroundProject, profile.Portfolio);
            }
        }

        private List<FreelancerProfile> GetFreelancerProfiles()
        {
            var profiles = new List<FreelancerProfile>();
            string query = "SELECT profile_name, profile_skill, experience, background_project, portfolio FROM profile";
            DBConnection con = new DBConnection();

            using (var cmd = new MySqlCommand(query, con.connection))
            {
                con.OpenConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        profiles.Add(new FreelancerProfile
                        {
                            ProfileName = reader.GetString("profile_name"),
                            ProfileSkill = reader.GetString("profile_skill"),
                            Experience = reader.GetString("experience"),
                            BackgroundProject = reader.GetString("background_project"),
                            Portfolio = reader.IsDBNull(reader.GetOrdinal("portfolio")) ? null : reader.GetString("portfolio")
                        });
                    }
                }
            }
            con.CloseConnection();
            return profiles;
        }

        public class FreelancerProfile
        {
            public string ProfileName { get; set; }
            public string ProfileSkill { get; set; }
            public string Experience { get; set; }
            public string BackgroundProject { get; set; }
            public string Portfolio { get; set; }
        }
    }
}
