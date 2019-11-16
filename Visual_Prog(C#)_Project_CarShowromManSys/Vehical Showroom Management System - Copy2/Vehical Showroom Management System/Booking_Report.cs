using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Vehical_Showroom_Management_System
{
    public partial class Booking_Report : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        public Booking_Report()
        {
            InitializeComponent();
            SellCar_grid();
        }

        public void SellCar_grid()
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from SellCar", con);

                //Customer
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bs.DataSource = dt;
                sellcar_gv.DataSource = bs;
                sda.Update(dt);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Report_Load(object sender, EventArgs e)
        {
            SellCar_grid();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            SellCar_grid();
            cnic_tb.Text = "";

        }

        private void sellcar_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sellcar_gv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = sellcar_gv.Rows[e.RowIndex];

                    bookno_tb.Text = row.Cells["BookingNo"].Value.ToString();
                    cnic_tb.Text = row.Cells["Customer_CNIC"].Value.ToString();
                    name_tb.Text = row.Cells["Customer_Name"].Value.ToString();
                    chasis_tb.Text = row.Cells["Car_ChassisNo"].Value.ToString();
                    brand_tb.Text = row.Cells["Car_Brand"].Value.ToString();
                    model_tb.Text = row.Cells["Car_Model"].Value.ToString();
                    //chasis_tb.Text = row.Cells["ChassisNo"].Value.ToString();
                    //brand_tb.Text = row.Cells["Brand"].Value.ToString();
                    selling_tb.Text = row.Cells["SellingPrice"].Value.ToString();
                    tax_tb.Text = row.Cells["TaxAmount"].Value.ToString();
                    discount_tb.Text = row.Cells["Discount"].Value.ToString();
                    totalPrice_tb.Text = row.Cells["TotalPrice"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from SellCar where BookingNo like  @book", con);
                cmd.Parameters.AddWithValue("@book", serBook_tb.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                sellcar_gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
