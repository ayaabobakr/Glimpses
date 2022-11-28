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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            cmbyear.Items.Clear();
            for (int i = DateTime.Now.Year; i >= 1930; i--)
            {
                cmbyear.Items.Add(i);
            }
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
            label10.ForeColor = ThemeColor.PrimaryColor;
            label11.ForeColor = ThemeColor.PrimaryColor;
            label12.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.SecondaryColor;
            label16.ForeColor = ThemeColor.SecondaryColor;
            label17.ForeColor = ThemeColor.SecondaryColor;
            label18.ForeColor = ThemeColor.SecondaryColor;
            label19.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label20.ForeColor = ThemeColor.SecondaryColor;
            label21.ForeColor = ThemeColor.SecondaryColor;
            radioButton1.ForeColor = ThemeColor.PrimaryColor;
            radioButton2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

    }
}
