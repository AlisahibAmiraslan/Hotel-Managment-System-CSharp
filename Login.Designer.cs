namespace HotelManagmentSystem
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mailtbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.maillbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtbx = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.loginExitlbl = new System.Windows.Forms.Label();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(217, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilot Hotel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagmentSystem.Properties.Resources.logo_912f9cb8ea4943c7b421;
            this.pictureBox1.Location = new System.Drawing.Point(225, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mailtbx
            // 
            this.mailtbx.Location = new System.Drawing.Point(225, 280);
            this.mailtbx.Name = "mailtbx";
            this.mailtbx.Size = new System.Drawing.Size(238, 37);
            this.mailtbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.mailtbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mailtbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.mailtbx.StateCommon.Border.Rounding = 15;
            this.mailtbx.TabIndex = 2;
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maillbl.Location = new System.Drawing.Point(77, 288);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(82, 26);
            this.maillbl.TabIndex = 3;
            this.maillbl.Text = "E-mail:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordlbl.Location = new System.Drawing.Point(77, 346);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(115, 26);
            this.passwordlbl.TabIndex = 5;
            this.passwordlbl.Text = "Password:";
            // 
            // passwordtbx
            // 
            this.passwordtbx.Location = new System.Drawing.Point(225, 340);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '*';
            this.passwordtbx.Size = new System.Drawing.Size(238, 37);
            this.passwordtbx.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordtbx.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordtbx.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.passwordtbx.StateCommon.Border.Rounding = 15;
            this.passwordtbx.TabIndex = 4;
            // 
            // loginExitlbl
            // 
            this.loginExitlbl.AutoSize = true;
            this.loginExitlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginExitlbl.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginExitlbl.Location = new System.Drawing.Point(562, 24);
            this.loginExitlbl.Name = "loginExitlbl";
            this.loginExitlbl.Size = new System.Drawing.Size(45, 48);
            this.loginExitlbl.TabIndex = 8;
            this.loginExitlbl.Text = "X";
            this.loginExitlbl.Click += new System.EventHandler(this.loginExitlbl_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(262, 429);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 51);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagmentSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(635, 539);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.loginExitlbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.mailtbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mailtbx;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.Label passwordlbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordtbx;
        private System.Windows.Forms.Label loginExitlbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
    }
}