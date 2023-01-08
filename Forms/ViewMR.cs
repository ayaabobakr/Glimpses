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
    public partial class ViewMR : Form
    {

        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

        public ViewMR()
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
        }

        private void ViewMR_Load(object sender, EventArgs e)
        {
            LoadTheme();
            surgerytext.Visible = false;

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            string sql = "Select [NationalID],[Eye_History],[Family_History],[Allergies],[Pat_Symptoms],[Surgery],[Surgery_list]," +
                "[Glasses],[Contacts],[Screentime],[Sinus],[Diabetes],[Pressure],[Redness],[Tearing],[Eyepain],[Burning]" +
                ",[Discharge],[Soreness],[Itching],[Dryness],[Flashes] From MR where NationalID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Patients.nID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                eye_histtext.Text = da.GetValue(1).ToString();
                famhistorytext.Text = da.GetValue(2).ToString();
                allergies.Text = da.GetValue(3).ToString();
                symptomstext.Text = da.GetValue(4).ToString();
                var list = new string[] {"Blurred or distorted vision","Eyestrain or discomfort","Headaches",
                    "Difficulty with night vision","Squinting"};
                if (list.Contains(da.GetValue(4).ToString()))
                {
                    diseasetext.Text = "Astigmatism";
                }
                else
                {
                    diseasetext.Text = "Coloboma";
                }

                if (da.GetBoolean(5) == true)
                {
                    surgyes.Checked = true;
                    surgerytext.Visible = true;
                    surgerytext.Text = da.GetValue(6).ToString();
                }
                else
                {
                    surgno.Checked = true;
                    surgerytext.Visible = false;
                }

                if (da.GetBoolean(7) == true)
                {
                    glassesyes.Checked = true;
                }
                else
                    glassesno.Checked = true;

                if (da.GetBoolean(8) == true)
                {
                    contactsyes.Checked = true;
                }
                else
                    contactsno.Checked = true;


                screentext.Text = da.GetInt32(9).ToString();


                if (da.GetBoolean(10) == true)
                {
                    sinus.Checked = true;
                }

                if (da.GetBoolean(11) == true)
                {
                    diabetes.Checked = true;
                }

                if (da.GetBoolean(12) == true)
                {
                    pressure.Checked = true;
                }

                if (da.GetBoolean(13) == true)
                {
                    redness.Checked = true;
                }

                if (da.GetBoolean(14) == true)
                {
                    watering.Checked = true;
                }

                if (da.GetBoolean(15) == true)
                {
                    pain.Checked = true;
                }

                if (da.GetBoolean(16) == true)
                {
                    burning.Checked = true;
                }

                if (da.GetBoolean(17) == true)
                {
                    discharge.Checked = true;
                }

                if (da.GetBoolean(18) == true)
                {
                    soreness.Checked = true;
                }

                if (da.GetBoolean(19) == true)
                {
                    itching.Checked = true;
                }

                if (da.GetBoolean(20) == true)
                {
                    dryness.Checked = true;
                }

                if (da.GetBoolean(21) == true)
                {
                    floaters.Checked = true;
                }

            }
            conn.Close();

        }

    }
    }

