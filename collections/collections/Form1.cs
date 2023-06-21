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
            students.Add("---muthu");
            students.Add("---sanjay");
            students.Add("---vicky");
            students.Add("---abdul");

            for (int i = 0; i < students.Count; i++)
            {

                listBox1.Items.Add(students[i]);

            }
            students.Add("vishali");
            listBox1.Items.Add("Add new person---" + students[6]);

           students.Sort();
            listBox1.Items.Add("=============================");
            for(int i = 0; i < students.Count; i++)
            {
                listBox1.Items.Add("after sorting---" + students[i]);
            }
            students.Remove("vishali");
            listBox1.Items.Add(students[6]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
