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
    public partial class viewfeed : Form
    {
        public viewfeed()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            man2 m = new man2();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query = "Select * from restaurent.feedback;";

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

    }
}

