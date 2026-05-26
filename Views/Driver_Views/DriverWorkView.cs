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

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverWorkView : UserControl
    {
        private int id;

        public DriverWorkView(int id)
        {
            InitializeComponent();
            this.id = id;


            cmbWorkType.Items.Add("Выезд");
            cmbWorkType.Items.Add("Возвращение");
            cmbWorkType.Items.Add("Прием-сдача");

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        d.*,
                        w.full_name,
                        w.position,
                        w.org_name,
                        w.phone
                    FROM driver_vehicle_work d
                    LEFT JOIN worker w 
                        ON d.authorized_person_id = w.worker_id
                    WHERE d.work_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "work_id")?.ToString() ?? "";
                    cmbWorkType.Text = DbSafe.S(reader, "work_type");

                    if (reader["scheduled_date"] != DBNull.Value)
                        dtpScheduledDate.Value = Convert.ToDateTime(reader["scheduled_date"]);

                    if (reader["scheduled_time"] != DBNull.Value)
                        dtpScheduledTime.Value = DateTime.Today.Add((TimeSpan)reader["scheduled_time"]);

                    dtpActualDate.Value = Convert.ToDateTime(reader["actual_date"]);
                    dtpActualTime.Value = DateTime.Today.Add((TimeSpan)reader["actual_time"]);

                    txtZeroRun.Text = DbSafe.I(reader, "zero_run")?.ToString() ?? "";
                    txtOdometer.Text = DbSafe.I(reader, "odometer_reading")?.ToString() ?? "";

                    txtFullName.Text = DbSafe.S(reader, "full_name");
                    txtPosition.Text = DbSafe.S(reader, "position");
                    txtOrgName.Text = DbSafe.S(reader, "org_name");
                    txtPhone.Text = DbSafe.S(reader, "phone");
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is ComboBox || control is DateTimePicker)
                    control.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }

        private void DriverWorkView_Load(object sender, EventArgs e)
        {

        }
    }
}
