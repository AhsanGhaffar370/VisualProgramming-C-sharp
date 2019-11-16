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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Miles to Kilometers")
            {
                label1.Text = "Miles:";
                label2.Text = "Kilometers:";


            }
            else if (comboBox1.Text == "Kilometers to Miles")
            {
                label1.Text = "Kilometers:";
                label2.Text = "Miles:";

            }
            else if (comboBox1.Text == "Feet to Meters")
            {
                label1.Text = "Feet:";
                label2.Text = "Meters:";

            }
             else if (comboBox1.Text == "Meters to Feet")
            {
                label1.Text = "Meters:";
                label2.Text = "Feet:";

            }
             else if (comboBox1.Text == "Inches to Centimeters")
            {
                label1.Text = "Inches:";
                label2.Text = "Centimeters:";

            }
            else if (comboBox1.Text == "Centimeters to Inches")
            {
                label1.Text = "Centimeters:";
                label2.Text = "Inches:";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   double result=0;
            if (comboBox1.Text == "Miles to Kilometers")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 1.6093).ToString();


            }
            if (comboBox1.Text == "Kilometers to Miles")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 0.6214).ToString();
            }
            if (comboBox1.Text == "Feet to Meters")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 0.3048).ToString();
            }
            if (comboBox1.Text == "Meters to Feet")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 3.2808).ToString();
            }
            if (comboBox1.Text == "Inches to Centimeters")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 2.54).ToString();
            }
            if (comboBox1.Text == "Centimeters to Inches")
            {
                result = Double.Parse(textBox2.Text);
                res.Text = (result * 0.3937).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            res.Text = "";
            comboBox1.Text = "select";
        }
    }
}
