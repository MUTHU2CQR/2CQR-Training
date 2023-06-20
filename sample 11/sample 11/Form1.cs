using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sample_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populatedata();
        }
        SqlConnection conn = new SqlConnection(@"Data source = DESKTOP-8H27944;DataBase = details; Integrated security = true");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          

        }
        private void populatedata()
        {
            SqlCommand cmd1 = new SqlCommand("select id,firstname As firstname,lastname As lastname,sum from details", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populatedata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("insert into details (id,firstname,lastname,sum)values(@id,@firstname,@lastname,@sum)", conn);
            cmd2.Parameters.AddWithValue("id", textBox1.Text);
            cmd2.Parameters.AddWithValue("firstname", textBox2.Text);
            cmd2.Parameters.AddWithValue("lastname", textBox3.Text);
            cmd2.Parameters.AddWithValue("sum", textBox4.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            populatedata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int index;
                index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView1.Rows[index];
                textBox1.Text = selectedrow.Cells[0].Value.ToString();
                textBox2.Text = selectedrow.Cells[1].Value.ToString();
                textBox3.Text = selectedrow.Cells[2].Value.ToString();
                textBox4.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update details set firstname=@firstname,lastname=@lastname,sum=@sum where id=@id", conn);
           
            cmd3.Parameters.AddWithValue("firstname", textBox2.Text);
            cmd3.Parameters.AddWithValue("lastname", textBox3.Text);
            cmd3.Parameters.AddWithValue("sum", textBox4.Text);
            cmd3.Parameters.AddWithValue("id", textBox1.Text);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            populatedata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from details where id=@id",conn);
            cmd4.Parameters.AddWithValue("id", textBox1.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            populatedata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select id,firstname As firstname,lastname As lastname,sum from details where firstname Like @firstname+'%'", conn);
            cmd1.Parameters.AddWithValue("firstname", textBox5.Text);
           
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
