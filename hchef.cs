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
    public partial class hchef : Form
    {
        public hchef()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            man2 m = new man2();
            m.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "insert into restaurent.chef (waitername_name,waiter_phno,waiter_username,waiter_pass) values('" + this.cust_name.Text + "','" + this.cust_phno.Text + "','" + this.cust_username.Text + "','" + this.cust_pass.Text + "')  ;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("New Waiter Hired");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
