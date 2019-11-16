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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = paragraph.Text;
            int lngth = x.Length;
            int reslt = 160 - lngth;
            count.Text = "Characters left " + reslt;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
