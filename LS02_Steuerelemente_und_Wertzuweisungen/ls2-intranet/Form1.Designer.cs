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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_info = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_stat_user = new System.Windows.Forms.Label();
            this.lbl_stat_pass = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.gpb_design = new System.Windows.Forms.GroupBox();
            this.rbtn_blau = new System.Windows.Forms.RadioButton();
            this.rbtn_weiß = new System.Windows.Forms.RadioButton();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.btn_keypad = new System.Windows.Forms.Button();
            this.gpb_keypad = new System.Windows.Forms.GroupBox();
            this.btn_key_3 = new System.Windows.Forms.Button();
            this.btn_key_2 = new System.Windows.Forms.Button();
            this.btn_key_1 = new System.Windows.Forms.Button();
            this.btn_key_6 = new System.Windows.Forms.Button();
            this.btn_key_5 = new System.Windows.Forms.Button();
            this.btn_key_4 = new System.Windows.Forms.Button();
            this.btn_key_7 = new System.Windows.Forms.Button();
            this.btn_key_9 = new System.Windows.Forms.Button();
            this.btn_key_8 = new System.Windows.Forms.Button();
            this.btn_keypad_0 = new System.Windows.Forms.Button();
            this.nti_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_del = new System.Windows.Forms.Button();
            this.gpb_design.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.gpb_keypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(90, 315);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(109, 23);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(134, 186);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(218, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(134, 212);
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
            this.lbl_stat_user.Location = new System.Drawing.Point(87, 189);
            this.lbl_stat_user.Name = "lbl_stat_user";
            this.lbl_stat_user.Size = new System.Drawing.Size(35, 13);
            this.lbl_stat_user.TabIndex = 4;
            this.lbl_stat_user.Text = "Name";
            // 
            // lbl_stat_pass
            // 
            this.lbl_stat_pass.AutoSize = true;
            this.lbl_stat_pass.Location = new System.Drawing.Point(78, 215);
            this.lbl_stat_pass.Name = "lbl_stat_pass";
            this.lbl_stat_pass.Size = new System.Drawing.Size(25, 13);
            this.lbl_stat_pass.TabIndex = 5;
            this.lbl_stat_pass.Text = "PIN";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(134, 238);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(218, 30);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Anmelden";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(172, 128);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(141, 39);
            this.lbl_text.TabIndex = 7;
            this.lbl_text.Text = "LeitSystems Version 1.2\r\n\r\nAuthentifizierung Erforderlich";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Black;
            this.lbl_status.Location = new System.Drawing.Point(131, 285);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpb_design
            // 
            this.gpb_design.Controls.Add(this.rbtn_blau);
            this.gpb_design.Controls.Add(this.rbtn_weiß);
            this.gpb_design.Location = new System.Drawing.Point(12, 309);
            this.gpb_design.Name = "gpb_design";
            this.gpb_design.Size = new System.Drawing.Size(67, 58);
            this.gpb_design.TabIndex = 10;
            this.gpb_design.TabStop = false;
            this.gpb_design.Text = "Theme";
            // 
            // rbtn_blau
            // 
            this.rbtn_blau.AutoSize = true;
            this.rbtn_blau.Location = new System.Drawing.Point(7, 38);
            this.rbtn_blau.Name = "rbtn_blau";
            this.rbtn_blau.Size = new System.Drawing.Size(46, 17);
            this.rbtn_blau.TabIndex = 1;
            this.rbtn_blau.Text = "Blau";
            this.rbtn_blau.UseVisualStyleBackColor = true;
            this.rbtn_blau.CheckedChanged += new System.EventHandler(this.rbtn_blau_CheckedChanged);
            // 
            // rbtn_weiß
            // 
            this.rbtn_weiß.AutoSize = true;
            this.rbtn_weiß.Checked = true;
            this.rbtn_weiß.Location = new System.Drawing.Point(7, 19);
            this.rbtn_weiß.Name = "rbtn_weiß";
            this.rbtn_weiß.Size = new System.Drawing.Size(50, 17);
            this.rbtn_weiß.TabIndex = 0;
            this.rbtn_weiß.TabStop = true;
            this.rbtn_weiß.Text = "Weiß";
            this.rbtn_weiß.UseVisualStyleBackColor = true;
            this.rbtn_weiß.CheckedChanged += new System.EventHandler(this.rbtn_weiß_CheckedChanged);
            // 
            // img_logo
            // 
            this.img_logo.Image = global::ls2_intranet.Properties.Resources.LS2_3_1_Logo_LeitSystems;
            this.img_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("img_logo.InitialImage")));
            this.img_logo.Location = new System.Drawing.Point(36, 12);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(420, 113);
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // btn_keypad
            // 
            this.btn_keypad.Location = new System.Drawing.Point(90, 344);
            this.btn_keypad.Name = "btn_keypad";
            this.btn_keypad.Size = new System.Drawing.Size(109, 23);
            this.btn_keypad.TabIndex = 12;
            this.btn_keypad.Text = "Keys";
            this.btn_keypad.UseVisualStyleBackColor = true;
            this.btn_keypad.Click += new System.EventHandler(this.btn_keypad_Click);
            // 
            // gpb_keypad
            // 
            this.gpb_keypad.Controls.Add(this.btn_del);
            this.gpb_keypad.Controls.Add(this.btn_key_3);
            this.gpb_keypad.Controls.Add(this.btn_key_2);
            this.gpb_keypad.Controls.Add(this.btn_key_1);
            this.gpb_keypad.Controls.Add(this.btn_key_6);
            this.gpb_keypad.Controls.Add(this.btn_key_5);
            this.gpb_keypad.Controls.Add(this.btn_key_4);
            this.gpb_keypad.Controls.Add(this.btn_key_7);
            this.gpb_keypad.Controls.Add(this.btn_key_9);
            this.gpb_keypad.Controls.Add(this.btn_key_8);
            this.gpb_keypad.Controls.Add(this.btn_keypad_0);
            this.gpb_keypad.Location = new System.Drawing.Point(518, 65);
            this.gpb_keypad.Name = "gpb_keypad";
            this.gpb_keypad.Size = new System.Drawing.Size(254, 304);
            this.gpb_keypad.TabIndex = 13;
            this.gpb_keypad.TabStop = false;
            this.gpb_keypad.Text = "Keypad";
            this.gpb_keypad.Enter += new System.EventHandler(this.gpb_keypad_Enter);
            // 
            // btn_key_3
            // 
            this.btn_key_3.Location = new System.Drawing.Point(155, 41);
            this.btn_key_3.Name = "btn_key_3";
            this.btn_key_3.Size = new System.Drawing.Size(56, 56);
            this.btn_key_3.TabIndex = 9;
            this.btn_key_3.Text = "3";
            this.btn_key_3.UseVisualStyleBackColor = true;
            this.btn_key_3.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_2
            // 
            this.btn_key_2.Location = new System.Drawing.Point(93, 41);
            this.btn_key_2.Name = "btn_key_2";
            this.btn_key_2.Size = new System.Drawing.Size(56, 56);
            this.btn_key_2.TabIndex = 8;
            this.btn_key_2.Text = "2";
            this.btn_key_2.UseVisualStyleBackColor = true;
            this.btn_key_2.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_1
            // 
            this.btn_key_1.Location = new System.Drawing.Point(31, 41);
            this.btn_key_1.Name = "btn_key_1";
            this.btn_key_1.Size = new System.Drawing.Size(56, 56);
            this.btn_key_1.TabIndex = 7;
            this.btn_key_1.Text = "1";
            this.btn_key_1.UseVisualStyleBackColor = true;
            this.btn_key_1.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_6
            // 
            this.btn_key_6.Location = new System.Drawing.Point(155, 106);
            this.btn_key_6.Name = "btn_key_6";
            this.btn_key_6.Size = new System.Drawing.Size(56, 56);
            this.btn_key_6.TabIndex = 6;
            this.btn_key_6.Text = "6";
            this.btn_key_6.UseVisualStyleBackColor = true;
            this.btn_key_6.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_5
            // 
            this.btn_key_5.Location = new System.Drawing.Point(93, 103);
            this.btn_key_5.Name = "btn_key_5";
            this.btn_key_5.Size = new System.Drawing.Size(56, 56);
            this.btn_key_5.TabIndex = 5;
            this.btn_key_5.Text = "5";
            this.btn_key_5.UseVisualStyleBackColor = true;
            this.btn_key_5.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_4
            // 
            this.btn_key_4.Location = new System.Drawing.Point(31, 103);
            this.btn_key_4.Name = "btn_key_4";
            this.btn_key_4.Size = new System.Drawing.Size(56, 56);
            this.btn_key_4.TabIndex = 4;
            this.btn_key_4.Text = "4";
            this.btn_key_4.UseVisualStyleBackColor = true;
            this.btn_key_4.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_7
            // 
            this.btn_key_7.Location = new System.Drawing.Point(31, 165);
            this.btn_key_7.Name = "btn_key_7";
            this.btn_key_7.Size = new System.Drawing.Size(56, 56);
            this.btn_key_7.TabIndex = 3;
            this.btn_key_7.Text = "7";
            this.btn_key_7.UseVisualStyleBackColor = true;
            this.btn_key_7.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_9
            // 
            this.btn_key_9.Location = new System.Drawing.Point(155, 165);
            this.btn_key_9.Name = "btn_key_9";
            this.btn_key_9.Size = new System.Drawing.Size(56, 56);
            this.btn_key_9.TabIndex = 2;
            this.btn_key_9.Text = "9";
            this.btn_key_9.UseVisualStyleBackColor = true;
            this.btn_key_9.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_key_8
            // 
            this.btn_key_8.Location = new System.Drawing.Point(93, 165);
            this.btn_key_8.Name = "btn_key_8";
            this.btn_key_8.Size = new System.Drawing.Size(56, 56);
            this.btn_key_8.TabIndex = 1;
            this.btn_key_8.Text = "8";
            this.btn_key_8.UseVisualStyleBackColor = true;
            this.btn_key_8.Click += new System.EventHandler(this.key_button_click);
            // 
            // btn_keypad_0
            // 
            this.btn_keypad_0.Location = new System.Drawing.Point(93, 226);
            this.btn_keypad_0.Name = "btn_keypad_0";
            this.btn_keypad_0.Size = new System.Drawing.Size(56, 56);
            this.btn_keypad_0.TabIndex = 0;
            this.btn_keypad_0.Text = "0";
            this.btn_keypad_0.UseVisualStyleBackColor = true;
            this.btn_keypad_0.Click += new System.EventHandler(this.key_button_click);
            // 
            // nti_main
            // 
            this.nti_main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nti_main.BalloonTipText = "Login Erforderlich";
            this.nti_main.BalloonTipTitle = "LeitSystems Intranet Access";
            this.nti_main.Icon = ((System.Drawing.Icon)(resources.GetObject("nti_main.Icon")));
            this.nti_main.Text = "LeitSystems Intranet Access";
            this.nti_main.Visible = true;
            this.nti_main.BalloonTipClicked += new System.EventHandler(this.nti_main_Click);
            this.nti_main.Click += new System.EventHandler(this.nti_main_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(155, 227);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(56, 56);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Del.";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.gpb_keypad);
            this.Controls.Add(this.btn_keypad);
            this.Controls.Add(this.gpb_design);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_stat_pass);
            this.Controls.Add(this.lbl_stat_user);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.img_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Leitsystems v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_design.ResumeLayout(false);
            this.gpb_design.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.gpb_keypad.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.GroupBox gpb_design;
        private System.Windows.Forms.RadioButton rbtn_blau;
        private System.Windows.Forms.RadioButton rbtn_weiß;
        private System.Windows.Forms.Button btn_keypad;
        private System.Windows.Forms.GroupBox gpb_keypad;
        private System.Windows.Forms.Button btn_keypad_0;
        private System.Windows.Forms.NotifyIcon nti_main;
        private System.Windows.Forms.Button btn_key_3;
        private System.Windows.Forms.Button btn_key_2;
        private System.Windows.Forms.Button btn_key_1;
        private System.Windows.Forms.Button btn_key_6;
        private System.Windows.Forms.Button btn_key_5;
        private System.Windows.Forms.Button btn_key_4;
        private System.Windows.Forms.Button btn_key_7;
        private System.Windows.Forms.Button btn_key_9;
        private System.Windows.Forms.Button btn_key_8;
        private System.Windows.Forms.Button btn_del;
    }
}

