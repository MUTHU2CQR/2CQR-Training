using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number1;
            int number2;
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox1.Text);
            Add(number1,number2);


        }
        private int Subract(int firstnum,int secondnum)
        {
            int answer;
            answer = firstnum - secondnum;
            return answer;
        }
        void Add(int firstnum,int secondnum)
        {
            int answer;
            answer = firstnum + secondnum;
            MessageBox.Show(answer.ToString());

            return;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnvalue = 0;
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox1.Text);
            returnvalue = Subract(number1,number2);
            MessageBox.Show(returnvalue.ToString());

        }
    }
}
