using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using Patagames.Ocr;

namespace Glimpses_Clinic.Forms
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void OCR_Load(object sender, EventArgs e)
        {
            checkbtn.BackColor = ThemeColor.PrimaryColor;
            checkbtn.ForeColor = Color.White;
            checkbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(pictureBox1.ImageLocation);
                textBox1.Text = plainText;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Glimpses Clinic\Resources\Screenshot (1060).png";
        }
    }
}
