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
    public partial class Receptionist : Form
    {
        //Fields
        private Button current;
        private Random random;
        private int tempindex;
        private Form activateForm;

        public Receptionist()
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
                    current.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void OpenChildPanel(Form childForm, object btnSender)
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
            OpenChildPanel(new Forms.RecAppointments(), sender);
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.Register(), sender);
        }

    }
}
