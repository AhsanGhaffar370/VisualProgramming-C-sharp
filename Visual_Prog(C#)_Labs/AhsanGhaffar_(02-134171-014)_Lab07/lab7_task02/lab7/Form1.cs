using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bal.Text = opBal.Text;
        }

        private void dept_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(bal.Text);
            double d2 = double.Parse(dw.Text);

            deposit d = new deposit(d1,d2);


            double val=d.dep();

            string val1 = val.ToString();

            if (d2 < 1)
            {
                error_lbl.Text = "can't deposit negative val";
                error_lbl.Show();
            }
               
            else
            {
                bal.Text = val1;
                error_lbl.Hide();
            }
                
        }

        private void wd_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(bal.Text);

            double d2 = double.Parse(dw.Text);

            deposit d = new deposit(d1, d2);

            double val = d.with();

            string val1 = val.ToString();

            if (d2 > d1)
            {
                error_lbl.Text = "not enough balance in account";
                error_lbl.Show();
            }
                
            else
            {
                bal.Text = val1;
                error_lbl.Hide();
            }
            
        }
    }
}
