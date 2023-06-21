using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = textBox1.Text;
            textBox1.Text = var.ToUpper();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string trim = textBox2.Text;
            trim = trim.TrimEnd(' ');
            int stringlength = trim.Length;
            MessageBox.Show(stringlength.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string var2 = "muthu";
            if (var2.Contains('m'))
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oldString = "muthu";

            MessageBox.Show(oldString);

            string newString = oldString.Remove(2,3);

            MessageBox.Show(newString.ToString());
        }
    }
}
