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
    public partial class CargoToConsignmentView : UserControl
    {
        private int consignmentNoteId;
        private Action refresh;

        public CargoToConsignmentView(int consignmentNoteId, Action refresh)
        {
            InitializeComponent();

            this.consignmentNoteId = consignmentNoteId;
            this.refresh = refresh;

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
                volume
            FROM cargo
            WHERE consignment_note_id IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCargo.DataSource = dt;
            }
        }

        private void CargoToConsignmentView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCargo.CurrentRow == null)
                return;

            int cargoId = Convert.ToInt32(
                dgvCargo.CurrentRow.Cells["cargo_id"].Value
            );

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
            UPDATE cargo
            SET consignment_note_id = @cn_id
            WHERE cargo_id = @cargo_id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cn_id", consignmentNoteId);
                cmd.Parameters.AddWithValue("@cargo_id", cargoId);

                cmd.ExecuteNonQuery();
            }

            LoadFreeCargo();
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.GoBack();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
