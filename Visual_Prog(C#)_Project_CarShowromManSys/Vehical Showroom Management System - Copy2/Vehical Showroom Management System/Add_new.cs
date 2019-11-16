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
    public partial class Add_new : Form
    {
        public Add_new()
        {
            InitializeComponent();
            slidepanel3.Height = Booking_request_b.Height;
            booking_Request1.BringToFront();
        }

        private void Booking_request_b_Click(object sender, EventArgs e)
        {
            slidepanel3.Height = Booking_request_b.Height;
            slidepanel3.Top = Booking_request_b.Top;
            booking_Request1.BringToFront();
        }

        private void customer_Add_b_Click(object sender, EventArgs e)
        {
            slidepanel3.Height = customer_Add_b.Height;
            slidepanel3.Top = customer_Add_b.Top;
            add_Customers1.BringToFront();
        }

        private void Vehical_reg_Add_b_Click(object sender, EventArgs e)
        {
            slidepanel3.Height = home_addpanel.Height;
            slidepanel3.Top = home_addpanel.Top;

            this.Hide();
            Admincs ad = new Admincs();
            ad.Show();
        }

        private void vehical_Add_b_Click(object sender, EventArgs e)
        {
            slidepanel3.Height = vehical_Add_b.Height;
            slidepanel3.Top = vehical_Add_b.Top;
            add_Vehicals1.BringToFront();

        }

        private void home_addpanel_Click(object sender, EventArgs e)
        {
            slidepanel3.Height = home_addpanel.Height;
            slidepanel3.Top = home_addpanel.Top;

            this.Hide();
            Admincs ad = new Admincs();
            ad.Show();


        }
    }
}
