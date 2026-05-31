using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using logistic_BD.Reports;

namespace logistic_BD.Views.Report_Views
{
    public partial class ContractReportListView : UserControl
    {
        public ContractReportListView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT
                c.contract_id,
                c.contract_num,
                c.contract_date,

                cust.org_name AS customer_org,
                cust.last_name AS customer_last_name,
                cust.first_name AS customer_first_name,
                cust.patronymic AS customer_patronymic,

                cons.org_name AS consignee_org,
                cons.last_name AS consignee_last_name,
                cons.first_name AS consignee_first_name,
                cons.patronymic AS consignee_patronymic,

                ship.org_name AS shipper_org,
                ship.last_name AS shipper_last_name,
                ship.first_name AS shipper_first_name,
                ship.patronymic AS shipper_patronymic,

                org.name AS organization,
                perf.name AS performer,

                c.loading_address,
                c.loading_time,
                loadw.full_name AS loading_contact,

                c.unloading_address,
                c.unloading_time,
                unloadw.full_name AS unloading_contact,

                c.cost_services,
                c.payment_terms

                FROM contract c
                LEFT JOIN client cust ON c.customer_id = cust.client_id
                LEFT JOIN client cons ON c.consignee_id = cons.client_id
                LEFT JOIN client ship ON c.shipper_id = ship.client_id
                LEFT JOIN organization org ON c.organization_id = org.organization_id
                LEFT JOIN organization perf ON c.performer_id = perf.organization_id
                LEFT JOIN worker loadw ON c.loading_contact_id = loadw.worker_id
                LEFT JOIN worker unloadw ON c.unloading_contact_id = unloadw.worker_id
                
                ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["contract_id"].Visible = false;

                //dataGridView1.Columns["contract_id"].HeaderText = "ID";
                dataGridView1.Columns["contract_num"].HeaderText = "Номер договора";
                dataGridView1.Columns["contract_date"].HeaderText = "Дата";

                dataGridView1.Columns["customer_org"].HeaderText = "организация Заказчик";
                dataGridView1.Columns["customer_last_name"].HeaderText = "Фамилия заказчика";
                dataGridView1.Columns["customer_first_name"].HeaderText = "Имя заказчика";
                dataGridView1.Columns["customer_patronymic"].HeaderText = "Отчество заказчика";


                dataGridView1.Columns["consignee_org"].HeaderText = "организация грузополучателя";
                dataGridView1.Columns["consignee_last_name"].HeaderText = "Фамилия грузополучателя";
                dataGridView1.Columns["consignee_first_name"].HeaderText = "Имя грузополучателя";
                dataGridView1.Columns["consignee_patronymic"].HeaderText = "Отчество грузополучателя";


                dataGridView1.Columns["shipper_org"].HeaderText = "организация грузоотправителя";
                dataGridView1.Columns["shipper_last_name"].HeaderText = "Фамилия грузоотправителя";
                dataGridView1.Columns["shipper_first_name"].HeaderText = "Имя грузоотправителя";
                dataGridView1.Columns["shipper_patronymic"].HeaderText = "Отчество грузоотправителя";

                dataGridView1.Columns["organization"].HeaderText = "Организация";
                dataGridView1.Columns["performer"].HeaderText = "Исполнитель";

                dataGridView1.Columns["loading_address"].HeaderText = "Адрес погрузки";
                dataGridView1.Columns["loading_time"].HeaderText = "Время погрузки";

                dataGridView1.Columns["loading_contact"].HeaderText = "Контакт погрузки";


                dataGridView1.Columns["unloading_address"].HeaderText = "Адрес разгрузки";
                dataGridView1.Columns["unloading_time"].HeaderText = "Время разгрузки";

                dataGridView1.Columns["unloading_contact"].HeaderText = "Контакт разгрузки";


                dataGridView1.Columns["cost_services"].HeaderText = "Стоимость";
                dataGridView1.Columns["payment_terms"].HeaderText = "Условия оплаты";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["contract_id"].Value);
            ContractReport.Export(id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }
    }
}