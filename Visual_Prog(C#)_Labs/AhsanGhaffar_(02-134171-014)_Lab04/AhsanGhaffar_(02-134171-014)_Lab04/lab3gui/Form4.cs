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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            int result=1;

            int n1 = Int32.Parse(number.Text);
          for(int i=n1;i>=1;i--)
          {
              result =result* i;
            

          }
          factorial.Text = result.ToString();
        
        }
    }
}
