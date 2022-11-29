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
    public partial class EyeReport : Form
    {
        public EyeReport()
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
            foreach (Control labels in this.Controls)
            {
                if (labels.GetType() == typeof(Label))
                {
                    Label l = (Label)labels;
                    l.ForeColor = ThemeColor.PrimaryColor;
                }
                label1.ForeColor = ThemeColor.SecondaryColor;
                label28.ForeColor = ThemeColor.SecondaryColor;
                label31.ForeColor = ThemeColor.SecondaryColor;
                label32.ForeColor = ThemeColor.SecondaryColor;
            }

            foreach (Control radios in this.Controls)
            {
                if (radios.GetType() == typeof(RadioButton))
                {
                    RadioButton r = (RadioButton)radios;
                    r.ForeColor = ThemeColor.PrimaryColor;
                }
            }

            foreach (Control checks in this.Controls)
            {
                if (checks.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)checks;
                    c.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }

        private void EyeReport_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
