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
    public partial class Form4 : Form
    {
        
        double bill, disc, tax, extraDisc, exd;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void make_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (make_cbb.Text == "Daihatsu")
            {
                model_cbb.Enabled = true;
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Cuore");
                model_cbb.Items.Add("Move");

            }
            else if (make_cbb.Text == "Toyota")
            {
                model_cbb.Enabled = true;
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Corolla");
                model_cbb.Items.Add("Prius");
            }
            else if (make_cbb.Text == "Suzuki")
            {
                model_cbb.Enabled = true;
                model_cbb.Items.Clear();
                model_cbb.Items.Add("Cultus");
                model_cbb.Items.Add("Swift");
            }
        }

        private void make_cbb_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void make_cbb_Click(object sender, EventArgs e)
        {
            
        }

        private void disc_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void name_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle(allow) letter + whitespace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                exd = Double.Parse(disc_tb.Text);

                if (exd >= 0 && exd <= 100 && disc_tb.Text != "" && (card_rb.Checked || cash_rb.Checked))
                {
                    extraDisc = (bill *  exd )/ 100;
                    tax = (bill * 15)/100;
                    disc = (bill * 5)/100;
                    
                    if (cash_rb.Checked)
                        bill -= disc;
                    
                    bill -= extraDisc;
                    bill += tax;

                    tbill_tb.Text = bill.ToString();

                    add_btn.Enabled = true;
                    cal_btn.Enabled = false;
                    cash_rb.Checked = false;
                    card_rb.Checked = false;
                    extraDisc = 0;
                    disc = 0;
                    tax = 0;
                    disc_tb.Clear();
                    car_lb.Items.Clear();
                }
                else
                    MessageBox.Show("Please filled out all fields correctly:");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name_tb.Text != "" && make_cbb.SelectedIndex != -1 && model_cbb.SelectedIndex != -1 && days_num.Value != 0)
            {
                CarRent cr = new CarRent();

                string dvr = "no", ac = "no", ass = "no";
                int dvr1=feat_gcb.Items.IndexOf("Driver(DVR)");
                int ac1 = feat_gcb.Items.IndexOf("Air Conditioner(AC)");
                int as1 = feat_gcb.Items.IndexOf("Audio System(AS)");

                if (feat_gcb.GetItemChecked(dvr1))
                    dvr = "YES";
                
                if (feat_gcb.GetItemChecked(ac1))
                    ac = "YES";
                
                if (feat_gcb.GetItemChecked(as1))
                    ass = "YES";
                
                cr.Make = make_cbb.Text;
                cr.Model = model_cbb.Text;
                cr.Days = Convert.ToInt32(days_num.Value);
                cr.Dvr = dvr;
                cr.Ac = ac;
                cr.As = ass;

                bill = cr.rent();
                 
                car_lb.Items.Add("Customer Name:    " + name_tb.Text );
                car_lb.Items.Add("Car Make:         " + make_cbb.Text);
                car_lb.Items.Add("Car Model:        " + model_cbb.Text);
                car_lb.Items.Add("Days:             " + days_num.Value);
                car_lb.Items.Add("Driver:           " + dvr);
                car_lb.Items.Add("Air Conditioner:  " + ac);
                car_lb.Items.Add("Audio System:     " + ass);

                add_btn.Enabled = false;
                cal_btn.Enabled = true;
                name_tb.Clear();
                make_cbb.SelectedIndex = -1;
                model_cbb.SelectedIndex = -1;
                tbill_tb.Clear();

                days_num.Value = 0;
                for(int i=0;i<feat_gcb.Items.Count;i++)
                    feat_gcb.SetItemChecked(i,false);
            }
            else
            {
                MessageBox.Show("Please Filled out fields correctly:");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
