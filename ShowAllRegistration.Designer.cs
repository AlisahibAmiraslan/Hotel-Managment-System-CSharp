namespace HotelManagmentSystem
{
    partial class ShowAllRegistration
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
            this.showAllRegdgw = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnbackRegAll = new System.Windows.Forms.Button();
            this.btnshowOnlyReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllRegdgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.dashbaordExit);
            this.kryptonPanel1.Location = new System.Drawing.Point(-1, -1);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1694, 103);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(686, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Show All Registrations";
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
            // showAllRegdgw
            // 
            this.showAllRegdgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showAllRegdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllRegdgw.Location = new System.Drawing.Point(46, 168);
            this.showAllRegdgw.Name = "showAllRegdgw";
            this.showAllRegdgw.RowHeadersWidth = 51;
            this.showAllRegdgw.RowTemplate.Height = 24;
            this.showAllRegdgw.Size = new System.Drawing.Size(1605, 488);
            this.showAllRegdgw.TabIndex = 3;
            this.showAllRegdgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showAllRegdgw_CellClick);
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
            this.btnbackRegAll.Location = new System.Drawing.Point(597, 741);
            this.btnbackRegAll.Name = "btnbackRegAll";
            this.btnbackRegAll.Size = new System.Drawing.Size(238, 55);
            this.btnbackRegAll.TabIndex = 29;
            this.btnbackRegAll.Text = "Back DashBoard";
            this.btnbackRegAll.UseVisualStyleBackColor = false;
            this.btnbackRegAll.Click += new System.EventHandler(this.btnbackRegAll_Click);
            // 
            // btnshowOnlyReg
            // 
            this.btnshowOnlyReg.BackColor = System.Drawing.Color.Crimson;
            this.btnshowOnlyReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowOnlyReg.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnshowOnlyReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnshowOnlyReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnshowOnlyReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowOnlyReg.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnshowOnlyReg.ForeColor = System.Drawing.Color.White;
            this.btnshowOnlyReg.Location = new System.Drawing.Point(889, 741);
            this.btnshowOnlyReg.Name = "btnshowOnlyReg";
            this.btnshowOnlyReg.Size = new System.Drawing.Size(239, 55);
            this.btnshowOnlyReg.TabIndex = 30;
            this.btnshowOnlyReg.Text = "Back Registration";
            this.btnshowOnlyReg.UseVisualStyleBackColor = false;
            this.btnshowOnlyReg.Click += new System.EventHandler(this.btnshowOnlyReg_Click);
            // 
            // ShowAllRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1690, 835);
            this.Controls.Add(this.btnshowOnlyReg);
            this.Controls.Add(this.btnbackRegAll);
            this.Controls.Add(this.showAllRegdgw);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllRegistration";
            this.Load += new System.EventHandler(this.ShowAllRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllRegdgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashbaordExit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView showAllRegdgw;
        private System.Windows.Forms.Button btnbackRegAll;
        private System.Windows.Forms.Button btnshowOnlyReg;
    }
}