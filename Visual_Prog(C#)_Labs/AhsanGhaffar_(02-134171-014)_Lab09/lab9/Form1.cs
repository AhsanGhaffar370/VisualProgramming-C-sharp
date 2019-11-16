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
    public partial class Form1 : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=AIS110CL7-028;Initial Catalog=eemp;User ID=sa;Password=bimcs");
        SqlCommand MyCommand;
        SqlDataReader MyDataReader;
        public Form1()
        {
            InitializeComponent();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyDataReader.Read();
                fname.Text = MyDataReader["Fname"].ToString();
                lname.Text = MyDataReader["Lname"].ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyCommand = MyConnection.CreateCommand();
            MyCommand.CommandText = "SELECT * FROM emp_table1";

            MyConnection.Open();
            MyDataReader = MyCommand.ExecuteReader();

            MyDataReader.Read();
            fname.Text = MyDataReader["Fname"].ToString();
            lname.Text = MyDataReader["Lname"].ToString();
        }
    }
}
