using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic
{
    public partial class Doctor : Form
    {
        //Fields
        private Button current;
        private Random random;
        private int tempindex;
        private Form activateForm;

        public Doctor()
        {
            InitializeComponent();
            random = new Random();
            closebtn.Visible = false;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (current != (Button)btnSender)
                {
                    DisableBtn();
                    Color color = SelectThemeColor();
                    current = (Button)btnSender;
                    current.BackColor = color;
                    current.ForeColor = Color.White;
                    current.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = color;
                    panel2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    closebtn.Visible = true;

                }
            }
        }

        private void DisableBtn()
        {
            foreach (Control previous in panel1.Controls)
            {
                if (previous.GetType() == typeof(Button))
                {
                    previous.BackColor = Color.FromArgb(37, 40, 65);
                    previous.ForeColor = Color.Gainsboro;
                    previous.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildPanel(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateBtn(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }


        private void Reset()
        {
            DisableBtn();
            label1.Text = "Doctor";
            panel3.BackColor = Color.FromArgb(48, 51, 74);
            panel2.BackColor = Color.FromArgb(33, 35, 58);
            current = null;
            closebtn.Visible = false;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            Reset();
        }

        private void appointbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenChildPanel(new Forms.Appointments(), sender);
        }

        private void medrecbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            OpenChildPanel(new Forms.ViewMR(), sender);
        }

        private void patbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenChildPanel(new Forms.Patients(), sender);
        }

        private void ordbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            OpenChildPanel(new Forms.VisualTest(), sender);
        }

        private void eyerepbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenChildPanel(new Forms.EyeReport(), sender);
        }

        private void receptionistsbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenChildPanel(new Forms.ViewRecept(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            OpenChildPanel(new Forms.OCR(), sender);
        }
    }
}

