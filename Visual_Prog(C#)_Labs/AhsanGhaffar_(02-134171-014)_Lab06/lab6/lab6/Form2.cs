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
    public partial class Form2 : Form
    {
        int seconds , mintes, hurs;
        public Form2()
        {
            InitializeComponent();
       seconds = mintes =  hurs = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            operation.Text = "Start";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation.Text = "Escape";
            listBox1.Items.Add(hurs+":"+(mintes)+":"+seconds);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            operation.Text = "Stop";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation.Text = "Reset";
            seconds = mintes = hurs = 0;
            hr.Text = "00";
            min.Text = "00";
            sec.Text = "00";
            timer1.Stop();
            listBox1.Items.Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                seconds = 0;
                mintes++;
            }
            if (mintes > 59)
            {
                hurs++;
                mintes = 0;
            }
            hr.Text = hurs.ToString("00");
            min.Text = mintes.ToString("00");
            sec.Text = seconds.ToString("00");

             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
