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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ais110cl7-034;Initial Catalog=lab1010;User ID=sa;Password=bimcs");
        SqlDataAdapter adap;
        private void comboBoxsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxsem.SelectedItem=="1")
            {
                checkedListBoxcourse.Items.Clear();
                checkedListBoxcourse.Items.Add("English 1");
                checkedListBoxcourse.Items.Add("islamiat");
                checkedListBoxcourse.Items.Add("programing fundamental");


            }
            if (comboBoxsem.SelectedItem == "2")
            {
                checkedListBoxcourse.Items.Clear();
                checkedListBoxcourse.Items.Add("DLD ");
                checkedListBoxcourse.Items.Add("OOP");
                checkedListBoxcourse.Items.Add("MVC");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string query ="insert into datatable (Name,sem,course,st_type,tutionfee,libfee"


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
