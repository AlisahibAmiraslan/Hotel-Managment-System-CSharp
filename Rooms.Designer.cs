namespace HotelManagmentSystem
{
    partial class Rooms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomNumlbl = new System.Windows.Forms.Label();
            this.roomAvalbl = new System.Windows.Forms.Label();
            this.roomTypelbl = new System.Windows.Forms.Label();
            this.roomNumbertbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomAvacbx = new System.Windows.Forms.ComboBox();
            this.roomTypecbx = new System.Windows.Forms.ComboBox();
            this.roomdwg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.btnRoomBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomdwg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 103);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pilot Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(674, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomNumlbl
            // 
            this.roomNumlbl.AutoSize = true;
            this.roomNumlbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomNumlbl.Location = new System.Drawing.Point(48, 188);
            this.roomNumlbl.Name = "roomNumlbl";
            this.roomNumlbl.Size = new System.Drawing.Size(152, 26);
            this.roomNumlbl.TabIndex = 1;
            this.roomNumlbl.Text = "Room Number";
            // 
            // roomAvalbl
            // 
            this.roomAvalbl.AutoSize = true;
            this.roomAvalbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomAvalbl.Location = new System.Drawing.Point(48, 241);
            this.roomAvalbl.Name = "roomAvalbl";
            this.roomAvalbl.Size = new System.Drawing.Size(184, 26);
            this.roomAvalbl.TabIndex = 2;
            this.roomAvalbl.Text = "Room Availability";
            // 
            // roomTypelbl
            // 
            this.roomTypelbl.AutoSize = true;
            this.roomTypelbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTypelbl.Location = new System.Drawing.Point(48, 296);
            this.roomTypelbl.Name = "roomTypelbl";
            this.roomTypelbl.Size = new System.Drawing.Size(120, 26);
            this.roomTypelbl.TabIndex = 3;
            this.roomTypelbl.Text = "Room Type";
            // 
            // roomNumbertbx
            // 
            this.roomNumbertbx.Location = new System.Drawing.Point(268, 188);
            this.roomNumbertbx.Name = "roomNumbertbx";
            this.roomNumbertbx.Size = new System.Drawing.Size(266, 35);
            this.roomNumbertbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.roomNumbertbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomNumbertbx.StateCommon.Border.Rounding = 12;
            this.roomNumbertbx.TabIndex = 5;
            // 
            // roomAvacbx
            // 
            this.roomAvacbx.FormattingEnabled = true;
            this.roomAvacbx.Items.AddRange(new object[] {
            "free"});
            this.roomAvacbx.Location = new System.Drawing.Point(268, 245);
            this.roomAvacbx.Name = "roomAvacbx";
            this.roomAvacbx.Size = new System.Drawing.Size(266, 24);
            this.roomAvacbx.TabIndex = 6;
            // 
            // roomTypecbx
            // 
            this.roomTypecbx.FormattingEnabled = true;
            this.roomTypecbx.Items.AddRange(new object[] {
            "single",
            "double",
            "triple"});
            this.roomTypecbx.Location = new System.Drawing.Point(268, 300);
            this.roomTypecbx.Name = "roomTypecbx";
            this.roomTypecbx.Size = new System.Drawing.Size(266, 24);
            this.roomTypecbx.TabIndex = 7;
            // 
            // roomdwg
            // 
            this.roomdwg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomdwg.BackgroundColor = System.Drawing.Color.White;
            this.roomdwg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomdwg.Location = new System.Drawing.Point(12, 538);
            this.roomdwg.Name = "roomdwg";
            this.roomdwg.RowHeadersWidth = 51;
            this.roomdwg.RowTemplate.Height = 24;
            this.roomdwg.Size = new System.Drawing.Size(726, 313);
            this.roomdwg.TabIndex = 8;
            this.roomdwg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomdwg_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(320, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rooms";
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnRoomAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAdd.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRoomAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRoomAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(53, 383);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(136, 48);
            this.btnRoomAdd.TabIndex = 9;
            this.btnRoomAdd.Text = "Add";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnRoomUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRoomUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRoomUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRoomUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomUpdate.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomUpdate.ForeColor = System.Drawing.Color.White;
            this.btnRoomUpdate.Location = new System.Drawing.Point(219, 383);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(136, 48);
            this.btnRoomUpdate.TabIndex = 10;
            this.btnRoomUpdate.Text = "Update";
            this.btnRoomUpdate.UseVisualStyleBackColor = false;
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDelete.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRoomDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRoomDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDelete.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomDelete.ForeColor = System.Drawing.Color.White;
            this.btnRoomDelete.Location = new System.Drawing.Point(378, 383);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(136, 48);
            this.btnRoomDelete.TabIndex = 11;
            this.btnRoomDelete.Text = "Delete";
            this.btnRoomDelete.UseVisualStyleBackColor = false;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // btnRoomBack
            // 
            this.btnRoomBack.BackColor = System.Drawing.Color.Crimson;
            this.btnRoomBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomBack.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRoomBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRoomBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRoomBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomBack.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomBack.ForeColor = System.Drawing.Color.White;
            this.btnRoomBack.Location = new System.Drawing.Point(542, 383);
            this.btnRoomBack.Name = "btnRoomBack";
            this.btnRoomBack.Size = new System.Drawing.Size(136, 48);
            this.btnRoomBack.TabIndex = 12;
            this.btnRoomBack.Text = "Back";
            this.btnRoomBack.UseVisualStyleBackColor = false;
            this.btnRoomBack.Click += new System.EventHandler(this.btnRoomBack_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(750, 873);
            this.Controls.Add(this.btnRoomBack);
            this.Controls.Add(this.btnRoomDelete);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.btnRoomAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomdwg);
            this.Controls.Add(this.roomTypecbx);
            this.Controls.Add(this.roomAvacbx);
            this.Controls.Add(this.roomNumbertbx);
            this.Controls.Add(this.roomTypelbl);
            this.Controls.Add(this.roomAvalbl);
            this.Controls.Add(this.roomNumlbl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomdwg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roomNumlbl;
        private System.Windows.Forms.Label roomAvalbl;
        private System.Windows.Forms.Label roomTypelbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomNumbertbx;
        private System.Windows.Forms.ComboBox roomAvacbx;
        private System.Windows.Forms.ComboBox roomTypecbx;
        private System.Windows.Forms.DataGridView roomdwg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Button btnRoomBack;
    }
}