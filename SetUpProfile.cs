using FP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class SetUpProfile : UserControl
    {
        public SetUpProfile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string query;
        DBConnection conn=new DBConnection();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!checkedNumber(textBox1.Text))
            {
                MessageBox.Show("Type only Numeric value 1,2 0r 3 etc..");
            }
        }

        private bool checkedNumber(string text)
        {
            Regex pregex = new Regex("^[0-9]*$");
            if (pregex.IsMatch(text))
            {
                return true;

            }

            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!checkedNumber(textBox2.Text))
            {
                MessageBox.Show("Type only Numeric value 1,2 0r 3 etc..");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!checkedNumber(textBox3.Text))
            {
                MessageBox.Show("Type only Numeric value 1,2 0r 3 etc..");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!checkedNumber(textBox4.Text))
            {
                MessageBox.Show("Type only Numeric value 1,2 0r 3 etc..");
            }
        }

        private void cbJava_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FreelancerSetUpProfile(string query)
        {
            if (conn.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Freelancer Profile have already created");
                //close connection
                conn.CloseConnection();
               

            }
        }

        private void txtPortfilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbJava.Checked)
            {
                query = "insert into profile ( profile_name,profile_skill,experience,background_project,portfolio) values('" + Program.userName + "','" + cbJava.Text + "','" + textBox1.Text + "','" + txtJavaPW.Text + "','" + txtPortfilo.Text + "')";
                FreelancerSetUpProfile(query);
            }
            if (cbCSharp.Checked)
            {
                query = "insert into profile ( profile_name,profile_skill,experience,background_project,portfolio) values('" + Program.userName + "','" + cbCSharp.Text + "','" + textBox2.Text + "','" + txtCsharpPW.Text + "','" + txtPortfilo.Text + "')";
                FreelancerSetUpProfile(query);
            }
            if (cbCPlusPlus.Checked)
            {
                query = "insert into profile ( profile_name,profile_skill,experience,background_project,portfolio) values('" + Program.userName + "','" + cbCPlusPlus.Text + "','" + textBox3.Text + "','" + txtCPlusPW.Text + "','" + txtPortfilo.Text + "')";
                FreelancerSetUpProfile(query);
            }
            if (cbPhP.Checked)
            {
                query = "insert into profile ( profile_name,profile_skill,experience,background_project,portfolio) values('" + Program.userName + "','" + cbPhP.Text + "','" + textBox4.Text + "','" + txtPhpPW.Text + "','" + txtPortfilo.Text + "')";
                FreelancerSetUpProfile(query);
            }

             ((Form)this.TopLevelControl).Close();

            Freelancer f = new Freelancer();

            f.Show();
        }
    }
}
