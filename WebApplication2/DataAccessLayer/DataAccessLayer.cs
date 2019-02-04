using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.DataAccessLayer
{
    public class DataAccessLayer
    {
        SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public String Submit(String txt)
        {

            string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("GetFruitName", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FruitId", int.Parse(txt.Trim()));
                    cmd.Parameters.Add("@FruitName", SqlDbType.VarChar, 30);
                    cmd.Parameters["@FruitName"].Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteReader();
                    return cmd.Parameters["@FruitName"].Value.ToString();
                }
            }
        }
    }
}