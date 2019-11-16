namespace lab7
{
    partial class Form1
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
            this.bal = new System.Windows.Forms.TextBox();
            this.wd = new System.Windows.Forms.Button();
            this.dept = new System.Windows.Forms.Button();
            this.dw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.New_Customer = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.cusName = new System.Windows.Forms.TextBox();
            this.opBal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.New_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.error_lbl);
            this.groupBox2.Controls.Add(this.bal);
            this.groupBox2.Controls.Add(this.wd);
            this.groupBox2.Controls.Add(this.dept);
            this.groupBox2.Controls.Add(this.dw);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 193);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // bal
            // 
            this.bal.Location = new System.Drawing.Point(149, 129);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(100, 20);
            this.bal.TabIndex = 10;
            // 
            // wd
            // 
            this.wd.Location = new System.Drawing.Point(149, 73);
            this.wd.Name = "wd";
            this.wd.Size = new System.Drawing.Size(75, 23);
            this.wd.TabIndex = 9;
            this.wd.Text = "WithDrawal";
            this.wd.UseVisualStyleBackColor = true;
            this.wd.Click += new System.EventHandler(this.wd_Click);
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(149, 35);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(75, 23);
            this.dept.TabIndex = 8;
            this.dept.Text = "Deposit";
            this.dept.UseVisualStyleBackColor = true;
            this.dept.Click += new System.EventHandler(this.dept_Click);
            // 
            // dw
            // 
            this.dw.Location = new System.Drawing.Point(22, 57);
            this.dw.Name = "dw";
            this.dw.Size = new System.Drawing.Size(100, 20);
            this.dw.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // New_Customer
            // 
            this.New_Customer.Controls.Add(this.save);
            this.New_Customer.Controls.Add(this.cusName);
            this.New_Customer.Controls.Add(this.opBal);
            this.New_Customer.Controls.Add(this.label1);
            this.New_Customer.Controls.Add(this.label2);
            this.New_Customer.Controls.Add(this.acNum);
            this.New_Customer.Controls.Add(this.label3);
            this.New_Customer.Location = new System.Drawing.Point(12, 12);
            this.New_Customer.Name = "New_Customer";
            this.New_Customer.Size = new System.Drawing.Size(377, 193);
            this.New_Customer.TabIndex = 9;
            this.New_Customer.TabStop = false;
            this.New_Customer.Text = "New_Customer";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(272, 151);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(168, 66);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(100, 20);
            this.cusName.TabIndex = 5;
            // 
            // opBal
            // 
            this.opBal.Location = new System.Drawing.Point(168, 107);
            this.opBal.Name = "opBal";
            this.opBal.Size = new System.Drawing.Size(100, 20);
            this.opBal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers Name";
            // 
            // acNum
            // 
            this.acNum.Location = new System.Drawing.Point(168, 29);
            this.acNum.Name = "acNum";
            this.acNum.Size = new System.Drawing.Size(100, 20);
            this.acNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opening Balance";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Location = new System.Drawing.Point(19, 83);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 13);
            this.error_lbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.New_Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.New_Customer.ResumeLayout(false);
            this.New_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bal;
        private System.Windows.Forms.Button wd;
        private System.Windows.Forms.Button dept;
        private System.Windows.Forms.TextBox dw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox New_Customer;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.TextBox opBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_lbl;
    }
}

