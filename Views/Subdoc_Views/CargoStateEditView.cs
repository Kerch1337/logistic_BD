using logistic_BD.logistic_BD;
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
    public partial class CargoStateEditView : UserControl
    {
        private string mode;
        private int id;
        private int cargoId;
        private Action refresh;


        public CargoStateEditView(string mode,int id,int cargoId,Action refreshAction)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.cargoId = cargoId;
            this.refresh = refreshAction;

            cmbStateType.Items.Add("Прием");
            cmbStateType.Items.Add("Выдача");

            if (mode == "edit")
                LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM cargo_state WHERE cargo_state_id = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        reader.GetInt("cargo_state_id")?.ToString();

                    cmbStateType.SelectedItem =
                        reader.GetString("state_type");

                    txtActualState.Text =
                        reader["actual_state"] == DBNull.Value
                            ? ""
                            : reader["actual_state"].ToString();

                    txtActualPackageCount.Text =
                        reader.GetInt("actual_package_count")?.ToString();

                    txtActualGrossWeight.Text =
                        reader["actual_gross_weight"] == DBNull.Value
                            ? ""
                            : Convert.ToDecimal(reader["actual_gross_weight"]).ToString();

                    txtActualGrossWeight.Text =
                        reader["actual_net_weight"] == DBNull.Value
                            ? ""
                            : Convert.ToDecimal(reader["actual_net_weight"]).ToString();

                    txtActualGrossWeight.Text =
                        reader["actual_density"] == DBNull.Value
                            ? ""
                            : Convert.ToDecimal(reader["actual_density"]).ToString();

                    txtActualState.Text =
                        reader["remarks"] == DBNull.Value
                            ? ""
                            : reader["remarks"].ToString();
                }
            }
        }

        private void GoBack()
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.GoBack();
        }


        private void btnCancel_Click(object sender,EventArgs e)
        {
            GoBack();
        }


        private void btnSave_Click(object sender,EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"
            INSERT INTO cargo_state
            (
                cargo_id,
                state_type,
                actual_state,
                actual_package_count,
                actual_gross_weight,
                actual_net_weight,
                actual_density,
                remarks
            )
            VALUES
            (
                @cargo_id,
                @state_type,
                @actual_state,
                @actual_package_count,
                @actual_gross_weight,
                @actual_net_weight,
                @actual_density,
                @remarks
            )";
                }
                else
                {
                    sql = @"
            UPDATE cargo_state
            SET
                state_type=@state_type,
                actual_state=@actual_state,
                actual_package_count=@actual_package_count,
                actual_gross_weight=@actual_gross_weight,
                actual_net_weight=@actual_net_weight,
                actual_density=@actual_density,
                remarks=@remarks
            WHERE cargo_state_id=@id";
                }

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@state_type",
                    cmbStateType.Text);

                cmd.Parameters.AddWithValue(
                    "@actual_state",
                    string.IsNullOrWhiteSpace(txtActualState.Text)
                        ? (object)DBNull.Value
                        : txtActualState.Text);

                cmd.Parameters.AddWithValue(
                    "@actual_package_count",
                    string.IsNullOrWhiteSpace(txtActualPackageCount.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txtActualPackageCount.Text));

                cmd.Parameters.AddWithValue(
                    "@actual_gross_weight",
                    string.IsNullOrWhiteSpace(txtActualGrossWeight.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtActualGrossWeight.Text));

                cmd.Parameters.AddWithValue(
                    "@actual_net_weight",
                    string.IsNullOrWhiteSpace(txtActualNetWeight.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtActualNetWeight.Text));

                cmd.Parameters.AddWithValue(
                    "@actual_density",
                    string.IsNullOrWhiteSpace(txtActualDensity.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtActualDensity.Text));

                cmd.Parameters.AddWithValue(
                    "@remarks",
                    string.IsNullOrWhiteSpace(txtRemarks.Text)
                        ? (object)DBNull.Value
                        : txtRemarks.Text);

                if (mode == "add")
                {
                    cmd.Parameters.AddWithValue(
                        "@cargo_id",
                        cargoId);
                }

                if (mode == "edit")
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        id);
                }

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();

            GoBack();
        }
    }
}
