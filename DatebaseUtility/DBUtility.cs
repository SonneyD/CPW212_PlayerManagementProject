using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PlayerDatabaseModule.DatebaseUtility
{
    public static class DBUtility
    {
        public static string GetConnectionString( string DataSource, string catalog )
        {
            return "Data Source=" + DataSource + ";Initial Catalog=" + catalog + "Integrated Security=True";
        }

        public static SqlConnection GetSqlConnection( string source, string catalog )
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString( source, catalog );
            return con;
        }

        public static void MakeQuery()
        {
            //var query =
        }
    }
}
