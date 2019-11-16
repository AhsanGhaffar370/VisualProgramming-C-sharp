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
    public partial class Customer_Report : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        public Customer_Report()
        {
            InitializeComponent();
            customer_grid();
        }
        public void customer_grid()
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer", con);

                //Customer
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bs.DataSource = dt;
                customer_gv.DataSource = bs;
                sda.Update(dt);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void customer_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = customer_gv.Rows[e.RowIndex];

                    cnic_tb.Text = row.Cells["Cus_CNIC"].Value.ToString();
                    name_tb.Text = row.Cells["Cus_Name"].Value.ToString();
                    cont_tb.Text = row.Cells["Cus_Contact"].Value.ToString();
                    email_tb.Text = row.Cells["Cus_Email"].Value.ToString();
                    country_co.Text = row.Cells["Cus_Country"].Value.ToString();
                    state_co.Text = row.Cells["Cus_State"].Value.ToString();
                    city_co.Text = row.Cells["Cus_City"].Value.ToString();
                    address_tb.Text = row.Cells["Cus_Address"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            customer_grid();
        }

        private void Search_Click(object sender, EventArgs e)
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

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            customer_grid();
        }

        private void customer_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Customer  where Cus_CNIC like @cnic ", con);
                cmd.Parameters.AddWithValue("@cnic", cnic_tb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted");

                con.Close();
                customer_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Customer set Cus_CNIC=@cnic, Cus_Name=@name, Cus_Contact=@cont, Cus_Email=@email, Cus_Country=@country, Cus_State=@state, Cus_City=@city, Cus_Address=@address, Cus_CreatedDate=@date where  Cus_CNIC=@cnic", con);
                                                                                       
                cmd.Parameters.AddWithValue("@cnic", cnic_tb.Text);
                cmd.Parameters.AddWithValue("@name", name_tb.Text);
                cmd.Parameters.AddWithValue("@cont", cont_tb.Text);
                cmd.Parameters.AddWithValue("@email", email_tb.Text);
                cmd.Parameters.AddWithValue("@country", country_co.selectedValue);
                cmd.Parameters.AddWithValue("@state", state_co.selectedValue);
                cmd.Parameters.AddWithValue("@city", city_co.selectedValue);
                cmd.Parameters.AddWithValue("@address", address_tb.Text);
                cmd.Parameters.AddWithValue("@date", update_date.Value.ToShortDateString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
