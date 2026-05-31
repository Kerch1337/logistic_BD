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

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverMedicalExamListView : UserControl
    {
        private int waybillId;

        public DriverMedicalExamListView(int waybillId)
        {
            InitializeComponent();
            this.waybillId = waybillId;
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                    me.medical_exam_id,
                    me.exam_type,
                    me.exam_datetime,
                    me.result,

                    wb.wb_number,

                    hw.full_name AS health_worker_full_name,
                    hw.position AS health_worker_position,
                    hw.med_org_name AS health_worker_org

                FROM medical_exam me

                LEFT JOIN health_worker hw
                    ON me.health_worker_id = hw.health_worker_id

                JOIN waybill wb
                    ON me.waybill_id = wb.waybill_id

                WHERE me.waybill_id = @id
                  AND wb.driver_id = @driver";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", waybillId);
                da.SelectCommand.Parameters.AddWithValue("@driver", Session.DriverId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["medical_exam_id"].HeaderText = "Идентификатор медосмотра";
                dataGridView1.Columns["wb_number"].HeaderText = "Номер ПЛ";
                dataGridView1.Columns["exam_type"].HeaderText = "Тип медосмотра";
                dataGridView1.Columns["exam_datetime"].HeaderText = "Дата медосмотра";
                dataGridView1.Columns["result"].HeaderText = "Результат";

                dataGridView1.Columns["health_worker_full_name"].HeaderText = "ФИО медработника";
                dataGridView1.Columns["health_worker_position"].HeaderText = "Должность медработника";
                dataGridView1.Columns["health_worker_org"].HeaderText = "Организация медработника";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["medical_exam_id"].Value);
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverMedicalExamView(id));
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
