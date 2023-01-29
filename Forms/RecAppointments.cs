using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glimpses_Clinic.Forms
{
    public partial class RecAppointments : Form
    {

        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ToString();
        public RecAppointments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppointments app = new AddAppointments();
            app.Show();
        }

        private void RecAppointments_Load(object sender, EventArgs e)
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

            listView1.ForeColor = ThemeColor.SecondaryColor;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "Select a.ID, a.NationalID, p.Name, a.Date, a.Time  From Appointment a Inner Join Patient p ON a.NationalID = p.NationalID where a.Date>GETDATE() order by a.Date, a.Time desc;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetString(3).ToString());
                lv.SubItems.Add(rd.GetString(4).ToString());
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cashierId = listView1.FocusedItem.Text;

            string query = "delete from Appointment where ID=@id;";

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
