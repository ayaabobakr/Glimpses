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
    public partial class VisualTest : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        public VisualTest()
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
                submitbtn.BackColor = ThemeColor.PrimaryColor;
                submitbtn.ForeColor = Color.White;
                submitbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }

        private void Order_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO VFT (NationalID, SPH_R_dist, SPH_R_near, CYL_R_dist, CYL_R_near, AXIS_R_dist, AXIS_R_near, SPH_L_dist, SPH_L_near,CYL_L_dist,CYL_L_near,AXIS_L_dist,AXIS_L_near," +
                    "IPD_dist,IPD_near) values (@nationalID, @SPH_R_dist, @SPH_R_near, @CYL_R_dist, @CYL_R_near, @AXIS_R_dist, @AXIS_R_near, @SPH_L_dist, @SPH_L_near,@CYL_L_dist,@CYL_L_near,@AXIS_L_dist,@AXIS_L_near," +
                    "@IPD_dist,@IPD_near)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                EyeReport er = new EyeReport();
                int fid = 0;
                fid = int.Parse(nIDcbox.SelectedValue.ToString());

                cmd.Parameters.Add("@nationalID", SqlDbType.Int);
                cmd.Parameters["@nationalID"].Value = fid;

                cmd.Parameters.Add("@SPH_R_dist", SqlDbType.Float);
                cmd.Parameters["@SPH_R_dist"].Value = SPH_R_dist.Text;

                cmd.Parameters.Add("@SPH_R_near", SqlDbType.Float);
                cmd.Parameters["@SPH_R_near"].Value = SPH_R_near.Text;

                cmd.Parameters.Add("@CYL_R_dist", SqlDbType.Float);
                cmd.Parameters["@CYL_R_dist"].Value = CYL_R_dist.Text;

                cmd.Parameters.Add("@CYL_R_near", SqlDbType.Float);
                cmd.Parameters["@CYL_R_near"].Value = CYL_R_near.Text;

                cmd.Parameters.Add("@AXIS_R_dist", SqlDbType.Float);
                cmd.Parameters["@AXIS_R_dist"].Value = AXIS_R_dist.Text;

                cmd.Parameters.Add("@AXIS_R_near", SqlDbType.Float);
                cmd.Parameters["@AXIS_R_near"].Value = AXIS_R_near.Text;

                cmd.Parameters.Add("@SPH_L_dist", SqlDbType.Float);
                cmd.Parameters["@SPH_L_dist"].Value = SPH_L_dist.Text;

                cmd.Parameters.Add("@SPH_L_near", SqlDbType.Float);
                cmd.Parameters["@SPH_L_near"].Value = SPH_L_near.Text;

                cmd.Parameters.Add("@CYL_L_dist", SqlDbType.Float);
                cmd.Parameters["@CYL_L_dist"].Value = CYL_L_dist.Text;

                cmd.Parameters.Add("@CYL_L_near", SqlDbType.Float);
                cmd.Parameters["@CYL_L_near"].Value = CYL_L_near.Text;

                cmd.Parameters.Add("@AXIS_L_dist", SqlDbType.Float);
                cmd.Parameters["@AXIS_L_dist"].Value = AXIS_L_dist.Text;

                cmd.Parameters.Add("@AXIS_L_near", SqlDbType.Float);
                cmd.Parameters["@AXIS_L_near"].Value = AXIS_L_near.Text;

                cmd.Parameters.Add("@IPD_dist", SqlDbType.Float);
                cmd.Parameters["@IPD_dist"].Value = IPD_dist.Text;

                cmd.Parameters.Add("@IPD_near", SqlDbType.Float);
                cmd.Parameters["@IPD_near"].Value = IPD_near.Text;
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("Test Saved!");
            this.Close();
        }
    }
}
