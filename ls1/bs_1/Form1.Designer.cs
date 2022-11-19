namespace bs_1
{
    partial class MyForm
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_out = new System.Windows.Forms.Label();
            this.lbl_stat_Output = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_ok.Location = new System.Drawing.Point(12, 383);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(167, 55);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.Red;
            this.btn_end.Location = new System.Drawing.Point(324, 383);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(167, 55);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "ENDE";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Location = new System.Drawing.Point(12, 266);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(0, 13);
            this.lbl_out.TabIndex = 2;
            // 
            // lbl_stat_Output
            // 
            this.lbl_stat_Output.AutoSize = true;
            this.lbl_stat_Output.Location = new System.Drawing.Point(12, 253);
            this.lbl_stat_Output.Name = "lbl_stat_Output";
            this.lbl_stat_Output.Size = new System.Drawing.Size(39, 13);
            this.lbl_stat_Output.TabIndex = 3;
            this.lbl_stat_Output.Text = "Output";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 83);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(462, 142);
            this.txt_input.TabIndex = 4;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_stat_Output);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_ok);
            this.Name = "MyForm";
            this.Text = "Kilians lustiges Programm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.Label lbl_stat_Output;
        private System.Windows.Forms.TextBox txt_input;
    }
}

