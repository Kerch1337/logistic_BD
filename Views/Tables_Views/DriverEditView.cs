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
    public partial class DriverEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public DriverEditView(string mode, int id, Action refreshAction)
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

                string sql = "SELECT * FROM driver WHERE driver_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    txtId.Text = reader.GetInt("driver_id")?.ToString();

                    txtLicenseId.Text = reader.GetString("license_id");

                    dtpLicenseDate.Value = Convert.ToDateTime(reader["license_issue_date"]);

                    txtSnils.Text = reader.GetString("snils");
                    txtPhone.Text = reader.GetString("phone");
                    txtPersonnelNumber.Text = reader.GetString("personnel_number");

                    txtFirstName.Text = reader.GetString("first_name");
                    txtLastName.Text = reader.GetString("last_name");
                    txtPatronymic.Text = reader.GetString("patronymic");
                }
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("driver"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO driver (license_id, license_issue_date, snils, phone, personnel_number, first_name, last_name, patronymic)
                        VALUES (@license_id, @license_issue_date, @snils, @phone, @personnel_number, @first_name, @last_name, @patronymic)";
                }
                else
                {
                    sql = @"UPDATE driver 
                        SET license_id=@license_id, license_issue_date=@license_issue_date,
                            snils=@snils, phone=@phone, personnel_number=@personnel_number,
                            first_name=@first_name, last_name=@last_name, patronymic=@patronymic
                        WHERE driver_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@license_id", txtLicenseId.Text);
                cmd.Parameters.AddWithValue("@license_issue_date", dtpLicenseDate.Value.Date);
                cmd.Parameters.AddWithValue("@snils", txtSnils.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                cmd.Parameters.AddWithValue("@personnel_number", txtPersonnelNumber.Text);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@patronymic", txtPatronymic.Text);

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
