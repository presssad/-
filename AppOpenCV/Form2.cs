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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            var myForm1 = new Form1();
            myForm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.msg2092552260_75108;
            pictureBox1.Location = new System.Drawing.Point(36, 85);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.msg2092552260_75113;
            pictureBox2.Location = new System.Drawing.Point(36, 85);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox3.Image = Properties.Resources.msg2092552260_75112;
            pictureBox3.Location = new System.Drawing.Point(36, 85);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox4.Image = Properties.Resources.msg2092552260_75114;
            pictureBox4.Location = new System.Drawing.Point(36, 85);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            checker();
        }
        public void checker()
        {
            if (textBox1 != null && textBox2 != null )
            {
                button6.Visible = true;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
