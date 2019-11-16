using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_tb.Text != "" && age_tb.Text != "" && dep_num.Text != "" && (Per_rb.Checked || tem_rb.Checked) && Sal_tb.Text != "" && experience_cb.SelectedIndex != -1 && loan_tb.Text != "")
            {
                int age = Int32.Parse(age_tb.Text);

                if( (age>=18 && age<=50) && Per_rb.Checked && experience_cb.Text!= "less than 1 Year")
                {
                    double sal = double.Parse(Sal_tb.Text);
                    double sal_range = 40000;

                    for(int i=0; i<dep_num.Value;i++)
                        sal_range += 20000;
                    
                    if (sal >= sal_range)
                    {
                        double loan = double.Parse(loan_tb.Text);
                        double loan_range = sal;

                        //finding interest per month
                        double interest_rate = 100 / 100;
                        double time = 10;
                        double interest = loan * interest_rate * time;
                        double interest_per_month = interest / 120;

                        if (experience_cb.Text == "1-3 Years")
                        {
                            loan_range *= 6;
                            if (loan>loan_range)
                                MessageBox.Show(name_tb.Text+", your loan application has not been successful this time");
                            else
                                MessageBox.Show(name_tb.Text + ", your loan application has been successful. Your monthly installment will be "+interest_per_month+" for 120 months.");
                        }
                        else if (experience_cb.Text == "3-5 Years")
                        {
                            loan_range *= 12;
                            if (loan > loan_range)
                                MessageBox.Show(name_tb.Text + ", your loan application has not been successful this time");
                            else
                                MessageBox.Show(name_tb.Text + ", your loan application has been successful. Your monthly installment will be " + interest_per_month + " for 120 months.");
                        }
                        else if (experience_cb.Text == "5-10 Years")
                        {
                            loan_range *= 24;
                            if (loan > loan_range)
                                MessageBox.Show(name_tb.Text + ", your loan application has not been successful this time");
                            else
                                MessageBox.Show(name_tb.Text + ", your loan application has been successful. Your monthly installment will be " + interest_per_month + " for 120 months.");
                        }
                        else if (experience_cb.Text == "more tha 10 Years")
                        {
                            loan_range *= 36;
                            if (loan > loan_range)
                                MessageBox.Show(name_tb.Text + ", your loan application has not been successful this time");
                            else
                                MessageBox.Show(name_tb.Text + ", your loan application has been successful. Your monthly installment will be " + interest_per_month + " for 120 months.");
                        }
                    }
                    else
                        MessageBox.Show("For dependence[" + dep_num.Value + "] salary must be greate than: [" + sal_range + "]");
                } 
                else
                    MessageBox.Show("Your Age, Employement Status or Experience is not matched the loan requirements:");
            }
            else
                MessageBox.Show("Please Fill Out All fields");
        }

        private void name_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle(allow) letter + whitespace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void homeSal_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void borr_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
                
        }

        private void loan_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void age_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
