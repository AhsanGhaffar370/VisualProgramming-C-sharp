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

namespace lab9
{
    public partial class Form3 : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=AIS110CL7-028;Initial Catalog=eemp;User ID=sa;Password=bimcs");
        SqlCommand command;
        //SqlDataReader MyDataReader;
        SqlDataAdapter adapter = new SqlDataAdapter();
        


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
            MyCommand = MyConnection.CreateCommand();
            MyCommand.CommandText = "SELECT * FROM reg1";

            MyConnection.Open();
            MyDataReader = MyCommand.ExecuteReader();

            MyDataReader.Read();
            fname.Text = MyDataReader["fname"].ToString();
            lname.Text = MyDataReader["lname"].ToString();
            address.Text = MyDataReader["address"].ToString();
            //address.Text = MyDataReader["gender"].ToString();
            country.Text = MyDataReader["country"].ToString();
            city.Text = MyDataReader["city"].ToString();
            //address.Text = MyDataReader["address"].ToString();

            string g1 = MyDataReader["gender"].ToString();

            if(g1=="male")
            {
                male.Checked=true;
            }
            else if(g1=="female")
            {
                female.Checked = true;
            }*/
        }

        private void add_Click(object sender, EventArgs e)
        {
            MyConnection.Open();
            string sql = "";
            string g,dob="sunday";
            if(male.Checked)
            {
                g="male";
            }
            else if (female.Checked)
            {
                g = "female";
            }

            sql="Insert into reg1(fname,lname,address,gender,country,city,dob) values('"+fname.Text+"','"+lname.Text+"','"+address.Text+"','"+g+"','"+country.SelectedItem+"','"+city.SelectedItem+"','"+dob+"`)" ;
            command = new SqlCommand(sql, MyConnection);
            adapter.InsertCommand = new SqlCommand(sql, MyConnection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            MyConnection.Close();



        }
    }
}
