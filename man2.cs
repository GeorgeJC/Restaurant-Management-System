using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent
{
    public partial class man2 : Form
    {
        public man2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            viewfeed m = new viewfeed();
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager m = new manager();
            m.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            status m = new status();
            m.Show();
        }

        private void man2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            hwait h = new hwait();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hire h = new hire();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            hchef h = new hchef();
            h.Show();
        }
    }
}
