namespace mwst_rechner
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_netto = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_brutto = new System.Windows.Forms.TextBox();
            this.lbl_netto = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_brutto = new System.Windows.Forms.Label();
            this.btn_netto = new System.Windows.Forms.Button();
            this.btn_tax = new System.Windows.Forms.Button();
            this.btn_brutto = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_netto
            // 
            this.txt_netto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_netto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_netto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_netto.ForeColor = System.Drawing.Color.White;
            this.txt_netto.Location = new System.Drawing.Point(72, 40);
            this.txt_netto.Name = "txt_netto";
            this.txt_netto.Size = new System.Drawing.Size(100, 20);
            this.txt_netto.TabIndex = 0;
            this.txt_netto.Text = "0,00";
            // 
            // txt_tax
            // 
            this.txt_tax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tax.ForeColor = System.Drawing.Color.White;
            this.txt_tax.Location = new System.Drawing.Point(72, 66);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 1;
            this.txt_tax.Text = "19,0";
            // 
            // txt_brutto
            // 
            this.txt_brutto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_brutto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_brutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brutto.ForeColor = System.Drawing.Color.White;
            this.txt_brutto.Location = new System.Drawing.Point(72, 92);
            this.txt_brutto.Name = "txt_brutto";
            this.txt_brutto.Size = new System.Drawing.Size(100, 20);
            this.txt_brutto.TabIndex = 2;
            this.txt_brutto.Text = "0,00";
            // 
            // lbl_netto
            // 
            this.lbl_netto.AutoSize = true;
            this.lbl_netto.Location = new System.Drawing.Point(31, 40);
            this.lbl_netto.Name = "lbl_netto";
            this.lbl_netto.Size = new System.Drawing.Size(36, 13);
            this.lbl_netto.TabIndex = 3;
            this.lbl_netto.Text = "Netto:";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(6, 66);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(60, 13);
            this.lbl_tax.TabIndex = 4;
            this.lbl_tax.Text = "Steuersatz:";
            // 
            // lbl_brutto
            // 
            this.lbl_brutto.AutoSize = true;
            this.lbl_brutto.Location = new System.Drawing.Point(31, 92);
            this.lbl_brutto.Name = "lbl_brutto";
            this.lbl_brutto.Size = new System.Drawing.Size(38, 13);
            this.lbl_brutto.TabIndex = 5;
            this.lbl_brutto.Text = "Brutto:";
            // 
            // btn_netto
            // 
            this.btn_netto.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_netto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_netto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_netto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_netto.Location = new System.Drawing.Point(179, 40);
            this.btn_netto.Name = "btn_netto";
            this.btn_netto.Size = new System.Drawing.Size(90, 23);
            this.btn_netto.TabIndex = 6;
            this.btn_netto.Text = "Berechnen";
            this.btn_netto.UseVisualStyleBackColor = false;
            this.btn_netto.Click += new System.EventHandler(this.btn_netto_Click);
            // 
            // btn_tax
            // 
            this.btn_tax.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_tax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_tax.Location = new System.Drawing.Point(179, 64);
            this.btn_tax.Name = "btn_tax";
            this.btn_tax.Size = new System.Drawing.Size(90, 23);
            this.btn_tax.TabIndex = 7;
            this.btn_tax.Text = "Berechnen";
            this.btn_tax.UseVisualStyleBackColor = false;
            this.btn_tax.Click += new System.EventHandler(this.btn_tax_Click);
            // 
            // btn_brutto
            // 
            this.btn_brutto.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_brutto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brutto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_brutto.Location = new System.Drawing.Point(179, 90);
            this.btn_brutto.Name = "btn_brutto";
            this.btn_brutto.Size = new System.Drawing.Size(90, 23);
            this.btn_brutto.TabIndex = 8;
            this.btn_brutto.Text = "Berechnen";
            this.btn_brutto.UseVisualStyleBackColor = false;
            this.btn_brutto.Click += new System.EventHandler(this.btn_brutto_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(72, 118);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 35);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(52, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 28);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "MwSt-Rechner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(281, 177);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_brutto);
            this.Controls.Add(this.btn_tax);
            this.Controls.Add(this.btn_netto);
            this.Controls.Add(this.lbl_brutto);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_netto);
            this.Controls.Add(this.txt_brutto);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_netto);
            this.Name = "Form1";
            this.Text = "MwSt-Recher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_title;

        #endregion

        private System.Windows.Forms.TextBox txt_netto;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_brutto;
        private System.Windows.Forms.Label lbl_netto;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_brutto;
        private System.Windows.Forms.Button btn_netto;
        private System.Windows.Forms.Button btn_tax;
        private System.Windows.Forms.Button btn_brutto;
        private System.Windows.Forms.Button btn_clear;
    }
}

