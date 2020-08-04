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
    public partial class manager : Form
    {
        string q;
        public manager()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=Localhost;port=3306;username=root;password=karadi8015";
            string query1 = "Select man_pass from restaurent.manager where man_username='" + this.man_username.Text + "';";
            MySqlConnection con1 = new MySqlConnection(constring);
            MySqlCommand cmd1 = new MySqlCommand(query1, con1);
            MySqlDataReader myReader1;

            try
            {
                con1.Open();
                myReader1 = cmd1.ExecuteReader();

                while (myReader1.Read())
                {
                    q = (myReader1.GetValue(0).ToString());
                }
                //MessageBox.Show(q);
                if (q == this.man_pass.Text)
                {
                    this.Hide();
                    man2 f4 = new man2();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password... Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
