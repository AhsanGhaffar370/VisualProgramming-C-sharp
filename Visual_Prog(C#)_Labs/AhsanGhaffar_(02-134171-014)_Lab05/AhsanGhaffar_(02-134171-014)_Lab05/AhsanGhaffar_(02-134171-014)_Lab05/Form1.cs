using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohib_121_lab_5__vp_
{
    public partial class Form1 : Form
    { double plus=0,minus=0,mul=0,divide=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text += button1.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int two = 2;
            result.Text += (two.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int three = 3;
            result.Text += (three.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int four = 4;
            result.Text += (four.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int five = 5;
            result.Text += (five.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int six = 6;
            result.Text += (six.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int seven = 7;
            result.Text += (seven.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int eight = 8;
            result.Text += (eight.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int nine = 9;
            result.Text += (nine.ToString());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int zero = 0;
            result.Text += (zero.ToString());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
             //plus = plus+Double.Parse(result.Text);
            result.Text +="+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
             //minus = Double.Parse(result.Text);
            result.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
             //mul = Double.Parse(result.Text);
            result.Text+= "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
             //divide = Double.Parse(result.Text);
            result.Text+= "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void sin_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Cos(Double.Parse(result.Text)).ToString());
        }

        private void cos_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sin(Double.Parse(result.Text)).ToString());
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Cosh(Double.Parse(result.Text)).ToString());
        }

        private void tan_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Tan(Double.Parse(result.Text)).ToString());
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sqrt(Double.Parse(result.Text)).ToString());
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Tanh(Double.Parse(result.Text)).ToString());
        }

        private void sininverse_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Asin(Double.Parse(result.Text)).ToString());
        }

        private void cosinverse_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Acos(Double.Parse(result.Text)).ToString());
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sinh(Double.Parse(result.Text)).ToString());
        }

        private void taninverse_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Atan(Double.Parse(result.Text)).ToString());
        }

        private void mod_Click(object sender, EventArgs e)
        {
           // result.Text = ((Double.Parse(result.Text)%).ToString());
        }

        private void ex_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Exp(Double.Parse(result.Text)).ToString());
        }

        private void log_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Log10(Double.Parse(result.Text)).ToString());
        }

        private void pi_Click(object sender, EventArgs e)
        {
            result.Text = (Math.PI).ToString();
        }
             
    }
}
