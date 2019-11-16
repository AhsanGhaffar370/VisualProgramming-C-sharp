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
    public partial class Admincs : Form
    {
        public Admincs()
        {
            InitializeComponent();
            slidepanel4.Height =homepage.Height;
            homepage1.BringToFront();
            
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            homepage1.BringToFront();
            slidepanel4.Top = homepage.Top;
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            messages1.BringToFront();
            slidepanel4.Height = contactus.Height;
            slidepanel4.Top = contactus.Top;

        }

        private void Abus_Click(object sender, EventArgs e)
        {
            about_Us1.BringToFront();
            slidepanel4.Height = Abus.Height;
            slidepanel4.Top = Abus.Top;
        }

        private void login_Click(object sender, EventArgs e)
        {
            slidepanel4.Height = login.Height;
            slidepanel4.Top = login.Top;

            Home h = new Home();
            h.Show();
            Visible = false;
        }

        private void availablecars_Click(object sender, EventArgs e)
        {
            slidepanel4.Height = availablecars.Height;
            slidepanel4.Top = availablecars.Top;

            Add_new ad = new Add_new();
            ad.Show();
            Visible = false;
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            slidepanel4.Height = aboutus.Height;
            slidepanel4.Top = aboutus.Top;

            Report_Admin rp = new Report_Admin();
            rp.Show();
            Visible = false;

        }
    }
}
