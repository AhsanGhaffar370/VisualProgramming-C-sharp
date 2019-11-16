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
    public partial class Form3 : Form
    {
        double salary = 0,housing=20000,convey=15000,ob1=10000,ob2=10000;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboBox1.Text=="Director")
           {
               salary = 0;
                Dsalary.Checked = true;
                salary += 100000;
            }
            if (comboBox1.Text == "Manager")
            {
                salary = 0;
                Msalary.Checked = true;
                salary += 50000;
            }
            if (comboBox1.Text == "Project Manager")
            {
                salary = 0;
                PMsalary.Checked = true;
                salary += 40000;
            }
            if (comboBox1.Text == "Programmer")
            {
                salary = 0;
                Psalary.Checked = true;
                salary += 30000;
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           if(HA.Checked&&CA.Checked&&OB1.Checked&&OB2.Checked)
            {
                salary += (housing + convey + ob1 + ob2);
            }
           else if (HA.Checked && CA.Checked && OB1.Checked)
            {
                salary += (housing + convey + ob1);
            }
           else if (HA.Checked && CA.Checked && OB2.Checked)
            {
                salary += (housing + convey + ob2);
            }
            else if (HA.Checked && OB1.Checked && OB2.Checked)
            {
                salary += (housing + ob1 + ob2);
            }
           else  if (CA.Checked && OB1.Checked && OB2.Checked)
            {
                salary += (convey + ob1 + ob2);
            }

           else if (HA.Checked && CA.Checked)
            {
                salary += (housing + convey);
            }
           else  if (HA.Checked && OB1.Checked)
            {
                salary += (housing + ob1);
            }
           else  if (HA.Checked && OB2.Checked)
            {
                salary += (housing + ob2);
            }
           else if (CA.Checked && OB1.Checked)
            {
                salary +=(convey + ob1);
            }
           else if (CA.Checked && OB2.Checked)
            {
                salary += (convey + ob1);
            }
           else  if (OB1.Checked && OB2.Checked)
            {
                salary += (ob2 + ob1);
            }
           else if (HA.Checked)
            {
                salary +=housing;
            }
           else  if(CA.Checked)
            {
                salary += convey;
            }
           else if (OB1.Checked)
            {
                salary +=ob1;
            }
           else if (OB2.Checked)
            {
                salary += ob2;
            }
           
            if (listBox1.Text == "Project Completion Bonus")
            {
                salary += 20000;
              }
            if (listBox1.Text == "Year End Bonus")
            {
                salary += 30000;
            }
            if (listBox1.Text == "Performance Bonus")
            {
                salary += 25000;
                            }
            if (listBox1.Text == "Customer Appreciation Bonus")
            {
                salary += 15000;
                }

            calc.Text = (salary - (Double.Parse(PF.Text) + Double.Parse(MF.Text))).ToString();
            
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PF_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
