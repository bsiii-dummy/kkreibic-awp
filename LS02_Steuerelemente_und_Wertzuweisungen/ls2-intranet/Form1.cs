using ls2_intranet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ls2_intranet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.login(txt_name.Text.ToString(), txt_pin.Text.ToString());
        }

        private void txt_pin_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txt_pin.Text, "[^0-9]"))
            {
                MessageBox.Show("Ungültige Zeichen angegeben! Bitte nur Ziffern angeben.");
                txt_pin.Text = "";
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txt_pin.Select();
            }
        }

        private void txt_pin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && btn_login.Enabled)
            {
                e.Handled = true;
                this.login(txt_name.Text.ToString(), txt_pin.Text.ToString());
            }
        }

        private void login(String users, String pins)
        {
            String user = "admin";
            String pin = "1234";
            if (users == user && pins == pin)
            {
                lbl_error.Visible = false;
                lbl_success.Visible = true;
                btn_login.Enabled = false;
            }
            else
            {
                lbl_error.Visible = true;
            }
        }

        private void rbtn_weiß_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_weiß.Checked)
            {
                this.BackColor = Color.White;
                img_logo.Image = Resources.LS2_3_1_Logo_LeitSystems;
            } else if (rbtn_blau.Checked)
            {
                this.BackColor = Color.FromArgb(0xD9E2F3);
                img_logo.Image = Resources.LS2_3_2_LogoBackground;
            }
        }
    }
}
