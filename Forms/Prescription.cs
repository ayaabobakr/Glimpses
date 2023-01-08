using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic.Forms
{
    public partial class Prescription : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        public Prescription()
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
                Submitbtn.BackColor = ThemeColor.PrimaryColor;
                Submitbtn.ForeColor = Color.White;
                Submitbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }


        private void Prescribe_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }


        ErrorProvider errorProvider = new ErrorProvider();
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Utilities.error(this, errorProvider);

            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider.SetError(comboBox1, "Must Select!");
                return;
            }

            if (!dayrb.Checked && !weekrb.Checked)
            {
                label5.Focus();
                errorProvider.SetError(label5, "Must Select!");
                return;
            }

            if (textBox13.Text == string.Empty)
            {
                textBox13.Focus();
                errorProvider.SetError(textBox13, "Can't be empty");
                return;
            }

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Prescription (NationalID, Date, Prescription, Medicine, Per" +
                    ") values (@NationalID, @Date, @Prescription, @Medicine, @Per)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                EyeReport er = new EyeReport();

                cmd.Parameters.Add("@NationalID", SqlDbType.VarChar);
                cmd.Parameters["@NationalID"].Value = EyeReport.NID;

                DateTime thisDay = DateTime.Today;
                cmd.Parameters.Add("@Date", SqlDbType.Date);
                cmd.Parameters["@Date"].Value = thisDay.ToString();

                cmd.Parameters.Add("@Prescription", SqlDbType.VarChar);
                cmd.Parameters["@Prescription"].Value = textBox13.Text;

                cmd.Parameters.Add("@Medicine", SqlDbType.VarChar);
                cmd.Parameters["@Medicine"].Value = comboBox1.SelectedItem;

                if (weekrb.Checked)
                {
                    cmd.Parameters.Add("@Per", SqlDbType.VarChar);
                    cmd.Parameters["@Per"].Value = "Week";
                }
                else
                {
                    cmd.Parameters.Add("@Per", SqlDbType.VarChar);
                    cmd.Parameters["@Per"].Value = "Day";
                }
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Prescription Saved!");
            this.Close();
        }
    }
}
