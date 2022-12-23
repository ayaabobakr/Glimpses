using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic.Forms
{
    public partial class AddAppointments : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        public AddAppointments()
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
        }

        private void AddAppointments_Load(object sender, EventArgs e)
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

            button1.Visible = false;
            button130.Visible = false;
            button12.Visible = false;
            button1230.Visible = false;
            button2.Visible = false;
            button230.Visible = false;
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button130.Visible = true;
            button12.Visible = true;
            button1230.Visible = true;
            button2.Visible = true;
            button230.Visible = true;
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                foreach (Control btns in this.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
                        String t = btn.Text.ToString();
                        MessageBox.Show(t, "Try Again");
                        var date = DateTime.ParseExact(t, "HH:mm:ss", CultureInfo.CurrentCulture);
                        string time = "SELECT Time from Appointment where Time = "+ date + "'";
                        sqlcon.Open();
                        SqlCommand cmdt = new SqlCommand(time, sqlcon);
                        object idfind = cmdt.ExecuteScalar();
                        if (idfind == null)
                        {
                            MessageBox.Show("Invalid user credentials!", "Try Again");
                        }
                        else
                        {
                            btn.Enabled = false;
                        }
                        sqlcon.Close();
                    }
                }
                
            }

















            //using (SqlConnection sqlcon = new SqlConnection(conStr))
            //{
            //    string date = "Select Date from Appointment where Date = " + monthCalendar1.SelectionRange.Start.ToShortDateString() + "'"; ;
            //    //string time = "SELECT Time from Appointment where Time = @time";
            //    sqlcon.Open();
            //    SqlCommand cmdd = new SqlCommand(date, sqlcon);
            //    //SqlCommand cmdt = new SqlCommand(time, sqlcon);
            //    //cmdt.Parameters.Add("@time", "123");
            //    //SqlDataReader red = cmdt.ExecuteReader();
            //    object idfind = cmdd.ExecuteScalar();
            //    if (idfind == null)
            //    {
            //        string data = "Insert into Appointment values(@ID, @date, @time, @bill)";
            //        SqlCommand cmddata = new SqlCommand(data, sqlcon);
            //        int fid = 0;
            //        fid = int.Parse(nIDcbox.SelectedValue.ToString());

            //        cmddata.Parameters.Add("@ID", SqlDbType.Int);
            //        cmddata.Parameters["@ID"].Value = fid;
            //        cmddata.Parameters.Add("@date", SqlDbType.Date);
            //        cmddata.Parameters["@date"].Value = monthCalendar1.SelectionRange.Start.ToShortDateString();
            //        cmddata.Parameters.Add("@time", SqlDbType.Time);
            //        cmddata.Parameters["@time"].Value = button1;
            //    }
            //    else
            //    {
            //        if (!string.IsNullOrEmpty(Convert.ToString(idfind)))
            //        {
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid user credentials!", "Try Again");
            //        }
            //    }

            //    sqlcon.Close();

            //}
        }
    }
}
