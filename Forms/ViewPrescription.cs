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
    public partial class ViewPrescription : Form
    {
        public ViewPrescription()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            label1.ForeColor = ThemeColor.SecondaryColor;
            button1.BackColor = ThemeColor.PrimaryColor;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription();
            p.Show();
        }

        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
