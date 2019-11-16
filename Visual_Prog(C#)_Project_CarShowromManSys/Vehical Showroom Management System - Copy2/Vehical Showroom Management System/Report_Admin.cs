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
    public partial class Report_Admin : Form
    {
        public Report_Admin()
        {
            InitializeComponent();
            slidepanel2.Height = Booking_reports_b.Height;
            booking_Report1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Booking_reports_b_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = Booking_reports_b.Height;
            slidepanel2.Top = Booking_reports_b.Top;
            booking_Report1.BringToFront();
        }

        private void homepage_rep_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = homepage_rep.Height;
            slidepanel2.Top = homepage_rep.Top;

            this.Hide();
            Admincs ad = new Admincs();
            ad.Show();
        }

        private void customer_reports_b_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = customer_reports_b.Height;
            slidepanel2.Top = customer_reports_b.Top;
            customer_Report1.BringToFront();
        }


        private void vehical_reports_b_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = vehical_reports_b.Height;
            slidepanel2.Top = vehical_reports_b.Top;
            vehical_Report1.BringToFront();
        }

        private void booking_Report1_Load(object sender, EventArgs e)
        {

        }
    }
}
