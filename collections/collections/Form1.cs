using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List < string > students = new List<string>();
            students.Add("BOYSSSS");
            students.Add("-----------------------------------");
            students.Add("1---muthu");
            students.Add("2---sanjay");
            students.Add("3---vicky");
            students.Add("4---abdul");

            for (int i = 0; i < students.Count; i++)
            {

                listBox1.Items.Add(students[i]);

            }
        }
    }
}
