using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pharmacy
{
    public partial class p_hair : Form
    {
        public p_hair()
        {
            InitializeComponent();
        }
        int x, y, z, n = 0;
        private void p_hair_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Disease frm = new Disease();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            n = 35;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            x = 50;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(x + y + z + n );
        }

        private void button5_Click(object sender, EventArgs e)
        {

            y = 120;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            z = 40;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
