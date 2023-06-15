using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 87;
            int number2 = 44;
            int number3 = 87;

            int total = (number1+number2+number3);
            MessageBox.Show("THE TOTAL NUMBER IS--->"+total.ToString());
        }
    }
}
