using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using logistic_BD.Models;
using MySql.Data.MySqlClient;

namespace logistic_BD.Repositories
{
    public class OrganizationRepository
    {
        public List<Organization> GetAll()
        {
            List<Organization> list = new List<Organization>();

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT
                                organization_id,
                                inn,
                                name,
                                address,
                                phone
                               FROM organization";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Organization org = new Organization();

                        org.OrganizationId = reader.GetInt32("organization_id");
                        org.Inn = reader.GetString("inn");
                        org.Name = reader.GetString("name");
                        org.Address = reader.GetString("address");
                        org.Phone = reader.GetString("phone");

                        list.Add(org);
                    }
                }
            }

            return list;
        }
    }
}
