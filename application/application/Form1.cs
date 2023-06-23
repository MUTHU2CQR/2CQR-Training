using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vedio();
            loopVedio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void vedio()
        {
            try
            {
                string f = @"C:\Users\Admin\Videos\2.mp4";
                axWindowsMediaPlayer1.URL = f;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            

        }
        private void loopVedio()
        {
           
                int m = 10;
                for (int i = 0; i <= m; i++)
                {
                    vedio();
                }
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

