using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Basic.DataBase.DDL
{
    public class BasicDDL
    {
        private SqlConnection conn;

        public BasicDDL()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CrudBasic"].ConnectionString);
        }

        public DataTable GetallTables()
        {
            try
            {
                conn.Open();

                return conn.GetSchema("Tables");
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetaAllFieldsTable(string table)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("SELECT * FROM {0}", table);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                dt = reader.GetSchemaTable();
            }
            catch (Exception e)
            {
                // ignored
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public void Create(string table, string[] campos)
        {
            var campo = string.Empty;
            var sql = string.Empty;

            campo = campos.Aggregate(campo, (current, c) => current + (c + ","));

            campo = campo.Remove(campo.Length - 1);

            sql = string.Format(@"CREATE TABLE {0} ({1});", table, campo);
            try
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(string table)
        {
            string sql = string.Format("DROP TABLE {0};", table);

            try
            {
                conn.Open();

                SqlCommand  comm = new SqlCommand(sql,conn);

                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
