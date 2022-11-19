using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bs_1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            String inp = txt_input.Text;
            inp = inp.Replace("a", "b");
            inp = inp.Replace("c", "d");
            inp = inp.Replace("e", "f");
            inp = inp.Replace("g", "h");
            inp = inp.Replace("i", "j");

            lbl_out.Text = inp;
        }
    }
}
