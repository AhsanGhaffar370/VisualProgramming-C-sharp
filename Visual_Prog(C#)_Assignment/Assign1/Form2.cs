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
    public partial class Form2 : Form
    {
        //globally initialize array of bookDetails class instance:
        int num = 0;
        BookDetails[] bk = new BookDetails[100];

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = books_lb.SelectedIndex;
            
            try
            {
                title_tb.Text = bk[index].Title;
                author_tb.Text = bk[index].Author;
                isbn_tb.Text = bk[index].Isbn;
                url_tb.Text = bk[index].Url;
                page_tb.Text = bk[index].Page.ToString();
                year_tb.Text = bk[index].Year.ToString();
                picbox.ImageLocation = bk[index].Pic;
            }
            catch(Exception ex)
            { }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sub_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
              
        }

        private void page_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void year_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle or allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void title_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle(allow) letter + whitespace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void author_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle(allow) letter + whitespace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void isbn_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY handle(allow) letter 
            if (!char.IsControl(e.KeyChar) && e.KeyChar !='-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string imgLoc = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All files('.')|'.'";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = dialog.FileName;
                    picbox.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alert", "Error in uploading image");
            }
        }

        private void update_brn_Click(object sender, EventArgs e)
        {
            int index = books_lb.SelectedIndex;

           if (title_tb.Text != "" && author_tb.Text != "" && isbn_tb.Text != "" && url_tb.Text != "" && page_tb.Text != "" && year_tb.Text != ""  )
            {
                try
                {
                    int pg = Int32.Parse(page_tb.Text);
                    int yr = Int32.Parse(year_tb.Text);

                    bk[index] = new BookDetails();
                    bk[index].Title = title_tb.Text;
                    bk[index].Author = author_tb.Text;
                    bk[index].Isbn = isbn_tb.Text;
                    bk[index].Url = url_tb.Text;
                    bk[index].Page = pg;
                    bk[index].Year = yr;
                    bk[index].Pic = picbox.ImageLocation;


                    books_lb.Items.Clear();
                    for (int i = 0; i < num; i++)
                    {
                        books_lb.Items.Add(bk[i].Title);
                    }

                    title_tb.Clear();
                    author_tb.Clear();
                    isbn_tb.Clear();
                    url_tb.Clear();
                    page_tb.Clear();
                    year_tb.Clear();
                    picbox.ImageLocation = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Exception");
                }
               

               
            }
            else
                MessageBox.Show("Please Fill Out All fields which you want's to update:");
                
            

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = books_lb.SelectedIndex;

                books_lb.Items.RemoveAt(index);

                for(int i=index;i<num;i++)
                    bk[i] = bk[i+1];

                num--;

                title_tb.Clear();
                author_tb.Clear();
                isbn_tb.Clear();
                url_tb.Clear();
                page_tb.Clear();
                year_tb.Clear();
                picbox.ImageLocation = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception:");
            }


        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            if (title_tb.Text != "" && author_tb.Text != "" && isbn_tb.Text != "" && url_tb.Text != "" && page_tb.Text != "" && year_tb.Text != ""  )
            {
                int pg = Int32.Parse(page_tb.Text);
                int yr = Int32.Parse(year_tb.Text);

                bk[num] = new BookDetails();
                bk[num].Title = title_tb.Text;
                bk[num].Author = author_tb.Text;
                bk[num].Isbn = isbn_tb.Text;
                bk[num].Url = url_tb.Text;
                bk[num].Page = pg;
                bk[num].Year = yr;
                bk[num].Pic = picbox.ImageLocation;
                
                books_lb.Items.Add(bk[num].Title);
                num++;

                title_tb.Clear();
                author_tb.Clear();
                isbn_tb.Clear();
                url_tb.Clear();
                page_tb.Clear();
                year_tb.Clear();
                picbox.ImageLocation = "";
            }
            else
                MessageBox.Show("Please Fill Out All fields");
        }

        private void url_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbn_tb_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
