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
    public partial class DriverWorkListView : UserControl
    {
        private int waybillId;

        public DriverWorkListView(int waybillId)
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
                        d.*,
                        w.full_name AS authorized_person
                    FROM driver_vehicle_work d
                    LEFT JOIN worker w
                        ON d.authorized_person_id =
                           w.worker_id
                    JOIN waybill wb
                        ON d.waybill_id =
                           wb.waybill_id
                    WHERE d.waybill_id=@id
                    AND wb.driver_id=@driver_id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", waybillId);

                cmd.Parameters.AddWithValue("@driver_id",Session.DriverId);

                DataTable dt =
                    new DataTable();

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridView1.DataSource =
                    dt;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int workId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["work_id"].Value);
            MainForm main = (MainForm)this.FindForm();
            main.NavigateTo(new DriverWorkView(workId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }

        private void DriverWorkListView_Load(object sender, EventArgs e)
        {

        }
    }
}