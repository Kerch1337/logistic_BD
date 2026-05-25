using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace logistic_BD
{
    public static class AuthDb
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(
                "server=localhost;" +
                "database=logistics;" +
                "user=db_root;" +
                "password=root123;"
            );
        }
    }
}
