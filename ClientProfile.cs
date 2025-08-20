using FP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class ClientProfile : UserControl
    {
        string query = "";
       
        public ClientProfile()
        {
            InitializeComponent();
        }
        DBConnection conn = new DBConnection();

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //Choose Radio Button Choice
            string rb = "";
            if (rbOne.Checked)
            {
                rb = rbOne.Text;
            }else if(rb10.Checked)
            {
                rb = rb10.Text;
            }else if(rb100.Checked)
            {
                rb = rb100.Text;
            }else if(rb1000.Checked)
            {
                rb = rb1000.Text;
            }else if(rb10000.Checked)
            {
                rb = rb10000.Text;
            }
            else
            {
                
                MessageBox.Show("Please Choose one for your company size");
               // throw new InvalidOperationException("No Choose any one");
            }
            //Insert Data into Student Profile
           
            query = "insert into client_details (client_name,company_growth,company_name,company_website) values ('" + Program.userName + "','" + rb + "','" + txtCN.Text + "','"+txtWS.Text+"')";
            //MessageBox.Show(Program.userName+" "+rb + " " + txtCN.Text + " " + txtWS.Text);
            if (conn.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
                //close connection
                conn.CloseConnection();
                ((Form)this.TopLevelControl).Close();

                Client c=new Client();
                
                c.Show();
               
               




            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rb10000_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1000_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb100_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
