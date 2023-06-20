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
            
            for (int i = 0; i < lottery_number.Length; i++)
            {
                lottery_number[i] = i + 0;
                listBox1.Items.Add(lottery_number[i]);

            }

        }
    }
}
