namespace ls2_intranet
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_stat_user = new System.Windows.Forms.Label();
            this.lbl_stat_pass = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.gpb_design = new System.Windows.Forms.GroupBox();
            this.rbtn_weiß = new System.Windows.Forms.RadioButton();
            this.rbtn_blau = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.gpb_design.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.Image = global::ls2_intranet.Properties.Resources.LS2_3_1_Logo_LeitSystems;
            this.img_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_logo.InitialImage")));
            this.img_logo.Location = new System.Drawing.Point(80, 12);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(420, 113);
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(616, 498);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(188, 186);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(218, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(188, 212);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.PasswordChar = '*';
            this.txt_pin.Size = new System.Drawing.Size(218, 20);
            this.txt_pin.TabIndex = 3;
            this.txt_pin.UseSystemPasswordChar = true;
            this.txt_pin.TextChanged += new System.EventHandler(this.txt_pin_TextChanged);
            this.txt_pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pin_KeyDown);
            // 
            // lbl_stat_user
            // 
            this.lbl_stat_user.AutoSize = true;
            this.lbl_stat_user.Location = new System.Drawing.Point(141, 189);
            this.lbl_stat_user.Name = "lbl_stat_user";
            this.lbl_stat_user.Size = new System.Drawing.Size(35, 13);
            this.lbl_stat_user.TabIndex = 4;
            this.lbl_stat_user.Text = "Name";
            // 
            // lbl_stat_pass
            // 
            this.lbl_stat_pass.AutoSize = true;
            this.lbl_stat_pass.Location = new System.Drawing.Point(132, 215);
            this.lbl_stat_pass.Name = "lbl_stat_pass";
            this.lbl_stat_pass.Size = new System.Drawing.Size(25, 13);
            this.lbl_stat_pass.TabIndex = 5;
            this.lbl_stat_pass.Text = "PIN";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(248, 238);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(90, 30);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Anmelden";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(226, 128);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(141, 39);
            this.lbl_text.TabIndex = 7;
            this.lbl_text.Text = "LeitSystems Version 1.2\r\n\r\nAuthentifizierung Erforderlich";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(132, 271);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(344, 13);
            this.lbl_error.TabIndex = 8;
            this.lbl_error.Text = "ANMELDUNG FEHLGESCHLAGEN! Bitte erneut versuchen!";
            this.lbl_error.Visible = false;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.Lime;
            this.lbl_success.Location = new System.Drawing.Point(132, 284);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_success.Size = new System.Drawing.Size(374, 13);
            this.lbl_success.TabIndex = 9;
            this.lbl_success.Text = "Anmeldung Erfolgreich, Verbindung zum Intranet wird hergestellt.";
            this.lbl_success.Visible = false;
            // 
            // gpb_design
            // 
            this.gpb_design.Controls.Add(this.rbtn_blau);
            this.gpb_design.Controls.Add(this.rbtn_weiß);
            this.gpb_design.Location = new System.Drawing.Point(573, 107);
            this.gpb_design.Name = "gpb_design";
            this.gpb_design.Size = new System.Drawing.Size(118, 75);
            this.gpb_design.TabIndex = 10;
            this.gpb_design.TabStop = false;
            this.gpb_design.Text = "Theme";
            // 
            // rbtn_weiß
            // 
            this.rbtn_weiß.AutoSize = true;
            this.rbtn_weiß.Checked = true;
            this.rbtn_weiß.Location = new System.Drawing.Point(7, 21);
            this.rbtn_weiß.Name = "rbtn_weiß";
            this.rbtn_weiß.Size = new System.Drawing.Size(50, 17);
            this.rbtn_weiß.TabIndex = 0;
            this.rbtn_weiß.TabStop = true;
            this.rbtn_weiß.Text = "Weiß";
            this.rbtn_weiß.UseVisualStyleBackColor = true;
            this.rbtn_weiß.CheckedChanged += new System.EventHandler(this.rbtn_weiß_CheckedChanged);
            // 
            // rbtn_blau
            // 
            this.rbtn_blau.AutoSize = true;
            this.rbtn_blau.Location = new System.Drawing.Point(7, 45);
            this.rbtn_blau.Name = "rbtn_blau";
            this.rbtn_blau.Size = new System.Drawing.Size(46, 17);
            this.rbtn_blau.TabIndex = 1;
            this.rbtn_blau.Text = "Blau";
            this.rbtn_blau.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(703, 533);
            this.Controls.Add(this.gpb_design);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_stat_pass);
            this.Controls.Add(this.lbl_stat_user);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.img_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Leitsystems v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.gpb_design.ResumeLayout(false);
            this.gpb_design.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label lbl_stat_user;
        private System.Windows.Forms.Label lbl_stat_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.GroupBox gpb_design;
        private System.Windows.Forms.RadioButton rbtn_blau;
        private System.Windows.Forms.RadioButton rbtn_weiß;
    }
}

