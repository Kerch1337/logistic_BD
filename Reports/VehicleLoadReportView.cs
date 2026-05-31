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

namespace logistic_BD.Views.ReportViews
{
    public partial class VehicleLoadReportView : UserControl
    {
        public VehicleLoadReportView()
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

                        v.reg_number,
                        v.brand,
                        v.model,

                        COUNT(DISTINCT wb.waybill_id)
                        AS trips_count,

                        IFNULL(SUM(c.gross_weight), 0)
                        AS total_weight,

                        IFNULL(SUM(c.volume), 0)
                        AS total_volume,

                        IFNULL(SUM(DISTINCT contract.cost_services), 0)
                        AS total_services,

                        MAX(wb.wb_date)
                        AS last_trip,

                        CASE
                            WHEN MAX(wb.effective_date_untill) >= NOW()
                            THEN 'Занят'
                            ELSE 'Свободен'
                        END AS status

                    FROM vehicle v

                    LEFT JOIN waybill wb
                    ON wb.vehicle_id = v.vehicle_id

                    LEFT JOIN consignment_note cn
                    ON cn.waybill_id = wb.waybill_id

                    LEFT JOIN cargo c
                    ON c.consignment_note_id = cn.consignment_note_id

                    LEFT JOIN contract
                    ON contract.contract_id = c.contract_id

                    WHERE wb.wb_date BETWEEN @from AND @to

                    GROUP BY
                        v.vehicle_id,
                        v.reg_number,
                        v.brand,
                        v.model

                    ORDER BY trips_count DESC
                    ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@from", dateFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@to", dateTo.Value.Date);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["reg_number"].HeaderText = "Рег. номер";
                dataGridView1.Columns["brand"].HeaderText = "Марка";
                dataGridView1.Columns["model"].HeaderText = "Модель";

                dataGridView1.Columns["trips_count"].HeaderText = "Количество рейсов";
                dataGridView1.Columns["total_weight"].HeaderText = "Общий вес";
                dataGridView1.Columns["total_volume"].HeaderText = "Общий объем";
                dataGridView1.Columns["total_services"].HeaderText = "Общая сумма";
                dataGridView1.Columns["last_trip"].HeaderText = "Последний рейс";
                dataGridView1.Columns["status"].HeaderText = "Статус";
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
            MainForm main = (MainForm)FindForm();
            main.GoBack();
        }
    }
}