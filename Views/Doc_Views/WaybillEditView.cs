using logistic_BD.Views.Subdoc_Views;
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

namespace logistic_BD.Views.Doc_Views
{
    public partial class WaybillEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public WaybillEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.refresh = refreshAction;

            LoadCombos();

            if (mode == "edit")
                LoadData();
        }

        private void LoadCombos()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                MySqlDataAdapter da;
                DataTable dt;


                da = new MySqlDataAdapter("SELECT driver_id, personnel_number FROM driver", conn);
                dt = new DataTable();
                da.Fill(dt);
                cmbDriver.DataSource = dt;
                cmbDriver.ValueMember = "driver_id";
                cmbDriver.DisplayMember = "personnel_number";

                da = new MySqlDataAdapter("SELECT vehicle_id, reg_number FROM vehicle", conn);
                dt = new DataTable();
                da.Fill(dt);
                cmbVehicle.DataSource = dt;
                cmbVehicle.ValueMember = "vehicle_id";
                cmbVehicle.DisplayMember = "reg_number";

                da = new MySqlDataAdapter("SELECT client_id, org_name, last_name FROM client", conn);
                dt = new DataTable();
                da.Fill(dt);

                dt.Columns.Add("display_client",typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["display_client"] = $"{row["org_name"]} | " + $"{row["last_name"]} ";
                }

                cmbCustomer.DataSource = dt;
                cmbCustomer.ValueMember = "client_id";
                cmbCustomer.DisplayMember = "display_client";

                da = new MySqlDataAdapter("SELECT organization_id, name FROM organization", conn);
                dt = new DataTable();
                da.Fill(dt);
                cmbOrganization.DataSource = dt;
                cmbOrganization.ValueMember = "organization_id";
                cmbOrganization.DisplayMember = "name";

                da = new MySqlDataAdapter("SELECT worker_id, full_name FROM worker", conn);
                dt = new DataTable();
                da.Fill(dt);

                cmbPersonFillingOut.DataSource = dt.Copy();
                cmbMechanic.DataSource = dt.Copy();
                cmbController.DataSource = dt.Copy();

                cmbPersonFillingOut.ValueMember = "worker_id";
                cmbMechanic.ValueMember = "worker_id";
                cmbController.ValueMember = "worker_id";

                cmbPersonFillingOut.DisplayMember = "full_name";
                cmbMechanic.DisplayMember = "full_name";
                cmbController.DisplayMember = "full_name";
            }

            cmbTransportType.Items.Add("Регулярная перевозка пассажиров и багажа");
            cmbTransportType.Items.Add("Перевозка пассажиров и багажа по заказу");
            cmbTransportType.Items.Add("Перевозка пассажиров и багажа легковым такси");
            cmbTransportType.Items.Add("Организованная перевозка группы детей");
            cmbTransportType.Items.Add("Перевозка грузов");
            cmbTransportType.Items.Add("Перевозка для собственных нужд");

            cmbMessageType.Items.Add("Городское");
            cmbMessageType.Items.Add("Пригородное");
            cmbMessageType.Items.Add("Междугороднее");

            cmbMessageType.SelectedIndex = 2;
            cmbTransportType.SelectedIndex = 4;

            dtpPreTripTime.Format = DateTimePickerFormat.Time;
            dtpPreTripTime.ShowUpDown = true;
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM waybill WHERE waybill_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "waybill_id")?.ToString() ?? "";

                    txtWbNumber.Text =
                        DbSafe.I(reader, "wb_number")?.ToString() ?? "";

                    cmbDriver.SelectedValue =
                        DbSafe.I(reader, "driver_id");

                    cmbVehicle.SelectedValue =
                        DbSafe.I(reader, "vehicle_id");

                    cmbCustomer.SelectedValue =
                        DbSafe.I(reader, "customer_id");

                    cmbOrganization.SelectedValue =
                        DbSafe.I(reader, "organization_filling_out_id");

                    cmbPersonFillingOut.SelectedValue =
                        DbSafe.I(reader, "person_filling_out_id");

                    cmbMechanic.SelectedValue =
                        DbSafe.I(reader, "mechanic_id");

                    cmbController.SelectedValue =
                        DbSafe.I(reader, "vehicle_condition_controller_id");

                    dtpWbDate.Value =
                        Convert.ToDateTime(reader["wb_date"]);

                    dtpFrom.Value =
                        Convert.ToDateTime(reader["effective_date_from"]);

                    dtpUntil.Value =
                        Convert.ToDateTime(reader["effective_date_untill"]);

                    if (reader["arrival_time"] != DBNull.Value)
                    {
                        dtpArrivalTime.Value =
                            Convert.ToDateTime(reader["arrival_time"]);
                    }

                    if (reader["departure_time"] != DBNull.Value)
                    {
                        dtpDepartureTime.Value =
                            Convert.ToDateTime(reader["departure_time"]);
                    }

                    if (reader["pre_trip_inspection_date"] != DBNull.Value)
                    {
                        dtpPreTripDate.Value =
                            Convert.ToDateTime(reader["pre_trip_inspection_date"]);
                    }

                    if (reader["pre_trip_inspection_time"] != DBNull.Value)
                    {
                        dtpPreTripTime.Value =
                            DateTime.Today.Add((TimeSpan)reader["pre_trip_inspection_time"]);
                    }

                    cmbTransportType.Text =
                        reader["transportation_type"].ToString();

                    cmbMessageType.Text =
                        reader["message_type"].ToString();
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WaybillEditView_Load(object sender, EventArgs e)
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

                var arrivalRaw = dtpArrivalTime.Checked ? dtpArrivalTime.Value.ToString("o") : "NULL";
                var departureRaw = dtpDepartureTime.Checked ? dtpDepartureTime.Value.ToString("o") : "NULL";

                if (mode == "add")
                {
                    sql = @"
                        INSERT INTO waybill
                        (
                        wb_number,
                        driver_id,
                        vehicle_id,
                        customer_id,
                        organization_filling_out_id,
                        wb_date,
                        effective_date_from,
                        effective_date_untill,
                        person_filling_out_id,
                        transportation_type,
                        message_type,
                        arrival_time,
                        departure_time,
                        mechanic_id,
                        vehicle_condition_controller_id,
                        pre_trip_inspection_date,
                        pre_trip_inspection_time
                        )
                        VALUES
                        (
                        @wb_number,
                        @driver_id,
                        @vehicle_id,
                        @customer_id,
                        @org,
                        @wb_date,
                        @from,
                        @until,
                        @person,
                        @transport,
                        @message,
                        @arrival_time,
                        @departure,
                        @mechanic,
                        @controller,
                        @pre_date,
                        @pre_time
                        )";
                }
                else
                {
                    sql = @"
                        UPDATE waybill SET
                        wb_number=@wb_number,
                        driver_id=@driver_id,
                        vehicle_id=@vehicle_id,
                        customer_id=@customer_id,
                        organization_filling_out_id=@org,
                        wb_date=@wb_date,
                        effective_date_from=@from,
                        effective_date_untill=@until,
                        person_filling_out_id=@person,
                        transportation_type=@transport,
                        message_type=@message,
                        arrival_time=@arrival_time,
                        departure_time=@departure,
                        mechanic_id=@mechanic,
                        vehicle_condition_controller_id=@controller,
                        pre_trip_inspection_date=@pre_date,
                        pre_trip_inspection_time=@pre_time
                        WHERE waybill_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@wb_number", txtWbNumber.Text);

                cmd.Parameters.AddWithValue("@driver_id", cmbDriver.SelectedValue);
                cmd.Parameters.AddWithValue("@vehicle_id", cmbVehicle.SelectedValue);
                cmd.Parameters.AddWithValue("@customer_id", cmbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@org", cmbOrganization.SelectedValue);

                cmd.Parameters.AddWithValue("@person", cmbPersonFillingOut.SelectedValue);
                cmd.Parameters.AddWithValue("@mechanic", cmbMechanic.SelectedValue);
                cmd.Parameters.AddWithValue("@controller", cmbController.SelectedValue);

                cmd.Parameters.AddWithValue("@wb_date", dtpWbDate.Value);
                cmd.Parameters.AddWithValue("@from", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@until", dtpUntil.Value);

                //cmd.Parameters.AddWithValue("@arrival_time", dtpArrivalTime.Value);
                //cmd.Parameters.AddWithValue("@departure", dtpDepartureTime.Value);

                cmd.Parameters.AddWithValue("@arrival_time",
    dtpArrivalTime.Checked ? dtpArrivalTime.Value : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@departure",
                    dtpDepartureTime.Checked ? dtpDepartureTime.Value : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@pre_date", dtpPreTripDate.Value);
                cmd.Parameters.AddWithValue("@pre_time", dtpPreTripTime.Value.TimeOfDay);

                cmd.Parameters.AddWithValue("@transport", cmbTransportType.Text);
                cmd.Parameters.AddWithValue("@message", cmbMessageType.Text);

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

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
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("waybill"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void open(string str)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView(str)
            );
        }

        private void btnOpenVehicle_Click(object sender, EventArgs e)
        {
            open("vehicle");
        }

        private void btnOpenDriver_Click(object sender, EventArgs e)
        {
            open("driver");
        }

        private void btnOpenPersonFillingOut_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void btnOpenMechanic_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenOrg_Click(object sender, EventArgs e)
        {
            open("organization");
        }

        private void btnOpenController_Click(object sender, EventArgs e)
        {
            open("worker");
        }


        private void btnMedicalExam_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show("Сначала сохраните путевой лист");
                return;
            }

            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("medical_exam", id)
            );
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show("Сначала сохраните путевой лист");
                return;
            }

            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("driver_vehicle_work", id)
            );
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show("Сначала сохраните путевой лист");

                return;
            }

            MainForm main =
                (MainForm)this.FindForm();

            main.ShowView(
                new WaybillTrailerView(
                    id,
                    () =>
                    {
                        main.ShowView(new WaybillEditView("edit", id, refresh));
                    }
                )
            );

        }


    }
}
