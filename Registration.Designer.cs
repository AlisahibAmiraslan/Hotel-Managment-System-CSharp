namespace HotelManagmentSystem
{
    partial class Registration
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
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.passportlbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.countrylbl = new System.Windows.Forms.Label();
            this.roomAvaReglbl = new System.Windows.Forms.Label();
            this.checkInlbl = new System.Windows.Forms.Label();
            this.CheckOutlbl = new System.Windows.Forms.Label();
            this.roomPricelbl = new System.Windows.Forms.Label();
            this.btnRegRoom = new System.Windows.Forms.Button();
            this.firstNametbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lastNametbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passprttbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.phonetbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.countrycbx = new System.Windows.Forms.ComboBox();
            this.checkIndatedp = new System.Windows.Forms.DateTimePicker();
            this.checkOutdp = new System.Windows.Forms.DateTimePicker();
            this.roomAvacbx = new System.Windows.Forms.ComboBox();
            this.roomPricetbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomNumbercbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnshowRezerv = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.modifyReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, -3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(922, 91);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Registration";
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
            this.dashbaordExit.Location = new System.Drawing.Point(848, 15);
            this.dashbaordExit.Name = "dashbaordExit";
            this.dashbaordExit.Size = new System.Drawing.Size(45, 48);
            this.dashbaordExit.TabIndex = 0;
            this.dashbaordExit.Text = "X";
            this.dashbaordExit.Click += new System.EventHandler(this.dashbaordExit_Click);
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.firstNamelbl.Location = new System.Drawing.Point(105, 161);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(101, 22);
            this.firstNamelbl.TabIndex = 3;
            this.firstNamelbl.Text = "First Name";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lastNamelbl.Location = new System.Drawing.Point(389, 161);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(99, 22);
            this.lastNamelbl.TabIndex = 4;
            this.lastNamelbl.Text = "Last Name";
            // 
            // passportlbl
            // 
            this.passportlbl.AutoSize = true;
            this.passportlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.passportlbl.Location = new System.Drawing.Point(686, 161);
            this.passportlbl.Name = "passportlbl";
            this.passportlbl.Size = new System.Drawing.Size(106, 22);
            this.passportlbl.TabIndex = 5;
            this.passportlbl.Text = "Passport ID";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.phonelbl.Location = new System.Drawing.Point(98, 277);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(108, 22);
            this.phonelbl.TabIndex = 6;
            this.phonelbl.Text = "Phone Num";
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.countrylbl.Location = new System.Drawing.Point(389, 277);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(76, 22);
            this.countrylbl.TabIndex = 7;
            this.countrylbl.Text = "Country";
            // 
            // roomAvaReglbl
            // 
            this.roomAvaReglbl.AutoSize = true;
            this.roomAvaReglbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomAvaReglbl.Location = new System.Drawing.Point(53, 487);
            this.roomAvaReglbl.Name = "roomAvaReglbl";
            this.roomAvaReglbl.Size = new System.Drawing.Size(153, 22);
            this.roomAvaReglbl.TabIndex = 8;
            this.roomAvaReglbl.Text = "Room Availability";
            // 
            // checkInlbl
            // 
            this.checkInlbl.AutoSize = true;
            this.checkInlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.checkInlbl.Location = new System.Drawing.Point(98, 383);
            this.checkInlbl.Name = "checkInlbl";
            this.checkInlbl.Size = new System.Drawing.Size(83, 22);
            this.checkInlbl.TabIndex = 9;
            this.checkInlbl.Text = "Check In";
            // 
            // CheckOutlbl
            // 
            this.CheckOutlbl.AutoSize = true;
            this.CheckOutlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CheckOutlbl.Location = new System.Drawing.Point(376, 383);
            this.CheckOutlbl.Name = "CheckOutlbl";
            this.CheckOutlbl.Size = new System.Drawing.Size(97, 22);
            this.CheckOutlbl.TabIndex = 10;
            this.CheckOutlbl.Text = "Check Out";
            // 
            // roomPricelbl
            // 
            this.roomPricelbl.AutoSize = true;
            this.roomPricelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomPricelbl.Location = new System.Drawing.Point(389, 487);
            this.roomPricelbl.Name = "roomPricelbl";
            this.roomPricelbl.Size = new System.Drawing.Size(105, 22);
            this.roomPricelbl.TabIndex = 11;
            this.roomPricelbl.Text = "Room Price";
            // 
            // btnRegRoom
            // 
            this.btnRegRoom.BackColor = System.Drawing.Color.Crimson;
            this.btnRegRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegRoom.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRegRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRegRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRegRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegRoom.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegRoom.ForeColor = System.Drawing.Color.White;
            this.btnRegRoom.Location = new System.Drawing.Point(26, 603);
            this.btnRegRoom.Name = "btnRegRoom";
            this.btnRegRoom.Size = new System.Drawing.Size(180, 43);
            this.btnRegRoom.TabIndex = 12;
            this.btnRegRoom.Text = "Add";
            this.btnRegRoom.UseVisualStyleBackColor = false;
            this.btnRegRoom.Click += new System.EventHandler(this.btnRegRoom_Click);
            // 
            // firstNametbx
            // 
            this.firstNametbx.Location = new System.Drawing.Point(25, 195);
            this.firstNametbx.Name = "firstNametbx";
            this.firstNametbx.Size = new System.Drawing.Size(238, 37);
            this.firstNametbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.firstNametbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNametbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.firstNametbx.StateCommon.Border.Rounding = 15;
            this.firstNametbx.TabIndex = 16;
            // 
            // lastNametbx
            // 
            this.lastNametbx.Location = new System.Drawing.Point(320, 195);
            this.lastNametbx.Name = "lastNametbx";
            this.lastNametbx.Size = new System.Drawing.Size(238, 37);
            this.lastNametbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.lastNametbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNametbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.lastNametbx.StateCommon.Border.Rounding = 15;
            this.lastNametbx.TabIndex = 17;
            // 
            // passprttbx
            // 
            this.passprttbx.Location = new System.Drawing.Point(615, 195);
            this.passprttbx.Name = "passprttbx";
            this.passprttbx.Size = new System.Drawing.Size(238, 37);
            this.passprttbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passprttbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passprttbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.passprttbx.StateCommon.Border.Rounding = 15;
            this.passprttbx.TabIndex = 18;
            // 
            // phonetbx
            // 
            this.phonetbx.Location = new System.Drawing.Point(25, 313);
            this.phonetbx.Name = "phonetbx";
            this.phonetbx.Size = new System.Drawing.Size(238, 37);
            this.phonetbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.phonetbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phonetbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.phonetbx.StateCommon.Border.Rounding = 15;
            this.phonetbx.TabIndex = 19;
            // 
            // countrycbx
            // 
            this.countrycbx.FormattingEnabled = true;
            this.countrycbx.Items.AddRange(new object[] {
            "Afganistan ",
            "Almanya ",
            "Amerika Birleşik Devletleri ",
            "Amerikan Samoa ",
            "Andorra ",
            "Angola ",
            "Anguilla, İngiltere ",
            "Antigua ve Barbuda ",
            "Arjantin ",
            "Arnavutluk ",
            "Aruba, Hollanda ",
            "Avustralya ",
            "Avusturya ",
            "Azerbaycan",
            "Bahama Adaları ",
            "Bahreyn ",
            "Bangladeş ",
            "Barbados ",
            "Belçika ",
            "Belize ",
            "Benin ",
            "Bermuda, İngiltere ",
            "Beyaz Rusya ",
            "Bhutan ",
            "Birleşik Arap Emirlikleri ",
            "Birmanya (Myanmar) ",
            "Bolivya ",
            "Bosna Hersek ",
            "Botswana ",
            "Brezilya ",
            "Brunei ",
            "Bulgaristan ",
            "Burkina Faso ",
            "Burundi ",
            "Cape Verde ",
            "Cayman Adaları, İngiltere ",
            "Cezayir ",
            "Christmas Adası , Avusturalya ",
            "Cibuti ",
            "Çad ",
            "Çek Cumhuriyeti ",
            "Çin ",
            "Danimarka ",
            "Doğu Timor ",
            "Dominik Cumhuriyeti ",
            "Dominika",
            "Ekvator ",
            "Ekvator Ginesi ",
            "El Salvador ",
            "Endonezya ",
            "Eritre ",
            "Ermenistan ",
            "Estonya ",
            "Etiyopya ",
            "Fas ",
            "Fiji ",
            "Fildişi Sahili ",
            "Filipinler ",
            "Filistin ",
            "Finlandiya ",
            "Folkland Adaları, İngiltere ",
            "Fransa ",
            "Fransız Guyanası ",
            "Fransız Güney Eyaletleri (Kerguelen Adaları) ",
            "Fransız Polinezyası ",
            "Gabon ",
            "Galler ",
            "Gambiya ",
            "Gana ",
            "Gaza Strip ",
            "Gibraltar, İngiltere ",
            "Gine ",
            "Gine-Bissau ",
            "Grenada ",
            "Grönland ",
            "Guadalup, Fransa ",
            "Guam, Amerika ",
            "Guatemala ",
            "Guyana ",
            "Güney Afrika ",
            "Güney Georgia ve Güney Sandviç Adaları, İngiltere ",
            "Güney Kıbrıs Rum Yönetimi ",
            "Güney Kore ",
            "Gürcistan",
            "Haiti ",
            "Havai Adaları ",
            "Hırvatistan ",
            "Hindistan ",
            "Hollanda ",
            "Hollanda Antilleri ",
            "Honduras ",
            "Irak ",
            "İngiltere ",
            "İran ",
            "İrlanda ",
            "İskoçya ",
            "İspanya ",
            "İsrail ",
            "İsveç ",
            "İsviçre ",
            "İtalya ",
            "İzlanda ",
            "Jamaika ",
            "Japonya ",
            "Johnston Atoll, Amerika ",
            "K.K.T.C. ",
            "Kamboçya ",
            "Kamerun ",
            "Kanada ",
            "Kanarya Adaları ",
            "Karadağ ",
            "Katar ",
            "Kazakistan ",
            "Kenya ",
            "Kırgızistan ",
            "Kiribati ",
            "Kolombiya ",
            "Komorlar ",
            "Kongo ",
            "Kongo Demokratik Cumhuriyeti ",
            "Kosova ",
            "Kosta Rika ",
            "Kuveyt ",
            "Kuzey İrlanda ",
            "Kuzey Kore ",
            "Kuzey Maryana Adaları ",
            "Küba ",
            "Laos ",
            "Lesotho ",
            "Letonya ",
            "Liberya ",
            "Libya ",
            "Liechtenstein ",
            "Litvanya ",
            "Lübnan ",
            "Lüksemburg ",
            "Macaristan ",
            "Madagaskar ",
            "Makau (Makao) ",
            "Makedonya ",
            "Malavi ",
            "Maldiv Adaları ",
            "Malezya ",
            "Mali ",
            "Malta ",
            "Marşal Adaları ",
            "Martinik, Fransa ",
            "Mauritius ",
            "Mayotte, Fransa ",
            "Meksika ",
            "Mısır ",
            "Midway Adaları, Amerika ",
            "Mikronezya ",
            "Moğolistan ",
            "Moldavya ",
            "Monako ",
            "Montserrat ",
            "Moritanya ",
            "Mozambik ",
            "Namibia ",
            "Nauru ",
            "Nepal ",
            "Nijer ",
            "Nijerya ",
            "Nikaragua ",
            "Niue, Yeni Zelanda ",
            "Norveç",
            "Orta Afrika Cumhuriyeti ",
            "Özbekistan ",
            "Pakistan ",
            "Palau Adaları ",
            "Palmyra Atoll, Amerika ",
            "Panama ",
            "Papua Yeni Gine ",
            "Paraguay ",
            "Peru ",
            "Polonya ",
            "Portekiz ",
            "Porto Riko, Amerika ",
            "Reunion, Fransa ",
            "Romanya ",
            "Ruanda ",
            "Rusya Federasyonu ",
            "Saint Helena, İngiltere ",
            "Saint Martin, Fransa ",
            "Saint Pierre ve Miquelon, Fransa ",
            "Samoa ",
            "San Marino ",
            "Santa Kitts ve Nevis ",
            "Santa Lucia ",
            "Santa Vincent ve Grenadinler ",
            "Sao Tome ve Principe ",
            "Senegal ",
            "Seyşeller ",
            "Sırbistan ",
            "Sierra Leone ",
            "Singapur ",
            "Slovakya ",
            "Slovenya ",
            "Solomon Adaları ",
            "Somali ",
            "Sri Lanka ",
            "Sudan ",
            "Surinam ",
            "Suriye ",
            "Suudi Arabistan ",
            "Svalbard, Norveç ",
            "Svaziland ",
            "Şili ",
            "Tacikistan ",
            "Tanzanya ",
            "Tayland ",
            "Tayvan ",
            "Togo ",
            "Tonga ",
            "Trinidad ve Tobago ",
            "Tunus ",
            "Turks ve Caicos Adaları, İngiltere ",
            "Tuvalu ",
            "Türkiye ",
            "Türkmenistan ",
            "Uganda ",
            "Ukrayna ",
            "Umman ",
            "Uruguay ",
            "Ürdün ",
            "Vallis ve Futuna, Fransa ",
            "Vanuatu ",
            "Venezuela ",
            "Vietnam ",
            "Virgin Adaları, Amerika ",
            "Virgin Adaları, İngiltere ",
            "Wake Adaları, Amerika ",
            "Yemen ",
            "Yeni Kaledonya, Fransa ",
            "Yeni Zelanda ",
            "Yunanistan ",
            "Zambiya ",
            "Zimbabve "});
            this.countrycbx.Location = new System.Drawing.Point(320, 313);
            this.countrycbx.Name = "countrycbx";
            this.countrycbx.Size = new System.Drawing.Size(238, 25);
            this.countrycbx.TabIndex = 20;
            // 
            // checkIndatedp
            // 
            this.checkIndatedp.Location = new System.Drawing.Point(25, 420);
            this.checkIndatedp.Name = "checkIndatedp";
            this.checkIndatedp.Size = new System.Drawing.Size(238, 28);
            this.checkIndatedp.TabIndex = 21;
            this.checkIndatedp.ValueChanged += new System.EventHandler(this.checkIndatedp_ValueChanged);
            // 
            // checkOutdp
            // 
            this.checkOutdp.Location = new System.Drawing.Point(320, 420);
            this.checkOutdp.Name = "checkOutdp";
            this.checkOutdp.Size = new System.Drawing.Size(238, 28);
            this.checkOutdp.TabIndex = 22;
            this.checkOutdp.ValueChanged += new System.EventHandler(this.checkOutdp_ValueChanged);
            // 
            // roomAvacbx
            // 
            this.roomAvacbx.FormattingEnabled = true;
            this.roomAvacbx.Items.AddRange(new object[] {
            "reserv",
            "check-in"});
            this.roomAvacbx.Location = new System.Drawing.Point(25, 517);
            this.roomAvacbx.Name = "roomAvacbx";
            this.roomAvacbx.Size = new System.Drawing.Size(238, 25);
            this.roomAvacbx.TabIndex = 23;
            // 
            // roomPricetbx
            // 
            this.roomPricetbx.Location = new System.Drawing.Point(320, 517);
            this.roomPricetbx.Name = "roomPricetbx";
            this.roomPricetbx.Size = new System.Drawing.Size(238, 37);
            this.roomPricetbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.roomPricetbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomPricetbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.roomPricetbx.StateCommon.Border.Rounding = 15;
            this.roomPricetbx.TabIndex = 24;
            // 
            // roomNumbercbx
            // 
            this.roomNumbercbx.FormattingEnabled = true;
            this.roomNumbercbx.Items.AddRange(new object[] {
            "reserv",
            "check-in"});
            this.roomNumbercbx.Location = new System.Drawing.Point(615, 313);
            this.roomNumbercbx.Name = "roomNumbercbx";
            this.roomNumbercbx.Size = new System.Drawing.Size(238, 25);
            this.roomNumbercbx.TabIndex = 26;
            this.roomNumbercbx.SelectionChangeCommitted += new System.EventHandler(this.roomNumbercbx_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(665, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Room Number";
            // 
            // btnshowRezerv
            // 
            this.btnshowRezerv.BackColor = System.Drawing.Color.Crimson;
            this.btnshowRezerv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowRezerv.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnshowRezerv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnshowRezerv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnshowRezerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowRezerv.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnshowRezerv.ForeColor = System.Drawing.Color.White;
            this.btnshowRezerv.Location = new System.Drawing.Point(427, 780);
            this.btnshowRezerv.Name = "btnshowRezerv";
            this.btnshowRezerv.Size = new System.Drawing.Size(192, 43);
            this.btnshowRezerv.TabIndex = 27;
            this.btnshowRezerv.Text = "Show All Reg";
            this.btnshowRezerv.UseVisualStyleBackColor = false;
            this.btnshowRezerv.Click += new System.EventHandler(this.btnshowRezerv_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Crimson;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(242, 780);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(153, 43);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // modifyReg
            // 
            this.modifyReg.BackColor = System.Drawing.Color.DodgerBlue;
            this.modifyReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyReg.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.modifyReg.FlatAppearance.BorderSize = 0;
            this.modifyReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.modifyReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.modifyReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyReg.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.modifyReg.ForeColor = System.Drawing.Color.White;
            this.modifyReg.Location = new System.Drawing.Point(690, 603);
            this.modifyReg.Name = "modifyReg";
            this.modifyReg.Size = new System.Drawing.Size(203, 43);
            this.modifyReg.TabIndex = 29;
            this.modifyReg.Text = "Modify Reservations";
            this.modifyReg.UseVisualStyleBackColor = false;
            this.modifyReg.Click += new System.EventHandler(this.modifyReg_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(920, 860);
            this.Controls.Add(this.modifyReg);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnshowRezerv);
            this.Controls.Add(this.roomNumbercbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomPricetbx);
            this.Controls.Add(this.roomAvacbx);
            this.Controls.Add(this.checkOutdp);
            this.Controls.Add(this.checkIndatedp);
            this.Controls.Add(this.countrycbx);
            this.Controls.Add(this.phonetbx);
            this.Controls.Add(this.passprttbx);
            this.Controls.Add(this.lastNametbx);
            this.Controls.Add(this.firstNametbx);
            this.Controls.Add(this.btnRegRoom);
            this.Controls.Add(this.roomPricelbl);
            this.Controls.Add(this.CheckOutlbl);
            this.Controls.Add(this.checkInlbl);
            this.Controls.Add(this.roomAvaReglbl);
            this.Controls.Add(this.countrylbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.passportlbl);
            this.Controls.Add(this.lastNamelbl);
            this.Controls.Add(this.firstNamelbl);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private System.Windows.Forms.Label firstNamelbl;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label passportlbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.Label roomAvaReglbl;
        private System.Windows.Forms.Label checkInlbl;
        private System.Windows.Forms.Label CheckOutlbl;
        private System.Windows.Forms.Label roomPricelbl;
        private System.Windows.Forms.Button btnRegRoom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstNametbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastNametbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passprttbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phonetbx;
        private System.Windows.Forms.ComboBox countrycbx;
        private System.Windows.Forms.DateTimePicker checkIndatedp;
        private System.Windows.Forms.DateTimePicker checkOutdp;
        private System.Windows.Forms.ComboBox roomAvacbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomPricetbx;
        private System.Windows.Forms.ComboBox roomNumbercbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnshowRezerv;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button modifyReg;
    }
}