using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Ahsan_Lab22
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AIS110CL7-10;Initial Catalog=Employee;User ID=sa;Password=bimcs");
        List<Employee> listEmp = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from EMPTABLE", con);
            //SqlCommand cmd = new SqlCommand("Select * from EMPTABLE where JOB='clerk' AND SALARY<'1000'", con);
            //SqlCommand cmd = new SqlCommand("Select * from EMPTABLE where (JOB='manager' OR JOB='professor' OR JOB='president')", con);
            //SqlCommand cmd = new SqlCommand("Select * from EMPTABLE where JOB != 'CLERK'", con);
            
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = Convert.ToInt32(rdr["EMPNO"].ToString());
                    emp.Ename = rdr["ENAME"].ToString();
                    emp.Job = rdr["JOB"].ToString();
                    emp.Mgr = rdr.IsDBNull(3) ? -1 : Convert.ToInt32(rdr["MGR"].ToString());
                    emp.HireDate = rdr.IsDBNull(4) ? DateTime.Now : Convert.ToDateTime(rdr["HIREDATE"].ToString());
                    emp.Sal = rdr.IsDBNull(5) ? 0.0 : Convert.ToDouble(rdr["SALARY"].ToString());
                    emp.Comm = rdr.IsDBNull(6) ? 0 : Convert.ToDouble(rdr["COMM"].ToString());
                    emp.DeptNo = rdr.IsDBNull(7) ? -1 : Convert.ToInt32(rdr["DEPTNO"].ToString());

                    listEmp.Add(emp);
                }

            }
            catch (Exception Ex)
            {
                label1.Text = Ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }

            dataGridView1.DataSource = listEmp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from Employee EMPTABLE in listEmp where EMPTABLE.Job == "clerk" && EMPTABLE.Sal > 1000 select EMPTABLE;
            dataGridView1.DataSource = query.ToList<Employee>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = from Employee EMPTABLE in listEmp where EMPTABLE.Job == "clerk" || EMPTABLE.Job == "president" || EMPTABLE.Job == "professor" select EMPTABLE;
            dataGridView1.DataSource = query.ToList<Employee>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from Employee EMPTABLE in listEmp where EMPTABLE.Job != "clerk"  select EMPTABLE;
            dataGridView1.DataSource = query.ToList<Employee>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = from Employee EMPTABLE in listEmp where EMPTABLE.Ename == "%a" select EMPTABLE;
            dataGridView1.DataSource = query.ToList<Employee>();
        }
    }
}
