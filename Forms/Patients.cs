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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            label1.ForeColor = ThemeColor.SecondaryColor;
            button1.BackColor = ThemeColor.PrimaryColor;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            button2.BackColor = ThemeColor.PrimaryColor;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ViewPrescription p = new ViewPrescription();
            p.Show();
        }
    }
}
