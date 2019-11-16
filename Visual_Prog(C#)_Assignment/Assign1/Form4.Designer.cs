namespace Assign1
{
    partial class Form4
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.car_lb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feat_gcb = new System.Windows.Forms.CheckedListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.make_cbb = new System.Windows.Forms.ComboBox();
            this.days_num = new System.Windows.Forms.NumericUpDown();
            this.model_cbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tax_tb = new System.Windows.Forms.TextBox();
            this.tbill_tb = new System.Windows.Forms.TextBox();
            this.disc_tb = new System.Windows.Forms.TextBox();
            this.cal_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cash_rb = new System.Windows.Forms.RadioButton();
            this.card_rb = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days_num)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.car_lb);
            this.groupBox2.Location = new System.Drawing.Point(350, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 244);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employement Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // car_lb
            // 
            this.car_lb.FormattingEnabled = true;
            this.car_lb.Location = new System.Drawing.Point(6, 24);
            this.car_lb.Name = "car_lb";
            this.car_lb.Size = new System.Drawing.Size(265, 186);
            this.car_lb.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feat_gcb);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.make_cbb);
            this.groupBox1.Controls.Add(this.days_num);
            this.groupBox1.Controls.Add(this.model_cbb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 244);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAR";
            // 
            // feat_gcb
            // 
            this.feat_gcb.FormattingEnabled = true;
            this.feat_gcb.Items.AddRange(new object[] {
            "Driver(DVR)",
            "Air Conditioner(AC)",
            "Audio System(AS)"});
            this.feat_gcb.Location = new System.Drawing.Point(96, 116);
            this.feat_gcb.Name = "feat_gcb";
            this.feat_gcb.Size = new System.Drawing.Size(216, 64);
            this.feat_gcb.TabIndex = 25;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(86, 201);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 37);
            this.add_btn.TabIndex = 24;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Features";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Days";
            // 
            // make_cbb
            // 
            this.make_cbb.FormattingEnabled = true;
            this.make_cbb.Items.AddRange(new object[] {
            "Daihatsu",
            "Toyota",
            "Suzuki"});
            this.make_cbb.Location = new System.Drawing.Point(96, 21);
            this.make_cbb.Name = "make_cbb";
            this.make_cbb.Size = new System.Drawing.Size(216, 21);
            this.make_cbb.TabIndex = 16;
            this.make_cbb.SelectedIndexChanged += new System.EventHandler(this.make_cbb_SelectedIndexChanged);
            this.make_cbb.Click += new System.EventHandler(this.make_cbb_Click);
            this.make_cbb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.make_cbb_MouseClick);
            // 
            // days_num
            // 
            this.days_num.Location = new System.Drawing.Point(96, 78);
            this.days_num.Name = "days_num";
            this.days_num.Size = new System.Drawing.Size(216, 20);
            this.days_num.TabIndex = 15;
            // 
            // model_cbb
            // 
            this.model_cbb.Enabled = false;
            this.model_cbb.FormattingEnabled = true;
            this.model_cbb.Location = new System.Drawing.Point(96, 51);
            this.model_cbb.Name = "model_cbb";
            this.model_cbb.Size = new System.Drawing.Size(216, 21);
            this.model_cbb.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "CAR RENTAL";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(108, 56);
            this.name_tb.MaxLength = 25;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(216, 20);
            this.name_tb.TabIndex = 22;
            this.name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Customer Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tax_tb);
            this.groupBox4.Controls.Add(this.tbill_tb);
            this.groupBox4.Controls.Add(this.disc_tb);
            this.groupBox4.Controls.Add(this.cal_btn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cash_rb);
            this.groupBox4.Controls.Add(this.card_rb);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(618, 151);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill";
            // 
            // tax_tb
            // 
            this.tax_tb.Enabled = false;
            this.tax_tb.Location = new System.Drawing.Point(137, 82);
            this.tax_tb.Name = "tax_tb";
            this.tax_tb.ReadOnly = true;
            this.tax_tb.Size = new System.Drawing.Size(49, 20);
            this.tax_tb.TabIndex = 27;
            this.tax_tb.Text = "   15%";
            // 
            // tbill_tb
            // 
            this.tbill_tb.Location = new System.Drawing.Point(136, 116);
            this.tbill_tb.Name = "tbill_tb";
            this.tbill_tb.ReadOnly = true;
            this.tbill_tb.Size = new System.Drawing.Size(167, 20);
            this.tbill_tb.TabIndex = 25;
            // 
            // disc_tb
            // 
            this.disc_tb.Location = new System.Drawing.Point(136, 47);
            this.disc_tb.Name = "disc_tb";
            this.disc_tb.Size = new System.Drawing.Size(167, 20);
            this.disc_tb.TabIndex = 24;
            this.disc_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disc_tb_KeyPress);
            // 
            // cal_btn
            // 
            this.cal_btn.Enabled = false;
            this.cal_btn.Location = new System.Drawing.Point(338, 62);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(141, 58);
            this.cal_btn.TabIndex = 23;
            this.cal_btn.Text = "CALCULATE";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Bill";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tax";
            // 
            // cash_rb
            // 
            this.cash_rb.AutoSize = true;
            this.cash_rb.Location = new System.Drawing.Point(137, 22);
            this.cash_rb.Name = "cash_rb";
            this.cash_rb.Size = new System.Drawing.Size(49, 17);
            this.cash_rb.TabIndex = 13;
            this.cash_rb.TabStop = true;
            this.cash_rb.Text = "Cash";
            this.cash_rb.UseVisualStyleBackColor = true;
            // 
            // card_rb
            // 
            this.card_rb.AutoSize = true;
            this.card_rb.Location = new System.Drawing.Point(228, 22);
            this.card_rb.Name = "card_rb";
            this.card_rb.Size = new System.Drawing.Size(47, 17);
            this.card_rb.TabIndex = 14;
            this.card_rb.TabStop = true;
            this.card_rb.Text = "Card";
            this.card_rb.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Discount Percentage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Payment Mode";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days_num)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox car_lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox make_cbb;
        private System.Windows.Forms.NumericUpDown days_num;
        private System.Windows.Forms.ComboBox model_cbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbill_tb;
        private System.Windows.Forms.TextBox disc_tb;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton cash_rb;
        private System.Windows.Forms.RadioButton card_rb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox feat_gcb;
        private System.Windows.Forms.TextBox tax_tb;
    }
}