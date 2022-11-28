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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control labels in this.Controls)
            {
                if (labels.GetType() == typeof(Label))
                {
                    Label l = (Label)labels;
                    l.ForeColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control radios in this.Controls)
            {
                if (radios.GetType() == typeof(RadioButton))
                {
                    RadioButton r = (RadioButton)radios;
                    r.ForeColor = ThemeColor.PrimaryColor;
                }
                button2.BackColor = ThemeColor.PrimaryColor;
                button2.ForeColor = Color.White;
                button2.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
