using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenu
{
    public static class SqlConnectionUtil
    {
        public static string DefaultConnectionString { get; private set; }

        static SqlConnectionUtil()
        {
            SqlConnectionUtil.DefaultConnectionString = String.Format("server={0};port=5432;user id={1};password={2};database={3};", "localhost", "z_admin", "whrahz5q", "antdb");
        }

        public static Npgsql.NpgsqlConnection CreateConnection()
        {
            return new Npgsql.NpgsqlConnection(SqlConnectionUtil.DefaultConnectionString);
        }
    }
}
