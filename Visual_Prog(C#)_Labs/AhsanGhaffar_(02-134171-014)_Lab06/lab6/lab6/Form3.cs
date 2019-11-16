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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sec_Click(object sender, EventArgs e)
        {

        }
        int seconds;
        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(numericUpDown1.Value);
             seconds = 60 * min;

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            sec.Text = seconds.ToString("00");
            if (seconds == 0 )
            {
                timer1.Stop();
                MessageBox.Show("time out");
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
