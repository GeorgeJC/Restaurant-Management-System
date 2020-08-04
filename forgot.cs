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

namespace Restaurent
{
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "update restaurent.cust_detail set password='"+this.cust_pass.Text+"' where cust_phno='"+this.cust_username.Text+"';" ;
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            int a = 0;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
