using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dieFliege
{
    public partial class FRM_main : Form
    {
        public FRM_main()
        {
            InitializeComponent();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            pbx_fliege.Image = dieFliege.Properties.Resources.Fliege_Norden;
            if (cb_border.Checked && pbx_fliege.Top <= 25)
            {
                return;
            }

            pbx_fliege.Top -= (int)Math.Round(0.5 * pbx_fliege.Height);
            if (pbx_fliege.Top < 0)
            { 
                pbx_fliege.Top = ClientSize.Height;
            }

        }

        private void btn_ende_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            pbx_fliege.Image = dieFliege.Properties.Resources.Fliege_Osten;
            if (cb_border.Checked && pbx_fliege.Left >= this.ClientSize.Width)
            {
                return;
            }
            pbx_fliege.Left += (int)Math.Round(0.5 * pbx_fliege.Width);
            if (pbx_fliege.Left > this.ClientSize.Width)
            {
                pbx_fliege.Left = 0 - pbx_fliege.Width;
            }

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            pbx_fliege.Image = dieFliege.Properties.Resources.Fliege_Westen;
            if (cb_border.Checked && pbx_fliege.Left <= 30 - 0)
            {
                return;
            }
            pbx_fliege.Left -= (int)Math.Round(0.5 * pbx_fliege.Width);
            if (pbx_fliege.Left < -10 - pbx_fliege.Width)
            {
                pbx_fliege.Left = this.ClientSize.Width;
            }
            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            pbx_fliege.Image = dieFliege.Properties.Resources.Fliege_Süden;
            if (cb_border.Checked && pbx_fliege.Top >= ClientSize.Height - btn_up.Top - 20)
            {
                return;
            }
            pbx_fliege.Top += (int)Math.Round(0.5 * pbx_fliege.Height);
                if (pbx_fliege.Top > this.ClientSize.Height)
                {
                    pbx_fliege.Top = 0 - pbx_fliege.Height;
                }
        }

        private void pbx_fliege_Click(object sender, EventArgs e)
        {
            MouseEventArgs mArgs = (MouseEventArgs)e;
            switch (mArgs.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    pbx_fliege.Height = (int)Math.Round(pbx_fliege.Height * 1.2);
                    pbx_fliege.Width = (int)Math.Round(pbx_fliege.Width * 1.2);
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    pbx_fliege.Height = (int)Math.Round(pbx_fliege.Height * 0.8);
                    pbx_fliege.Width = (int)Math.Round(pbx_fliege.Width * 0.8);
                    break;
                default:
                    break;
            }
            
        }
    }
}
