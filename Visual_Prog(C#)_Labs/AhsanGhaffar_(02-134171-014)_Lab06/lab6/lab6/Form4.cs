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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int salary = 0;
        
        private void calculate_Click(object sender, EventArgs e)
        {
            if(grades.Text== "Director")
                salary+=100000;
                if(grades.Text== "Manager")
                    salary+=75000;


                    if(grades.Text== "Project Manager")
                        salary+=50000;
                        if(grades.Text== "Programmer")
                            salary += 25000;
            if(radioButton1.Checked)
                salary += 100000;
            if(radioButton2.Checked)
                salary += 25000;
            if (radioButton3.Checked)
                salary += 50000;
            if (radioButton4.Checked)
                salary += 20000;
            if (Housing.Checked)
                salary += 20000;
            if (Convence.Checked)
                salary += 15000;
            if(other1.Checked)
               salary += 10000;
            if (Other2.Checked)
                salary += 10000;
            


            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if ((string)checkedListBox2.Items[i] == "Project Compiletion Bonus")
                {
                    salary += 20000;   
                }
                if ((string)checkedListBox2.Items[i] == "Year End Bonus")
                {
                    salary += 30000;   
                }
               if ((string)checkedListBox2.Items[i] == "Performance Bonus")
                {
                    salary += 25000;
                }
               if ((string)checkedListBox2.Items[i] == "Customer Apreciation Bonus")
               {
                   salary += 15000;
                
            }
               int dec = Int32.Parse(deduction.Text);
               salary -= dec;
               Result.Text = salary.ToString();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
