using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_6
{
    public partial class calculator : Form
    {
        int total1=0 ;
        int total2 =0 ;
        public calculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            total1 = total1 + int.Parse(textBox1.Text);
           
            total1 = int.Parse(textBox1.Text);
            textBox1.Text = total1.ToString();
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                total2 = total1 + int.Parse(textBox1.Text);
                textBox1.Text = total2.ToString();
                total1 = 0;
            }
            catch(Exception es)
            {
                Console.WriteLine(es);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            total1 = 0;
        }
    }
}
