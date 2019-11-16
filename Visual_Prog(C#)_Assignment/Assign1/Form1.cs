using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign1
{
    public partial class Form1 : Form
    {
        int rr = 0, a = 0, b = 0, bb = 0, c = 0, cc = 0, d = 0, f = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void reg_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdry_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int marks = Int32.Parse(marks_tb.Text);
            if (reg_tb.Text != "" && name_tb.Text != "" && class_rb.Text != "" && marks_tb.Text != "" && marks>=0 && marks<=100 && sub_tb.Text != "")
            {
                tab.Rows.Add(reg_tb.Text, name_tb.Text, class_rb.Text, marks_tb.Text, sub_tb.Text);
            
                //marks= Convert.ToInt32(dataGridView1.Rows[i].Cells["Marks"].Value);
                
                if (marks >= 87 && marks <= 100){
                    a++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "A";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (marks >= 80 && marks <= 86){
                    bb++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "B+";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (marks >= 72 && marks <= 79){
                    b++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "B";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.LightYellow;
                }   
                else if (marks >= 66 && marks <= 71){
                    cc++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "C+";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.Blue;
                }   
                else if (marks >= 60 && marks <= 65){
                    c++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "C";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (marks >= 50 && marks <= 59){
                    d++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "D";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.Pink;
                }
                else if (marks < 50){
                    f++;
                    dataGridView1.Rows[rr].Cells["Grade"].Value = "F";
                    dataGridView1.Rows[rr].DefaultCellStyle.BackColor = Color.Red;
                }
                rr++;
            }

            else
            {
                if(marks_tb.Text!="" && (marks<0 || marks>100) )
                    MessageBox.Show("please enter correct marks", "Alert");
                else
                MessageBox.Show("please fill out all fields of form", "Alert");
            }
                
            /*
            int s = 22;
            MessageBox.Show(s.ToString(),"Student");
            add_btn.Text = "New Add";
            add_btn.Enabled = false;
            add_btn.Height = 70;

            List<string> name = new List<string>();

            name.Add("ahsan");
            MessageBox.Show(name[0]);
            */
        }

        private void add_btn_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("hello mouse hovered", "Student");
        }

        DataTable tab = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            tab.Columns.Add("RegID", typeof(int));
            tab.Columns.Add("Name", typeof(string));
            tab.Columns.Add("Class", typeof(int));
            tab.Columns.Add("Marks", typeof(int));
            tab.Columns.Add("Subject", typeof(string));
            tab.Columns.Add("Grade", typeof(string));

            dataGridView1.DataSource = tab;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sumry_btn_Click(object sender, EventArgs e)
        {
            a_tb.Text = a.ToString();
            bb_tb.Text = bb.ToString();
            b_tb.Text = b.ToString();
            cc_tb.Text = cc.ToString();
            c_tb.Text = c.ToString();
            d_tb.Text = d.ToString();
            f_tb.Text = f.ToString();
        }
    }
}
