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
    public partial class Add_Vehicals : UserControl
    {
        static string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);

        string imgLoc = "";
        public Add_Vehicals()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imgbt = null;
                FileStream fstream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imgbt = br.ReadBytes((int)fstream.Length);

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into CarDetails(ChassisNo, Brand, Model, Color, Image, RegNo, EngineNo, ManufactDate, BuyPrice, SellPrice) values(@chassis, @brand, @model, @color, @img, @reg, @engine, @manuf, @buy, @sell)", con);
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
                MessageBox.Show("record insert");
                con.Close();
            }
            catch (Exception ex)
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
                    carImg.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alert", "Error in uploading image");
            }
        }

        private void chasis_tb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
