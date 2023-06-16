using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxname.Text = "";
            if (textBoxname.Text == "")
            {
                MessageBox.Show("NAME--> MUTHU \n PH NO-->99876543123", "WARNING", MessageBoxButtons.OK);
                
            }
           
            else
            {
                MessageBox.Show("please enter your name");
                MessageBox.Show("please enter your phone number");
            }
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
