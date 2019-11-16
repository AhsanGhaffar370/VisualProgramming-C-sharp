using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehical_Showroom_Management_System
{
    public partial class Homepage : UserControl
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private int imagenumber = 1;
        private void loadnextimage()
        {
            if (imagenumber==10)
            {
                imagenumber = 1;
            }
            slider.ImageLocation = string.Format(@"images/{0}.jpg", imagenumber);
            imagenumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimage();
        }
    }
}
