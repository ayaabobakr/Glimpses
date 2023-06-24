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
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Glimpses_Clinic.Forms
{
    public partial class EyeReport : Form
    {
        int counter = File.Exists("counter.txt") ? int.Parse(File.ReadAllText("counter.txt")) : 0;
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        //string conStr = "Data Source=LAPTOP-5DS7586S;Initial Catalog=EyeClinic;Integrated Security=True;";

        public EyeReport()
        {
            InitializeComponent();
            
        }


        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control labels in this.Controls)
            {
                if (labels.GetType() == typeof(Label))
                {
                    Label l = (Label)labels;
                    l.ForeColor = ThemeColor.PrimaryColor;
                }
                label1.ForeColor = ThemeColor.SecondaryColor;
                label28.ForeColor = ThemeColor.SecondaryColor;
                label31.ForeColor = ThemeColor.SecondaryColor;
                label32.ForeColor = ThemeColor.SecondaryColor;
                label8.ForeColor = ThemeColor.SecondaryColor;
                label22.ForeColor = ThemeColor.SecondaryColor;
                muscabnormal.ForeColor = ThemeColor.PrimaryColor;
                muscnormal.ForeColor = ThemeColor.PrimaryColor;
                label23.ForeColor = ThemeColor.SecondaryColor;
            }

            foreach (Control radios in this.Controls)
            {
                if (radios.GetType() == typeof(RadioButton))
                {
                    RadioButton r = (RadioButton)radios;
                    r.ForeColor = ThemeColor.PrimaryColor;
                }
            }

            foreach (Control checks in this.Controls)
            {
                if (checks.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)checks;
                    c.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }

        private void EyeReport_Load(object sender, EventArgs e)
        {
            softRtext.Visible = false;
            softLtext.Visible = false;
            soft.Visible = false;
            toric.Visible = false;
            abnormaltext.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            LoadTheme();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string strCmd = "select NationalID from Patient t1 where not exists(select 1 from EyeReport t2 where t2.NationalID = t1.NationalID)";
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

        private void button1_Click(object sender, EventArgs e)
        {
            NID = nIDcbox.SelectedValue.ToString();
            VisualTest vform = new VisualTest();
            vform.Show();
        }

        public static string NID;
        ErrorProvider errorProvider = new ErrorProvider();
        private void registerbtn_Click(object sender, EventArgs e)
        {
            Utilities.error(this, errorProvider);
            if (nIDcbox.SelectedItem == null)
            {
                nIDcbox.Focus();
                errorProvider.SetError(nIDcbox, "Must Select!");
                return;
            }

            if ((Without_Distance_L.Text == string.Empty)|| (Without_Distance_R.Text == string.Empty)||
                (Without_Near_L.Text == string.Empty)|| (Without_Near_R.Text == string.Empty)||
                (With_Distance_L.Text == string.Empty)|| (With_Distance_R.Text == string.Empty)||
                (With_Near_L.Text == string.Empty)|| (With_Near_R.Text == string.Empty))
            {
                label1.Focus();
                errorProvider.SetError(label1, "Please complete the empty fields");
                return;
            }


            if (diagnosistext.Text == string.Empty)
            {
                diagnosistext.Focus();
                errorProvider.SetError(diagnosistext, "Can't be empty");
                return;
            }

            if (!muscnormal.Checked && !muscabnormal.Checked)
            {
                errorProvider.SetError(panel1, "Must Select!");
                return;
            }

            if (muscabnormal.Checked)
            {
                if (abnormaltext.Text == string.Empty)
                {
                    abnormaltext.Focus();
                    errorProvider.SetError(abnormaltext, "Can't be empty");
                    return;
                }
            }

            if ((intraL.Text == string.Empty) || (intraR.Text == string.Empty))
            {
                label23.Focus();
                errorProvider.SetError(label23, "Please complete the empty fields");
                return;
            }

            if (contbox.Checked)
            {
                if (!soft.Checked && !toric.Checked)
                {
                    errorProvider.SetError(contbox, "Must Select!");
                    return;
                }

                if (soft.Checked)
                {
                    if ((softLtext.Text == string.Empty)|| (softRtext.Text == string.Empty))
                    {
                        contbox.Focus();
                        errorProvider.SetError(contbox, "Please complete the empty fields");
                        return;
                    }
                }
            }


            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
                {
                    string insert = "INSERT INTO EyeReport (ReportID,NationalID, Diagnosis, Muscle, IntraocularR, IntraocularL, Glasses, Contacts, SoftR, SoftL, Toric, " +
                        "Prescription, Surgery, Followup, Without_Near_R, Without_Near_L, Without_Distance_R, Without_Distance_L, With_Near_R, With_Near_L, With_Distance_R, With_Distance_L) values (@idd,@ID, @diagnosis, @muscle, @intrR, " +
                        "@intrL, @glasses, @contacts, @softr, @softl, @toric, @presc, @surgery, @followup, @Without_Near_R, @Without_Near_L, @Without_Distance_R, @Without_Distance_L, " +
                       "@With_Near_R, @With_Near_L, @With_Distance_R, @With_Distance_L)";
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(insert, sqlcon);
                    cmd.Parameters.Add("@idd", SqlDbType.Int);
                    cmd.Parameters["@idd"].Value = counter;
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                    cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@diagnosis", SqlDbType.VarChar);
                    cmd.Parameters["@diagnosis"].Value = diagnosistext.Text;

                    if (muscabnormal.Checked)
                    {
                        cmd.Parameters.Add("@muscle", SqlDbType.VarChar);
                        cmd.Parameters["@muscle"].Value = abnormaltext.Text;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@muscle", DBNull.Value);
                    }

                    cmd.Parameters.Add("@intrR", SqlDbType.Float);
                    cmd.Parameters["@intrR"].Value = intraR.Text;
                    cmd.Parameters.Add("@intrL", SqlDbType.Float);
                    cmd.Parameters["@intrL"].Value = intraL.Text;



                    if (glassescb.Checked)
                    {
                        cmd.Parameters.Add("@glasses", SqlDbType.Bit);
                        cmd.Parameters["@glasses"].Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@glasses", SqlDbType.Bit);
                        cmd.Parameters["@glasses"].Value = 0;
                    }


                
                    if (contbox.Checked)
                    {
                        cmd.Parameters.Add("@contacts", SqlDbType.Bit);
                        cmd.Parameters["@contacts"].Value = 1;
                        if (soft.Checked)
                        {
                            cmd.Parameters.Add("@softr", SqlDbType.Float);
                            cmd.Parameters["@softr"].Value = softRtext.Text;
                            cmd.Parameters.Add("@softl", SqlDbType.Float);
                            cmd.Parameters["@softl"].Value = softLtext.Text;
                            cmd.Parameters.Add("@toric", SqlDbType.Bit);
                            cmd.Parameters["@toric"].Value = 0;
                        }
                        else
                        {
                            cmd.Parameters.Add("@toric", SqlDbType.Bit);
                            cmd.Parameters["@toric"].Value = 1;
                            cmd.Parameters.AddWithValue("@softr", DBNull.Value);
                            cmd.Parameters.AddWithValue("@softl", DBNull.Value);
                        }

                    }
                    else
                    {
                        cmd.Parameters.Add("@contacts", SqlDbType.Bit);
                        cmd.Parameters["@contacts"].Value = 0;
                        cmd.Parameters.AddWithValue("@softr", DBNull.Value);
                        cmd.Parameters.AddWithValue("@softl", DBNull.Value); 
                        cmd.Parameters.Add("@toric", SqlDbType.Bit);
                        cmd.Parameters["@toric"].Value = 0;
                    }


                    if (prescb.Checked)
                    {
                        cmd.Parameters.Add("@presc", SqlDbType.Bit);
                        cmd.Parameters["@presc"].Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@presc", SqlDbType.Bit);
                        cmd.Parameters["@presc"].Value = 0;
                    }


                    if (surgerycb.Checked)
                    {
                        cmd.Parameters.Add("@surgery", SqlDbType.Bit);
                        cmd.Parameters["@surgery"].Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@surgery", SqlDbType.Bit);
                        cmd.Parameters["@surgery"].Value = 0;
                    }


                    if (fupcb.Checked)
                    {
                        cmd.Parameters.Add("@followup", SqlDbType.Bit);
                        cmd.Parameters["@followup"].Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@followup", SqlDbType.Bit);
                        cmd.Parameters["@followup"].Value = 0;
                    }

                    cmd.Parameters.Add("@With_Distance_L", SqlDbType.Float);
                    cmd.Parameters["@With_Distance_L"].Value = With_Distance_L.Text;

                    cmd.Parameters.Add("@With_Distance_R", SqlDbType.Float);
                    cmd.Parameters["@With_Distance_R"].Value = With_Distance_R.Text;

                    cmd.Parameters.Add("@With_Near_L", SqlDbType.Float);
                    cmd.Parameters["@With_Near_L"].Value = With_Near_L.Text;

                    cmd.Parameters.Add("@With_Near_R", SqlDbType.Float);
                    cmd.Parameters["@With_Near_R"].Value = With_Near_R.Text;

                    cmd.Parameters.Add("@Without_Distance_L", SqlDbType.Float);
                    cmd.Parameters["@Without_Distance_L"].Value = Without_Distance_L.Text;

                    cmd.Parameters.Add("@Without_Distance_R", SqlDbType.Float);
                    cmd.Parameters["@Without_Distance_R"].Value = Without_Distance_R.Text;

                    cmd.Parameters.Add("@Without_Near_L", SqlDbType.Float);
                    cmd.Parameters["@Without_Near_L"].Value = Without_Near_L.Text;

                    cmd.Parameters.Add("@Without_Near_R", SqlDbType.Float);
                    cmd.Parameters["@Without_Near_R"].Value = Without_Near_R.Text;

                
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();


            }
            MessageBox.Show("Saved!");
            Utilities.ClearAllControls(this);
        }

        private void prescb_CheckedChanged(object sender, EventArgs e)
        {
            if (prescb.Checked)
            {
                NID = nIDcbox.SelectedValue.ToString();
                Prescription pr = new Prescription();
                pr.Show();

            }
        }

        private void muscabnormal_CheckedChanged(object sender, EventArgs e)
        {
            if (muscabnormal.Checked)
                abnormaltext.Visible = true;
        }

        private void muscnormal_CheckedChanged(object sender, EventArgs e)
        {
            abnormaltext.Visible = false;
        }

        private void contbox_CheckedChanged(object sender, EventArgs e)
        {
            soft.Visible = true;
            toric.Visible = true;
            if (!contbox.Checked)
            {
                soft.Visible = false;
                toric.Visible = false;
                softRtext.Visible = false;
                softLtext.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
            }

        }

        private void soft_CheckedChanged(object sender, EventArgs e)
        {
            softRtext.Visible = true;
            softLtext.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
        }

        private void toric_CheckedChanged(object sender, EventArgs e)
        {
            softRtext.Visible = false;
            softLtext.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
        }

        private void nIDcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nIDcbox.SelectedItem != null)
            {
                Prob p = new Prob();
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string strCmd = "select name from Patient where nationalid=@id;";
                SqlCommand cmd = new SqlCommand(strCmd, con);
                cmd.Parameters.AddWithValue("@id", nIDcbox.SelectedValue.ToString());
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    patname.Text = p.prob(nIDcbox.SelectedValue.ToString());
                   // patname.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void glassescb_CheckedChanged(object sender, EventArgs e)
        {
            if (glassescb.Checked)
            {
                NID = nIDcbox.SelectedValue.ToString();
                Glasses g = new Glasses();
                g.Show();

            }
        }
    }


}

