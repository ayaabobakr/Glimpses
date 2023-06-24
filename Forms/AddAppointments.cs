using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic.Forms
{

    public partial class AddAppointments : Form
    {
        int counter = File.Exists("counter.txt") ? int.Parse(File.ReadAllText("counter.txt")) : 0;
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
            patname.ForeColor = ThemeColor.SecondaryColor;
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
        public static string theDate;
        private void button12_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button12.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        } 


        public void Date(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                foreach (Control btns in this.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
                        btn.Enabled = true;
                        string time = "SELECT Time, Date from Appointment where Time = '" + btn.Text + "' and Date = '" + theDate + "';";
                        SqlCommand cmdt = new SqlCommand(time, sqlcon);
                        SqlDataReader readert = cmdt.ExecuteReader();
                        if (readert.HasRows)
                        {
                            btn.Enabled = false;
                        }
                        readert.Close();
                        readert.Dispose();
                    }
                }sqlcon.Close();
            }
            


        }
        private void button1230_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button1230.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button1.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        }

        private void button130_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button130.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button2.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        }

        private void button230_Click(object sender, EventArgs e)
        {
            counter++;

            // Write the updated counter value back to the file
            File.WriteAllText("counter.txt", counter.ToString());
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "INSERT INTO Appointment values (@idd,@ID, @Date, @Time, @Bill)";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);
                cmd.Parameters.Add("@idd", SqlDbType.Int);
                cmd.Parameters["@idd"].Value = counter;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                cmd.Parameters["@ID"].Value = nIDcbox.SelectedValue.ToString();

                cmd.Parameters.Add("@Date", SqlDbType.VarChar);
                cmd.Parameters["@Date"].Value = theDate;


                cmd.Parameters.Add("@Time", SqlDbType.VarChar);
                cmd.Parameters["@Time"].Value = button230.Text;

                cmd.Parameters.Add("@Bill", SqlDbType.Float);
                cmd.Parameters["@Bill"].Value = 200;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Appointment Reserved!");
            this.Close();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button130.Visible = true;
            button12.Visible = true;
            button1230.Visible = true;
            button2.Visible = true;
            button230.Visible = true;

            button1.Enabled = true;
            button130.Enabled = true;
            button12.Enabled = true;
            button1230.Enabled = true;
            button2.Enabled = true;
            button230.Enabled = true;

            theDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string date = "SELECT Date from Appointment where Date = '" + theDate + "';";
                SqlCommand cmdd = new SqlCommand(date, sqlcon);
                SqlDataReader reader = cmdd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    reader.Dispose();
                    Date(sender, e);
                }
                reader.Close();
                reader.Dispose();
                sqlcon.Close();

            }
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
