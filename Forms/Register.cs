﻿using System;
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

        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
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


        ErrorProvider errorProvider = new ErrorProvider();
        private void registerbtn_Click(object sender, EventArgs e)
        {

            Utilities.error(this, errorProvider);
            if (nametext.Text == string.Empty)
            {
                nametext.Focus();
                errorProvider.SetError(nametext, "Can't be empty");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nametext.Text, "^[A-Za-z ]+$"))
            {
                nametext.Focus();
                errorProvider.SetError(nametext, "Invalid Name");
                return;
            }

            if (idtext.Text == string.Empty)
            {
                idtext.Focus();
                errorProvider.SetError(idtext, "Can't be empty");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(idtext.Text, "(2|3)[0-9][1-9][0-1][1-9][0-3][1-9](01|02|03|04|11|12|13|14|15|16|17|18|19|21|22|23|24|25|26|27|28|29|31|32|33|34|35|88)"))
            {
                idtext.Focus();
                errorProvider.SetError(idtext, "Invalid NationalID");
                return;
            }

            if (emailtext.Text == string.Empty)
            {
                emailtext.Focus();
                errorProvider.SetError(emailtext, "Can't be empty");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(emailtext.Text, "^([a-zA-Z0-9_-]+)@(([a-zA-Z]+.)+)(com)$"))
            {
                emailtext.Focus();
                errorProvider.SetError(emailtext, "Invalid E-mail");
                return;
            }

            if (gendercombo.SelectedItem==null)
            {
                gendercombo.Focus();
                errorProvider.SetError(gendercombo, "Must Select");
                return;
            }

            if (addresstext.Text== string.Empty)
            {
                addresstext.Focus();
                errorProvider.SetError(addresstext, "Can't be empty");
                return;
            }

            if (photext.Text == string.Empty)
            {
                photext.Focus();
                errorProvider.SetError(photext, "Can't be empty");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(photext.Text, "^(01)[0-2][0-9]{8}"))
            {
                photext.Focus();
                errorProvider.SetError(photext, "Invalid phone number");
                return;
            }

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Patient (NationalID, Name, Address, Phone, Email, DateOfBirth, Gender) values (@ID, @name," +
                    "@address, @phone, @email, @dob, @gender)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
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
                cmd.Parameters["@dob"].Value = DOB.Value.ToString("yyyy-MM-dd");

                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = gendercombo.Text;
                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            MessageBox.Show("Patient Registered!");
            Utilities.ClearAllControls(this);
        }

        private void MRbtn_Click(object sender, EventArgs e)
        {
            MedicalRecord mr = new MedicalRecord();
            mr.Show();
        }
    }
}
