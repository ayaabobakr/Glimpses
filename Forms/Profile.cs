using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic.Forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;
            label11.ForeColor = ThemeColor.SecondaryColor;
            label12.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.SecondaryColor;
            label16.ForeColor = ThemeColor.SecondaryColor;
            label17.ForeColor = ThemeColor.SecondaryColor;
            label18.ForeColor = ThemeColor.SecondaryColor;
            label20.ForeColor = ThemeColor.SecondaryColor;
            label27.ForeColor = ThemeColor.SecondaryColor;
            label23.ForeColor = ThemeColor.PrimaryColor;
            label28.ForeColor = ThemeColor.SecondaryColor;
            label26.ForeColor = ThemeColor.SecondaryColor;
            label27.ForeColor = ThemeColor.SecondaryColor;
            label28.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label9.ForeColor = ThemeColor.SecondaryColor;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
