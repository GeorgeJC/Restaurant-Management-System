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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query2 = "delete from restaurent.bill";
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

            string query = "delete from restaurent.temp";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewbill v = new viewbill();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "Select cust_name from restaurent.temp";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    textBox1.Text = myReader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback f = new feedback();
            f.Show();
        }
    }
}
