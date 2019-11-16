namespace Vehical_Showroom_Management_System
{
    partial class AvailableCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableCars));
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label12 = new System.Windows.Forms.Label();
            this.carimg = new System.Windows.Forms.PictureBox();
            this.car_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manuf_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label11 = new System.Windows.Forms.Label();
            this.engine_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sell_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buyPrice_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.color_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.model_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.brand_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.chasis_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serChassis_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.carimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 303);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(737, 10);
            this.bunifuSeparator2.TabIndex = 362;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(368, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 360;
            this.label12.Text = "Image";
            // 
            // carimg
            // 
            this.carimg.BackColor = System.Drawing.SystemColors.Control;
            this.carimg.Location = new System.Drawing.Point(539, 185);
            this.carimg.Name = "carimg";
            this.carimg.Size = new System.Drawing.Size(210, 128);
            this.carimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carimg.TabIndex = 359;
            this.carimg.TabStop = false;
            // 
            // car_gv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.car_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.car_gv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.car_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.car_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.car_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_gv.DoubleBuffered = true;
            this.car_gv.EnableHeadersVisualStyles = false;
            this.car_gv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.car_gv.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.car_gv.Location = new System.Drawing.Point(0, 360);
            this.car_gv.Name = "car_gv";
            this.car_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.car_gv.Size = new System.Drawing.Size(760, 287);
            this.car_gv.TabIndex = 357;
            // 
            // manuf_date
            // 
            this.manuf_date.BackColor = System.Drawing.Color.SeaGreen;
            this.manuf_date.BorderRadius = 0;
            this.manuf_date.ForeColor = System.Drawing.Color.White;
            this.manuf_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.manuf_date.FormatCustom = null;
            this.manuf_date.Location = new System.Drawing.Point(539, 78);
            this.manuf_date.Name = "manuf_date";
            this.manuf_date.Size = new System.Drawing.Size(210, 28);
            this.manuf_date.TabIndex = 356;
            this.manuf_date.Value = new System.DateTime(2019, 4, 27, 2, 15, 59, 603);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 18);
            this.label11.TabIndex = 355;
            this.label11.Text = "Year Of Manufacturing";
            // 
            // engine_tb
            // 
            this.engine_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.engine_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.engine_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.engine_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.engine_tb.ForeColor = System.Drawing.Color.Black;
            this.engine_tb.HintForeColor = System.Drawing.Color.Black;
            this.engine_tb.HintText = "";
            this.engine_tb.isPassword = false;
            this.engine_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.engine_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.engine_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.engine_tb.LineThickness = 2;
            this.engine_tb.Location = new System.Drawing.Point(102, 192);
            this.engine_tb.Margin = new System.Windows.Forms.Padding(4);
            this.engine_tb.Name = "engine_tb";
            this.engine_tb.Size = new System.Drawing.Size(227, 30);
            this.engine_tb.TabIndex = 354;
            this.engine_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // reg_tb
            // 
            this.reg_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reg_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reg_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_tb.ForeColor = System.Drawing.Color.Black;
            this.reg_tb.HintForeColor = System.Drawing.Color.Black;
            this.reg_tb.HintText = "";
            this.reg_tb.isPassword = false;
            this.reg_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.reg_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.reg_tb.LineThickness = 2;
            this.reg_tb.Location = new System.Drawing.Point(539, 41);
            this.reg_tb.Margin = new System.Windows.Forms.Padding(4);
            this.reg_tb.Name = "reg_tb";
            this.reg_tb.Size = new System.Drawing.Size(210, 30);
            this.reg_tb.TabIndex = 353;
            this.reg_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 352;
            this.label5.Text = "Engine No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 351;
            this.label9.Text = "Registration No";
            // 
            // sell_tb
            // 
            this.sell_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sell_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sell_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sell_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sell_tb.ForeColor = System.Drawing.Color.Black;
            this.sell_tb.HintForeColor = System.Drawing.Color.Black;
            this.sell_tb.HintText = "";
            this.sell_tb.isPassword = false;
            this.sell_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.sell_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.sell_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.sell_tb.LineThickness = 2;
            this.sell_tb.Location = new System.Drawing.Point(539, 148);
            this.sell_tb.Margin = new System.Windows.Forms.Padding(4);
            this.sell_tb.Name = "sell_tb";
            this.sell_tb.Size = new System.Drawing.Size(210, 30);
            this.sell_tb.TabIndex = 350;
            this.sell_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buyPrice_tb
            // 
            this.buyPrice_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buyPrice_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyPrice_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buyPrice_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buyPrice_tb.ForeColor = System.Drawing.Color.Black;
            this.buyPrice_tb.HintForeColor = System.Drawing.Color.Black;
            this.buyPrice_tb.HintText = "";
            this.buyPrice_tb.isPassword = false;
            this.buyPrice_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.buyPrice_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.buyPrice_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.buyPrice_tb.LineThickness = 2;
            this.buyPrice_tb.Location = new System.Drawing.Point(539, 110);
            this.buyPrice_tb.Margin = new System.Windows.Forms.Padding(4);
            this.buyPrice_tb.Name = "buyPrice_tb";
            this.buyPrice_tb.Size = new System.Drawing.Size(210, 30);
            this.buyPrice_tb.TabIndex = 349;
            this.buyPrice_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 348;
            this.label8.Text = "Sell Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 347;
            this.label7.Text = "Buy Price";
            // 
            // color_tb
            // 
            this.color_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.color_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.color_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.color_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.color_tb.ForeColor = System.Drawing.Color.Black;
            this.color_tb.HintForeColor = System.Drawing.Color.Black;
            this.color_tb.HintText = "";
            this.color_tb.isPassword = false;
            this.color_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.color_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.color_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.color_tb.LineThickness = 2;
            this.color_tb.Location = new System.Drawing.Point(102, 154);
            this.color_tb.Margin = new System.Windows.Forms.Padding(4);
            this.color_tb.Name = "color_tb";
            this.color_tb.Size = new System.Drawing.Size(227, 30);
            this.color_tb.TabIndex = 346;
            this.color_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 345;
            this.label1.Text = "COLOR";
            // 
            // model_tb
            // 
            this.model_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.model_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.model_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.model_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.model_tb.ForeColor = System.Drawing.Color.Black;
            this.model_tb.HintForeColor = System.Drawing.Color.Black;
            this.model_tb.HintText = "";
            this.model_tb.isPassword = false;
            this.model_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.model_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.model_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.model_tb.LineThickness = 2;
            this.model_tb.Location = new System.Drawing.Point(102, 116);
            this.model_tb.Margin = new System.Windows.Forms.Padding(4);
            this.model_tb.Name = "model_tb";
            this.model_tb.Size = new System.Drawing.Size(227, 30);
            this.model_tb.TabIndex = 344;
            this.model_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 343;
            this.label3.Text = "MODEL";
            // 
            // brand_tb
            // 
            this.brand_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brand_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brand_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brand_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brand_tb.ForeColor = System.Drawing.Color.Black;
            this.brand_tb.HintForeColor = System.Drawing.Color.Black;
            this.brand_tb.HintText = "";
            this.brand_tb.isPassword = false;
            this.brand_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.brand_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.brand_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.brand_tb.LineThickness = 2;
            this.brand_tb.Location = new System.Drawing.Point(102, 78);
            this.brand_tb.Margin = new System.Windows.Forms.Padding(4);
            this.brand_tb.Name = "brand_tb";
            this.brand_tb.Size = new System.Drawing.Size(227, 30);
            this.brand_tb.TabIndex = 342;
            this.brand_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "BRAND";
            // 
            // chasis_tb
            // 
            this.chasis_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chasis_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chasis_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chasis_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.chasis_tb.ForeColor = System.Drawing.Color.Black;
            this.chasis_tb.HintForeColor = System.Drawing.Color.Black;
            this.chasis_tb.HintText = "";
            this.chasis_tb.isPassword = false;
            this.chasis_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.chasis_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.chasis_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.chasis_tb.LineThickness = 2;
            this.chasis_tb.Location = new System.Drawing.Point(102, 42);
            this.chasis_tb.Margin = new System.Windows.Forms.Padding(4);
            this.chasis_tb.Name = "chasis_tb";
            this.chasis_tb.Size = new System.Drawing.Size(227, 30);
            this.chasis_tb.TabIndex = 340;
            this.chasis_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 339;
            this.label6.Text = "Chassis No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 338;
            this.label4.Text = "Chassis No";
            // 
            // serChassis_tb
            // 
            this.serChassis_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.serChassis_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serChassis_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serChassis_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.serChassis_tb.ForeColor = System.Drawing.Color.Black;
            this.serChassis_tb.HintForeColor = System.Drawing.Color.Black;
            this.serChassis_tb.HintText = "";
            this.serChassis_tb.isPassword = false;
            this.serChassis_tb.LineFocusedColor = System.Drawing.Color.Black;
            this.serChassis_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.serChassis_tb.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.serChassis_tb.LineThickness = 2;
            this.serChassis_tb.Location = new System.Drawing.Point(95, 323);
            this.serChassis_tb.Margin = new System.Windows.Forms.Padding(4);
            this.serChassis_tb.Name = "serChassis_tb";
            this.serChassis_tb.Size = new System.Drawing.Size(204, 30);
            this.serChassis_tb.TabIndex = 337;
            this.serChassis_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Search
            // 
            this.Search.ActiveBorderThickness = 1;
            this.Search.ActiveCornerRadius = 20;
            this.Search.ActiveFillColor = System.Drawing.Color.Tomato;
            this.Search.ActiveForecolor = System.Drawing.Color.White;
            this.Search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Search.BackColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.Search.Location = new System.Drawing.Point(306, 313);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 40);
            this.Search.TabIndex = 334;
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 30);
            this.label10.TabIndex = 333;
            this.label10.Text = "Available CARS";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 27);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(737, 19);
            this.bunifuSeparator1.TabIndex = 332;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // AvailableCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.carimg);
            this.Controls.Add(this.car_gv);
            this.Controls.Add(this.manuf_date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.engine_tb);
            this.Controls.Add(this.reg_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sell_tb);
            this.Controls.Add(this.buyPrice_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.color_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.model_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brand_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chasis_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serChassis_tb);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "AvailableCars";
            this.Size = new System.Drawing.Size(760, 647);
            ((System.ComponentModel.ISupportInitialize)(this.carimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox carimg;
        private Bunifu.Framework.UI.BunifuCustomDataGrid car_gv;
        private Bunifu.Framework.UI.BunifuDatepicker manuf_date;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox engine_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sell_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buyPrice_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox color_tb;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox model_tb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox brand_tb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox chasis_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox serChassis_tb;
        private Bunifu.Framework.UI.BunifuThinButton2 Search;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
