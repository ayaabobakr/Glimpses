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

namespace Glimpses_Clinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Conn(String get, SqlConnection conn, String form)
        {
            SqlCommand cmd = new SqlCommand(get, conn);
            try
            {
                conn.Open();

                object idfind = cmd.ExecuteScalar();
                if (idfind == null)
                {
                    MessageBox.Show("Invalid user credentials!", "Error");
                }
                else
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(idfind)))
                    {
                        if (form == "Doctor")
                        {
                            Doctor dform = new Doctor();
                            dform.Show();
                            this.Hide();
                        }
                        else
                        {
                            Receptionist rform = new Receptionist();
                            rform.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid user credentials!", "Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception!", "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection conn = new SqlConnection(conStr);
            if (usertext.Text == "")
            {
                MessageBox.Show("Please enter your username..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pwtext.Text == "")
            {
                MessageBox.Show("Please enter your password..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rolebox.Text == "")
            {
                MessageBox.Show("Please enter your role..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rolebox.Text == "Doctor")
            {
                string get = "SELECT username, password FROM Doctor WHERE username='" + usertext.Text + "' And password='" + pwtext.Text + "'"; //Security Issue: SQL Injection 
                Conn(get, conn, "Doctor");
            }
            else
            {
                string get = "SELECT username, password FROM Receptionist WHERE username='" + usertext.Text + "' And password='" + pwtext.Text + "'"; //Security Issue: SQL Injection 
                Conn(get, conn, "Receptionist");
            }


        }
    }
}
