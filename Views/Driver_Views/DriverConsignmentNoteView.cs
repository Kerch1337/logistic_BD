using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverConsignmentNoteView : UserControl
    {
        private int id;

        private int consigneeId;
        private int shipperId;
        private int carrierId;
        private int loadingOwnerId;
        private int loaderPersonId;
        private int carrierRepId;

        public DriverConsignmentNoteView(int id)
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
                    SELECT cn.*, w.wb_number
                    FROM consignment_note cn
                    LEFT JOIN waybill w ON cn.waybill_id = w.waybill_id
                    WHERE cn.consignment_note_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtCnNum.Text = DbSafe.I(reader, "cn_num")?.ToString() ?? "";
                    txtWBNum.Text = DbSafe.I(reader, "wb_number")?.ToString() ?? "";

                    txtLoadAddress.Text = DbSafe.S(reader, "loading_adress");
                    txtUnloadAddress.Text = DbSafe.S(reader, "unloading_adress");

                    dtpCnDate.Value = Convert.ToDateTime(reader["cn_date"]);

                    if (reader["actual_loading_date"] != DBNull.Value)
                        dtpActualLoadingDate.Value = Convert.ToDateTime(reader["actual_loading_date"]);

                    if (reader["stated_loading_date"] != DBNull.Value)
                        dtpStatedLoadingDate.Value = Convert.ToDateTime(reader["stated_loading_date"]);

                    if (reader["actual_departure_date_load"] != DBNull.Value)
                        dtpActualDepartureLoad.Value = Convert.ToDateTime(reader["actual_departure_date_load"]);

                    if (reader["actual_unloading_date"] != DBNull.Value)
                        dtpActualUnloadingDate.Value = Convert.ToDateTime(reader["actual_unloading_date"]);

                    if (reader["stated_unloading_date"] != DBNull.Value)
                        dtpStatedUnloadingDate.Value = Convert.ToDateTime(reader["stated_unloading_date"]);

                    if (reader["actual_departure_date_unload"] != DBNull.Value)
                        dtpActualDepartureUnload.Value = Convert.ToDateTime(reader["actual_departure_date_unload"]);


                    consigneeId = DbSafe.I(reader, "consignee_id") ?? 0;
                    shipperId = DbSafe.I(reader, "shipper_id") ?? 0;
                    carrierId = DbSafe.I(reader, "carrier_id") ?? 0;
                    loadingOwnerId = DbSafe.I(reader, "loading_point_owner_id") ?? 0;
                    loaderPersonId = DbSafe.I(reader, "loader_person_id") ?? 0;
                    carrierRepId = DbSafe.I(reader, "carriers_representative_id") ?? 0;
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is DateTimePicker)
                    c.Enabled = false;
            }
        }

        private void btnOpenCarriersRepresentative_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverWorkerView(carrierRepId));
        }

        private void btnOpenConsignee_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverClientView(consigneeId));
        }

        private void btnOpenShipper_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverClientView(shipperId));
        }

        private void btnOpenCarrier_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverOrganizationView(carrierId));
        }

        private void btnOpenLoadingPointOwner_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverOrganizationView(loadingOwnerId));
        }

        private void btnOpenLoaderPerson_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverWorkerView(loaderPersonId));
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverCargoListView(id));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.GoBack();
        }
    }
}
