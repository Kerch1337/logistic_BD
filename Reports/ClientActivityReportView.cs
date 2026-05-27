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

namespace logistic_BD.Reports
{
    public partial class ClientActivityReportView : UserControl
    {
        public ClientActivityReportView()
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Today.AddMonths(-1);
            dateTo.Value = DateTime.Today;
        }

        private void LoadReport()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"

                SELECT

                    c.inn,
                    c.org_name,

                    c.last_name,
                    c.first_name,
                    c.patronymic,

                    c.phone,

                    COUNT(DISTINCT contract.contract_id)
                    AS contracts_count,

                    IFNULL(SUM(cargo.gross_weight), 0)
                    AS total_weight,

                    IFNULL(SUM(cargo.volume), 0)
                    AS total_volume,

                    IFNULL(SUM(DISTINCT contract.cost_services), 0)
                    AS total_contract_sum,

                    IFNULL(AVG(DISTINCT contract.cost_services), 0)
                    AS avg_contract_sum

                FROM client c

                LEFT JOIN contract
                    ON contract.customer_id =
                       c.client_id

                LEFT JOIN cargo
                    ON cargo.contract_id =
                       contract.contract_id

                WHERE contract.contract_date
                    BETWEEN @from AND @to

                GROUP BY

                    c.client_id,
                    c.inn,
                    c.org_name,
                    c.last_name,
                    c.first_name,
                    c.patronymic,
                    c.phone

                ORDER BY contracts_count DESC

                ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@from", dateFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@to", dateTo.Value.Date);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date > dateTo.Value.Date)
            {
                MessageBox.Show("Дата От не может быть больше даты До", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }
    }
}