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

namespace ADMIN
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
            showdata();
        }
        SqlConnection conn = new SqlConnection(@"Data source = DESKTOP-8H27944;DataBase = login; Integrated security = true");
        private void showdata()
        {
            SqlCommand cmd1 = new SqlCommand(" Select * From login", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable d = new DataTable();
            d.Clear();
            da.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            textBox1.Text = selectedrow.Cells[0].Value.ToString();
            textBox2.Text = selectedrow.Cells[1].Value.ToString();
            dateTimePicker1.Text = selectedrow.Cells[2].Value.ToString();
            textBox4.Text = selectedrow.Cells[3].Value.ToString();
            textBox5.Text = selectedrow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("insert into login (empid,empname,date,workstatus,remarks)values(@empid,@empname,@date,@workstatus,@remarks)", conn);
            cmd2.Parameters.AddWithValue("@empid", textBox1.Text);
            cmd2.Parameters.AddWithValue("@empname", textBox2.Text);
            cmd2.Parameters.AddWithValue("@date", dateTimePicker1.Text);
            cmd2.Parameters.AddWithValue("@workstatus", textBox4.Text);
            cmd2.Parameters.AddWithValue("@remarks", textBox5.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update login set empname=@empname,date=@date,workstatus=@workstatus,remarks=@remarks where empid=@empid", conn);
            
            cmd3.Parameters.AddWithValue("@empname",textBox2.Text);
            cmd3.Parameters.AddWithValue("@date",dateTimePicker1.Text);
            cmd3.Parameters.AddWithValue("@workstatus",textBox4.Text);
            cmd3.Parameters.AddWithValue("@remarks", textBox5.Text);
            cmd3.Parameters.AddWithValue("@empid", textBox1.Text);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            showdata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from login where empid=@empid", conn);
            cmd4.Parameters.AddWithValue("@empid", textBox1.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            showdata();
        }
    }
}
