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
    public partial class Add_Customers : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        public Add_Customers()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer(Cus_CNIC, Cus_Name, Cus_Contact, Cus_Email, Cus_Country, Cus_State, Cus_City, Cus_Address, Cus_CreatedDate) values(@cnic, @name, @cont, @email, @country, @state, @city, @address, @date)", con);
                cmd.Parameters.AddWithValue("@cnic", cnic_tb.Text);
                cmd.Parameters.AddWithValue("@name", name_tb.Text);
                cmd.Parameters.AddWithValue("@cont", cont_tb.Text);
                cmd.Parameters.AddWithValue("@email", email_tb.Text);
                cmd.Parameters.AddWithValue("@country", country_co.selectedValue);
                cmd.Parameters.AddWithValue("@state", state_co.selectedValue);
                cmd.Parameters.AddWithValue("@city", city_co.selectedValue);
                cmd.Parameters.AddWithValue("@address", address_tb.Text);
                cmd.Parameters.AddWithValue("@date", create_date.Value.ToShortDateString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("record insert");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
