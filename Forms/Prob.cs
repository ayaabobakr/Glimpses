using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glimpses_Clinic.Forms
{
    class Prob
    {
        public string prob(string nid)
        {
            int prob = 0;
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            string sql = "Select [Eye_History],[Family_History],[Pat_Symptoms],[Surgery]," +
                "[Contacts],[Redness],[Tearing],[Eyepain],[Burning]" +
                ",[Discharge],[Soreness],[Itching],[Dryness],[Flashes] From MR where NationalID = @id;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", nid);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                if (da.GetValue(0).ToString() != null)
                {
                    prob += 1;
                }

                if (da.GetValue(1).ToString() != null)
                {
                    prob += 1;
                }

                if(da.GetValue(2).ToString()== "Squinting")
                {
                    prob += 2;
                }

                if (da.GetBoolean(3) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(4) == true)
                {
                    prob += 2;
                }

                if (da.GetBoolean(5) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(6) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(7) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(8) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(9) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(10) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(11) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(12) == true)
                {
                    prob += 1;
                }

                if (da.GetBoolean(13) == true)
                {
                    prob += 1;
                }
            }
            conn.Close();

            if (prob > 5)
            {
                return "A high risk of needing cataract surgery!";
            }
            else
            {
                return "Might need Lasik surgery!";
            }


        }
    }
}
