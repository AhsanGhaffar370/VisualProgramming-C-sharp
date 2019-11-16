namespace Assign1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.dep_num = new System.Windows.Forms.NumericUpDown();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.experience_cb = new System.Windows.Forms.ComboBox();
            this.Per_rb = new System.Windows.Forms.RadioButton();
            this.tem_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sal_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loan_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dep_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOAN CALCULATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.age_tb);
            this.groupBox1.Controls.Add(this.dep_num);
            this.groupBox1.Controls.Add(this.name_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(95, 67);
            this.age_tb.MaxLength = 3;
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(216, 20);
            this.age_tb.TabIndex = 16;
            this.age_tb.TextChanged += new System.EventHandler(this.age_tb_TextChanged);
            this.age_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dep_num
            // 
            this.dep_num.Location = new System.Drawing.Point(96, 97);
            this.dep_num.Name = "dep_num";
            this.dep_num.Size = new System.Drawing.Size(216, 20);
            this.dep_num.TabIndex = 15;
            this.dep_num.ValueChanged += new System.EventHandler(this.dep_num_ValueChanged);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(96, 38);
            this.name_tb.MaxLength = 25;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(216, 20);
            this.name_tb.TabIndex = 5;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            this.name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dependence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // experience_cb
            // 
            this.experience_cb.FormattingEnabled = true;
            this.experience_cb.Items.AddRange(new object[] {
            "less than 1 Year",
            "1-3 Years",
            "3-5 Years",
            "5-10 Years",
            "more tha 10 Years"});
            this.experience_cb.Location = new System.Drawing.Point(128, 89);
            this.experience_cb.Name = "experience_cb";
            this.experience_cb.Size = new System.Drawing.Size(184, 21);
            this.experience_cb.TabIndex = 12;
            // 
            // Per_rb
            // 
            this.Per_rb.AutoSize = true;
            this.Per_rb.Location = new System.Drawing.Point(129, 36);
            this.Per_rb.Name = "Per_rb";
            this.Per_rb.Size = new System.Drawing.Size(76, 17);
            this.Per_rb.TabIndex = 13;
            this.Per_rb.TabStop = true;
            this.Per_rb.Text = "Permanent";
            this.Per_rb.UseVisualStyleBackColor = true;
            // 
            // tem_rb
            // 
            this.tem_rb.AutoSize = true;
            this.tem_rb.Location = new System.Drawing.Point(236, 34);
            this.tem_rb.Name = "tem_rb";
            this.tem_rb.Size = new System.Drawing.Size(75, 17);
            this.tem_rb.TabIndex = 14;
            this.tem_rb.TabStop = true;
            this.tem_rb.Text = "Temporary";
            this.tem_rb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.experience_cb);
            this.groupBox2.Controls.Add(this.Sal_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Per_rb);
            this.groupBox2.Controls.Add(this.tem_rb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employement Information";
            // 
            // Sal_tb
            // 
            this.Sal_tb.Location = new System.Drawing.Point(129, 61);
            this.Sal_tb.Name = "Sal_tb";
            this.Sal_tb.Size = new System.Drawing.Size(183, 20);
            this.Sal_tb.TabIndex = 5;
            this.Sal_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.homeSal_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employement Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.loan_tb);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Evaluation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apply For Loan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loan_tb
            // 
            this.loan_tb.Location = new System.Drawing.Point(128, 30);
            this.loan_tb.Name = "loan_tb";
            this.loan_tb.Size = new System.Drawing.Size(97, 20);
            this.loan_tb.TabIndex = 5;
            this.loan_tb.TextChanged += new System.EventHandler(this.loan_tb_TextChanged);
            this.loan_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borr_tb_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loan Amount";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dep_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dep_num;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Per_rb;
        private System.Windows.Forms.RadioButton tem_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Sal_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox loan_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox experience_cb;
        private System.Windows.Forms.TextBox age_tb;
    }
}