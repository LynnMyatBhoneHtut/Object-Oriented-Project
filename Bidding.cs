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
using MySql.Data.MySqlClient;
namespace FP
{
    public partial class BidProject : Form
    {
        public BidProject()
        {
            InitializeComponent();
        }
        string query;
        DBConnection conn = new DBConnection();
        private void BidProject_Load(object sender, EventArgs e)
        {

        }

        private void txtPortfilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "insert into quotation(person_name,quotation) values('" + Program.userName + "','" + txtProposal.Text + "')";
            if (conn.OpenConnection() == true)
            {
              
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
            
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your quotation is Submited.");
           
                conn.CloseConnection();
                ((Form)this.TopLevelControl).Close();
                Freelancer c = new Freelancer();
                c.Show();
            }
        }
    }
}
