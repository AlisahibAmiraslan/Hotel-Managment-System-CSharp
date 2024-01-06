namespace HotelManagmentSystem
{
    partial class Reservations
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
            this.label2 = new System.Windows.Forms.Label();
            this.reservationdgw = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.roomNumberRescbx = new System.Windows.Forms.ComboBox();
            this.roomPriceRestbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomAvaRescbx = new System.Windows.Forms.ComboBox();
            this.checkOutResdp = new System.Windows.Forms.DateTimePicker();
            this.checkIndateResdp = new System.Windows.Forms.DateTimePicker();
            this.countryRescbx = new System.Windows.Forms.ComboBox();
            this.phoneRestbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passprtRestbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lastNameRestbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firstNameRestbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomPriceReslbl = new System.Windows.Forms.Label();
            this.CheckOutReslbl = new System.Windows.Forms.Label();
            this.checkInReslbl = new System.Windows.Forms.Label();
            this.roomAvaReslbl = new System.Windows.Forms.Label();
            this.countryReslbl = new System.Windows.Forms.Label();
            this.phoneReslbl = new System.Windows.Forms.Label();
            this.lastNameReslbl = new System.Windows.Forms.Label();
            this.firstNameReslbl = new System.Windows.Forms.Label();
            this.roomNumberReslbl = new System.Windows.Forms.Label();
            this.passportReslbl = new System.Windows.Forms.Label();
            this.updateResbtn = new System.Windows.Forms.Button();
            this.deleteResbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.backDash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(-6, -2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1595, 105);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(636, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Reservations";
            // 
            // dashbaordExit
            // 
            this.dashbaordExit.AutoSize = true;
            this.dashbaordExit.BackColor = System.Drawing.Color.Crimson;
            this.dashbaordExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbaordExit.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashbaordExit.ForeColor = System.Drawing.Color.White;
            this.dashbaordExit.Location = new System.Drawing.Point(1520, 19);
            this.dashbaordExit.Name = "dashbaordExit";
            this.dashbaordExit.Size = new System.Drawing.Size(45, 48);
            this.dashbaordExit.TabIndex = 0;
            this.dashbaordExit.Text = "X";
            this.dashbaordExit.Click += new System.EventHandler(this.dashbaordExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(641, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modify Reservations";
            // 
            // reservationdgw
            // 
            this.reservationdgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationdgw.Location = new System.Drawing.Point(12, 197);
            this.reservationdgw.Name = "reservationdgw";
            this.reservationdgw.RowHeadersWidth = 51;
            this.reservationdgw.RowTemplate.Height = 24;
            this.reservationdgw.Size = new System.Drawing.Size(1558, 232);
            this.reservationdgw.TabIndex = 4;
            this.reservationdgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationdgw_CellClick);
            // 
            // roomNumberRescbx
            // 
            this.roomNumberRescbx.FormattingEnabled = true;
            this.roomNumberRescbx.Location = new System.Drawing.Point(1124, 622);
            this.roomNumberRescbx.Name = "roomNumberRescbx";
            this.roomNumberRescbx.Size = new System.Drawing.Size(238, 24);
            this.roomNumberRescbx.TabIndex = 44;
            // 
            // roomPriceRestbx
            // 
            this.roomPriceRestbx.Location = new System.Drawing.Point(541, 733);
            this.roomPriceRestbx.Name = "roomPriceRestbx";
            this.roomPriceRestbx.Size = new System.Drawing.Size(238, 37);
            this.roomPriceRestbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.roomPriceRestbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomPriceRestbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.roomPriceRestbx.StateCommon.Border.Rounding = 15;
            this.roomPriceRestbx.TabIndex = 43;
            // 
            // roomAvaRescbx
            // 
            this.roomAvaRescbx.FormattingEnabled = true;
            this.roomAvaRescbx.Items.AddRange(new object[] {
            "reserv",
            "check-in"});
            this.roomAvaRescbx.Location = new System.Drawing.Point(217, 746);
            this.roomAvaRescbx.Name = "roomAvaRescbx";
            this.roomAvaRescbx.Size = new System.Drawing.Size(267, 24);
            this.roomAvaRescbx.TabIndex = 42;
            // 
            // checkOutResdp
            // 
            this.checkOutResdp.Location = new System.Drawing.Point(541, 624);
            this.checkOutResdp.Name = "checkOutResdp";
            this.checkOutResdp.Size = new System.Drawing.Size(238, 22);
            this.checkOutResdp.TabIndex = 41;
            // 
            // checkIndateResdp
            // 
            this.checkIndateResdp.Location = new System.Drawing.Point(217, 627);
            this.checkIndateResdp.Name = "checkIndateResdp";
            this.checkIndateResdp.Size = new System.Drawing.Size(267, 22);
            this.checkIndateResdp.TabIndex = 40;
            // 
            // countryRescbx
            // 
            this.countryRescbx.FormattingEnabled = true;
            this.countryRescbx.Items.AddRange(new object[] {
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
            this.countryRescbx.Location = new System.Drawing.Point(836, 624);
            this.countryRescbx.Name = "countryRescbx";
            this.countryRescbx.Size = new System.Drawing.Size(238, 24);
            this.countryRescbx.TabIndex = 39;
            // 
            // phoneRestbx
            // 
            this.phoneRestbx.Location = new System.Drawing.Point(1124, 524);
            this.phoneRestbx.Name = "phoneRestbx";
            this.phoneRestbx.Size = new System.Drawing.Size(238, 37);
            this.phoneRestbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.phoneRestbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneRestbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.phoneRestbx.StateCommon.Border.Rounding = 15;
            this.phoneRestbx.TabIndex = 38;
            // 
            // passprtRestbx
            // 
            this.passprtRestbx.Location = new System.Drawing.Point(836, 524);
            this.passprtRestbx.Name = "passprtRestbx";
            this.passprtRestbx.Size = new System.Drawing.Size(238, 37);
            this.passprtRestbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passprtRestbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passprtRestbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.passprtRestbx.StateCommon.Border.Rounding = 15;
            this.passprtRestbx.TabIndex = 37;
            // 
            // lastNameRestbx
            // 
            this.lastNameRestbx.Location = new System.Drawing.Point(541, 524);
            this.lastNameRestbx.Name = "lastNameRestbx";
            this.lastNameRestbx.Size = new System.Drawing.Size(238, 37);
            this.lastNameRestbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.lastNameRestbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameRestbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.lastNameRestbx.StateCommon.Border.Rounding = 15;
            this.lastNameRestbx.TabIndex = 36;
            // 
            // firstNameRestbx
            // 
            this.firstNameRestbx.Location = new System.Drawing.Point(217, 524);
            this.firstNameRestbx.Name = "firstNameRestbx";
            this.firstNameRestbx.Size = new System.Drawing.Size(267, 37);
            this.firstNameRestbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.firstNameRestbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameRestbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.firstNameRestbx.StateCommon.Border.Rounding = 15;
            this.firstNameRestbx.TabIndex = 35;
            // 
            // roomPriceReslbl
            // 
            this.roomPriceReslbl.AutoSize = true;
            this.roomPriceReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomPriceReslbl.Location = new System.Drawing.Point(578, 708);
            this.roomPriceReslbl.Name = "roomPriceReslbl";
            this.roomPriceReslbl.Size = new System.Drawing.Size(105, 22);
            this.roomPriceReslbl.TabIndex = 34;
            this.roomPriceReslbl.Text = "Room Price";
            // 
            // CheckOutReslbl
            // 
            this.CheckOutReslbl.AutoSize = true;
            this.CheckOutReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CheckOutReslbl.Location = new System.Drawing.Point(577, 590);
            this.CheckOutReslbl.Name = "CheckOutReslbl";
            this.CheckOutReslbl.Size = new System.Drawing.Size(97, 22);
            this.CheckOutReslbl.TabIndex = 33;
            this.CheckOutReslbl.Text = "Check Out";
            // 
            // checkInReslbl
            // 
            this.checkInReslbl.AutoSize = true;
            this.checkInReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.checkInReslbl.Location = new System.Drawing.Point(299, 590);
            this.checkInReslbl.Name = "checkInReslbl";
            this.checkInReslbl.Size = new System.Drawing.Size(83, 22);
            this.checkInReslbl.TabIndex = 32;
            this.checkInReslbl.Text = "Check In";
            // 
            // roomAvaReslbl
            // 
            this.roomAvaReslbl.AutoSize = true;
            this.roomAvaReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomAvaReslbl.Location = new System.Drawing.Point(255, 708);
            this.roomAvaReslbl.Name = "roomAvaReslbl";
            this.roomAvaReslbl.Size = new System.Drawing.Size(153, 22);
            this.roomAvaReslbl.TabIndex = 31;
            this.roomAvaReslbl.Text = "Room Availability";
            // 
            // countryReslbl
            // 
            this.countryReslbl.AutoSize = true;
            this.countryReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.countryReslbl.Location = new System.Drawing.Point(888, 590);
            this.countryReslbl.Name = "countryReslbl";
            this.countryReslbl.Size = new System.Drawing.Size(76, 22);
            this.countryReslbl.TabIndex = 30;
            this.countryReslbl.Text = "Country";
            // 
            // phoneReslbl
            // 
            this.phoneReslbl.AutoSize = true;
            this.phoneReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.phoneReslbl.Location = new System.Drawing.Point(1188, 490);
            this.phoneReslbl.Name = "phoneReslbl";
            this.phoneReslbl.Size = new System.Drawing.Size(108, 22);
            this.phoneReslbl.TabIndex = 29;
            this.phoneReslbl.Text = "Phone Num";
            // 
            // lastNameReslbl
            // 
            this.lastNameReslbl.AutoSize = true;
            this.lastNameReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lastNameReslbl.Location = new System.Drawing.Point(610, 490);
            this.lastNameReslbl.Name = "lastNameReslbl";
            this.lastNameReslbl.Size = new System.Drawing.Size(99, 22);
            this.lastNameReslbl.TabIndex = 28;
            this.lastNameReslbl.Text = "Last Name";
            // 
            // firstNameReslbl
            // 
            this.firstNameReslbl.AutoSize = true;
            this.firstNameReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.firstNameReslbl.Location = new System.Drawing.Point(326, 490);
            this.firstNameReslbl.Name = "firstNameReslbl";
            this.firstNameReslbl.Size = new System.Drawing.Size(101, 22);
            this.firstNameReslbl.TabIndex = 27;
            this.firstNameReslbl.Text = "First Name";
            // 
            // roomNumberReslbl
            // 
            this.roomNumberReslbl.AutoSize = true;
            this.roomNumberReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.roomNumberReslbl.Location = new System.Drawing.Point(1168, 597);
            this.roomNumberReslbl.Name = "roomNumberReslbl";
            this.roomNumberReslbl.Size = new System.Drawing.Size(128, 22);
            this.roomNumberReslbl.TabIndex = 46;
            this.roomNumberReslbl.Text = "Room Number";
            // 
            // passportReslbl
            // 
            this.passportReslbl.AutoSize = true;
            this.passportReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.passportReslbl.Location = new System.Drawing.Point(888, 490);
            this.passportReslbl.Name = "passportReslbl";
            this.passportReslbl.Size = new System.Drawing.Size(106, 22);
            this.passportReslbl.TabIndex = 47;
            this.passportReslbl.Text = "Passport ID";
            // 
            // updateResbtn
            // 
            this.updateResbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateResbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateResbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.updateResbtn.FlatAppearance.BorderSize = 0;
            this.updateResbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateResbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.updateResbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateResbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.updateResbtn.ForeColor = System.Drawing.Color.White;
            this.updateResbtn.Location = new System.Drawing.Point(948, 719);
            this.updateResbtn.Name = "updateResbtn";
            this.updateResbtn.Size = new System.Drawing.Size(203, 43);
            this.updateResbtn.TabIndex = 49;
            this.updateResbtn.Text = "Update";
            this.updateResbtn.UseVisualStyleBackColor = false;
            this.updateResbtn.Click += new System.EventHandler(this.updateResbtn_Click);
            // 
            // deleteResbtn
            // 
            this.deleteResbtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteResbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteResbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.deleteResbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.deleteResbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.deleteResbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteResbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.deleteResbtn.ForeColor = System.Drawing.Color.White;
            this.deleteResbtn.Location = new System.Drawing.Point(1192, 719);
            this.deleteResbtn.Name = "deleteResbtn";
            this.deleteResbtn.Size = new System.Drawing.Size(180, 43);
            this.deleteResbtn.TabIndex = 48;
            this.deleteResbtn.Text = "Delete";
            this.deleteResbtn.UseVisualStyleBackColor = false;
            this.deleteResbtn.Click += new System.EventHandler(this.deleteResbtn_Click);
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
            this.backbtn.Location = new System.Drawing.Point(696, 876);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(180, 43);
            this.backbtn.TabIndex = 50;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // backDash
            // 
            this.backDash.BackColor = System.Drawing.Color.Crimson;
            this.backDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backDash.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.backDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.backDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.backDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backDash.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.backDash.ForeColor = System.Drawing.Color.White;
            this.backDash.Location = new System.Drawing.Point(931, 876);
            this.backDash.Name = "backDash";
            this.backDash.Size = new System.Drawing.Size(180, 43);
            this.backDash.TabIndex = 51;
            this.backDash.Text = "Back Dashbaord";
            this.backDash.UseVisualStyleBackColor = false;
            this.backDash.Click += new System.EventHandler(this.backDash_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1582, 931);
            this.Controls.Add(this.backDash);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.updateResbtn);
            this.Controls.Add(this.deleteResbtn);
            this.Controls.Add(this.passportReslbl);
            this.Controls.Add(this.roomNumberReslbl);
            this.Controls.Add(this.roomNumberRescbx);
            this.Controls.Add(this.roomPriceRestbx);
            this.Controls.Add(this.roomAvaRescbx);
            this.Controls.Add(this.checkOutResdp);
            this.Controls.Add(this.checkIndateResdp);
            this.Controls.Add(this.countryRescbx);
            this.Controls.Add(this.phoneRestbx);
            this.Controls.Add(this.passprtRestbx);
            this.Controls.Add(this.lastNameRestbx);
            this.Controls.Add(this.firstNameRestbx);
            this.Controls.Add(this.roomPriceReslbl);
            this.Controls.Add(this.CheckOutReslbl);
            this.Controls.Add(this.checkInReslbl);
            this.Controls.Add(this.roomAvaReslbl);
            this.Controls.Add(this.countryReslbl);
            this.Controls.Add(this.phoneReslbl);
            this.Controls.Add(this.lastNameReslbl);
            this.Controls.Add(this.firstNameReslbl);
            this.Controls.Add(this.reservationdgw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView reservationdgw;
        private System.Windows.Forms.ComboBox roomNumberRescbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomPriceRestbx;
        private System.Windows.Forms.ComboBox roomAvaRescbx;
        private System.Windows.Forms.DateTimePicker checkOutResdp;
        private System.Windows.Forms.DateTimePicker checkIndateResdp;
        private System.Windows.Forms.ComboBox countryRescbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneRestbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passprtRestbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastNameRestbx;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstNameRestbx;
        private System.Windows.Forms.Label roomPriceReslbl;
        private System.Windows.Forms.Label CheckOutReslbl;
        private System.Windows.Forms.Label checkInReslbl;
        private System.Windows.Forms.Label roomAvaReslbl;
        private System.Windows.Forms.Label countryReslbl;
        private System.Windows.Forms.Label phoneReslbl;
        private System.Windows.Forms.Label lastNameReslbl;
        private System.Windows.Forms.Label firstNameReslbl;
        private System.Windows.Forms.Label roomNumberReslbl;
        private System.Windows.Forms.Label passportReslbl;
        private System.Windows.Forms.Button updateResbtn;
        private System.Windows.Forms.Button deleteResbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button backDash;
    }
}