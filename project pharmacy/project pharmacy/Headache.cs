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
    public partial class Headache : Form
    {
        public Headache()
        {
            InitializeComponent();
        }

        int x, y, z ,n = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            Disease frm = new Disease();
            frm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Headache_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            z = 17;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            y = 20;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(x + y + z +n);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 25;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n = 30;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text="0";
            textBox3.Text = "0";

        }
    }
}
