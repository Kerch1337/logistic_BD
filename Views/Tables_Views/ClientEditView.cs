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
using System.Xml.Linq;
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD
{
    public partial class ClientEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public ClientEditView(string mode, int id, Action refreshAction)
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

                string sql = "SELECT * FROM client WHERE client_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "client_id")?.ToString() ?? "";

                    txtInn.Text = DbSafe.S(reader, "inn");

                    txtOrgName.Text = DbSafe.S(reader, "org_name");

                    txtAddress.Text = DbSafe.S(reader, "address");

                    txtPhone.Text = DbSafe.S(reader, "phone");

                    txtLN.Text = DbSafe.S(reader, "first_name");

                    txtFN.Text = DbSafe.S(reader, "last_name");

                    txtPatr.Text = DbSafe.S(reader, "patronymic");
                }
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("client"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO client (inn, org_name, address, phone, first_name, last_name, patronymic)
                        VALUES (@inn, @org_name, @address, @phone, @first_name, @last_name, @patronymic)";
                }
                else
                {
                    sql = @"UPDATE client 
                        SET inn=@inn, org_name=@org_name, address=@address, phone=@phone,
                            first_name=@first_name, last_name=@last_name, patronymic=@patronymic
                        WHERE client_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@inn", txtInn.Text);
                cmd.Parameters.AddWithValue("@org_name", txtOrgName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                cmd.Parameters.AddWithValue("@first_name", txtLN.Text);
                cmd.Parameters.AddWithValue("@last_name", txtFN.Text);
                cmd.Parameters.AddWithValue("@patronymic", txtPatr.Text);

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void textPatr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
