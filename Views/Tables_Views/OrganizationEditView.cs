using logistic_BD.logistic_BD;
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
    public partial class OrganizationEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;


        public OrganizationEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.refresh = refreshAction;

            if (mode == "edit")
                LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM organization WHERE organization_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader.GetInt("organization_id")?.ToString();

                    txtInn.Text = reader.GetString("inn");
                    txtName.Text = reader.GetString("name");
                    txtAddress.Text = reader.GetString("address");
                    txtPhone.Text = reader.GetString("phone");
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("organization"));
        }

        private void OrganizationEditView_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO organization (inn, name, address, phone)
                    VALUES (@inn, @name, @address, @phone)";
                }
                else
                {
                    sql = @"UPDATE organization 
                    SET inn=@inn, name=@name, address=@address, phone=@phone
                    WHERE organization_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@inn", txtInn.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
