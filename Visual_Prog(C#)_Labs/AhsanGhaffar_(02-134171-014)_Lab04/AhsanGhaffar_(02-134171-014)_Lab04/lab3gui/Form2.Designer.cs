namespace lab3gui
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
            this.squares = new System.Windows.Forms.TextBox();
            this.sqofnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squares
            // 
            this.squares.Location = new System.Drawing.Point(46, 38);
            this.squares.Multiline = true;
            this.squares.Name = "squares";
            this.squares.Size = new System.Drawing.Size(177, 140);
            this.squares.TabIndex = 0;
            // 
            // sqofnum
            // 
            this.sqofnum.Location = new System.Drawing.Point(107, 201);
            this.sqofnum.Name = "sqofnum";
            this.sqofnum.Size = new System.Drawing.Size(75, 23);
            this.sqofnum.TabIndex = 1;
            this.sqofnum.Text = "Calculate";
            this.sqofnum.UseVisualStyleBackColor = true;
            this.sqofnum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.sqofnum);
            this.Controls.Add(this.squares);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox squares;
        private System.Windows.Forms.Button sqofnum;
    }
}