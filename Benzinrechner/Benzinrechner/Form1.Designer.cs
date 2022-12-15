namespace Benzinrechner
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
            this.lbl_head = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_bProHun = new System.Windows.Forms.TextBox();
            this.txt_bPreis = new System.Windows.Forms.TextBox();
            this.txt_ausgabe = new System.Windows.Forms.TextBox();
            this.btn_rechner = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ende = new System.Windows.Forms.Button();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_bProHun = new System.Windows.Forms.Label();
            this.lbl_bPreis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_head.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_head.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.White;
            this.lbl_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(434, 86);
            this.lbl_head.TabIndex = 0;
            this.lbl_head.Text = "Benzinrechner";
            this.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(72, 127);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(134, 20);
            this.txt_km.TabIndex = 1;
            // 
            // txt_bProHun
            // 
            this.txt_bProHun.Location = new System.Drawing.Point(72, 153);
            this.txt_bProHun.Name = "txt_bProHun";
            this.txt_bProHun.Size = new System.Drawing.Size(134, 20);
            this.txt_bProHun.TabIndex = 3;
            // 
            // txt_bPreis
            // 
            this.txt_bPreis.Location = new System.Drawing.Point(72, 179);
            this.txt_bPreis.Name = "txt_bPreis";
            this.txt_bPreis.Size = new System.Drawing.Size(134, 20);
            this.txt_bPreis.TabIndex = 4;
            // 
            // txt_ausgabe
            // 
            this.txt_ausgabe.BackColor = System.Drawing.Color.White;
            this.txt_ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ausgabe.ForeColor = System.Drawing.Color.Red;
            this.txt_ausgabe.Location = new System.Drawing.Point(72, 251);
            this.txt_ausgabe.Multiline = true;
            this.txt_ausgabe.Name = "txt_ausgabe";
            this.txt_ausgabe.ReadOnly = true;
            this.txt_ausgabe.Size = new System.Drawing.Size(280, 86);
            this.txt_ausgabe.TabIndex = 5;
            // 
            // btn_rechner
            // 
            this.btn_rechner.Location = new System.Drawing.Point(270, 127);
            this.btn_rechner.Name = "btn_rechner";
            this.btn_rechner.Size = new System.Drawing.Size(82, 19);
            this.btn_rechner.TabIndex = 6;
            this.btn_rechner.Text = "Berechnen";
            this.btn_rechner.UseVisualStyleBackColor = true;
            this.btn_rechner.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(270, 155);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 19);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ende
            // 
            this.btn_ende.Location = new System.Drawing.Point(270, 180);
            this.btn_ende.Name = "btn_ende";
            this.btn_ende.Size = new System.Drawing.Size(82, 19);
            this.btn_ende.TabIndex = 8;
            this.btn_ende.Text = "ENDE";
            this.btn_ende.UseVisualStyleBackColor = true;
            this.btn_ende.Click += new System.EventHandler(this.btn_ende_Click);
            // 
            // lbl_km
            // 
            this.lbl_km.Location = new System.Drawing.Point(212, 130);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(52, 16);
            this.lbl_km.TabIndex = 9;
            this.lbl_km.Text = "km";
            // 
            // lbl_bProHun
            // 
            this.lbl_bProHun.Location = new System.Drawing.Point(212, 156);
            this.lbl_bProHun.Name = "lbl_bProHun";
            this.lbl_bProHun.Size = new System.Drawing.Size(52, 16);
            this.lbl_bProHun.TabIndex = 10;
            this.lbl_bProHun.Text = "l/100km";
            // 
            // lbl_bPreis
            // 
            this.lbl_bPreis.Location = new System.Drawing.Point(212, 179);
            this.lbl_bPreis.Name = "lbl_bPreis";
            this.lbl_bPreis.Size = new System.Drawing.Size(52, 16);
            this.lbl_bPreis.TabIndex = 11;
            this.lbl_bPreis.Text = "€/Liter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 349);
            this.Controls.Add(this.lbl_bPreis);
            this.Controls.Add(this.lbl_bProHun);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.btn_ende);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_rechner);
            this.Controls.Add(this.txt_ausgabe);
            this.Controls.Add(this.txt_bPreis);
            this.Controls.Add(this.txt_bProHun);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.lbl_head);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_bProHun;
        private System.Windows.Forms.Label lbl_bPreis;

        private System.Windows.Forms.Button btn_rechner;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ende;

        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_bPreis;
        private System.Windows.Forms.TextBox txt_bProHun;
        private System.Windows.Forms.TextBox txt_ausgabe;

        private System.Windows.Forms.Label lbl_head;

        #endregion
    }
}

