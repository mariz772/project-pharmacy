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
    public partial class Constipation : Form
    {
        public Constipation()
        {
            InitializeComponent();
        }
        Disease frm = new Disease();

        private void button2_Click_2(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x = int.Parse(textBox2.Text);
            textBox2.Text = Convert.ToString(x + 1);
            textBox3.Text = Convert.ToString((x + 1) * 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
