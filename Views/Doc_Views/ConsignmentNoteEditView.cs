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
    public partial class ConsignmentNoteEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public ConsignmentNoteEditView(string mode, int id, Action refresh)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.refresh = refresh;

            LoadCombos();

            if (mode == "edit")
                LoadData();
        }

        private void LoadCombos()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                DataTable clients = new DataTable();
                new MySqlDataAdapter(
                    "SELECT client_id, org_name, last_name FROM client",
                    conn
                ).Fill(clients);


                clients.Columns.Add("display_client", typeof(string));

                foreach (DataRow row in clients.Rows)
                {
                    row["display_client"] = $"{row["org_name"]} | " + $"{row["last_name"]} ";
                }

                cmbConsignee.DataSource = clients.Copy();
                cmbConsignee.ValueMember = "client_id";
                cmbConsignee.DisplayMember = "display_client";

                cmbShipper.DataSource = clients.Copy();
                cmbShipper.ValueMember = "client_id";
                cmbShipper.DisplayMember = "display_client";


                DataTable orgs = new DataTable();
                new MySqlDataAdapter(
                    "SELECT organization_id, name FROM organization",
                    conn
                ).Fill(orgs);

                cmbCarrier.DataSource = orgs.Copy();
                cmbCarrier.ValueMember = "organization_id";
                cmbCarrier.DisplayMember = "name";

                cmbLoadingPointOwner.DataSource = orgs;
                cmbLoadingPointOwner.ValueMember = "organization_id";
                cmbLoadingPointOwner.DisplayMember = "name";

                DataTable workers = new DataTable();
                new MySqlDataAdapter(
                    "SELECT worker_id, full_name FROM worker",
                    conn
                ).Fill(workers);

                cmbLoaderPerson.DataSource = workers.Copy();
                cmbLoaderPerson.ValueMember = "worker_id";
                cmbLoaderPerson.DisplayMember = "full_name";

                cmbCarrierRepresentative.DataSource = workers;
                cmbCarrierRepresentative.ValueMember = "worker_id";
                cmbCarrierRepresentative.DisplayMember = "full_name";

                DataTable waybills = new DataTable();
                new MySqlDataAdapter(
                    "SELECT waybill_id, wb_number FROM waybill",
                    conn
                ).Fill(waybills);

                cmbWaybill.DataSource = waybills;
                cmbWaybill.ValueMember = "waybill_id";
                cmbWaybill.DisplayMember = "wb_number";
            }
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM consignment_note WHERE consignment_note_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtCnNum.Text = DbSafe.I(reader, "cn_num")?.ToString() ?? "";
                    dtpCnDate.Value = Convert.ToDateTime(reader["cn_date"]);

                    cmbWaybill.SelectedValue = DbSafe.I(reader, "waybill_id");

                    cmbConsignee.SelectedValue = DbSafe.I(reader, "consignee_id");
                    cmbShipper.SelectedValue = DbSafe.I(reader, "shipper_id");
                    cmbCarrier.SelectedValue = DbSafe.I(reader, "carrier_id");

                    cmbLoadingPointOwner.SelectedValue = DbSafe.I(reader, "loading_point_owner_id");
                    cmbLoaderPerson.SelectedValue = DbSafe.I(reader, "loader_person_id");
                    cmbCarrierRepresentative.SelectedValue = DbSafe.I(reader, "carriers_representative_id");

                    txtLoadAddress.Text = DbSafe.S(reader, "loading_adress");
                    txtUnloadAddress.Text = DbSafe.S(reader, "unloading_adress");

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
                }
            }
        }

        private void ConsignmentNoteEditView_Load(object sender, EventArgs e)
        {

        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show("Сначала сохраните накладную");
                return;
            }

            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CargoToConsignmentView(id, LoadData));
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
            INSERT INTO consignment_note
            (
                cn_num,
                cn_date,
                waybill_id,
                consignee_id,
                shipper_id,
                carrier_id,
                loading_point_owner_id,
                loader_person_id,
                carriers_representative_id,
                loading_adress,
                unloading_adress,
                actual_loading_date,
                stated_loading_date,
                actual_departure_date_load,
                actual_unloading_date,
                stated_unloading_date,
                actual_departure_date_unload
            )
            VALUES
            (
                @cn_num,
                @cn_date,
                @waybill_id,
                @consignee_id,
                @shipper_id,
                @carrier_id,
                @loading_point_owner_id,
                @loader_person_id,
                @carriers_representative_id,
                @loading_adress,
                @unloading_adress,
                @actual_loading_date,
                @stated_loading_date,
                @actual_departure_date_load,
                @actual_unloading_date,
                @stated_unloading_date,
                @actual_departure_date_unload
            )";
                }
                else
                {
                    sql = @"
            UPDATE consignment_note SET
                cn_num = @cn_num,
                cn_date = @cn_date,
                waybill_id = @waybill_id,
                consignee_id = @consignee_id,
                shipper_id = @shipper_id,
                carrier_id = @carrier_id,
                loading_point_owner_id = @loading_point_owner_id,
                loader_person_id = @loader_person_id,
                carriers_representative_id = @carriers_representative_id,
                loading_adress = @loading_adress,
                unloading_adress = @unloading_adress,
                actual_loading_date = @actual_loading_date,
                stated_loading_date = @stated_loading_date,
                actual_departure_date_load = @actual_departure_date_load,
                actual_unloading_date = @actual_unloading_date,
                stated_unloading_date = @stated_unloading_date,
                actual_departure_date_unload = @actual_departure_date_unload
            WHERE consignment_note_id = @id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cn_num", txtCnNum.Text);
                cmd.Parameters.AddWithValue("@cn_date", dtpCnDate.Value);

                cmd.Parameters.AddWithValue("@waybill_id",
                    cmbWaybill.SelectedValue ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@consignee_id", cmbConsignee.SelectedValue);
                cmd.Parameters.AddWithValue("@shipper_id", cmbShipper.SelectedValue);
                cmd.Parameters.AddWithValue("@carrier_id", cmbCarrier.SelectedValue);

                cmd.Parameters.AddWithValue("@loading_point_owner_id", cmbLoadingPointOwner.SelectedValue);
                cmd.Parameters.AddWithValue("@loader_person_id",
                    cmbLoaderPerson.SelectedValue ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@carriers_representative_id",
                    cmbCarrierRepresentative.SelectedValue ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@loading_adress", txtLoadAddress.Text);
                cmd.Parameters.AddWithValue("@unloading_adress", txtUnloadAddress.Text);

                cmd.Parameters.AddWithValue("@actual_loading_date", dtpActualLoadingDate.Value);
                cmd.Parameters.AddWithValue("@stated_loading_date", dtpStatedLoadingDate.Value);
                cmd.Parameters.AddWithValue("@actual_departure_date_load", dtpActualDepartureLoad.Value);

                cmd.Parameters.AddWithValue("@actual_unloading_date", dtpActualUnloadingDate.Value);
                cmd.Parameters.AddWithValue("@stated_unloading_date", dtpStatedUnloadingDate.Value);
                cmd.Parameters.AddWithValue("@actual_departure_date_unload", dtpActualDepartureUnload.Value);

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

            main.ShowView(new CrudView("consignment_note"));
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

        private void btnOpenCarriersRepresentative_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void btnOpenWaybill_Click(object sender, EventArgs e)
        {
            open("waybill");
        }

        private void btnOpenShipper_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenConsignee_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenCarrier_Click(object sender, EventArgs e)
        {
            open("organization");
        }

        private void btnOpenLoadingPointOwner_Click(object sender, EventArgs e)
        {
            open("organization");
        }

        private void btnOpenLoaderPerson_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void cmbCarrierRepresentative_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
