using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesProject
{
    
    public static class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["VideoGame"].ConnectionString;

        public static object GetValue(string sql)
        {
            object retValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                retValue = cmd.ExecuteScalar();

            }

            return retValue;
        }
    }
}
