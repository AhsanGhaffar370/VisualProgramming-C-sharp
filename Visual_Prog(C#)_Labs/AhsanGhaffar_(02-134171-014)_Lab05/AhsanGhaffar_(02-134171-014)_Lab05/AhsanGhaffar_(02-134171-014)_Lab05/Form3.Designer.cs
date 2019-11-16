namespace mohib_121_lab_5__vp_
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
            this.name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dsalary = new System.Windows.Forms.RadioButton();
            this.PMsalary = new System.Windows.Forms.RadioButton();
            this.Psalary = new System.Windows.Forms.RadioButton();
            this.Msalary = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OB1 = new System.Windows.Forms.CheckBox();
            this.CA = new System.Windows.Forms.CheckBox();
            this.OB2 = new System.Windows.Forms.CheckBox();
            this.HA = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PF = new System.Windows.Forms.TextBox();
            this.MF = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(130, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Project Manager",
            "Programmer"});
            this.comboBox1.Location = new System.Drawing.Point(118, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "select";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dsalary
            // 
            this.Dsalary.AutoSize = true;
            this.Dsalary.Location = new System.Drawing.Point(45, 19);
            this.Dsalary.Name = "Dsalary";
            this.Dsalary.Size = new System.Drawing.Size(64, 17);
            this.Dsalary.TabIndex = 4;
            this.Dsalary.TabStop = true;
            this.Dsalary.Text = "100,000";
            this.Dsalary.UseVisualStyleBackColor = true;
            // 
            // PMsalary
            // 
            this.PMsalary.AutoSize = true;
            this.PMsalary.Location = new System.Drawing.Point(45, 53);
            this.PMsalary.Name = "PMsalary";
            this.PMsalary.Size = new System.Drawing.Size(58, 17);
            this.PMsalary.TabIndex = 5;
            this.PMsalary.TabStop = true;
            this.PMsalary.Text = "40,000";
            this.PMsalary.UseVisualStyleBackColor = true;
            // 
            // Psalary
            // 
            this.Psalary.AutoSize = true;
            this.Psalary.Location = new System.Drawing.Point(179, 53);
            this.Psalary.Name = "Psalary";
            this.Psalary.Size = new System.Drawing.Size(58, 17);
            this.Psalary.TabIndex = 6;
            this.Psalary.TabStop = true;
            this.Psalary.Text = "30,000";
            this.Psalary.UseVisualStyleBackColor = true;
            // 
            // Msalary
            // 
            this.Msalary.AutoSize = true;
            this.Msalary.Location = new System.Drawing.Point(179, 19);
            this.Msalary.Name = "Msalary";
            this.Msalary.Size = new System.Drawing.Size(58, 17);
            this.Msalary.TabIndex = 7;
            this.Msalary.TabStop = true;
            this.Msalary.Text = "50,000";
            this.Msalary.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PMsalary);
            this.groupBox1.Controls.Add(this.Dsalary);
            this.groupBox1.Controls.Add(this.Msalary);
            this.groupBox1.Controls.Add(this.Psalary);
            this.groupBox1.Location = new System.Drawing.Point(25, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OB1);
            this.groupBox2.Controls.Add(this.CA);
            this.groupBox2.Controls.Add(this.OB2);
            this.groupBox2.Controls.Add(this.HA);
            this.groupBox2.Location = new System.Drawing.Point(25, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benifits";
            // 
            // OB1
            // 
            this.OB1.AutoSize = true;
            this.OB1.Location = new System.Drawing.Point(45, 65);
            this.OB1.Name = "OB1";
            this.OB1.Size = new System.Drawing.Size(98, 17);
            this.OB1.TabIndex = 3;
            this.OB1.Text = "Other Benifits 1";
            this.OB1.UseVisualStyleBackColor = true;
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(169, 19);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(137, 17);
            this.CA.TabIndex = 2;
            this.CA.Text = "Convinience Allowance";
            this.CA.UseVisualStyleBackColor = true;
            // 
            // OB2
            // 
            this.OB2.AutoSize = true;
            this.OB2.Location = new System.Drawing.Point(169, 65);
            this.OB2.Name = "OB2";
            this.OB2.Size = new System.Drawing.Size(98, 17);
            this.OB2.TabIndex = 1;
            this.OB2.Text = "Other Benifits 2";
            this.OB2.UseVisualStyleBackColor = true;
            // 
            // HA
            // 
            this.HA.AutoSize = true;
            this.HA.Location = new System.Drawing.Point(45, 19);
            this.HA.Name = "HA";
            this.HA.Size = new System.Drawing.Size(117, 17);
            this.HA.TabIndex = 0;
            this.HA.Text = "Housing Allowance";
            this.HA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bonus:";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Project Completion Bonus",
            "Year End Bonus",
            "Performance Bonus",
            "Customer Appreciation Bonus"});
            this.listBox1.Location = new System.Drawing.Point(78, 372);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 17);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Provident Fund:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Medical Fund:";
            // 
            // PF
            // 
            this.PF.Location = new System.Drawing.Point(100, 27);
            this.PF.Name = "PF";
            this.PF.Size = new System.Drawing.Size(123, 20);
            this.PF.TabIndex = 17;
            this.PF.TextChanged += new System.EventHandler(this.PF_TextChanged);
            // 
            // MF
            // 
            this.MF.Location = new System.Drawing.Point(100, 69);
            this.MF.Name = "MF";
            this.MF.Size = new System.Drawing.Size(123, 20);
            this.MF.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MF);
            this.groupBox3.Controls.Add(this.PF);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(25, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deduction";
            // 
            // button1
            // 
            this.button1.AccessibleName = "calc";
            this.button1.Location = new System.Drawing.Point(28, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calc
            // 
            this.calc.AutoSize = true;
            this.calc.Location = new System.Drawing.Point(174, 563);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(13, 13);
            this.calc.TabIndex = 13;
            this.calc.Text = "--";
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // exit
            // 
            this.exit.AccessibleName = "calc";
            this.exit.Location = new System.Drawing.Point(246, 553);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 23);
            this.exit.TabIndex = 14;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // Form3
            // 
            this.AccessibleName = "form3";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 594);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "salary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Dsalary;
        private System.Windows.Forms.RadioButton PMsalary;
        private System.Windows.Forms.RadioButton Psalary;
        private System.Windows.Forms.RadioButton Msalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox OB1;
        private System.Windows.Forms.CheckBox CA;
        private System.Windows.Forms.CheckBox OB2;
        private System.Windows.Forms.CheckBox HA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PF;
        private System.Windows.Forms.TextBox MF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label calc;
        private System.Windows.Forms.Button exit;
    }
}