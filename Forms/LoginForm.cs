using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic_BD
{
    public partial class LoginForm : Form
    {
        public bool IsLoggedIn = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            using (var conn = AuthDb.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT * 
                       FROM user 
                       WHERE login = @login
                       AND password_hash = SHA2(@password,256)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                var reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return;
                }

                Session.UserId = Convert.ToInt32(reader["user_id"]);

                Session.Role = reader["role"].ToString();

                Session.WorkerId =
                    reader["worker_id"] == DBNull.Value
                    ? null
                    : (int?)Convert.ToInt32(reader["worker_id"]);

                Session.DriverId =
                    reader["driver_id"] == DBNull.Value
                    ? null
                    : (int?)Convert.ToInt32(reader["driver_id"]);


                switch (Session.Role)
                {
                    case "root":
                        Session.ConnectionString =
                            "server=localhost;database=logistics;user=db_root;password=root123;";
                        break;

                    case "manager":
                        Session.ConnectionString =
                            "server=localhost;database=logistics;user=db_manager;password=manager123;";
                        break;

                    case "driver":
                        Session.ConnectionString =
                            "server=localhost;database=logistics;user=db_driver;password=driver123;";
                        break;
                }

                IsLoggedIn = true;
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
