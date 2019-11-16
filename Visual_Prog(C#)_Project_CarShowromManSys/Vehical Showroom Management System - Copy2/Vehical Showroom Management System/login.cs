using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Vehical_Showroom_Management_System
{
    public partial class login : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=desktop-274hh7u\sqlexpress;Initial Catalog=VehicleShowroom;Integrated Security=True");
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);

        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
            //DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("select * from login where Username= @un and Password =@pswd", con);
            sda.SelectCommand.Parameters.AddWithValue("@un", name.Text);
            sda.SelectCommand.Parameters.AddWithValue("@pswd", pass.Text);
            SqlDataReader reader;
            
            try
            {
                con.Open();
                //sda.Fill(dta);
                reader = sda.SelectCommand.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count = count + 1;
                }
                //if (dta.Rows.Count == 1)
                if (count == 1)
                {
                    //MessageBox.Show("Login Successfully", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Admincs ad = new Admincs();
                    ad.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    name.Text = "";
                    pass.Text = "";
                    error.Visible = true;
                    name.Focus();
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Visible = false;
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Visible = false;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void pass_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
