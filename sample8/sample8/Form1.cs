using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncompare_Click(object sender, EventArgs e)
        {
            int firstnum;
            int secondnum;

            firstnum = int.Parse(textBox1.Text);
            secondnum = int.Parse(textBox2.Text);

            if (firstnum > secondnum)
            {
                MessageBox.Show("first number is greater then second number", "RESULT BOX", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("first number is less than second number", "RESULTBOX", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            
           

            }
        }

            
                    

            
        }
    

