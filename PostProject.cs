using FP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class PostProject : UserControl
    {
      
        public PostProject()
        {
            InitializeComponent();
        }
        string query;
        DBConnection conn=new DBConnection();
        private void PostProject_Load(object sender, EventArgs e)
        {

        }

        private void txtBugdet_TextChanged(object sender, EventArgs e)
        {
            if(!CheckDecimalNumber(txtBugdet.Text))
            {
                MessageBox.Show("Enter decimal number only ");
            }

        }
        public Boolean CheckDecimalNumber(string text)
        {
            var regex = new Regex(@"^-?[0-9][0-9,\.]*$");
            if (regex.IsMatch(txtBugdet.Text))
            {
                return true;
            }
            return false;

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string rb = "";
            if (rbSmall.Checked)
            {
                rb = rbSmall.Text;
            }
            else if (rbMedium.Checked)
            {
                rb = rbMedium.Text;
            }
            else if (rbLarge.Checked)
            {
                rb = rbLarge.Text;
            }
           
            else
            {

                MessageBox.Show("Please Choose one for your company size");
                // throw new InvalidOperationException("No Choose any one");
            }
            query = "INSERT INTO work (work_title, work_skill, work_scope, duration, budget, description, client_name) " +
         "VALUES ('" + txtTitle.Text + "','" + txtSkill.Text + "','" + rb + "','" + txtDuration.Text + "','" + txtBugdet.Text + "','" + txtDes.Text + "','" + Program.userName + "')";

            if (conn.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project has already posted");
                //close connection
                conn.CloseConnection();
                ((Form)this.TopLevelControl).Close();

                Client c = new Client();

                c.Show();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
