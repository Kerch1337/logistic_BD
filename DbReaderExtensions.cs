using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_BD
{


    using System;
    using MySql.Data.MySqlClient;

    namespace logistic_BD
    {
        public static class DbReaderExtensions
        {

            public static DateTime? GetDateTime(this MySqlDataReader reader, string column)
            {
                return reader[column] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(reader[column]);
            }

            public static string GetString(this MySqlDataReader reader, string column)
            {
                return reader[column] == DBNull.Value
                    ? null
                    : reader[column].ToString();
            }

            public static int? GetInt(this MySqlDataReader reader, string column)
            {
                return reader[column] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader[column]);
            }

            public static decimal? GetDecimal(this MySqlDataReader reader, string column)
            {
                return reader[column] == DBNull.Value
                    ? (decimal?)null
                    : Convert.ToDecimal(reader[column]);
            }
        }
    }
}
