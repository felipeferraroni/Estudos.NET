using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Basic.DataBase.DML
{
    public class BasicDML
    {
        private SqlConnection conn;

        public BasicDML()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CrudBasic"].ConnectionString);
        }

        public DataTable LoadTable(string table, int id = 0,string tableFk = "")
        {
            DataSet ds = new DataSet();
            string sql = string.Empty;
            if (!string.IsNullOrWhiteSpace(table))
            {
                sql = string.Format("SELECT * FROM {0}", table);
            }

            if (id > 0)
            {
                sql += $" WHERE {tableFk}Id = {id}";
            }

            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand(sql,conn);

                SqlDataAdapter da = new SqlDataAdapter(comm);

                da.Fill(ds,table);

                return ds.Tables[table];
            }
            finally
            {
                conn.Close();
            }


        }

        public void InsertContato(string nome, DateTime data)
        {
            var sql = @"INSERT INTO Contato (ContatoNome,ContatoDataNascimento )";
            sql += $" VALUES ('{nome}', '{data.ToString("yyyy-MM-dd")}' );";

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertTelefone(string ddd, string numero, int contatoId)
        {
            string sql = "INSERT INTO Telefone ( TelefoneDDD, TelefoneNumero, ContatoId )";
            sql += $"Values ('{ddd}', '{numero}',{contatoId} )";

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Exclude(string table, int id)
        {
            string sql = $"DELETE FROM {table} WHERE {table}Id = {id};";
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand(sql, conn);

                comm.ExecuteNonQuery();

            }
            finally
            {
                conn.Close();
            }

        }

        public void CriarTable()
        {
            var contato = @"CREATE TABLE Contato ( ";
            contato += @"ContatoId INT IDENTITY(1,1) NOT NULL,";
            contato += @"ContatoNome VARCHAR(100),";
            contato += @"ContatoDataNascimento DATETIME,";
            contato += @"Constraint pk_ContatoId Primary key (ContatoId));";

            var Telefone = @"CREATE TABLE Telefone( ";
            Telefone += @"TelefoneId INT IDENTITY(1,1) NOT NULL,";
            Telefone += @"TelefoneDDD VARCHAR(2),";
            Telefone += @"TelefoneNumero VARCHAR(9),";
            Telefone += @"ContatoId INT,";
            Telefone += @"Constraint pk_TelefoneId primary key (TelefoneId),";
            Telefone += @"Constraint fk_ContatoId Foreign key (ContatoId) References Contato (ContatoId))";

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(contato, conn);
                comm.ExecuteNonQuery();

                comm = new SqlCommand(Telefone, conn);

                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteTable()
        {
            string sql = @"DROP TABLE TELEFONE;";
            sql += @"DROP TABLE CONTATO;";

            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand(sql, conn);

                comm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
