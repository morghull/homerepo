using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu
{
    public static class DatabaseManager
    {
        private static string GetConnectionString()
        {
            return String.Format("server={0};port=5432;user id={1};password={2};database={3};", "localhost", "z_admin", "whrahz5q", "antdb");
            //return Properties.Settings.Default.ConnectionString;
        }
        public static Npgsql.NpgsqlConnection CreateConnection()
        {
            return new Npgsql.NpgsqlConnection(GetConnectionString());
        }
        public static System.Data.DataTable doQuery(Npgsql.NpgsqlCommand cmd)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            cmd.Connection = CreateConnection();

            try
            {
                cmd.Connection.Open();
                using (Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                cmd.Connection.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Ошибка при выполнении запроса" + Environment.NewLine + ex.Message);
            }

            return dt;
        }
    }
}
