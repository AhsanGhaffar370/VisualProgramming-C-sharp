using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehical_Showroom_Management_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            Visible = false;
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ahoo");
            login l = new login();
            l.Show();
            Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
