using ls2_intranet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using ls2_intranet.Models;
using Newtonsoft.Json;
#pragma warning disable CS4014


namespace ls2_intranet
{
    public partial class Form1 : Form
    {
        private bool _keyact = false;
        private bool _logSuccess = false;
        private const int WidthNoKey = 490;
        private const int WidthWithKey = 800;

        public Form1()
        {
            InitializeComponent();
            _keyact = false;
            btn_keypad.Text = Resources.keypad_act;
            this.Width = WidthNoKey;
            gpb_keypad.Visible = false;
            nti_main.ShowBalloonTip(5000);
            nti_main.Icon = Resources.ls_err;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_keypad.Text = Resources.keypad_act;
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
            if (_logSuccess)
            {
                e.Handled = true;
            }
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txt_pin.Select();
            }
        }

        private void txt_pin_KeyDown(object sender, KeyEventArgs e)
        {
            if (_logSuccess)
            {
                e.Handled = true;
            }
            if(e.KeyCode == Keys.Enter && btn_login.Enabled)
            {
                e.Handled = true;
                this.login(txt_name.Text.ToString(), txt_pin.Text.ToString());
            }
        }

        private void login(String users, String pins)
        {
            if (_logSuccess) return;
            int userId = int.Parse(users);
            int userPin = int.Parse(pins);
            login_to_server(userId, userPin);

            /***
            if (users == user && pins == pin)
            {
                lbl_status.ForeColor = Color.Green;
                lbl_status.Text = Resources.login_success;
                btn_login.Enabled = false;
                _logSuccess = true;
                nti_main.Icon = Resources.ls_ok;
                nti_main.BalloonTipTitle = "Login Erfolgt.";
                nti_main.BalloonTipText = "Sie wurden im LeitSystems Intranet angemeldet als: " + users;
                nti_main.BalloonTipIcon = ToolTipIcon.Info;
                nti_main.ShowBalloonTip(5000);
                txt_name.Enabled = false;
                txt_pin.Enabled = false;
            }
            else
            {
                lbl_status.ForeColor = Color.Red;
                lbl_status.Text = Resources.login_err_creds;
                _logSuccess = false;
                txt_name.Clear();
                txt_pin.Clear();
            }
            */
        }
        
        private async Task login_to_server(int userid, int userpin)
        {
            Console.WriteLine(userid);
            HttpClient client = new HttpClient();
            try
            {
                string reqBody = JsonConvert.SerializeObject(new LoginRequest(userid, userpin));
                Console.WriteLine(reqBody);
                StringContent content = new StringContent(reqBody, Encoding.UTF8, "text/json");
                Console.WriteLine(content);
                HttpResponseMessage response = await client.PostAsync("https://localhost:7251/api/User/Login", content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Login Success
                    string responseBody = await response.Content.ReadAsStringAsync();
                    User user = JsonConvert.DeserializeObject<User>(responseBody);
                    
                    lbl_status.ForeColor = Color.Green;
                    lbl_status.Text = "Angemeldet: " + user.UserRole + "\\" + user.UserId + " - " + user.DisplayName;
                    btn_login.Enabled = false;
                    _logSuccess = true;
                    nti_main.Icon = Resources.ls_ok;
                    nti_main.BalloonTipTitle = "Login Erfolgt.";
                    nti_main.BalloonTipText = "Sie wurden im LeitSystems Intranet angemeldet als: " + user.DisplayName + ". Rolle: " + user.UserRole;
                    nti_main.BalloonTipIcon = ToolTipIcon.Info;
                    nti_main.ShowBalloonTip(5000);
                    txt_name.Enabled = false;
                    txt_pin.Enabled = false;
                    return;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            lbl_status.ForeColor = Color.Red;
            lbl_status.Text = Resources.login_err_creds;
            _logSuccess = false;
            txt_name.Clear();
            txt_pin.Clear();
        }
        
        private void rbtn_weiß_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_weiß.Checked)
            {
                this.BackColor = Color.White;
                img_logo.Image = Resources.LS2_3_1_Logo_LeitSystems;
            } else if (rbtn_blau.Checked)
            {
                this.BackColor = Color.FromArgb(217,226,243);
                img_logo.Image = Resources.LS2_3_2_LogoBackground;
            }
        }

        private void rbtn_blau_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leitsystems Intranet Login by Kilian Kreibich (Copyright 2022)", "LeitSystems Intranet Login");
        }

        private void btn_keypad_Click(object sender, EventArgs e)
        {
            if (_keyact)
            {
                _keyact = false;
                btn_keypad.Text = Resources.keypad_act;
                this.Width = WidthNoKey;
                gpb_keypad.Visible = false;
            }
            else
            {
                _keyact = true;
                btn_keypad.Text = Resources.keypad_deact;
                this.Width = WidthWithKey;
                gpb_keypad.Visible = true;
            }
        }

        private void key_button_click(object sender, EventArgs e)
        {
            String num_enter = ((Button)sender).Text;
            if (_keyact)
            {
                txt_pin.Text = txt_pin.Text + num_enter;
            }
            
        }

        private void gpb_keypad_Enter(object sender, EventArgs e)
        {

        }

        private void nti_main_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_pin.Text.Length > 0)
            {
                txt_pin.Text = txt_pin.Text.Remove(txt_pin.Text.Length - 1);
            }
        }
    }
}
