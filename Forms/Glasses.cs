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
    public partial class Glasses : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
        //string conStr = "Data Source=LAPTOP-5DS7586S;Initial Catalog=EyeClinic;Integrated Security=True;";
        public Glasses()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            float price;
            if (glassescb.SelectedItem == "Cat Eye Women Glasses")
            {
                price = 30;
            }
            else if (glassescb.SelectedItem == "Aviator Sunglasses")
            {
                price = 70;
            }
            else
            {
                price = 100;
            }

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                string insert = "Update VFT SET Glasses = @Glasses, LensType = @LensType, Material =@Material, Coating =@Coating, Price =@Price, Statue =@Statue " +
                    " Where nationalID ='" + EyeReport.NID + "'";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(insert, sqlcon);

                cmd.Parameters.Add("@Glasses", SqlDbType.VarChar);
                cmd.Parameters["@Glasses"].Value = glassescb.Text;

                cmd.Parameters.Add("@LensType", SqlDbType.VarChar);
                cmd.Parameters["@LensType"].Value = typecb.Text;

                cmd.Parameters.Add("@Material", SqlDbType.VarChar);
                cmd.Parameters["@Material"].Value = materialcb.Text;

                cmd.Parameters.Add("@Coating", SqlDbType.VarChar);
                cmd.Parameters["@Coating"].Value = coatcb.Text;

                cmd.Parameters.Add("@Price", SqlDbType.Float);
                cmd.Parameters["@Price"].Value = price;

                cmd.Parameters.Add("@Statue", SqlDbType.VarChar);
                cmd.Parameters["@Statue"].Value = "false";


                cmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            MessageBox.Show("Saved!");
        }
    }
}
