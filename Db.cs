using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_BD
{
    public static class Db
    {

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(Session.ConnectionString);
        }
    }
}