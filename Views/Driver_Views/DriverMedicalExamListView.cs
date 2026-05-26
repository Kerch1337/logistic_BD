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
                        me.*,
                        hw.full_name,
                        hw.position,
                        hw.med_org_name
                    FROM medical_exam me
                    LEFT JOIN health_worker hw
                        ON me.health_worker_id =
                           hw.health_worker_id
                    JOIN waybill w
                        ON me.waybill_id =
                           w.waybill_id
                    WHERE me.waybill_id = @id
                    AND w.driver_id = @driver";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", waybillId);
                da.SelectCommand.Parameters.AddWithValue("@driver", Session.DriverId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
