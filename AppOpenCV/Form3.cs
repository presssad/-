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
    public partial class Form3 : Form
    {
        List<String> _animals = new List<String> { "cat", "carrot", "dog", "goat", "pig" };

        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            label2.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
            }
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
            }
            label2.Visible = false;
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Hide();
        }
        public void checker()
        {
            if (textBox1 != null && textBox2 !=null && textBox3 != null)
            {
                button2.Visible = true;
            }
        }
        public void phoneNumber()
        {
            if (textBox3.TextLength >= 8)
            {
                label2 = new Label();
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            checker();
        }
    }
}