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
    public partial class Disease : Form
    {
        public Disease()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Headache frm = new Headache();
            this.Hide();
            frm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Disease_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Fever frm = new Fever();
            frm.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Constipation frm = new Constipation();
            frm.Show();
            this.Hide();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Pressure frm = new Pressure();
            frm.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Diabetes frm = new Diabetes();
            frm.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Diarrhea frm = new Diarrhea();
            this.Hide();
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Info frm = new Info ();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p_skin frm = new p_skin();
            frm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            p_hair frm = new p_hair();
            frm.Show();
            this.Hide();
        }
    }
}
