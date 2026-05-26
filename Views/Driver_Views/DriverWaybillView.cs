using MySql.Data.MySqlClient;
using System;
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
    public partial class DriverWaybillView : UserControl
    {
        private int id;

        private int mechanicId;
        private int fillingPersonId;
        private int controllerId;
        private int organizationId;
        private int clientId;

        public DriverWaybillView(int id)
        {
            InitializeComponent();

            this.id = id;

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT *
                    FROM waybill
                    WHERE waybill_id = @id
                    AND driver_id = @driver_id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@driver_id", Session.DriverId);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "waybill_id")?.ToString() ?? "";

                    txtWbNumber.Text = DbSafe.I(reader, "wb_number")?.ToString() ?? "";

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
                            DateTime.Today.Add(
                                (TimeSpan)reader["pre_trip_inspection_time"]);
                    }

                    cmbTransportType.Text =
                        reader["transportation_type"].ToString();

                    cmbMessageType.Text =
                        reader["message_type"].ToString();


                    mechanicId = DbSafe.I(reader, "mechanic_id") ?? 0;
                    fillingPersonId = DbSafe.I(reader, "person_filling_out_id") ?? 0;
                    controllerId = DbSafe.I(reader, "vehicle_condition_controller_id") ?? 0;
                    organizationId = DbSafe.I(reader, "organization_filling_out_id") ?? 0;
                    clientId = DbSafe.I(reader, "customer_id") ?? 0;

                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox ||
                    c is ComboBox ||
                    c is DateTimePicker)
                {
                    c.Enabled = false;
                }
            }
        }

        private void DriverWaybillView_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenVehicle_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverVehicleView(id));
        }

        private void btnMedicalExam_Click(object sender,EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverMedicalExamListView(id));
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverTrailerListView(id));
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverWorkListView(id));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.GoBack();
        }

        private void btnOpenController_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverWorkerView(controllerId));
        }

        private void btnOpenOrg_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverOrganizationView(organizationId));
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverClientView(clientId));
        }

        private void btnOpenMechanic_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverWorkerView(mechanicId));
        }

        private void btnOpenPersonFillingOut_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverWorkerView(fillingPersonId));
        }

        private void btnOpenDriver_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverProfileView());
        }
    }
}