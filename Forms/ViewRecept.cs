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
    }
}
