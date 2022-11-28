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
    public partial class AboutUs : Form
    {
        public AboutUs()
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
                label3.ForeColor = ThemeColor.SecondaryColor;
                label5.ForeColor = ThemeColor.SecondaryColor;
                label1.ForeColor = ThemeColor.PrimaryColor;
                label10.ForeColor = ThemeColor.PrimaryColor;
                label11.ForeColor = ThemeColor.PrimaryColor;
                label2.ForeColor = ThemeColor.PrimaryColor;
                label4.ForeColor = ThemeColor.PrimaryColor;
                label6.ForeColor = ThemeColor.PrimaryColor;
                label7.ForeColor = ThemeColor.PrimaryColor;
                label8.ForeColor = ThemeColor.PrimaryColor;
                label9.ForeColor = ThemeColor.PrimaryColor;
                pictureBox2.BackColor = ThemeColor.PrimaryColor;
            }
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
