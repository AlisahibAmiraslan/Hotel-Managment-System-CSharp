namespace HotelManagmentSystem
{
    partial class CheckOut
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashbaordExit = new System.Windows.Forms.Label();
            this.checkOutdgw = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.checkOutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.checkOutPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.checkIndp = new System.Windows.Forms.DateTimePicker();
            this.checkInChecklbl = new System.Windows.Forms.Label();
            this.roomNumberChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.countryChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passportChecklbl = new System.Windows.Forms.Label();
            this.roomNumberChecklbl = new System.Windows.Forms.Label();
            this.roomPriceChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.checkOutCheckdp = new System.Windows.Forms.DateTimePicker();
            this.phoneChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passprtChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lastNameChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firstNameChecktbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomPriceChecklbl = new System.Windows.Forms.Label();
            this.CheckOutChecklbl = new System.Windows.Forms.Label();
            this.countryChecklbl = new System.Windows.Forms.Label();
            this.phoneChecklbl = new System.Windows.Forms.Label();
            this.lastNameChecklbl = new System.Windows.Forms.Label();
            this.firstNameChecklbl = new System.Windows.Forms.Label();
            this.checkOutlbl = new System.Windows.Forms.Label();
            this.showAllcheckOutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutdgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutPanel)).BeginInit();
            this.checkOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(-2, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1624, 91);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(737, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Check Out";
            // 
            // dashbaordExit
            // 
            this.dashbaordExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashbaordExit.AutoSize = true;
            this.dashbaordExit.BackColor = System.Drawing.Color.Crimson;
            this.dashbaordExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbaordExit.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashbaordExit.ForeColor = System.Drawing.Color.White;
            this.dashbaordExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashbaordExit.Location = new System.Drawing.Point(1559, 12);
            this.dashbaordExit.Name = "dashbaordExit";
            this.dashbaordExit.Size = new System.Drawing.Size(45, 48);
            this.dashbaordExit.TabIndex = 0;
            this.dashbaordExit.Text = "X";
            this.dashbaordExit.Click += new System.EventHandler(this.dashbaordExit_Click);
            // 
            // checkOutdgw
            // 
            this.checkOutdgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkOutdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkOutdgw.Location = new System.Drawing.Point(23, 129);
            this.checkOutdgw.Name = "checkOutdgw";
            this.checkOutdgw.RowHeadersWidth = 51;
            this.checkOutdgw.RowTemplate.Height = 24;
            this.checkOutdgw.Size = new System.Drawing.Size(1563, 314);
            this.checkOutdgw.TabIndex = 4;
            this.checkOutdgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkOutdgw_CellClick);
            // 
            // checkOutbtn
            // 
            this.checkOutbtn.BackColor = System.Drawing.Color.Crimson;
            this.checkOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.checkOutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.checkOutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.checkOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.checkOutbtn.ForeColor = System.Drawing.Color.White;
            this.checkOutbtn.Location = new System.Drawing.Point(23, 832);
            this.checkOutbtn.Name = "checkOutbtn";
            this.checkOutbtn.Size = new System.Drawing.Size(180, 43);
            this.checkOutbtn.TabIndex = 49;
            this.checkOutbtn.Text = "Check Out";
            this.checkOutbtn.UseVisualStyleBackColor = false;
            this.checkOutbtn.Click += new System.EventHandler(this.checkOutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Crimson;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.backbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(1406, 832);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(180, 43);
            this.backbtn.TabIndex = 50;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // checkOutPanel
            // 
            this.checkOutPanel.Controls.Add(this.checkIndp);
            this.checkOutPanel.Controls.Add(this.checkInChecklbl);
            this.checkOutPanel.Controls.Add(this.roomNumberChecktbx);
            this.checkOutPanel.Controls.Add(this.countryChecktbx);
            this.checkOutPanel.Controls.Add(this.passportChecklbl);
            this.checkOutPanel.Controls.Add(this.roomNumberChecklbl);
            this.checkOutPanel.Controls.Add(this.roomPriceChecktbx);
            this.checkOutPanel.Controls.Add(this.checkOutCheckdp);
            this.checkOutPanel.Controls.Add(this.phoneChecktbx);
            this.checkOutPanel.Controls.Add(this.passprtChecktbx);
            this.checkOutPanel.Controls.Add(this.lastNameChecktbx);
            this.checkOutPanel.Controls.Add(this.firstNameChecktbx);
            this.checkOutPanel.Controls.Add(this.roomPriceChecklbl);
            this.checkOutPanel.Controls.Add(this.CheckOutChecklbl);
            this.checkOutPanel.Controls.Add(this.countryChecklbl);
            this.checkOutPanel.Controls.Add(this.phoneChecklbl);
            this.checkOutPanel.Controls.Add(this.lastNameChecklbl);
            this.checkOutPanel.Controls.Add(this.firstNameChecklbl);
            this.checkOutPanel.Location = new System.Drawing.Point(23, 534);
            this.checkOutPanel.Name = "checkOutPanel";
            this.checkOutPanel.Size = new System.Drawing.Size(1563, 244);
            this.checkOutPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOutPanel.TabIndex = 51;
            // 
            // checkIndp
            // 
            this.checkIndp.Enabled = false;
            this.checkIndp.Location = new System.Drawing.Point(200, 161);
            this.checkIndp.Name = "checkIndp";
            this.checkIndp.Size = new System.Drawing.Size(267, 22);
            this.checkIndp.TabIndex = 73;
            // 
            // checkInChecklbl
            // 
            this.checkInChecklbl.AutoSize = true;
            this.checkInChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.checkInChecklbl.Location = new System.Drawing.Point(286, 123);
            this.checkInChecklbl.Name = "checkInChecklbl";
            this.checkInChecklbl.Size = new System.Drawing.Size(83, 22);
            this.checkInChecklbl.TabIndex = 72;
            this.checkInChecklbl.Text = "Check In";
            // 
            // roomNumberChecktbx
            // 
            this.roomNumberChecktbx.Enabled = false;
            this.roomNumberChecktbx.Location = new System.Drawing.Point(820, 152);
            this.roomNumberChecktbx.Name = "roomNumberChecktbx";
            this.roomNumberChecktbx.Size = new System.Drawing.Size(238, 37);
            this.roomNumberChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.roomNumberChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomNumberChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.roomNumberChecktbx.StateCommon.Border.Rounding = 15;
            this.roomNumberChecktbx.TabIndex = 71;
            // 
            // countryChecktbx
            // 
            this.countryChecktbx.Enabled = false;
            this.countryChecktbx.Location = new System.Drawing.Point(1231, 59);
            this.countryChecktbx.Name = "countryChecktbx";
            this.countryChecktbx.Size = new System.Drawing.Size(238, 37);
            this.countryChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.countryChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.countryChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.countryChecktbx.StateCommon.Border.Rounding = 15;
            this.countryChecktbx.TabIndex = 70;
            // 
            // passportChecklbl
            // 
            this.passportChecklbl.AutoSize = true;
            this.passportChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.passportChecklbl.Location = new System.Drawing.Point(721, 25);
            this.passportChecklbl.Name = "passportChecklbl";
            this.passportChecklbl.Size = new System.Drawing.Size(106, 22);
            this.passportChecklbl.TabIndex = 69;
            this.passportChecklbl.Text = "Passport ID";
            // 
            // roomNumberChecklbl
            // 
            this.roomNumberChecklbl.AutoSize = true;
            this.roomNumberChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomNumberChecklbl.Location = new System.Drawing.Point(863, 123);
            this.roomNumberChecklbl.Name = "roomNumberChecklbl";
            this.roomNumberChecklbl.Size = new System.Drawing.Size(128, 22);
            this.roomNumberChecklbl.TabIndex = 68;
            this.roomNumberChecklbl.Text = "Room Number";
            // 
            // roomPriceChecktbx
            // 
            this.roomPriceChecktbx.Enabled = false;
            this.roomPriceChecktbx.Location = new System.Drawing.Point(1108, 152);
            this.roomPriceChecktbx.Name = "roomPriceChecktbx";
            this.roomPriceChecktbx.Size = new System.Drawing.Size(238, 37);
            this.roomPriceChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.roomPriceChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomPriceChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.roomPriceChecktbx.StateCommon.Border.Rounding = 15;
            this.roomPriceChecktbx.TabIndex = 66;
            // 
            // checkOutCheckdp
            // 
            this.checkOutCheckdp.Location = new System.Drawing.Point(514, 162);
            this.checkOutCheckdp.Name = "checkOutCheckdp";
            this.checkOutCheckdp.Size = new System.Drawing.Size(267, 22);
            this.checkOutCheckdp.TabIndex = 64;
            // 
            // phoneChecktbx
            // 
            this.phoneChecktbx.Enabled = false;
            this.phoneChecktbx.Location = new System.Drawing.Point(957, 59);
            this.phoneChecktbx.Name = "phoneChecktbx";
            this.phoneChecktbx.Size = new System.Drawing.Size(238, 37);
            this.phoneChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.phoneChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.phoneChecktbx.StateCommon.Border.Rounding = 15;
            this.phoneChecktbx.TabIndex = 61;
            // 
            // passprtChecktbx
            // 
            this.passprtChecktbx.Enabled = false;
            this.passprtChecktbx.Location = new System.Drawing.Point(669, 59);
            this.passprtChecktbx.Name = "passprtChecktbx";
            this.passprtChecktbx.Size = new System.Drawing.Size(238, 37);
            this.passprtChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passprtChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passprtChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.passprtChecktbx.StateCommon.Border.Rounding = 15;
            this.passprtChecktbx.TabIndex = 60;
            // 
            // lastNameChecktbx
            // 
            this.lastNameChecktbx.Enabled = false;
            this.lastNameChecktbx.Location = new System.Drawing.Point(374, 59);
            this.lastNameChecktbx.Name = "lastNameChecktbx";
            this.lastNameChecktbx.Size = new System.Drawing.Size(238, 37);
            this.lastNameChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.lastNameChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.lastNameChecktbx.StateCommon.Border.Rounding = 15;
            this.lastNameChecktbx.TabIndex = 59;
            // 
            // firstNameChecktbx
            // 
            this.firstNameChecktbx.Enabled = false;
            this.firstNameChecktbx.Location = new System.Drawing.Point(50, 59);
            this.firstNameChecktbx.Name = "firstNameChecktbx";
            this.firstNameChecktbx.Size = new System.Drawing.Size(267, 37);
            this.firstNameChecktbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.firstNameChecktbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameChecktbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.firstNameChecktbx.StateCommon.Border.Rounding = 15;
            this.firstNameChecktbx.TabIndex = 58;
            // 
            // roomPriceChecklbl
            // 
            this.roomPriceChecklbl.AutoSize = true;
            this.roomPriceChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomPriceChecklbl.Location = new System.Drawing.Point(1164, 123);
            this.roomPriceChecklbl.Name = "roomPriceChecklbl";
            this.roomPriceChecklbl.Size = new System.Drawing.Size(105, 22);
            this.roomPriceChecklbl.TabIndex = 57;
            this.roomPriceChecklbl.Text = "Room Price";
            // 
            // CheckOutChecklbl
            // 
            this.CheckOutChecklbl.AutoSize = true;
            this.CheckOutChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CheckOutChecklbl.Location = new System.Drawing.Point(600, 123);
            this.CheckOutChecklbl.Name = "CheckOutChecklbl";
            this.CheckOutChecklbl.Size = new System.Drawing.Size(97, 22);
            this.CheckOutChecklbl.TabIndex = 56;
            this.CheckOutChecklbl.Text = "Check Out";
            // 
            // countryChecklbl
            // 
            this.countryChecklbl.AutoSize = true;
            this.countryChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.countryChecklbl.Location = new System.Drawing.Point(1310, 25);
            this.countryChecklbl.Name = "countryChecklbl";
            this.countryChecklbl.Size = new System.Drawing.Size(76, 22);
            this.countryChecklbl.TabIndex = 53;
            this.countryChecklbl.Text = "Country";
            // 
            // phoneChecklbl
            // 
            this.phoneChecklbl.AutoSize = true;
            this.phoneChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.phoneChecklbl.Location = new System.Drawing.Point(1010, 25);
            this.phoneChecklbl.Name = "phoneChecklbl";
            this.phoneChecklbl.Size = new System.Drawing.Size(108, 22);
            this.phoneChecklbl.TabIndex = 52;
            this.phoneChecklbl.Text = "Phone Num";
            // 
            // lastNameChecklbl
            // 
            this.lastNameChecklbl.AutoSize = true;
            this.lastNameChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lastNameChecklbl.Location = new System.Drawing.Point(443, 25);
            this.lastNameChecklbl.Name = "lastNameChecklbl";
            this.lastNameChecklbl.Size = new System.Drawing.Size(99, 22);
            this.lastNameChecklbl.TabIndex = 51;
            this.lastNameChecklbl.Text = "Last Name";
            // 
            // firstNameChecklbl
            // 
            this.firstNameChecklbl.AutoSize = true;
            this.firstNameChecklbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.firstNameChecklbl.Location = new System.Drawing.Point(136, 25);
            this.firstNameChecklbl.Name = "firstNameChecklbl";
            this.firstNameChecklbl.Size = new System.Drawing.Size(101, 22);
            this.firstNameChecklbl.TabIndex = 50;
            this.firstNameChecklbl.Text = "First Name";
            // 
            // checkOutlbl
            // 
            this.checkOutlbl.AutoSize = true;
            this.checkOutlbl.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkOutlbl.Location = new System.Drawing.Point(698, 469);
            this.checkOutlbl.Name = "checkOutlbl";
            this.checkOutlbl.Size = new System.Drawing.Size(259, 36);
            this.checkOutlbl.TabIndex = 52;
            this.checkOutlbl.Text = "Check Out Rooms";
            // 
            // showAllcheckOutbtn
            // 
            this.showAllcheckOutbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.showAllcheckOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllcheckOutbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.showAllcheckOutbtn.FlatAppearance.BorderSize = 0;
            this.showAllcheckOutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showAllcheckOutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.showAllcheckOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllcheckOutbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.showAllcheckOutbtn.ForeColor = System.Drawing.Color.White;
            this.showAllcheckOutbtn.Location = new System.Drawing.Point(680, 832);
            this.showAllcheckOutbtn.Name = "showAllcheckOutbtn";
            this.showAllcheckOutbtn.Size = new System.Drawing.Size(257, 43);
            this.showAllcheckOutbtn.TabIndex = 53;
            this.showAllcheckOutbtn.Text = "Show All check Outs";
            this.showAllcheckOutbtn.UseVisualStyleBackColor = false;
            this.showAllcheckOutbtn.Click += new System.EventHandler(this.showAllcheckOutbtn_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1614, 894);
            this.Controls.Add(this.showAllcheckOutbtn);
            this.Controls.Add(this.checkOutlbl);
            this.Controls.Add(this.checkOutPanel);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.checkOutbtn);
            this.Controls.Add(this.checkOutdgw);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutdgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutPanel)).EndInit();
            this.checkOutPanel.ResumeLayout(false);
            this.checkOutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView checkOutdgw;
        private System.Windows.Forms.Button checkOutbtn;
        private System.Windows.Forms.Button backbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel checkOutPanel;
        private System.Windows.Forms.Label checkOutlbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomNumberChecktbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox countryChecktbx;
        private System.Windows.Forms.Label passportChecklbl;
        private System.Windows.Forms.Label roomNumberChecklbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomPriceChecktbx;
        private System.Windows.Forms.DateTimePicker checkOutCheckdp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneChecktbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passprtChecktbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastNameChecktbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstNameChecktbx;
        private System.Windows.Forms.Label roomPriceChecklbl;
        private System.Windows.Forms.Label CheckOutChecklbl;
        private System.Windows.Forms.Label countryChecklbl;
        private System.Windows.Forms.Label phoneChecklbl;
        private System.Windows.Forms.Label lastNameChecklbl;
        private System.Windows.Forms.Label firstNameChecklbl;
        private System.Windows.Forms.Button showAllcheckOutbtn;
        private System.Windows.Forms.DateTimePicker checkIndp;
        private System.Windows.Forms.Label checkInChecklbl;
    }
}