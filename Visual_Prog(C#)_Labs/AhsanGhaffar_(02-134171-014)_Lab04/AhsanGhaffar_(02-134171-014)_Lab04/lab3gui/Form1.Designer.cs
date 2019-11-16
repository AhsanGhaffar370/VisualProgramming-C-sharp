namespace lab3gui
{
    partial class form1
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
            this.divide = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.reslt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(56, 202);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 27);
            this.divide.TabIndex = 0;
            this.divide.Text = "Divide";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.task1_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(53, 61);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(97, 13);
            this.num1.TabIndex = 1;
            this.num1.Text = "Enter First Number:";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(53, 100);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(115, 13);
            this.num2.TabIndex = 2;
            this.num2.Text = "Enter Second Number:";
            this.num2.UseMnemonic = false;
            this.num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(53, 142);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 3;
            this.result.Text = "Result";
            this.result.Click += new System.EventHandler(this.label3_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(137, 204);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 4;
            this.sub.Text = "Subtraction";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(218, 204);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(309, 204);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 6;
            this.mul.Text = "Multiply";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(182, 58);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 7;
            this.number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(182, 97);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 8;
            this.number2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // reslt
            // 
            this.reslt.Location = new System.Drawing.Point(182, 139);
            this.reslt.Name = "reslt";
            this.reslt.Size = new System.Drawing.Size(100, 20);
            this.reslt.TabIndex = 9;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 298);
            this.Controls.Add(this.reslt);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.divide);
            this.Name = "form1";
            this.Text = "task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox reslt;
    }
}

