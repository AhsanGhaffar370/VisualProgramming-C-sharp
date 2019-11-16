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
    public partial class Booking_Request : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        
        public void customer_car_grid()
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            BindingSource bs = new BindingSource();
            BindingSource bs1 = new BindingSource();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer", con);
                SqlCommand cmd1 = new SqlCommand("Select * from CarDetails", con);

                //Customer
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bs.DataSource = dt;
                customer_gv.DataSource = bs;
                sda.Update(dt);

                //CAR
                sda.SelectCommand = cmd1;
                sda.Fill(dt1);
                bs1.DataSource = dt1;
                car_gv.DataSource = bs1;
                sda.Update(dt1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Booking_Request()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                float sp = Int32.Parse(selling_tb.Text);
                float tx = Int32.Parse(tax_tb.Text);
                float dis = Int32.Parse(discount_tb.Text);
                float tdisc = (sp * dis) / 100;
                float total = sp - tdisc;
                total += tx;

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into SellCar(Customer_CNIC, Customer_Name, Car_ChassisNo, Car_Brand, Car_Model, Booking_Date, Delivery_Date, SellingPrice, TaxAmount, Discount, TotalPrice) values(@cnic, @name, @chassis, @brand, @model, @book, @del, @sell, @tax, @discount, @total)", con);
                cmd.Parameters.AddWithValue("@cnic", cnic_tb.Text);
                cmd.Parameters.AddWithValue("@name", name_tb.Text);
                cmd.Parameters.AddWithValue("@chassis", chasis_tb.Text);
                cmd.Parameters.AddWithValue("@brand", brand_tb.Text);
                cmd.Parameters.AddWithValue("@model", model_tb.Text);
                cmd.Parameters.AddWithValue("@book", booking_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@del", deliver_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@sell", selling_tb.Text);
                cmd.Parameters.AddWithValue("@tax", tax_tb.Text);
                cmd.Parameters.AddWithValue("@discount", discount_tb.Text);
                cmd.Parameters.AddWithValue("@total", total.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("record insert");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Booking_Request_Load(object sender, EventArgs e)
        {
            customer_car_grid();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            customer_car_grid();
        }

        private void selling_tb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void customer_gv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void customer_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void car_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void customer_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customer_gv.Rows[e.RowIndex];

                cnic_tb.Text = row.Cells["Cus_CNIC"].Value.ToString();
                name_tb.Text = row.Cells["Cus_Name"].Value.ToString();
            }
        }

        private void car_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = car_gv.Rows[e.RowIndex];

                chasis_tb.Text = row.Cells["ChassisNo"].Value.ToString();
                brand_tb.Text = row.Cells["Brand"].Value.ToString();
                model_tb.Text = row.Cells["Model"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serCnic_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Customer where Cus_CNIC like  @cnic", con);
                cmd.Parameters.AddWithValue("@cnic", serCnic_tb.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                customer_gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serChasis_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CarDetails where ChassisNo like  @chassis", con);
                cmd.Parameters.AddWithValue("@chassis", serChasis_tb.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                car_gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
