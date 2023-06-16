using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample10
{
    public partial class Form1 : Form
    {
        int loopstart;
        int endloop;
        string answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loopstart = int.Parse(textBox1.Text);
            endloop = int.Parse(textBox2.Text);
            for(int i =loopstart; i <= endloop; i++)
            {
                answer = answer + i;
            }
            MessageBox.Show(answer.ToString());
        }
    }
}
