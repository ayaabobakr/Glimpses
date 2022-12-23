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
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string strCmd = "select NationalID from Patient";
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

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Prescription (NationalID, Date, Prescription, Medicine, Per" +
                    ") values (@NationalID, @Date, @Prescription, @Medicine, @Per)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                EyeReport er = new EyeReport();
                int fid = 0;
                fid = int.Parse(nIDcbox.SelectedValue.ToString());

                cmd.Parameters.Add("@NationalID", SqlDbType.Int);
                cmd.Parameters["@NationalID"].Value = fid;

                cmd.Parameters.Add("@Date", SqlDbType.Date);
                cmd.Parameters["@Date"].Value = dateTimePicker1.Value;

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
        }
    }
}
