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
    public partial class CargoToConsignmentView
        : UserControl
    {
        private int consignmentNoteId;
        private Action refresh;

        public CargoToConsignmentView(
            int consignmentNoteId,
            Action refresh)
        {
            InitializeComponent();

            this.consignmentNoteId =
                consignmentNoteId;

            this.refresh =
                refresh;

            LoadFreeCargo();
        }


        private void LoadFreeCargo()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        cargo_id,
                        cargo_name,
                        gross_weight,
                        volume,
                        consignment_note_id
                    FROM cargo
                    WHERE consignment_note_id IS NULL
                       OR consignment_note_id = @cn_id";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@cn_id",
                    consignmentNoteId);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvCargo.DataSource = dt;

                dgvCargo.Columns["cargo_id"].HeaderText = "Идентификатор груза";
                dgvCargo.Columns["cargo_name"].HeaderText = "Наименование груза";
                dgvCargo.Columns["gross_weight"].HeaderText = "Вес груза (брутто)";
                dgvCargo.Columns["volume"].HeaderText = "Объем";
                dgvCargo.Columns["consignment_note_id"].HeaderText = "Идентификатор ТН";
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCargo.CurrentRow == null)
                return;

            int cargoId =
                Convert.ToInt32(
                dgvCargo.CurrentRow.Cells["cargo_id"].Value);

            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE cargo
                        SET consignment_note_id = @cn_id
                        WHERE cargo_id = @cargo_id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@cn_id",
                        consignmentNoteId);

                    cmd.Parameters.AddWithValue(
                        "@cargo_id",
                        cargoId);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
                LoadFreeCargo();
        }


        private void GoBack()
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.GoBack();
        }


        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            GoBack();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCargo.CurrentRow == null)
                return;

            int cargoId =
                Convert.ToInt32(
                dgvCargo.CurrentRow.Cells["cargo_id"].Value);

            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE cargo
                        SET consignment_note_id = NULL
                        WHERE cargo_id = @cargo_id
                        AND consignment_note_id = @cn_id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@cargo_id",
                        cargoId);

                    cmd.Parameters.AddWithValue(
                        "@cn_id",
                        consignmentNoteId);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
                LoadFreeCargo();
        }

        private void CargoToConsignmentView_Load(object sender, EventArgs e) { }
    }
}