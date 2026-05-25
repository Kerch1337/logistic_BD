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

namespace logistic_BD.Views.Subdoc_Views
{
    public partial class DriverVehicleWorkEditView : UserControl
    {
        private string mode;
        private int id;
        private int waybillId;
        private Action refresh;

        public DriverVehicleWorkEditView(
            string mode,
            int id,
            int waybillId,
            Action refresh)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.waybillId = waybillId;
            this.refresh = refresh;

            LoadCombos();

            cmbWorkType.Items.Add("Выезд");
            cmbWorkType.Items.Add("Возвращение");
            cmbWorkType.Items.Add("Прием-сдача");

            cmbWorkType.SelectedIndex = 0;

            if (mode == "edit")
                LoadData();
        }

        private void LoadCombos()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT worker_id FROM worker";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbAuthorizedPerson.DataSource = dt;

                cmbAuthorizedPerson.ValueMember =
                    "worker_id";

                cmbAuthorizedPerson.DisplayMember =
                    "worker_id";
            }
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM driver_vehicle_work WHERE work_id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "work_id")?.ToString() ?? "";

                    cmbWorkType.Text =
                        DbSafe.S(reader, "work_type");

                    if (reader["scheduled_date"] != DBNull.Value)
                    {
                        dtpScheduledDate.Value =
                            Convert.ToDateTime(reader["scheduled_date"]);
                    }

                    if (reader["scheduled_time"] != DBNull.Value)
                    {
                        dtpScheduledTime.Value =
                            DateTime.Today.Add(
                                (TimeSpan)reader["scheduled_time"]);
                    }

                    dtpActualDate.Value =
                        Convert.ToDateTime(reader["actual_date"]);

                    dtpActualTime.Value =
                        DateTime.Today.Add(
                            (TimeSpan)reader["actual_time"]);

                    txtZeroRun.Text =
                        DbSafe.I(reader, "zero_run")?.ToString() ?? "";

                    txtOdometer.Text =
                        DbSafe.I(reader, "odometer_reading")?.ToString() ?? "";

                    if (reader["authorized_person_id"] != DBNull.Value)
                    {
                        cmbAuthorizedPerson.SelectedValue =
                            DbSafe.I(reader, "authorized_person_id");
                    }
                }
            }
        }

        private void DriverVehicleWorkEditView_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql;

                if (mode == "add")
                {
                    sql = @"
            INSERT INTO driver_vehicle_work
            (
                waybill_id,
                work_type,
                scheduled_date,
                scheduled_time,
                actual_date,
                actual_time,
                zero_run,
                odometer_reading,
                authorized_person_id
            )
            VALUES
            (
                @waybill_id,
                @work_type,
                @scheduled_date,
                @scheduled_time,
                @actual_date,
                @actual_time,
                @zero_run,
                @odometer,
                @authorized_person
            )";
                }
                else
                {
                    sql = @"
            UPDATE driver_vehicle_work SET
                work_type = @work_type,
                scheduled_date = @scheduled_date,
                scheduled_time = @scheduled_time,
                actual_date = @actual_date,
                actual_time = @actual_time,
                zero_run = @zero_run,
                odometer_reading = @odometer,
                authorized_person_id = @authorized_person
            WHERE work_id = @id";
                }

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@work_type",
                    cmbWorkType.Text
                );

                cmd.Parameters.AddWithValue(
                    "@scheduled_date",
                    dtpScheduledDate.Value.Date
                );

                cmd.Parameters.AddWithValue(
                    "@scheduled_time",
                    dtpScheduledTime.Value.TimeOfDay
                );

                cmd.Parameters.AddWithValue(
                    "@actual_date",
                    dtpActualDate.Value.Date
                );

                cmd.Parameters.AddWithValue(
                    "@actual_time",
                    dtpActualTime.Value.TimeOfDay
                );

                cmd.Parameters.AddWithValue(
                    "@zero_run",
                    string.IsNullOrWhiteSpace(txtZeroRun.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txtZeroRun.Text)
                );

                cmd.Parameters.AddWithValue(
                    "@odometer",
                    Convert.ToInt32(txtOdometer.Text)
                );

                cmd.Parameters.AddWithValue(
                    "@authorized_person",
                    cmbAuthorizedPerson.SelectedValue == null
                        ? (object)DBNull.Value
                        : cmbAuthorizedPerson.SelectedValue
                );

                if (mode == "add")
                {
                    cmd.Parameters.AddWithValue(
                        "@waybill_id",
                        waybillId
                    );
                }

                if (mode == "edit")
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        id
                    );
                }

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
            {
                refresh?.Invoke();
                GoBack();
            }
        }

        private void GoBack()
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.ShowView(
                new CrudView("driver_vehicle_work", waybillId));
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void btnOpenAuthorizedPerson_Click(object sender, EventArgs e)
        {

        }
    }
}
