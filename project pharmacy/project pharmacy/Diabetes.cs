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
    public partial class Diabetes : Form
    {
        public Diabetes()
        {
            InitializeComponent();
        }
        int x, y, z, n = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text);

            textBox2.Text = Convert.ToString(x + 1);
            textBox3.Text = Convert.ToString((x + 1) * 45);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Disease frm = new Disease();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            z =25;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(x + y + z + n);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 33;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y= 40;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            n = 50;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }
    }
}
