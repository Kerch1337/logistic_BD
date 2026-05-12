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
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Doc_Views
{
    public partial class ContractEditView : UserControl
    {

        private string mode;
        private int id;
        private Action refresh;

        public ContractEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

            ReloadCombos();

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

                string sql =
                    "SELECT * FROM contract WHERE contract_id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "contract_id")?.ToString() ?? "";

                    txtContractNum.Text =
                        DbSafe.I(reader, "contract_num")?.ToString() ?? "";

                    dtpContractDate.Value =
                        Convert.ToDateTime(reader["contract_date"]);

                    txtLoadingAddress.Text =
                        DbSafe.S(reader, "loading_address");

                    txtUnloadingAddress.Text =
                        DbSafe.S(reader, "unloading_address");

                    txtPaymentTerms.Text =
                        DbSafe.S(reader, "payment_terms");

                    txtCostServices.Text =
                        DbSafe.D(reader, "cost_services")?.ToString() ?? "";

                    if (reader["loading_time"] != DBNull.Value)
                    {
                        dtpLoadingTime.Value =
                            Convert.ToDateTime(reader["loading_time"]);
                    }

                    if (reader["unloading_time"] != DBNull.Value)
                    {
                        dtpUnloadingTime.Value =
                            Convert.ToDateTime(reader["unloading_time"]);
                    }

                    cmbCustomer.SelectedValue =
                        DbSafe.I(reader, "customer_id");

                    cmbConsignee.SelectedValue =
                        DbSafe.I(reader, "consignee_id");

                    cmbShipper.SelectedValue =
                        DbSafe.I(reader, "shipper_id");

                    cmbOrganization.SelectedValue =
                        DbSafe.I(reader, "organization_id");

                    cmbPerformer.SelectedValue =
                        DbSafe.I(reader, "performer_id");

                    cmbLoadingContact.SelectedValue =
                        DbSafe.I(reader, "loading_contact_id");

                    cmbUnloadingContact.SelectedValue =
                        DbSafe.I(reader, "unloading_contact_id");
                }
            }
        }

        private void ReloadCombos()
        {
            LoadClients(cmbCustomer);
            LoadClients(cmbConsignee);
            LoadClients(cmbShipper);

            LoadOrganizations(cmbOrganization);
            LoadOrganizations(cmbPerformer);

            LoadWorkers(cmbLoadingContact);
            LoadWorkers(cmbUnloadingContact);
        }

        public void RefreshCombos()
        {
            ReloadCombos();
        }

        private void LoadClients(ComboBox combo)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT client_id FROM client";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                combo.DataSource = dt;

                combo.DisplayMember = "client_id";

                combo.ValueMember = "client_id";
            }
        }

        private void LoadOrganizations(ComboBox combo)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT organization_id FROM organization";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                combo.DataSource = dt;

                combo.DisplayMember = "organization_id";

                combo.ValueMember = "organization_id";
            }
        }

        private void LoadWorkers(ComboBox combo)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT worker_id FROM worker";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                combo.DataSource = dt;

                combo.DisplayMember = "worker_id";

                combo.ValueMember = "worker_id";
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql =
                    @"INSERT INTO contract
                    (
                        customer_id,
                        consignee_id,
                        shipper_id,
                        organization_id,
                        performer_id,

                        contract_num,
                        contract_date,

                        loading_address,
                        loading_time,
                        loading_contact_id,

                        unloading_address,
                        unloading_time,
                        unloading_contact_id,

                        cost_services,
                        payment_terms
                    )

                    VALUES
                    (
                        @customer_id,
                        @consignee_id,
                        @shipper_id,
                        @organization_id,
                        @performer_id,

                        @contract_num,
                        @contract_date,

                        @loading_address,
                        @loading_time,
                        @loading_contact_id,

                        @unloading_address,
                        @unloading_time,
                        @unloading_contact_id,

                        @cost_services,
                        @payment_terms
                    )";
                }
                else
                {
                    sql =
                    @"UPDATE contract

                    SET

                    customer_id=@customer_id,
                    consignee_id=@consignee_id,
                    shipper_id=@shipper_id,
                    organization_id=@organization_id,
                    performer_id=@performer_id,

                    contract_num=@contract_num,
                    contract_date=@contract_date,

                    loading_address=@loading_address,
                    loading_time=@loading_time,
                    loading_contact_id=@loading_contact_id,

                    unloading_address=@unloading_address,
                    unloading_time=@unloading_time,
                    unloading_contact_id=@unloading_contact_id,

                    cost_services=@cost_services,
                    payment_terms=@payment_terms

                    WHERE contract_id=@id";
                }


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@customer_id",
                    cmbCustomer.SelectedValue);

                cmd.Parameters.AddWithValue("@consignee_id",
                    cmbConsignee.SelectedValue);

                cmd.Parameters.AddWithValue("@shipper_id",
                    cmbShipper.SelectedValue);

                cmd.Parameters.AddWithValue("@organization_id",
                    cmbOrganization.SelectedValue);

                cmd.Parameters.AddWithValue("@performer_id",
                    cmbPerformer.SelectedValue);

                cmd.Parameters.AddWithValue("@contract_num",
                    txtContractNum.Text);

                cmd.Parameters.AddWithValue("@contract_date",
                    dtpContractDate.Value.Date);

                cmd.Parameters.AddWithValue("@loading_address",
                    txtLoadingAddress.Text);

                cmd.Parameters.AddWithValue("@loading_time",
                    dtpLoadingTime.Value);

                cmd.Parameters.AddWithValue("@loading_contact_id",
                    cmbLoadingContact.SelectedValue);

                cmd.Parameters.AddWithValue("@unloading_address",
                    txtUnloadingAddress.Text);

                cmd.Parameters.AddWithValue("@unloading_time",
                    dtpUnloadingTime.Value);

                cmd.Parameters.AddWithValue("@unloading_contact_id",
                    cmbUnloadingContact.SelectedValue);

                decimal cost = Convert.ToDecimal(txtCostServices.Text);
                cmd.Parameters.AddWithValue("@cost_services", cost);

                cmd.Parameters.AddWithValue("@payment_terms",
                    txtPaymentTerms.Text);

                if (mode == "edit")
                {
                    cmd.Parameters.AddWithValue("@id", id);
                }

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();

            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("contract"));
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("contract"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoadingContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void open(string str)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView(str)
            );
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenConsignee_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenShipper_Click(object sender, EventArgs e)
        {
            open("client");
        }

        private void btnOpenOrganization_Click(object sender, EventArgs e)
        {
            open("organization");
        }

        private void btnOpenPerformer_Click(object sender, EventArgs e)
        {
            open("organization");
        }

        private void btnOpenLoadingContact_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void btnOpenUnloadingContact_Click(object sender, EventArgs e)
        {
            open("worker");
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show(
                    "Сначала сохраните договор"
                );

                return;
            }

            MainForm main =
                (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("cargo", id)
            );
        }

        private void ContractEditView_Load(object sender, EventArgs e)
        {

        }
    }
}
