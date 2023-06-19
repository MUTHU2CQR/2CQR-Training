using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emptable
{
    public partial class Form1 : Form
    {
        string conn = "server = DESKTOP-8H27944; Database = emptable; Integrated Security = True;";
        


        private object dataGridView1;

        public Form1()
        {
            InitializeComponent();
            
        }
        private populatedata()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from empDetails2", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter your user name", "warning", MessageBoxButtons.OKCancel);
            }
            if(textBox2.Text == "")
            {
                MessageBox.Show("please enter your password","warning",MessageBoxButtons.OKCancel);
            }
        }

        
    }
}

       

  
