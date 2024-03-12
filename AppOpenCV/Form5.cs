using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppOpenCV
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            comboBox1.Visible = true;
            comboBox1.Location = new System.Drawing.Point(255, 158);
            button1.Location = new System.Drawing.Point(259, 118);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            comboBox3.Visible = true;
            comboBox3.Location = new System.Drawing.Point(255, 158);
            button2.Location = new System.Drawing.Point(259, 118);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            comboBox3.Visible = true;
            comboBox3.Location = new System.Drawing.Point(255, 158);
            button3.Location = new System.Drawing.Point(259, 118);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            comboBox4.Visible = true;
            comboBox4.Location = new System.Drawing.Point(255, 158);
            button4.Location = new System.Drawing.Point(259, 118);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox4.Visible = false;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;

            {
                checker();
            }
        }
        public void checker()
        {
            if (textBox1 != null )
            {
                button5.Visible = true;
            }
        }
    }
}