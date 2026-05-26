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
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverProfileView : UserControl
    {
        public DriverProfileView()
        {
            InitializeComponent();

            LoadData();
            MakeReadOnly();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM driver " +
                    "WHERE driver_id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    Session.DriverId
                );

                var reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "driver_id")
                        ?.ToString() ?? "";

                    txtLicenseId.Text =
                        DbSafe.S(reader, "license_id");

                    dtpLicenseDate.Value =
                        Convert.ToDateTime(
                            reader["license_issue_date"]
                        );

                    txtSnils.Text =
                        DbSafe.S(reader, "snils");

                    txtPhone.Text =
                        DbSafe.S(reader, "phone");

                    txtPersonnelNumber.Text =
                        DbSafe.S(reader, "personnel_number");

                    txtFirstName.Text =
                        DbSafe.S(reader, "first_name");

                    txtLastName.Text =
                        DbSafe.S(reader, "last_name");

                    txtPatronymic.Text =
                        DbSafe.S(reader, "patronymic");
                }
            }
        }


        private void MakeReadOnly()
        {
            txtId.ReadOnly = true;
            txtLicenseId.ReadOnly = true;
            txtSnils.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtPersonnelNumber.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPatronymic.ReadOnly = true;

            dtpLicenseDate.Enabled = false;
        }

        private void DriverProfileView_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.GoBack();
        }
    }
}
