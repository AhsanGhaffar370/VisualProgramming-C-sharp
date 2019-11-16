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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int currenttckn = Int32.Parse(currentno.Text);
            int peopleque = Int32.Parse(counter.Text);
            int mytkn = Int32.Parse(tockenno.Text);

            peopleque--;
            currenttckn++;
            
            currentno.Text = currenttckn.ToString("00");
            counter.Text = peopleque.ToString("00");
            tockenno.Text = mytkn.ToString("00");
            if (peopleque == 0)
            {
                button1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currenttckn = Int32.Parse(currentno.Text);
            int peopleque = Int32.Parse(counter.Text);
            int mytkn = Int32.Parse(tockenno.Text);

           
            peopleque++;
            mytkn++;
            currentno.Text = currenttckn.ToString("00");
            counter.Text = peopleque.ToString("00");
            tockenno.Text = mytkn.ToString("00");
            if(peopleque>0)
            {
                button1.Enabled=true;
            }

            
        }
    }
}
