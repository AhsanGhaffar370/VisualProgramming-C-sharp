namespace Assign1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.books_lb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_brn = new System.Windows.Forms.Button();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.page_tb = new System.Windows.Forms.TextBox();
            this.isbn_tb = new System.Windows.Forms.TextBox();
            this.author_tb = new System.Windows.Forms.TextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // books_lb
            // 
            this.books_lb.FormattingEnabled = true;
            this.books_lb.Location = new System.Drawing.Point(12, 31);
            this.books_lb.Name = "books_lb";
            this.books_lb.Size = new System.Drawing.Size(198, 225);
            this.books_lb.TabIndex = 0;
            this.books_lb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.url_tb);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.update_brn);
            this.groupBox1.Controls.Add(this.year_tb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.page_tb);
            this.groupBox1.Controls.Add(this.isbn_tb);
            this.groupBox1.Controls.Add(this.author_tb);
            this.groupBox1.Controls.Add(this.title_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 244);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(60, 205);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 32;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.picbox);
            this.groupBox2.Location = new System.Drawing.Point(394, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 160);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(0, 0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(139, 160);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 13;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Image = global::Assign1.Properties.Resources.dad2d8_143642_b81f24_0f8b8d_ec9a29;
            this.label8.Location = new System.Drawing.Point(394, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Upload Image";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // url_tb
            // 
            this.url_tb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.url_tb.Location = new System.Drawing.Point(91, 107);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(297, 20);
            this.url_tb.TabIndex = 18;
            this.url_tb.TextChanged += new System.EventHandler(this.url_tb_TextChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(271, 205);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_brn
            // 
            this.update_brn.Location = new System.Drawing.Point(158, 205);
            this.update_brn.Name = "update_brn";
            this.update_brn.Size = new System.Drawing.Size(75, 23);
            this.update_brn.TabIndex = 15;
            this.update_brn.Text = "UPDATE";
            this.update_brn.UseVisualStyleBackColor = true;
            this.update_brn.Click += new System.EventHandler(this.update_brn_Click);
            // 
            // year_tb
            // 
            this.year_tb.Location = new System.Drawing.Point(91, 159);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(109, 20);
            this.year_tb.TabIndex = 11;
            this.year_tb.TextChanged += new System.EventHandler(this.year_tb_TextChanged);
            this.year_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_tb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Year";
            // 
            // page_tb
            // 
            this.page_tb.Location = new System.Drawing.Point(91, 133);
            this.page_tb.Name = "page_tb";
            this.page_tb.Size = new System.Drawing.Size(109, 20);
            this.page_tb.TabIndex = 9;
            this.page_tb.TextChanged += new System.EventHandler(this.sub_tb_TextChanged);
            this.page_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.page_tb_KeyPress);
            // 
            // isbn_tb
            // 
            this.isbn_tb.Location = new System.Drawing.Point(91, 81);
            this.isbn_tb.Name = "isbn_tb";
            this.isbn_tb.Size = new System.Drawing.Size(297, 20);
            this.isbn_tb.TabIndex = 7;
            this.isbn_tb.TextChanged += new System.EventHandler(this.isbn_tb_TextChanged);
            this.isbn_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbn_tb_KeyPress);
            // 
            // author_tb
            // 
            this.author_tb.Location = new System.Drawing.Point(91, 55);
            this.author_tb.Name = "author_tb";
            this.author_tb.Size = new System.Drawing.Size(297, 20);
            this.author_tb.TabIndex = 6;
            this.author_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.author_tb_KeyPress);
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(91, 29);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(297, 20);
            this.title_tb.TabIndex = 5;
            this.title_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pages";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Books";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 260);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.books_lb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox books_lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox page_tb;
        private System.Windows.Forms.TextBox isbn_tb;
        private System.Windows.Forms.TextBox author_tb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_brn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_btn;
    }
}