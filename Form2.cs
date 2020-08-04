using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurent
{
    public partial class Form2 : Form
    {
        string q;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "Insert into restaurent.temp select * from restaurent.cust_detail where cust_username='" + this.cust_username.Text + "';";
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
            
            string query1 = "Select cust_pass from restaurent.cust_detail where cust_username='" + this.cust_username.Text + "';";
            MySqlConnection con1 = new MySqlConnection(constring);
            MySqlCommand cmd1 = new MySqlCommand(query1, con1);
            MySqlDataReader myReader1;

            try
            {
                con1.Open();
                myReader1 = cmd1.ExecuteReader();

                while (myReader1.Read())
                {
                    q=(myReader1.GetValue(0).ToString());
                }
                //MessageBox.Show(q);
                if (q == this.cust_pass.Text)
                {
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password... Try Again or Create new account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            /*if (q == this.cust_pass.Text)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password... Try Again or Create new account");
            }*/
   
        }

       

        private void cust_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
