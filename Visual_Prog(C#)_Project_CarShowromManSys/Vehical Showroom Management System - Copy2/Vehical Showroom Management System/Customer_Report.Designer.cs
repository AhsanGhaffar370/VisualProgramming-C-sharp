namespace Vehical_Showroom_Management_System
{
    partial class Customer_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.serCnic_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.update_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnic_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cont_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customer_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Reset_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.state_co = new Bunifu.Framework.UI.BunifuDropdown();
            this.country_co = new Bunifu.Framework.UI.BunifuDropdown();
            this.city_co = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.customer_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 30);
            this.label10.TabIndex = 176;
            this.label10.Text = "Customer Report";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 22);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(737, 19);
            this.bunifuSeparator1.TabIndex = 175;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // delete
            // 
            this.delete.ActiveBorderThickness = 1;
            this.delete.ActiveCornerRadius = 20;
            this.delete.ActiveFillColor = System.Drawing.Color.Tomato;
            this.delete.ActiveForecolor = System.Drawing.Color.White;
            this.delete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.ButtonText = "Delete";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.IdleBorderThickness = 1;
            this.delete.IdleCornerRadius = 20;
            this.delete.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.delete.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.IdleLineColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(500, 238);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 40);
            this.delete.TabIndex = 183;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.ActiveBorderThickness = 1;
            this.update.ActiveCornerRadius = 20;
            this.update.ActiveFillColor = System.Drawing.Color.Tomato;
            this.update.ActiveForecolor = System.Drawing.Color.White;
            this.update.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.ButtonText = "Update";
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.IdleBorderThickness = 1;
            this.update.IdleCornerRadius = 20;
            this.update.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.update.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.update.IdleLineColor = System.Drawing.Color.Transparent;
            this.update.Location = new System.Drawing.Point(619, 238);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 40);
            this.update.TabIndex = 182;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Search
            // 
            this.Search.ActiveBorderThickness = 1;
            this.Search.ActiveCornerRadius = 20;
            this.Search.ActiveFillColor = System.Drawing.Color.Tomato;
            this.Search.ActiveForecolor = System.Drawing.Color.White;
            this.Search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.ButtonText = "Search";
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.IdleBorderThickness = 1;
            this.Search.IdleCornerRadius = 20;
            this.Search.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.Search.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.Search.IdleLineColor = System.Drawing.Color.Transparent;
            this.Search.Location = new System.Drawing.Point(315, 271);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 40);
            this.Search.TabIndex = 181;
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // serCnic_tb
            // 
            this.serCnic_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.serCnic_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serCnic_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serCnic_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.serCnic_tb.ForeColor = System.Drawing.Color.Black;
            this.serCnic_tb.HintForeColor = System.Drawing.Color.Black;
            this.serCnic_tb.HintText = "";
            this.serCnic_tb.isPassword = false;
            this.serCnic_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.serCnic_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.serCnic_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.serCnic_tb.LineThickness = 2;
            this.serCnic_tb.Location = new System.Drawing.Point(91, 281);
            this.serCnic_tb.Margin = new System.Windows.Forms.Padding(4);
            this.serCnic_tb.Name = "serCnic_tb";
            this.serCnic_tb.Size = new System.Drawing.Size(215, 30);
            this.serCnic_tb.TabIndex = 184;
            this.serCnic_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.address_tb.Location = new System.Drawing.Point(500, 158);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(249, 72);
            this.address_tb.TabIndex = 273;
            this.address_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 272;
            this.label1.Text = "Update Date";
            // 
            // update_date
            // 
            this.update_date.BackColor = System.Drawing.Color.SeaGreen;
            this.update_date.BorderRadius = 0;
            this.update_date.ForeColor = System.Drawing.Color.White;
            this.update_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.update_date.FormatCustom = null;
            this.update_date.Location = new System.Drawing.Point(108, 198);
            this.update_date.Margin = new System.Windows.Forms.Padding(6);
            this.update_date.Name = "update_date";
            this.update_date.Size = new System.Drawing.Size(278, 31);
            this.update_date.TabIndex = 271;
            this.update_date.Value = new System.DateTime(2019, 4, 27, 2, 15, 59, 603);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(423, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 269;
            this.label12.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 268;
            this.label9.Text = "City";
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
            this.email_tb.Location = new System.Drawing.Point(108, 158);
            this.email_tb.Margin = new System.Windows.Forms.Padding(4);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(278, 30);
            this.email_tb.TabIndex = 264;
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
            this.cnic_tb.Location = new System.Drawing.Point(108, 44);
            this.cnic_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cnic_tb.Name = "cnic_tb";
            this.cnic_tb.Size = new System.Drawing.Size(278, 30);
            this.cnic_tb.TabIndex = 263;
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
            this.cont_tb.Location = new System.Drawing.Point(108, 120);
            this.cont_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cont_tb.Name = "cont_tb";
            this.cont_tb.Size = new System.Drawing.Size(278, 30);
            this.cont_tb.TabIndex = 262;
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
            this.name_tb.Location = new System.Drawing.Point(108, 82);
            this.name_tb.Margin = new System.Windows.Forms.Padding(4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(278, 30);
            this.name_tb.TabIndex = 261;
            this.name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 260;
            this.label11.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 259;
            this.label7.Text = "CNIC No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 258;
            this.label6.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 257;
            this.label2.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 256;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 274;
            this.label4.Text = "CNIC No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(423, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 278;
            this.label13.Text = "State";
            // 
            // customer_gv
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customer_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.customer_gv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.customer_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.customer_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_gv.DoubleBuffered = true;
            this.customer_gv.EnableHeadersVisualStyles = false;
            this.customer_gv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.customer_gv.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.customer_gv.Location = new System.Drawing.Point(12, 329);
            this.customer_gv.Name = "customer_gv";
            this.customer_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customer_gv.Size = new System.Drawing.Size(737, 198);
            this.customer_gv.TabIndex = 288;
            this.customer_gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_gv_CellClick);
            this.customer_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_gv_CellContentClick);
            // 
            // Reset_btn
            // 
            this.Reset_btn.ActiveBorderThickness = 1;
            this.Reset_btn.ActiveCornerRadius = 20;
            this.Reset_btn.ActiveFillColor = System.Drawing.Color.Tomato;
            this.Reset_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Reset_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Reset_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Reset_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reset_btn.BackgroundImage")));
            this.Reset_btn.ButtonText = "Reset";
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.Color.Black;
            this.Reset_btn.IdleBorderThickness = 1;
            this.Reset_btn.IdleCornerRadius = 20;
            this.Reset_btn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.Reset_btn.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.Reset_btn.Location = new System.Drawing.Point(619, 281);
            this.Reset_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(118, 44);
            this.Reset_btn.TabIndex = 292;
            this.Reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
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
            this.state_co.Location = new System.Drawing.Point(500, 77);
            this.state_co.Name = "state_co";
            this.state_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.state_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.state_co.selectedIndex = -1;
            this.state_co.Size = new System.Drawing.Size(249, 35);
            this.state_co.TabIndex = 295;
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
            this.country_co.Location = new System.Drawing.Point(500, 36);
            this.country_co.Name = "country_co";
            this.country_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.country_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.country_co.selectedIndex = -1;
            this.country_co.Size = new System.Drawing.Size(249, 35);
            this.country_co.TabIndex = 294;
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
            this.city_co.Location = new System.Drawing.Point(500, 118);
            this.city_co.Name = "city_co";
            this.city_co.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.city_co.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.city_co.selectedIndex = -1;
            this.city_co.Size = new System.Drawing.Size(249, 35);
            this.city_co.TabIndex = 293;
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.state_co);
            this.Controls.Add(this.country_co);
            this.Controls.Add(this.city_co);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.customer_gv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.cnic_tb);
            this.Controls.Add(this.cont_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serCnic_tb);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "Customer_Report";
            this.Size = new System.Drawing.Size(753, 539);
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 delete;
        private Bunifu.Framework.UI.BunifuThinButton2 update;
        private Bunifu.Framework.UI.BunifuThinButton2 Search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox serCnic_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address_tb;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker update_date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnic_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cont_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuCustomDataGrid customer_gv;
        private Bunifu.Framework.UI.BunifuThinButton2 Reset_btn;
        private Bunifu.Framework.UI.BunifuDropdown state_co;
        private Bunifu.Framework.UI.BunifuDropdown country_co;
        private Bunifu.Framework.UI.BunifuDropdown city_co;
    }
}
