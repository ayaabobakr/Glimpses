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
    public partial class Appointments : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString(); 

        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            listView1.ForeColor = ThemeColor.SecondaryColor;
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "Select P.NationalID, P.Name, P.Gender, P.DateOfBirth, A.Date, A.Time " +
                "From Patient as P, Appointment AS A where A.NationalID=P.NationalID and A.Date>GETDATE() " +
                "order by A.Date, A.Time desc;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                int now = int.Parse(DateTime.Now.ToString("yyyy"));
                int dob = int.Parse(rd.GetDateTime(3).ToString("yyyy"));
                int age = (now - dob);
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(age.ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetString(4).ToString());
                lv.SubItems.Add(rd.GetString(5).ToString());
                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
        }

    }
}
