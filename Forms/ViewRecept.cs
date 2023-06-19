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
    public partial class ViewRecept : Form
    {
        //string conStr = "Data Source=mssql-132348-0.cloudclusters.net,19983;Initial Catalog=Glimpses;User ID=admin;Password=#Sahar2023";
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        public ViewRecept()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            label1.ForeColor = ThemeColor.SecondaryColor;
            searchbtn.BackColor = ThemeColor.PrimaryColor;
            searchbtn.ForeColor = Color.White;
            searchbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            addrecepbtn.BackColor = ThemeColor.PrimaryColor;
            addrecepbtn.ForeColor = Color.White;
            addrecepbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }
        private void addrecepbtn_Click(object sender, EventArgs e)
        {

        }

        private void ViewRecept_Load(object sender, EventArgs e)
        {
            LoadTheme();
            listView1.ForeColor = ThemeColor.SecondaryColor;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "Select * From Receptionist";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                int now = int.Parse(DateTime.Now.ToString("yyyy"));
                int dob = int.Parse(rd.GetDateTime(7).ToString("yyyy"));
                int age = (now - dob);
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetInt32(4).ToString());
                lv.SubItems.Add(rd.GetString(5).ToString());
                lv.SubItems.Add(rd.GetString(6).ToString());
                lv.SubItems.Add(rd.GetDateTime(7).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(age.ToString());
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var cashierId = listView1.FocusedItem.Text;

            string query = "delete from Receptionist where ID=@id;";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            if (textBox1.Text != "")
            {
                listView1.Items.Clear();
                con.Open();
                string str = "Select* from Receptionist Where Name Like'%" + textBox1.Text + "%' or ID Like'%" + textBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
                    item.SubItems.Add(reader[6].ToString());
                    item.SubItems.Add(reader.GetDateTime(7).ToString("dd/MM/yyyy"));
                    int now = int.Parse(DateTime.Now.ToString("yyyy"));
                    int dob = int.Parse(reader.GetDateTime(7).ToString("yyyy"));
                    int age = (now - dob);
                    item.SubItems.Add(age.ToString());
                    listView1.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            else
            {
                listView1.ForeColor = ThemeColor.SecondaryColor;
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "Select * From Receptionist";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (rd.Read())
                {
                    int now = int.Parse(DateTime.Now.ToString("yyyy"));
                    int dob = int.Parse(rd.GetDateTime(7).ToString("yyyy"));
                    int age = (now - dob);
                    ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                    lv.SubItems.Add(rd.GetString(1).ToString());
                    lv.SubItems.Add(rd.GetInt32(4).ToString());
                    lv.SubItems.Add(rd.GetString(5).ToString());
                    lv.SubItems.Add(rd.GetString(6).ToString());
                    lv.SubItems.Add(rd.GetDateTime(7).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(age.ToString());
                    listView1.Items.Add(lv);
                }
                rd.Close();
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
