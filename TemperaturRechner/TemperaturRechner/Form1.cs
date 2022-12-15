using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturRechner
{
    public partial class Form1 : Form
    {
        private double cels = 0.0;
        private double farh = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_celsius_TextChanged(object sender, EventArgs e)
        {
            if (!txt_celsius.Focused)
            {
                return;
            }
            if (txt_celsius.Text == "")
            {
                return;
            }
            cels = Convert.ToDouble(txt_celsius.Text);
            farh = ((cels * 9) / 5) + 32;
            txt_farenheit.Text = farh.ToString("0.00");
        }

        private void txt_farenheit_TextChanged(object sender, EventArgs e)
        {
            if (!txt_farenheit.Focused)
            {
                return;
            }
            if (txt_farenheit.Text == "")
            {
                return;
            }
            farh = Convert.ToDouble(txt_farenheit.Text);
            //cels = ((cels * 9) / 5) + 32;
            cels = (farh - 32) * 5 / 9;
            txt_celsius.Text = cels.ToString("0.00");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_celsius.Text = "";
            txt_farenheit.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
