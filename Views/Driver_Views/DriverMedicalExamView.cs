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
    public partial class DriverMedicalExamView : UserControl
    {
        private int id;

        public DriverMedicalExamView(int id)
        {
            InitializeComponent();

            this.id = id;

            cmbExamType.Items.Add("Предрейсовый");
            cmbExamType.Items.Add("Послерейсовый");

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

                    WHERE me.medical_exam_id = @id
                    AND w.driver_id = @driver";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@driver", Session.DriverId);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "medical_exam_id")?.ToString() ?? "";
                    cmbExamType.Text = DbSafe.S(reader, "exam_type");
                    dtpExamDateTime.Value = Convert.ToDateTime(reader["exam_datetime"]);
                    txtResult.Text = DbSafe.S(reader, "result");
                    txtFullName.Text = DbSafe.S(reader, "full_name");
                    txtPosition.Text = DbSafe.S(reader, "position");
                    txtMedOrgName.Text = DbSafe.S(reader, "med_org_name");
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                {
                    c.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.GoBack();
        }
    }
}
