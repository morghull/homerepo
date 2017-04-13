using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu
{
    public class DataProcesor
    {
        private Npgsql.NpgsqlConnection connection;
        public String connectionString;

        public DataProcesor(String ConnectionString)
        {
            this.connectionString = ConnectionString;
            try
            {
                this.connection = new Npgsql.NpgsqlConnection(ConnectionString);
                this.connection.Open();
                this.connection.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Ошибка при подключении к базе данных" + Environment.NewLine + exception.Message);
            }
        }
        public void doNonQuery(Npgsql.NpgsqlCommand cmd)
        {
            cmd.Connection = this.connection;
            try
            {

            }
            catch (Exception) { }
        }
        public System.Data.DataTable doQuery(Npgsql.NpgsqlCommand cmd)
        {
            cmd.Connection = this.connection;
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                cmd.Connection.Open();
                using (Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                cmd.Connection.Close();
            }
            catch (Exception) { }
            return dt;
        }
    }
}
