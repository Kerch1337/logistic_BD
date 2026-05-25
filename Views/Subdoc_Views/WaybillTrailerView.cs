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

namespace logistic_BD.Views.Subdoc_Views
{
    public partial class WaybillTrailerView : UserControl
    {
        private int waybillId;
        private Action goBack;

        public WaybillTrailerView(int waybillId, Action goBack)
        {
            InitializeComponent();

            this.waybillId = waybillId;
            this.goBack = goBack;

            LoadCombo();
            LoadTrailers();
        }

        private void LoadCombo()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT trailer_id, reg_number FROM trailer";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTrailer.DataSource = dt;
                cmbTrailer.DisplayMember = "trailer_id";
                cmbTrailer.ValueMember = "trailer_id";
            }
        }

        private void LoadTrailers()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
            SELECT
                wt.trailer_id,
                t.reg_number,
                t.brand
            FROM waybill_trailer wt
            JOIN trailer t
                ON wt.trailer_id = t.trailer_id
            WHERE wt.waybill_id = @waybill_id";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@waybill_id",
                    waybillId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTrailers.DataSource = dt;
            }
        }

        private void WaybillTrailerView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string checkSql = @"
            SELECT COUNT(*) 
            FROM waybill_trailer
            WHERE waybill_id = @waybill_id
              AND trailer_id = @trailer_id";

                MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@waybill_id", waybillId);
                checkCmd.Parameters.AddWithValue("@trailer_id", cmbTrailer.SelectedValue);

                long exists = (long)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Этот прицеп уже добавлен");
                    return;
                }

                string sql = @"
            INSERT INTO waybill_trailer (waybill_id, trailer_id)
            VALUES (@waybill_id, @trailer_id)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@waybill_id", waybillId);
                cmd.Parameters.AddWithValue("@trailer_id", cmbTrailer.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
                LoadTrailers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrailers.CurrentRow == null)
                return;

            int trailerId =
                Convert.ToInt32(
                dgvTrailers.CurrentRow
                .Cells["trailer_id"].Value);

            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn =
                    Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        DELETE FROM waybill_trailer
                        WHERE waybill_id=@waybill_id
                        AND trailer_id=@trailer_id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@waybill_id",
                        waybillId);

                    cmd.Parameters.AddWithValue(
                        "@trailer_id",
                        trailerId);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
                LoadTrailers();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            goBack?.Invoke();
        }

        private void btnOpenTrailer_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("trailer")
            );
        }
    }
}
