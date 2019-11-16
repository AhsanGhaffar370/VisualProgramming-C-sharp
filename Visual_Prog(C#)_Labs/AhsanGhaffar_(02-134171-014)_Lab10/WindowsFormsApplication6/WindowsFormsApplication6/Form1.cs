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
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=ais110cl7-034;Initial Catalog=lab1010;User ID=sa;Password=bimcs");
        SqlDataAdapter adap;
        DataSet ds;
        int intCurrentindex = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            con.Open();
            adap = new SqlDataAdapter("select * from data", con);
            adap.Fill(ds, "student");
            if(ds.Tables[0].Rows.Count>0)
            {
                textBoxfname.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                textBoxlname.Text = ds.Tables[0].Rows[0]["lname"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intCurrentindex = 0;
            textBoxfname.Text = ds.Tables[0].Rows[intCurrentindex]["fname"].ToString();
            textBoxlname.Text = ds.Tables[0].Rows[intCurrentindex]["lname"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(intCurrentindex< ds.Tables[0].Rows.Count-1)
            {

                intCurrentindex = intCurrentindex + 1;
                textBoxfname.Text = ds.Tables[0].Rows[intCurrentindex]["fname"].ToString();
                textBoxlname.Text = ds.Tables[0].Rows[intCurrentindex]["lname"].ToString();
            }
            else
            {
                MessageBox.Show("your're already at the last record");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            intCurrentindex = ds.Tables[0].Rows.Count - 1;
            textBoxfname.Text = ds.Tables[0].Rows[intCurrentindex]["fname"].ToString();
            textBoxlname.Text = ds.Tables[0].Rows[intCurrentindex]["lname"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(intCurrentindex!=0)
            {

                intCurrentindex = intCurrentindex - 1;
                textBoxfname.Text = ds.Tables[0].Rows[intCurrentindex]["fname"].ToString();
                textBoxlname.Text = ds.Tables[0].Rows[intCurrentindex]["lname"].ToString();
            }
            else
            {
                MessageBox.Show("your're already at the first record");
            }

        }
    }
}
