﻿using System;
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
    public partial class Presure : Form
    {
        public Presure()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text);

            textBox2.Text = Convert.ToString(x + 1);
            textBox3.Text = Convert.ToString((x + 1) * 25);
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
    }
}
