using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int count=0;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count % 8;
            pictureBox1.ImageLocation = textBox1.Text + count++ + ".jpg";
        }

       
    }
}
