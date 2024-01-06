namespace HotelManagmentSystem
{
    partial class AllCheckOuts
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
            this.showAllCheckOutdgw = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnShowcheckOut = new System.Windows.Forms.Button();
            this.btnbackRegAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalAmountPricelbl = new System.Windows.Forms.Label();
            this.totalTextlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllCheckOutdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1694, 103);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(686, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Check Out Rooms";
            // 
            // dashbaordExit
            // 
            this.dashbaordExit.AutoSize = true;
            this.dashbaordExit.BackColor = System.Drawing.Color.Crimson;
            this.dashbaordExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbaordExit.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashbaordExit.ForeColor = System.Drawing.Color.White;
            this.dashbaordExit.Location = new System.Drawing.Point(1607, 20);
            this.dashbaordExit.Name = "dashbaordExit";
            this.dashbaordExit.Size = new System.Drawing.Size(45, 48);
            this.dashbaordExit.TabIndex = 0;
            this.dashbaordExit.Text = "X";
            this.dashbaordExit.Click += new System.EventHandler(this.dashbaordExit_Click);
            // 
            // showAllCheckOutdgw
            // 
            this.showAllCheckOutdgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showAllCheckOutdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllCheckOutdgw.Location = new System.Drawing.Point(31, 184);
            this.showAllCheckOutdgw.Name = "showAllCheckOutdgw";
            this.showAllCheckOutdgw.RowHeadersWidth = 51;
            this.showAllCheckOutdgw.RowTemplate.Height = 24;
            this.showAllCheckOutdgw.Size = new System.Drawing.Size(1622, 488);
            this.showAllCheckOutdgw.TabIndex = 4;
            // 
            // btnShowcheckOut
            // 
            this.btnShowcheckOut.BackColor = System.Drawing.Color.Crimson;
            this.btnShowcheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowcheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnShowcheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnShowcheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnShowcheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowcheckOut.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowcheckOut.ForeColor = System.Drawing.Color.White;
            this.btnShowcheckOut.Location = new System.Drawing.Point(635, 769);
            this.btnShowcheckOut.Name = "btnShowcheckOut";
            this.btnShowcheckOut.Size = new System.Drawing.Size(239, 55);
            this.btnShowcheckOut.TabIndex = 32;
            this.btnShowcheckOut.Text = "Back Check Out";
            this.btnShowcheckOut.UseVisualStyleBackColor = false;
            this.btnShowcheckOut.Click += new System.EventHandler(this.btnShowcheckOut_Click);
            // 
            // btnbackRegAll
            // 
            this.btnbackRegAll.BackColor = System.Drawing.Color.Crimson;
            this.btnbackRegAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbackRegAll.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnbackRegAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnbackRegAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnbackRegAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackRegAll.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnbackRegAll.ForeColor = System.Drawing.Color.White;
            this.btnbackRegAll.Location = new System.Drawing.Point(923, 769);
            this.btnbackRegAll.Name = "btnbackRegAll";
            this.btnbackRegAll.Size = new System.Drawing.Size(238, 55);
            this.btnbackRegAll.TabIndex = 31;
            this.btnbackRegAll.Text = "Back DashBoard";
            this.btnbackRegAll.UseVisualStyleBackColor = false;
            this.btnbackRegAll.Click += new System.EventHandler(this.btnbackRegAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(356, 1007);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 10);
            this.panel1.TabIndex = 33;
            // 
            // totalAmountPricelbl
            // 
            this.totalAmountPricelbl.AutoSize = true;
            this.totalAmountPricelbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalAmountPricelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmountPricelbl.Location = new System.Drawing.Point(1264, 966);
            this.totalAmountPricelbl.Name = "totalAmountPricelbl";
            this.totalAmountPricelbl.Size = new System.Drawing.Size(21, 22);
            this.totalAmountPricelbl.TabIndex = 38;
            this.totalAmountPricelbl.Text = "$";
            // 
            // totalTextlbl
            // 
            this.totalTextlbl.AutoSize = true;
            this.totalTextlbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.totalTextlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalTextlbl.Location = new System.Drawing.Point(366, 966);
            this.totalTextlbl.Name = "totalTextlbl";
            this.totalTextlbl.Size = new System.Drawing.Size(125, 22);
            this.totalTextlbl.TabIndex = 37;
            this.totalTextlbl.Text = "Total Amount:";
            // 
            // AllCheckOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1693, 1044);
            this.Controls.Add(this.totalAmountPricelbl);
            this.Controls.Add(this.totalTextlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowcheckOut);
            this.Controls.Add(this.btnbackRegAll);
            this.Controls.Add(this.showAllCheckOutdgw);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCheckOuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllCheckOuts";
            this.Load += new System.EventHandler(this.AllCheckOuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllCheckOutdgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView showAllCheckOutdgw;
        private System.Windows.Forms.Button btnShowcheckOut;
        private System.Windows.Forms.Button btnbackRegAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalAmountPricelbl;
        private System.Windows.Forms.Label totalTextlbl;
    }
}