using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  Name;
            string messagetext;

            messagetext = "your name is:";

            Name = textBox1.Text;
            MessageBox.Show(messagetext+"--->"+Name);

        }
    }
}
