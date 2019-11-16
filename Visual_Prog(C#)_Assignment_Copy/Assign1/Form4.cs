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
    public partial class Form4 : Form
    {


        double tax = 0;
        double price = 0;
        double total;
        string driver = "NO", Ac = "NO", AS = "NO";
        double disc = 0;

        public void bill()
        {
            double car_rate = 1000, driver=800, ac=400, audis=400;


        }
        public Form4()
        {
            InitializeComponent();
        }

        private void make_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (make_cbb.SelectedIndex == 0)
            {
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Cuore");
                model_cbb.Items.Add("Move");

            }
            else if (make_cbb.SelectedIndex == 1)
            {
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Corolla");
                model_cbb.Items.Add("Prius");
            }
            else if (make_cbb.SelectedIndex == 2)
            {
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Cultus");
                model_cbb.Items.Add("Swift");
            }
        }

        private void make_cbb_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void make_cbb_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
