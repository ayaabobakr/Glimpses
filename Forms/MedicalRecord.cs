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
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            button1.BackColor = ThemeColor.PrimaryColor;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label10.ForeColor = ThemeColor.PrimaryColor;
            label11.ForeColor = ThemeColor.SecondaryColor;
            label12.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.PrimaryColor;
            label17.ForeColor = ThemeColor.PrimaryColor;
            label18.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label20.ForeColor = ThemeColor.SecondaryColor;
            label23.ForeColor = ThemeColor.SecondaryColor;

            foreach (Control checks in this.Controls)
            {
                if (checks.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)checks;
                    c.ForeColor = ThemeColor.PrimaryColor;
                }
            }

            foreach (Control radio in this.Controls)
            {
                if (radio.GetType() == typeof(RadioButton))
                {
                    RadioButton r = (RadioButton)radio;
                    r.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }
        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
