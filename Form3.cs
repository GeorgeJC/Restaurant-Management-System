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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "insert into restaurent.cust_detail (cust_name,cust_phno,cust_email,cust_username,cust_pass) values('" + this.cust_name.Text + "','" + this.cust_phno.Text + "','" + this.cust_email.Text + "','" + this.cust_username.Text + "','" + this.cust_pass.Text + "')  ;";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Account Created");
                while(myReader.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query2 = "insert into restaurent.temp (cust_name,cust_phno,cust_email,cust_username,cust_pass) values('" + this.cust_name.Text + "','" + this.cust_phno.Text + "','" + this.cust_email.Text + "','" + this.cust_username.Text + "','" + this.cust_pass.Text + "')  ;";
            MySqlConnection con1 = new MySqlConnection(constring);
            MySqlCommand cmd1 = new MySqlCommand(query2, con1);
            MySqlDataReader myReader1;
            try
            {
                con1.Open();
                myReader1 = cmd1.ExecuteReader();
                
                while (myReader1.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void cust_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
