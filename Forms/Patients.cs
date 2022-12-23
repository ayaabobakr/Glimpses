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
    public partial class Patients : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

        public Patients()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            label1.ForeColor = ThemeColor.SecondaryColor;
            searchbtn.BackColor = ThemeColor.PrimaryColor;
            searchbtn.ForeColor = Color.White;
            searchbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            viewMRbtn.BackColor = ThemeColor.PrimaryColor;
            viewMRbtn.ForeColor = Color.White;
            viewMRbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            deletebtn.BackColor = ThemeColor.PrimaryColor;
            deletebtn.ForeColor = Color.White;
            deletebtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            LoadTheme();
            listView1.ForeColor = ThemeColor.SecondaryColor;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "Select * From Patient";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                int now = int.Parse(DateTime.Now.ToString("yyyy"));
                int dob = int.Parse(rd.GetDateTime(5).ToString("yyyy"));
                int age = (now - dob);
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetInt32(3).ToString());
                lv.SubItems.Add(rd.GetString(4).ToString());
                lv.SubItems.Add(rd.GetDateTime(5).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(age.ToString());
                lv.SubItems.Add(rd.GetString(6).ToString());
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void viewMRbtn_Click(object sender, EventArgs e)
        {
            ViewMR p = new ViewMR();
            p.Show();
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var cashierId = listView1.FocusedItem.Text;

            string query = "delete from Patient where NationalID=@id;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {

                        using (SqlCommand com = new SqlCommand(query, con, trans))
                        {

                            com.Parameters.AddWithValue("@id", cashierId);

                            var should_be_one = com.ExecuteNonQuery();

                            if (should_be_one == 1)
                            {

                                trans.Commit();
                                foreach (ListViewItem item in listView1.Items)
                                    if (item.Selected)
                                        listView1.Items.Remove(item);
                            }
                            else
                            {

                                trans.Rollback();

                                throw new Exception("An attempt to delete multiple rows was detected");
                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }

        }
    }
}
