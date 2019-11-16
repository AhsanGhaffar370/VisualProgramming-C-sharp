namespace Vehical_Showroom_Management_System
{
    partial class Add_Customers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Customers));
            this.cancel_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.create_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.email_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnic_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cont_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.save_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.state_co = new Bunifu.Framework.UI.BunifuDropdown();
            this.country_co = new Bunifu.Framework.UI.BunifuDropdown();
            this.city_co = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.ActiveBorderThickness = 1;
            this.cancel_btn.ActiveCornerRadius = 20;
            this.cancel_btn.ActiveFillColor = System.Drawing.Color.Tomato;
            this.cancel_btn.ActiveForecolor = System.Drawing.Color.White;
            this.cancel_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_btn.BackgroundImage")));
            this.cancel_btn.ButtonText = "Cancel";
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.Black;
            this.cancel_btn.IdleBorderThickness = 1;
            this.cancel_btn.IdleCornerRadius = 20;
            this.cancel_btn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.cancel_btn.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.cancel_btn.Location = new System.Drawing.Point(245, 585);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(5);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(118, 40);
            this.cancel_btn.TabIndex = 225;
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 224;
            this.label1.Text = "Create Date";
            // 
            // create_date
            // 
            this.create_date.BackColor = System.Drawing.Color.SeaGreen;
            this.create_date.BorderRadius = 0;
            this.create_date.ForeColor = System.Drawing.Color.White;
            this.create_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.create_date.FormatCustom = null;
            this.create_date.Location = new System.Drawing.Point(167, 504);
            this.create_date.Name = "create_date";
            this.create_date.Size = new System.Drawing.Size(278, 34);
            this.create_date.TabIndex = 223;
            this.create_date.Value = new System.DateTime(2019, 4, 27, 2, 15, 59, 603);
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.email_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.email_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_tb.ForeColor = System.Drawing.Color.Black;
            this.email_tb.HintForeColor = System.Drawing.Color.Black;
            this.email_tb.HintText = "";
            this.email_tb.isPassword = false;
            this.email_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.email_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.email_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.email_tb.LineThickness = 2;
            this.email_tb.Location = new System.Drawing.Point(167, 234);
            this.email_tb.Margin = new System.Windows.Forms.Padding(4);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(278, 30);
            this.email_tb.TabIndex = 216;
            this.email_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cnic_tb
            // 
            this.cnic_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cnic_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnic_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnic_tb.ForeColor = System.Drawing.Color.Black;
            this.cnic_tb.HintForeColor = System.Drawing.Color.Black;
            this.cnic_tb.HintText = "";
            this.cnic_tb.isPassword = false;
            this.cnic_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.cnic_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.cnic_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.cnic_tb.LineThickness = 2;
            this.cnic_tb.Location = new System.Drawing.Point(167, 95);
            this.cnic_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cnic_tb.Name = "cnic_tb";
            this.cnic_tb.Size = new System.Drawing.Size(278, 30);
            this.cnic_tb.TabIndex = 215;
            this.cnic_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cont_tb
            // 
            this.cont_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cont_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cont_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cont_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cont_tb.ForeColor = System.Drawing.Color.Black;
            this.cont_tb.HintForeColor = System.Drawing.Color.Black;
            this.cont_tb.HintText = "";
            this.cont_tb.isPassword = false;
            this.cont_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.cont_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.cont_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.cont_tb.LineThickness = 2;
            this.cont_tb.Location = new System.Drawing.Point(167, 186);
            this.cont_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cont_tb.Name = "cont_tb";
            this.cont_tb.Size = new System.Drawing.Size(278, 30);
            this.cont_tb.TabIndex = 214;
            this.cont_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.name_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_tb.ForeColor = System.Drawing.Color.Black;
            this.name_tb.HintForeColor = System.Drawing.Color.Black;
            this.name_tb.HintText = "";
            this.name_tb.isPassword = false;
            this.name_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.name_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.name_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.name_tb.LineThickness = 2;
            this.name_tb.Location = new System.Drawing.Point(167, 141);
            this.name_tb.Margin = new System.Windows.Forms.Padding(4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(278, 30);
            this.name_tb.TabIndex = 213;
            this.name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // save_btn
            // 
            this.save_btn.ActiveBorderThickness = 1;
            this.save_btn.ActiveCornerRadius = 20;
            this.save_btn.ActiveFillColor = System.Drawing.Color.Tomato;
            this.save_btn.ActiveForecolor = System.Drawing.Color.White;
            this.save_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.save_btn.BackColor = System.Drawing.SystemColors.Control;
            this.save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_btn.BackgroundImage")));
            this.save_btn.ButtonText = "Save";
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.IdleBorderThickness = 1;
            this.save_btn.IdleCornerRadius = 20;
            this.save_btn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.save_btn.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.save_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.save_btn.Location = new System.Drawing.Point(86, 585);
            this.save_btn.Margin = new System.Windows.Forms.Padding(5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 40);
            this.save_btn.TabIndex = 211;
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(11, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 30);
            this.label14.TabIndex = 210;
            this.label14.Text = "Add Customer ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 55);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(429, 13);
            this.bunifuSeparator1.TabIndex = 209;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 208;
            this.label11.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 207;
            this.label7.Text = "CNIC No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 206;
            this.label6.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 205;
            this.label2.Text = "Contact No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 204;
            this.label3.Text = "Name";
            // 
            // address_tb
            // 
            this.address_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.address_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.address_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.address_tb.ForeColor = System.Drawing.Color.Black;
            this.address_tb.HintForeColor = System.Drawing.Color.Black;
            this.address_tb.HintText = "";
            this.address_tb.isPassword = false;
            this.address_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.address_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.address_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.address_tb.LineThickness = 2;
            this.address_tb.Location = new System.Drawing.Point(167, 396);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(278, 101);
            this.address_tb.TabIndex = 255;
            this.address_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 284;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 281;
            this.label5.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 280;
            this.label8.Text = "City";
            // 
            // state_co
            // 
            this.state_co.BackColor = System.Drawing.Color.Transparent;
            this.state_co.BorderRadius = 3;
            this.state_co.DisabledColor = System.Drawing.Color.Gray;
            this.state_co.ForeColor = System.Drawing.Color.White;
            this.state_co.Items = new string[] {
        "Sindh",
        "Punjab",
        "Mexico",
        "Chicago",
        "Chitagong"};
            this.state_co.Location = new System.Drawing.Point(167, 313);
            this.state_co.Name = "state_co";
            this.state_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.state_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.state_co.selectedIndex = -1;
            this.state_co.Size = new System.Drawing.Size(278, 35);
            this.state_co.TabIndex = 288;
            // 
            // country_co
            // 
            this.country_co.BackColor = System.Drawing.Color.Transparent;
            this.country_co.BorderRadius = 3;
            this.country_co.DisabledColor = System.Drawing.Color.Gray;
            this.country_co.ForeColor = System.Drawing.Color.White;
            this.country_co.Items = new string[] {
        "Pakistan",
        "Saudia_Arabia",
        "Bangladesh",
        "Afghanistan",
        "India",
        "Austrail"};
            this.country_co.Location = new System.Drawing.Point(167, 272);
            this.country_co.Name = "country_co";
            this.country_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.country_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.country_co.selectedIndex = -1;
            this.country_co.Size = new System.Drawing.Size(278, 35);
            this.country_co.TabIndex = 287;
            // 
            // city_co
            // 
            this.city_co.BackColor = System.Drawing.Color.Transparent;
            this.city_co.BorderRadius = 3;
            this.city_co.DisabledColor = System.Drawing.Color.Gray;
            this.city_co.ForeColor = System.Drawing.Color.White;
            this.city_co.Items = new string[] {
        "Hyderabad",
        "Delhi",
        "Karachi",
        "Islamabad"};
            this.city_co.Location = new System.Drawing.Point(167, 354);
            this.city_co.Name = "city_co";
            this.city_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.city_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.city_co.selectedIndex = -1;
            this.city_co.Size = new System.Drawing.Size(278, 35);
            this.city_co.TabIndex = 286;
            // 
            // Add_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.state_co);
            this.Controls.Add(this.country_co);
            this.Controls.Add(this.city_co);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_date);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.cnic_tb);
            this.Controls.Add(this.cont_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Add_Customers";
            this.Size = new System.Drawing.Size(804, 704);
            this.Load += new System.EventHandler(this.Add_Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancel_btn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker create_date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnic_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cont_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_tb;
        private Bunifu.Framework.UI.BunifuThinButton2 save_btn;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDropdown state_co;
        private Bunifu.Framework.UI.BunifuDropdown country_co;
        private Bunifu.Framework.UI.BunifuDropdown city_co;
    }
}
