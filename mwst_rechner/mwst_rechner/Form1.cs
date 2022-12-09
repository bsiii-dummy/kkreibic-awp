using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwst_rechner
{
    public partial class Form1 : Form
    {
        private double mwst = 0.19;
        private double netto = 0.00;
        private double brutto = 0.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_netto_Click(object sender, EventArgs e)
        {
            mwst = Convert.ToDouble(txt_tax.Text) / 100;
            brutto = Convert.ToDouble(txt_brutto.Text);
            double factor = 100 + mwst * 100;
            netto = (brutto / factor) * 100;
            update_fields();
        }

        private void btn_brutto_Click(object sender, EventArgs e)
        {
            mwst = Convert.ToDouble(txt_tax.Text) / 100;
            netto = Convert.ToDouble(txt_netto.Text);
            brutto = netto + netto * mwst;
            update_fields();
        }

        private void btn_tax_Click(object sender, EventArgs e)
        {
            netto = Convert.ToDouble(txt_netto.Text);
            brutto = Convert.ToDouble(txt_brutto.Text);
            mwst = (brutto / netto) - 1;
            update_fields();
        }
        private void update_fields()
        {
            txt_brutto.Text = brutto.ToString("0.00");
            txt_netto.Text = netto.ToString("0.00");
            txt_tax.Text = (mwst * 100).ToString("00.0");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            netto = 0.0;
            brutto = 0.0;
            mwst = 0.19;
            update_fields();
        }
    }
}
