﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppOpenCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            var myForm4 = new Form4();
            myForm4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            var myForm5 = new Form5();
            myForm5.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
