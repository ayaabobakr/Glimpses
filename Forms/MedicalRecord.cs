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
    public partial class MedicalRecord : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            submitbtn.BackColor = ThemeColor.PrimaryColor;
            submitbtn.ForeColor = Color.White;
            submitbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label18.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            surgyes.ForeColor = ThemeColor.PrimaryColor;
            surgno.ForeColor = ThemeColor.PrimaryColor;
            glassesno.ForeColor = ThemeColor.PrimaryColor;
            glassesyes.ForeColor = ThemeColor.PrimaryColor;
            contactsno.ForeColor = ThemeColor.PrimaryColor;
            contactsyes.ForeColor = ThemeColor.PrimaryColor;
            label20.ForeColor = ThemeColor.SecondaryColor;
            label23.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;

            foreach (Control checks in this.Controls)
            {
                if (checks.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)checks;
                    c.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }
        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            LoadTheme();
            surgerytext.Visible = false;
            label18.Visible = false;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string strCmd = "select NationalID from Patient t1 where not exists(select 1 from MR t2 where t2.NationalID = t1.NationalID) ";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            nIDcbox.DataSource = ds.Tables[0];
            nIDcbox.ValueMember = "NationalID";
            nIDcbox.Enabled = true;
            this.nIDcbox.SelectedIndex = -1;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        ErrorProvider errorProvider = new ErrorProvider();
        private void submitbtn_Click(object sender, EventArgs e)
        {
            Utilities.error(this, errorProvider);
            if (nIDcbox.SelectedItem == null)
            {
                nIDcbox.Focus();
                errorProvider.SetError(nIDcbox, "Must Select!");
                return;
            }
            if (psymptext.Text == string.Empty)
            {
                psymptext.Focus();
                errorProvider.SetError(psymptext, "Can't be empty");
                return;
            }
            if (sympcbox.SelectedItem == null)
            {
                errorProvider.SetError(sympcbox, "Must Select!");
                return;
            }
            
            if (!surgno.Checked && !surgyes.Checked)
            {
                errorProvider.SetError(panel3, "Must Select!");
                return;
            }

            if (surgyes.Checked)
            {
                if (surgerytext.Text == string.Empty)
                {
                    surgerytext.Focus();
                    errorProvider.SetError(surgerytext, "Can't be empty");
                    return;
                }
            }
            if (!glassesno.Checked && !glassesyes.Checked)
            {
                errorProvider.SetError(panel2, "Must Select!");
                return;
            }
            if (!contactsno.Checked && !contactsyes.Checked)
            {
                errorProvider.SetError(panel1, "Must Select!");
                return;
            }

            if (screentext.Text == string.Empty)
            {
                screentext.Focus();
                errorProvider.SetError(screentext, "Can't be empty");
                return;
            }

            int text = int.Parse(screentext.Text);
            if (text < 0 || text > 24)
            {
                screentext.Focus();
                errorProvider.SetError(screentext, "Invalid number of hours");
                return;
            }

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO MR values (@ID, @Eye_History, @Family_History, @Allergies, " +
                    "@Pat_Symptoms, @Symptoms, @Surgery, @Surgery_list, @Glasses, @Contacts, @Screentime, @Sinus, @Diabetes, " +
                    "@Pressure, @Redness, @Tearing, @Eyepain, @Burning, @Discharge, @Soreness, @Itching, @Dryness, @Flashes)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Eye_History", SqlDbType.VarChar);
                cmd.Parameters["@Eye_History"].Value = eye_histtext.Text;

                cmd.Parameters.Add("@Family_History", SqlDbType.VarChar);
                cmd.Parameters["@Family_History"].Value = famhistorytext.Text;

                cmd.Parameters.Add("@Allergies", SqlDbType.VarChar);
                cmd.Parameters["@Allergies"].Value = allergies.Text;

                cmd.Parameters.Add("@Pat_Symptoms", SqlDbType.VarChar);
                cmd.Parameters["@Pat_Symptoms"].Value = psymptext.Text;

                cmd.Parameters.Add("@Symptoms", SqlDbType.VarChar);
                cmd.Parameters["@Symptoms"].Value = sympcbox.SelectedItem;

                cmd.Parameters.Add("@Screentime", SqlDbType.Int);
                cmd.Parameters["@Screentime"].Value = screentext.Text;

                if (surgyes.Checked)
                {
                    cmd.Parameters.Add("@Surgery", SqlDbType.Bit);
                    cmd.Parameters["@Surgery"].Value = 1;
                    cmd.Parameters.Add("@Surgery_list", SqlDbType.VarChar);
                    cmd.Parameters["@Surgery_list"].Value = surgerytext.Text;
                }
                else
                {
                    cmd.Parameters.Add("@Surgery", SqlDbType.Bit);
                    cmd.Parameters["@Surgery"].Value = 0;
                    cmd.Parameters.AddWithValue("@Surgery_list", DBNull.Value);
                }

                if (glassesyes.Checked)
                {
                    cmd.Parameters.Add("@Glasses", SqlDbType.Bit);
                    cmd.Parameters["@Glasses"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Glasses", SqlDbType.Bit);
                    cmd.Parameters["@Glasses"].Value = 0;
                }
                if (contactsyes.Checked)
                {
                    cmd.Parameters.Add("@Contacts", SqlDbType.Bit);
                    cmd.Parameters["@Contacts"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Contacts", SqlDbType.Bit);
                    cmd.Parameters["@Contacts"].Value = 0;
                }

                if (sinus.Checked)
                {
                    cmd.Parameters.Add("@Sinus", SqlDbType.Bit);
                    cmd.Parameters["@Sinus"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Sinus", SqlDbType.Bit);
                    cmd.Parameters["@Sinus"].Value = 0;
                }

                if (diabetes.Checked)
                {
                    cmd.Parameters.Add("@Diabetes", SqlDbType.Bit);
                    cmd.Parameters["@Diabetes"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Diabetes", SqlDbType.Bit);
                    cmd.Parameters["@Diabetes"].Value = 0;
                }

                if (pressure.Checked)
                {
                    cmd.Parameters.Add("@Pressure", SqlDbType.Bit);
                    cmd.Parameters["@Pressure"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Pressure", SqlDbType.Bit);
                    cmd.Parameters["@Pressure"].Value = 0;
                }

                if (redness.Checked)
                {
                    cmd.Parameters.Add("@Redness", SqlDbType.Bit);
                    cmd.Parameters["@Redness"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Redness", SqlDbType.Bit);
                    cmd.Parameters["@Redness"].Value = 0;
                }

                if (watering.Checked)
                {
                    cmd.Parameters.Add("@Tearing", SqlDbType.Bit);
                    cmd.Parameters["@Tearing"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Tearing", SqlDbType.Bit);
                    cmd.Parameters["@Tearing"].Value = 0;
                }

                if (pain.Checked)
                {
                    cmd.Parameters.Add("@Eyepain", SqlDbType.Bit);
                    cmd.Parameters["@Eyepain"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Eyepain", SqlDbType.Bit);
                    cmd.Parameters["@Eyepain"].Value = 0;
                }

                if (burning.Checked)
                {
                    cmd.Parameters.Add("@Burning", SqlDbType.Bit);
                    cmd.Parameters["@Burning"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Burning", SqlDbType.Bit);
                    cmd.Parameters["@Burning"].Value = 0;
                }

                if (discharge.Checked)
                {
                    cmd.Parameters.Add("@Discharge", SqlDbType.Bit);
                    cmd.Parameters["@Discharge"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Discharge", SqlDbType.Bit);
                    cmd.Parameters["@Discharge"].Value = 0;
                }

                if (soreness.Checked)
                {
                    cmd.Parameters.Add("@Soreness", SqlDbType.Bit);
                    cmd.Parameters["@Soreness"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Soreness", SqlDbType.Bit);
                    cmd.Parameters["@Soreness"].Value = 0;
                }

                if (itching.Checked)
                {
                    cmd.Parameters.Add("@Itching", SqlDbType.Bit);
                    cmd.Parameters["@Itching"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Itching", SqlDbType.Bit);
                    cmd.Parameters["@Itching"].Value = 0;
                }

                if (dryness.Checked)
                {
                    cmd.Parameters.Add("@Dryness", SqlDbType.Bit);
                    cmd.Parameters["@Dryness"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Dryness", SqlDbType.Bit);
                    cmd.Parameters["@Dryness"].Value = 0;
                }

                if (floaters.Checked)
                {
                    cmd.Parameters.Add("@Flashes", SqlDbType.Bit);
                    cmd.Parameters["@Flashes"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Flashes", SqlDbType.Bit);
                    cmd.Parameters["@Flashes"].Value = 0;
                }

                cmd.ExecuteNonQuery();
                sqlcon.Close();



            }
            MessageBox.Show("Saved!");
            this.Close();
        }


        private void surgyes_CheckedChanged_1(object sender, EventArgs e)
        {
            surgerytext.Visible = true;
            label18.Visible = true;
        }

        private void surgno_CheckedChanged_1(object sender, EventArgs e)
        {
            surgerytext.Visible = false;
            label18.Visible = false;
        }

        private void nIDcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nIDcbox.SelectedItem != null)
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string strCmd = "select name from Patient where nationalid=@id;";
                SqlCommand cmd = new SqlCommand(strCmd, con);
                cmd.Parameters.AddWithValue("@id", nIDcbox.SelectedValue.ToString());
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    patname.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
        }
    }
}

        