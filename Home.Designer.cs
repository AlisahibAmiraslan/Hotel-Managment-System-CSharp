namespace HotelManagmentSystem
{
    partial class Home
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
            this.homedgw = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.filtercbx = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalTextlbl = new System.Windows.Forms.Label();
            this.totalPricelbl = new System.Windows.Forms.Label();
            this.totalAmountReslbl = new System.Windows.Forms.Label();
            this.totalAmountPricelbl = new System.Windows.Forms.Label();
            this.totalAmountResPrice = new System.Windows.Forms.Label();
            this.totalAmountCheckInlbl = new System.Windows.Forms.Label();
            this.totalAmountCheckPrice = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homedgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(-2, -2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1287, 105);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Home";
            // 
            // dashbaordExit
            // 
            this.dashbaordExit.AutoSize = true;
            this.dashbaordExit.BackColor = System.Drawing.Color.Crimson;
            this.dashbaordExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbaordExit.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashbaordExit.ForeColor = System.Drawing.Color.White;
            this.dashbaordExit.Location = new System.Drawing.Point(1201, 27);
            this.dashbaordExit.Name = "dashbaordExit";
            this.dashbaordExit.Size = new System.Drawing.Size(45, 48);
            this.dashbaordExit.TabIndex = 0;
            this.dashbaordExit.Text = "X";
            this.dashbaordExit.Click += new System.EventHandler(this.dashbaordExit_Click);
            // 
            // homedgw
            // 
            this.homedgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homedgw.Location = new System.Drawing.Point(32, 217);
            this.homedgw.Name = "homedgw";
            this.homedgw.RowHeadersWidth = 51;
            this.homedgw.RowTemplate.Height = 24;
            this.homedgw.Size = new System.Drawing.Size(1212, 463);
            this.homedgw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Today\'s Schedule";
            // 
            // filtercbx
            // 
            this.filtercbx.FormattingEnabled = true;
            this.filtercbx.Items.AddRange(new object[] {
            "reserv",
            "check-in"});
            this.filtercbx.Location = new System.Drawing.Point(666, 168);
            this.filtercbx.Name = "filtercbx";
            this.filtercbx.Size = new System.Drawing.Size(234, 24);
            this.filtercbx.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Crimson;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(936, 158);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(139, 41);
            this.btnsearch.TabIndex = 30;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Crimson;
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.refreshbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.refreshbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(1105, 158);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(139, 41);
            this.refreshbtn.TabIndex = 31;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(97, 937);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 10);
            this.panel1.TabIndex = 32;
            // 
            // totalTextlbl
            // 
            this.totalTextlbl.AutoSize = true;
            this.totalTextlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalTextlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalTextlbl.Location = new System.Drawing.Point(110, 896);
            this.totalTextlbl.Name = "totalTextlbl";
            this.totalTextlbl.Size = new System.Drawing.Size(125, 22);
            this.totalTextlbl.TabIndex = 33;
            this.totalTextlbl.Text = "Total Amount:";
            // 
            // totalPricelbl
            // 
            this.totalPricelbl.AutoSize = true;
            this.totalPricelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPricelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalPricelbl.Location = new System.Drawing.Point(1022, 807);
            this.totalPricelbl.Name = "totalPricelbl";
            this.totalPricelbl.Size = new System.Drawing.Size(0, 26);
            this.totalPricelbl.TabIndex = 34;
            // 
            // totalAmountReslbl
            // 
            this.totalAmountReslbl.AutoSize = true;
            this.totalAmountReslbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountReslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountReslbl.Location = new System.Drawing.Point(110, 850);
            this.totalAmountReslbl.Name = "totalAmountReslbl";
            this.totalAmountReslbl.Size = new System.Drawing.Size(193, 22);
            this.totalAmountReslbl.TabIndex = 35;
            this.totalAmountReslbl.Text = "Reservations Amount:";
            // 
            // totalAmountPricelbl
            // 
            this.totalAmountPricelbl.AutoSize = true;
            this.totalAmountPricelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountPricelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountPricelbl.Location = new System.Drawing.Point(1008, 896);
            this.totalAmountPricelbl.Name = "totalAmountPricelbl";
            this.totalAmountPricelbl.Size = new System.Drawing.Size(21, 22);
            this.totalAmountPricelbl.TabIndex = 36;
            this.totalAmountPricelbl.Text = "$";
            // 
            // totalAmountResPrice
            // 
            this.totalAmountResPrice.AutoSize = true;
            this.totalAmountResPrice.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountResPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountResPrice.Location = new System.Drawing.Point(1008, 850);
            this.totalAmountResPrice.Name = "totalAmountResPrice";
            this.totalAmountResPrice.Size = new System.Drawing.Size(21, 22);
            this.totalAmountResPrice.TabIndex = 37;
            this.totalAmountResPrice.Text = "$";
            // 
            // totalAmountCheckInlbl
            // 
            this.totalAmountCheckInlbl.AutoSize = true;
            this.totalAmountCheckInlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountCheckInlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountCheckInlbl.Location = new System.Drawing.Point(110, 807);
            this.totalAmountCheckInlbl.Name = "totalAmountCheckInlbl";
            this.totalAmountCheckInlbl.Size = new System.Drawing.Size(158, 22);
            this.totalAmountCheckInlbl.TabIndex = 38;
            this.totalAmountCheckInlbl.Text = "Check In Amount:";
            // 
            // totalAmountCheckPrice
            // 
            this.totalAmountCheckPrice.AutoSize = true;
            this.totalAmountCheckPrice.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountCheckPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountCheckPrice.Location = new System.Drawing.Point(1008, 807);
            this.totalAmountCheckPrice.Name = "totalAmountCheckPrice";
            this.totalAmountCheckPrice.Size = new System.Drawing.Size(21, 22);
            this.totalAmountCheckPrice.TabIndex = 39;
            this.totalAmountCheckPrice.Text = "$";
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
            this.backbtn.Location = new System.Drawing.Point(1105, 710);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(139, 41);
            this.backbtn.TabIndex = 40;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1275, 962);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.totalAmountCheckPrice);
            this.Controls.Add(this.totalAmountCheckInlbl);
            this.Controls.Add(this.totalAmountResPrice);
            this.Controls.Add(this.totalAmountPricelbl);
            this.Controls.Add(this.totalAmountReslbl);
            this.Controls.Add(this.totalPricelbl);
            this.Controls.Add(this.totalTextlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.filtercbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homedgw);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homedgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView homedgw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filtercbx;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalTextlbl;
        private System.Windows.Forms.Label totalPricelbl;
        private System.Windows.Forms.Label totalAmountReslbl;
        private System.Windows.Forms.Label totalAmountPricelbl;
        private System.Windows.Forms.Label totalAmountResPrice;
        private System.Windows.Forms.Label totalAmountCheckInlbl;
        private System.Windows.Forms.Label totalAmountCheckPrice;
        private System.Windows.Forms.Button backbtn;
    }
}