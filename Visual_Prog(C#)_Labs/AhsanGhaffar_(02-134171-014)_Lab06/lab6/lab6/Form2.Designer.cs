namespace lab6
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
            this.components = new System.ComponentModel.Container();
            this.hr = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.Escape = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.operation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sec = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hr
            // 
            this.hr.AutoSize = true;
            this.hr.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr.ForeColor = System.Drawing.Color.Red;
            this.hr.Location = new System.Drawing.Point(85, 164);
            this.hr.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(96, 73);
            this.hr.TabIndex = 0;
            this.hr.Text = "00";
            this.hr.Click += new System.EventHandler(this.label1_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(111, 306);
            this.start.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(175, 73);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(294, 407);
            this.reset.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(175, 69);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(111, 407);
            this.stop.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(175, 69);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // Escape
            // 
            this.Escape.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escape.Location = new System.Drawing.Point(294, 306);
            this.Escape.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Escape.Name = "Escape";
            this.Escape.Size = new System.Drawing.Size(175, 73);
            this.Escape.TabIndex = 6;
            this.Escape.Text = "Escape";
            this.Escape.UseVisualStyleBackColor = false;
            this.Escape.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(514, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 263);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Location = new System.Drawing.Point(615, 164);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(0, 37);
            this.operation.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.Color.Red;
            this.sec.Location = new System.Drawing.Point(373, 164);
            this.sec.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(96, 73);
            this.sec.TabIndex = 9;
            this.sec.Text = "00";
            this.sec.Click += new System.EventHandler(this.label2_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.Red;
            this.min.Location = new System.Drawing.Point(241, 164);
            this.min.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(96, 73);
            this.min.TabIndex = 10;
            this.min.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 73);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(332, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 73);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(241, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 73);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stop Watch";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Escape);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.hr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hr;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button Escape;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}