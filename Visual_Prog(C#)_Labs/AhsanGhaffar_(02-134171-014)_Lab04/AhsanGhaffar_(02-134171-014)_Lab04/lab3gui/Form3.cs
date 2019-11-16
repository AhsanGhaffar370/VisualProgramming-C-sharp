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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String frhiet;
            frhiet = Farenhiet.Text;
            int Fht = Int32.Parse(frhiet);
            int result = (Fht - 32) * 5 / 9;
            celcius.Text = result.ToString();

        }
    }
}
