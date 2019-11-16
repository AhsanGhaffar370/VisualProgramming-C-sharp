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
using System.IO;
namespace Vehical_Showroom_Management_System
{
    public partial class Vehical_Report : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);

        string imgLoc = "";
        public Vehical_Report()
        {
            InitializeComponent();
            car_grid();
        }

        public void car_grid()
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            BindingSource bs1 = new BindingSource();
            try
            {
                SqlCommand cmd1 = new SqlCommand("Select * from CarDetails", con);
                
                //CAR
                sda.SelectCommand = cmd1;
                sda.Fill(dt1);
                bs1.DataSource = dt1;
                car_gv.DataSource = bs1;
                sda.Update(dt1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chasis_tb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void car_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = car_gv.Rows[e.RowIndex];

                chasis_tb.Text = row.Cells["ChassisNo"].Value.ToString();
                brand_tb.Text = row.Cells["Brand"].Value.ToString();
                model_tb.Text = row.Cells["Model"].Value.ToString();
                color_tb.Text = row.Cells["Color"].Value.ToString();
                reg_tb.Text = row.Cells["RegNo"].Value.ToString();
                engine_tb.Text = row.Cells["EngineNo"].Value.ToString();
                buyPrice_tb.Text = row.Cells["BuyPrice"].Value.ToString();
                sell_tb.Text = row.Cells["SellPrice"].Value.ToString();



                //byte[] img= (byte[])(row.Cells["Imgage"]);
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            car_grid();

            serChassis_tb.Text = "";
            chasis_tb.Text = "";
            brand_tb.Text = "";
            model_tb.Text = "";
            color_tb.Text = "";
            engine_tb.Text = "";
            reg_tb.Text = "";
            buyPrice_tb.Text = "";
            sell_tb.Text = "";

        }

        private void Vehical_Report_Load(object sender, EventArgs e)
        {
            car_grid();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CarDetails where ChassisNo like  @chassis", con);
                cmd.Parameters.AddWithValue("@chassis", serChassis_tb.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                car_gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from CarDetails  where ChassisNo like @chassis ", con);
                cmd.Parameters.AddWithValue("@chassis", chasis_tb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted");

                con.Close();
                car_grid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All files('.')|'.'";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = dialog.FileName.ToString();
                    carimg.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alert", "Error in uploading image");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream fstream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CarDetails set ChassisNo=@chassis, Brand=@brand, Model=@model, Color=@color, Image= @img, RegNo=@reg, EngineNo=@engine, ManufactDate=@manuf, BuyPrice=@buy, SellPrice=@sell where ChassisNo=@chassis ", con);
                cmd.Parameters.AddWithValue("@chassis", chasis_tb.Text);
                cmd.Parameters.AddWithValue("@brand", brand_tb.Text);
                cmd.Parameters.AddWithValue("@model", model_tb.Text);
                cmd.Parameters.AddWithValue("@color", color_tb.Text);
                cmd.Parameters.AddWithValue("@img", imgbt);
                cmd.Parameters.AddWithValue("@reg", reg_tb.Text);
                cmd.Parameters.AddWithValue("@engine", engine_tb.Text);
                cmd.Parameters.AddWithValue("@manuf", manuf_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@buy", buyPrice_tb.Text);
                cmd.Parameters.AddWithValue("@sell", sell_tb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");

                con.Close();
                car_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
