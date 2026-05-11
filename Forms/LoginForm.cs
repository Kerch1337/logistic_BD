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

            if (login == "admin" && password == "admin")
            {
                Session.Role = "Admin";
                Session.ConnectionString =
                    "server=localhost;port=3306;database=logistics;user=admin;password=admin123;";
                IsLoggedIn = true;
                this.Close();
            }
            else if (login == "manager" && password == "manager")
            {
                Session.Role = "Manager";
                Session.ConnectionString =
                    "server=localhost;port=3306;database=logistics;user=manager;password=manager123;";
                IsLoggedIn = true;
                this.Close();
            }
            else if (login == "driver" && password == "driver")
            {
                Session.Role = "Driver";
                Session.ConnectionString =
                    "server=localhost;port=3306;database=logistics;user=driver;password=driver123;";
                IsLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
