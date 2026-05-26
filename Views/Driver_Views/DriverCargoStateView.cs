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
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverCargoStateView : UserControl
    {
        private int cargoStateId;

        public DriverCargoStateView(int cargoStateId)
        {
            InitializeComponent();
            this.cargoStateId = cargoStateId;
            cmbStateType.Items.Add("Прием");
            cmbStateType.Items.Add("Выдача");
            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM cargo_state WHERE cargo_state_id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cargoStateId);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "cargo_state_id")?.ToString() ?? "";
                    cmbStateType.Text = DbSafe.S(reader, "state_type");
                    txtActualState.Text = DbSafe.S(reader, "actual_state");
                    txtActualPackageCount.Text = DbSafe.I(reader, "actual_package_count")?.ToString() ?? "";
                    txtActualGrossWeight.Text = DbSafe.D(reader, "actual_gross_weight")?.ToString() ?? "";
                    txtActualNetWeight.Text = DbSafe.D(reader, "actual_net_weight")?.ToString() ?? "";
                    txtActualDensity.Text = DbSafe.D(reader, "actual_density")?.ToString() ?? "";
                    txtRemarks.Text = DbSafe.S(reader, "remarks");
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.GoBack();
        }
    }
}
