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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs e)
        {
            this.Hide();
            soup s = new soup();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            rice r = new rice();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            starter q = new starter();
            q.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            curry c = new curry();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bread b = new bread();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Desert d = new Desert();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
