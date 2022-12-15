namespace TemperaturRechner
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
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_farenheit = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.lbl_fahrenheit = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_head.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.White;
            this.lbl_head.Location = new System.Drawing.Point(-1, 0);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(421, 63);
            this.lbl_head.TabIndex = 0;
            this.lbl_head.Text = "Temperatur-Rechner";
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(49, 97);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(172, 20);
            this.txt_celsius.TabIndex = 1;
            this.txt_celsius.TextChanged += new System.EventHandler(this.txt_celsius_TextChanged);
            // 
            // txt_farenheit
            // 
            this.txt_farenheit.Location = new System.Drawing.Point(49, 124);
            this.txt_farenheit.Name = "txt_farenheit";
            this.txt_farenheit.Size = new System.Drawing.Size(171, 20);
            this.txt_farenheit.TabIndex = 2;
            this.txt_farenheit.TextChanged += new System.EventHandler(this.txt_farenheit_TextChanged);
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_calc.Location = new System.Drawing.Point(337, 66);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(65, 37);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "CALC";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.Location = new System.Drawing.Point(337, 109);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "CLR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.Location = new System.Drawing.Point(227, 97);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(55, 20);
            this.lbl_celsius.TabIndex = 6;
            this.lbl_celsius.Text = "°C";
            // 
            // lbl_fahrenheit
            // 
            this.lbl_fahrenheit.Location = new System.Drawing.Point(226, 124);
            this.lbl_fahrenheit.Name = "lbl_fahrenheit";
            this.lbl_fahrenheit.Size = new System.Drawing.Size(55, 20);
            this.lbl_fahrenheit.TabIndex = 7;
            this.lbl_fahrenheit.Text = "°F";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(337, 152);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 37);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(408, 183);
            this.Controls.Add(this.lbl_fahrenheit);
            this.Controls.Add(this.lbl_celsius);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_farenheit);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.lbl_head);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_celsius;
        private System.Windows.Forms.Label lbl_fahrenheit;
        private System.Windows.Forms.Button btn_exit;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_farenheit;

        private System.Windows.Forms.Label lbl_head;

        #endregion
    }
}

