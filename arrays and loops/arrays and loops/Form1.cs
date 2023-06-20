using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays_and_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[]  lottery_number;
            lottery_number = new int [49];
            
            for (int i = 0; i< lottery_number.Length; i++)
            {
                 lottery_number[i] = i + 1;
                listBox1.Items.Add(lottery_number[i]);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            int[] arraySize;
            arraySize = new int[a];


            for (int i = 0; i != (arraySize.Length); i++)
            {

                arraySize[i] = i + 1;

                listBox1.Items.Add(arraySize[i]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] runtimes;
            runtimes = new int[10];
            int times = int.Parse(textBox1.Text);

            for(int i = 1; i != runtimes.Length; i++)
            {
                runtimes[i] = i * times;
                listBox1.Items.Add(times + "times" + i + "=" + runtimes[i]);
            }
        }
    }
}
