namespace dieFliege
{
    partial class FrmMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.pbx_fliege = new System.Windows.Forms.PictureBox();
            this.btn_ende = new System.Windows.Forms.Button();
            this.cb_border = new System.Windows.Forms.CheckBox();
            this.txt_stepMulti = new System.Windows.Forms.TextBox();
            this.btn_step_width = new System.Windows.Forms.Button();
            this.cc_step_width = new System.Windows.Forms.ContainerControl();
            this.lbl_step_width = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fliege)).BeginInit();
            this.cc_step_width.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(210, 331);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 52);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "Hoch";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(129, 360);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 52);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "Links";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(210, 389);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 52);
            this.btn_down.TabIndex = 2;
            this.btn_down.Text = "Runter";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(291, 360);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 52);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Rechts";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // pbx_fliege
            // 
            this.pbx_fliege.Image = global::dieFliege.Properties.Resources.Fliege_Norden;
            this.pbx_fliege.Location = new System.Drawing.Point(219, 195);
            this.pbx_fliege.Name = "pbx_fliege";
            this.pbx_fliege.Size = new System.Drawing.Size(66, 66);
            this.pbx_fliege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fliege.TabIndex = 4;
            this.pbx_fliege.TabStop = false;
            this.pbx_fliege.Click += new System.EventHandler(this.pbx_fliege_Click);
            // 
            // btn_ende
            // 
            this.btn_ende.Location = new System.Drawing.Point(12, 389);
            this.btn_ende.Name = "btn_ende";
            this.btn_ende.Size = new System.Drawing.Size(75, 52);
            this.btn_ende.TabIndex = 5;
            this.btn_ende.Text = "ENDE";
            this.btn_ende.UseVisualStyleBackColor = true;
            this.btn_ende.Click += new System.EventHandler(this.btn_ende_Click);
            // 
            // cb_border
            // 
            this.cb_border.Location = new System.Drawing.Point(192, 308);
            this.cb_border.Name = "cb_border";
            this.cb_border.Size = new System.Drawing.Size(103, 17);
            this.cb_border.TabIndex = 6;
            this.cb_border.Text = "Am Rand halten";
            this.cb_border.UseVisualStyleBackColor = true;
            // 
            // txt_stepMulti
            // 
            this.txt_stepMulti.Location = new System.Drawing.Point(28, 26);
            this.txt_stepMulti.Name = "txt_stepMulti";
            this.txt_stepMulti.Size = new System.Drawing.Size(108, 20);
            this.txt_stepMulti.TabIndex = 7;
            this.txt_stepMulti.TextChanged += new System.EventHandler(this.txt_stepMulti_TextChanged);
            // 
            // btn_step_width
            // 
            this.btn_step_width.Location = new System.Drawing.Point(28, 54);
            this.btn_step_width.Name = "btn_step_width";
            this.btn_step_width.Size = new System.Drawing.Size(107, 23);
            this.btn_step_width.TabIndex = 8;
            this.btn_step_width.Text = "Set";
            this.btn_step_width.UseVisualStyleBackColor = true;
            this.btn_step_width.Click += new System.EventHandler(this.btn_step_width_Click);
            // 
            // cc_step_width
            // 
            this.cc_step_width.BackColor = System.Drawing.SystemColors.Control;
            this.cc_step_width.Controls.Add(this.lbl_step_width);
            this.cc_step_width.Controls.Add(this.btn_step_width);
            this.cc_step_width.Controls.Add(this.txt_stepMulti);
            this.cc_step_width.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cc_step_width.Location = new System.Drawing.Point(517, 338);
            this.cc_step_width.Name = "cc_step_width";
            this.cc_step_width.Size = new System.Drawing.Size(158, 103);
            this.cc_step_width.TabIndex = 9;
            this.cc_step_width.Text = "Schrittweitenmultiplikator";
            // 
            // lbl_step_width
            // 
            this.lbl_step_width.Location = new System.Drawing.Point(3, 0);
            this.lbl_step_width.Name = "lbl_step_width";
            this.lbl_step_width.Size = new System.Drawing.Size(132, 23);
            this.lbl_step_width.TabIndex = 9;
            this.lbl_step_width.Text = "Schrittweitenmultiplikator";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cc_step_width);
            this.Controls.Add(this.cb_border);
            this.Controls.Add(this.btn_ende);
            this.Controls.Add(this.pbx_fliege);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_up);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Die Flieege";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fliege)).EndInit();
            this.cc_step_width.ResumeLayout(false);
            this.cc_step_width.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_step_width;

        private System.Windows.Forms.Button btn_step_width;
        private System.Windows.Forms.ContainerControl cc_step_width;

        private System.Windows.Forms.TextBox txt_stepMulti;

        private System.Windows.Forms.CheckBox cb_border;

        #endregion

        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.PictureBox pbx_fliege;
        private System.Windows.Forms.Button btn_ende;
    }
}

