using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPProject.App.Utilities
{
    public class ERPSqlHelper
    {
        private static string _connectionString;
        public static void SetConnectionString(string connection)
        {
            _connectionString = connection;
        }
        public static T ExcuteFirstOrDefault<T>(string sqlQuery, DynamicParameters dynamicParameters = null, System.Data.CommandType commandType = System.Data.CommandType.Text)
        {
            using (var con = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                return con.QueryFirstOrDefault<T>(sql: sqlQuery, param: dynamicParameters, commandType: commandType);
            }
        }
        public static IEnumerable<T> ExcuteEnumerable<T>(string sqlQuery, DynamicParameters dynamicParameters = null, System.Data.CommandType commandType = System.Data.CommandType.Text)
        {
            using (var con = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                return con.Query<T>(sql: sqlQuery, param: dynamicParameters, commandType: commandType);
            }
        }
    }
}
