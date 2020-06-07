using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesProject
{

    internal static class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["VideoGame"].ConnectionString;

        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
        public static DataSet GetData(string[] sqlStatements)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                for (int i = 0; i < sqlStatements.Length; i++)
                {
                    sqlStatements[i] = SQLCleaner(sqlStatements[i]);
                }

                string sql = String.Join(";", sqlStatements);

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                for (int i = 0; i < sqlStatements.Length; i++)
                {
                    da.TableMappings.Add(i.ToString(), $"Data{i}");
                }

                da.Fill(ds);
            }

            return ds;
        }

        public static int ExecuteNonQuery(string sql)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLCleaner(sql), conn);

                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return rowsAffected;
        }

        public static object ExecuteScalar(string sql)
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

        /// <summary>
        /// Clean double spaces in sql statement
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string SQLCleaner(string sql)
        {
            while (sql.Contains("  "))
                sql = sql.Replace("  ", " ");
            return sql.Replace(Environment.NewLine, "");
        }

        public static string SQLFix(string str)
        {
            return str.Replace("'", "''");
        }
    }
}
