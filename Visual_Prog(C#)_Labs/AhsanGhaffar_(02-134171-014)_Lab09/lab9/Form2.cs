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
    public partial class Form2 : Form
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=AIS110CL7-028;Initial Catalog=eemp;User ID=sa;Password=bimcs");
        SqlCommand MyCommand;
        SqlDataReader MyDataReader;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlCommand MyCommand = new SqlCommand("SELECT * FROM emp_table1", MyConnection))
            {
                MyCommand.CommandType = CommandType.Text;
                MyConnection.Open();
                DataTable dt = new DataTable();
                dt.Load(MyCommand.ExecuteReader());
                dataGridView1.DataSource = dt;
                MyConnection.Close();
            }
        }
    }
}
