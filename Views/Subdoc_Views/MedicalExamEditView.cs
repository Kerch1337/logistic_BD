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

namespace logistic_BD.Views.Subdoc_Views
{
    public partial class MedicalExamEditView : UserControl
    {
        private string mode;
        private int id;
        private int waybillId;
        private Action refresh;

        public MedicalExamEditView(string mode, int id, int waybillId, Action refresh)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.waybillId = waybillId;
            this.refresh = refresh;

            cmbExamType.Items.Add("Предрейсовый");
            cmbExamType.Items.Add("Послерейсовый");

            LoadCombos();

            if (mode == "edit")
                LoadData();
        }

        private void LoadCombos()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                MySqlDataAdapter da =
                    new MySqlDataAdapter(
                        "SELECT health_worker_id FROM health_worker",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbHealthWorker.DataSource = dt;

                cmbHealthWorker.ValueMember =
                    "health_worker_id";

                cmbHealthWorker.DisplayMember =
                    "health_worker_id";
            }
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM medical_exam WHERE medical_exam_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "medical_exam_id")?.ToString() ?? "";

                    cmbExamType.Text =
                        DbSafe.S(reader, "exam_type");

                    dtpExamDateTime.Value =
                        Convert.ToDateTime(reader["exam_datetime"]);

                    txtResult.Text =
                        DbSafe.S(reader, "result");

                    if (reader["health_worker_id"] != DBNull.Value)
                    {
                        cmbHealthWorker.SelectedValue =
                            Convert.ToInt32(reader["health_worker_id"]);
                    }
                }
            }
        }

        private void MedicalExamEditView_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"
                INSERT INTO medical_exam
                (
                    waybill_id,
                    exam_type,
                    exam_datetime,
                    result,
                    health_worker_id
                )
                VALUES
                (
                    @waybill_id,
                    @exam_type,
                    @exam_datetime,
                    @result,
                    @health_worker_id
                )";
                }
                else
                {
                    sql = @"
                UPDATE medical_exam SET
                    exam_type = @exam_type,
                    exam_datetime = @exam_datetime,
                    result = @result,
                    health_worker_id = @health_worker_id
                WHERE medical_exam_id = @id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@exam_type",
                    cmbExamType.Text
                );

                cmd.Parameters.AddWithValue(
                    "@exam_datetime",
                    dtpExamDateTime.Value
                );

                cmd.Parameters.AddWithValue(
                    "@result",
                    string.IsNullOrWhiteSpace(txtResult.Text)
                        ? (object)DBNull.Value
                        : txtResult.Text
                );

                cmd.Parameters.AddWithValue(
                    "@health_worker_id",
                    cmbHealthWorker.SelectedValue == null
                        ? (object)DBNull.Value
                        : cmbHealthWorker.SelectedValue
                );

                if (mode == "add")
                {
                    cmd.Parameters.AddWithValue(
                        "@waybill_id",
                        waybillId
                    );
                }

                if (mode == "edit")
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        id
                    );
                }

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("medical_exam", waybillId));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void btnOpenHealthWorker_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("health_worker")
            );
        }
    }
}
