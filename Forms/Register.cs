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

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void LoadTheme()
        {
            registerbtn.BackColor = ThemeColor.PrimaryColor;
            registerbtn.ForeColor = Color.White;
            registerbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            MRbtn.BackColor = ThemeColor.PrimaryColor;
            MRbtn.ForeColor = Color.White;
            MRbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            foreach (Control labels in this.Controls)
            {
                if (labels.GetType() == typeof(Label))
                {
                    Label l = (Label)labels;
                    l.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Patient (NationalID, Name, Address, Phone, Email, DateOfBirth, Gender) values (@ID, @name," +
                    "@address, @phone, @email, @dob, @gender)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = idtext.Text;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = nametext.Text;

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = addresstext.Text;

                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = photext.Text;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = emailtext.Text;

                cmd.Parameters.Add("@dob", SqlDbType.Date);
                cmd.Parameters["@dob"].Value = DOB.Text;

                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = gendercombo.Text;
                cmd.ExecuteNonQuery();



            }
            MessageBox.Show("Patient Registered!");
        }

        private void MRbtn_Click(object sender, EventArgs e)
        {
            MedicalRecord mr = new MedicalRecord();
            mr.Show();
        }
    }
}
