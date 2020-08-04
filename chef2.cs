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
    public partial class chef2 : Form
    {
        public chef2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "Select * from restaurent.ord;";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            chef c = new chef();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waiter has been Notified and Food will be served");
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";

            string query3 = "insert into restaurent.serve select * from restaurent.ord where cust_name=(select cust_name from restaurent.wait limit 1);";
            MySqlConnection con3 = new MySqlConnection(constring);
            MySqlCommand cmd3 = new MySqlCommand(query3, con3);
            MySqlDataReader myReader3;
            try
            {
                con3.Open();
                myReader3 = cmd3.ExecuteReader();

                while (myReader3.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "delete from restaurent.ord where cust_name=(select cust_name from restaurent.wait limit 1);";
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

            string query2 = "delete from restaurent.wait limit 1;";
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

        }
    }
}
