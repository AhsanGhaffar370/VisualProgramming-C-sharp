namespace lab6
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
            this.components = new System.ComponentModel.Container();
            this.min = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(257, 122);
            this.min.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(201, 75);
            this.min.TabIndex = 0;
            this.min.Text = "22:22";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.Location = new System.Drawing.Point(478, 122);
            this.sec.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(108, 75);
            this.sec.TabIndex = 1;
            this.sec.Text = "22";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(19, 36);
            this.date.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(439, 69);
            this.date.TabIndex = 3;
            this.date.Text = "March 11 2019";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(469, 36);
            this.day.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(296, 69);
            this.day.TabIndex = 4;
            this.day.Text = "MONDAY";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 263);
            this.Controls.Add(this.day);
            this.Controls.Add(this.date);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.min);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Timer timer1;
    }
}

