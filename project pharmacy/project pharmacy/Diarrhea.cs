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
    public partial class Diarrhea : Form
    {
        public Diarrhea()
        {
            InitializeComponent();
        }
        int x, y, z = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);

            textBox2.Text = Convert.ToString(x + 1);
            textBox3.Text = Convert.ToString((x + 1) * 18.5);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Disease frm = new Disease();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Info frm = new Info();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            y = 19;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(x + y + z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 29;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            z = 35;
            int qu = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(qu + 1);
        }
    }
}
