using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3gui
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {
            String n1, n2;
            n1 = number1.Text;
            n2 = number2.Text;
            int n11, n22;
            n11 = Int32.Parse(n1);
            n22 = Int32.Parse(n2);
            int res = n11 / n22;
            reslt.Text = res.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String n1, n2;
            n1 = number1.Text;
            n2 = number2.Text;
            int n11, n22;
            n11 = Int32.Parse(n1);
            n22 = Int32.Parse(n2);
            int res = n11 + n22;
            reslt.Text = res.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String n1, n2;
            n1 = number1.Text;
            n2 = number2.Text;
            int n11, n22;
            n11 = Int32.Parse(n1);
            n22 = Int32.Parse(n2);
            int res = n11 - n22;
            reslt.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mul_Click(object sender, EventArgs e)
        {
            String n1, n2;
            n1 = number1.Text;
            n2 = number2.Text;
            int n11, n22;
            n11 = Int32.Parse(n1);
            n22 = Int32.Parse(n2);
            int res = n11 * n22;
            reslt.Text = res.ToString();

        }
    }
}
