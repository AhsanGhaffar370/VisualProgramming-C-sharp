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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            slidepanel.Height = homepage.Height;
            homepage1.BringToFront();
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            slidepanel.Height = homepage.Height;
            slidepanel.Top = homepage.Top;
            homepage1.BringToFront();
        }

        private void availablecars_Click(object sender, EventArgs e)
        {
            slidepanel.Height = availablecars.Height;
            slidepanel.Top = availablecars.Top;
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            slidepanel.Height = aboutus.Height;
            slidepanel.Top = aboutus.Top;
            about_Us1.BringToFront();
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            slidepanel.Height = contactus.Height;
            slidepanel.Top = contactus.Top;
            contact_Us1.BringToFront();
        }

        private void register_Click(object sender, EventArgs e)
        {
            slidepanel.Height = register.Height;
            slidepanel.Top = register.Top;

            //this.Hide();
            // Registration rg = new Registration();
            //rg.Show();
            this.Close();

        }

        private void login_Click(object sender, EventArgs e)
        {
            slidepanel.Height = login.Height;
            slidepanel.Top = login.Top;

            this.Hide();
            login lg = new login();
            lg.Show(); 
        }

        private void slidepanel_Paint(object sender, PaintEventArgs e)
        {

        }
        

      
    }
}
