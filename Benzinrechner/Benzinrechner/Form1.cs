using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzinrechner
{
    public partial class Form1 : Form
    {
        private int km_driven = 0;
        private double gas_per_hundred = 0.0;
        private double costPerLiter = 0.0;
        private double cost_per_km = 0.0;
        private double cost_per_trip = 0.0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            km_driven = Convert.ToInt32(txt_km.Text);
            gas_per_hundred = Convert.ToDouble(txt_bProHun.Text);
            costPerLiter = Convert.ToDouble(txt_bPreis.Text);

            cost_per_km = gas_per_hundred * costPerLiter / 100;
            cost_per_trip = cost_per_km * km_driven;

            txt_ausgabe.Text = "Pro km: " + cost_per_km.ToString("C") + " \r\nGesamte Reise: " + cost_per_trip.ToString("C");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ausgabe.Clear();
            txt_km.Clear();
            txt_bPreis.Clear();
            txt_bProHun.Clear();
        }

        private void btn_ende_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
