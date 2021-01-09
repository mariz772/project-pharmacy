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

            int x = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(x + 1);
            textBox3.Text = Convert.ToString((x + 1) * 17);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int y = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(y + 1);
            textBox3.Text = Convert.ToString((y + 1) * 20);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int z = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(z + 1);
            textBox3.Text = Convert.ToString((z + 1) * 25);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int n = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(n + 1);
            textBox3.Text = Convert.ToString((n + 1) * 30);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
