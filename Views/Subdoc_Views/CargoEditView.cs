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
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Subdoc_Views
{
    public partial class CargoEditView : UserControl
    {

        private string mode;
        private int id;
        private int contractId;
        private Action refresh;

        public CargoEditView(string mode, int id, int contractId, Action refreshAction)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.contractId = contractId;
            this.refresh = refreshAction;

            if (mode == "edit")
                LoadData();
        }

        private void CargoEditView_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM cargo WHERE cargo_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "cargo_id")?.ToString();

                    txtCargoName.Text = DbSafe.S(reader, "cargo_name");

                    txtAdditionalInfo.Text = DbSafe.S(reader, "additional_info");

                    txtCargoCondition.Text = DbSafe.S(reader, "cargo_сondition");

                    txtPackageCount.Text = DbSafe.I(reader, "package_count")?.ToString();

                    txtMarking.Text = DbSafe.S(reader, "marking");

                    txtPackagingType.Text = DbSafe.S(reader, "packaging_type");

                    txtPackingMethod.Text = DbSafe.S(reader, "packing_method");

                    txtGrossWeight.Text = DbSafe.D(reader, "gross_weight")?.ToString() ?? "";

                    txtNetWeight.Text = DbSafe.D(reader, "net_weight")?.ToString() ?? "";

                    txtLength.Text = DbSafe.D(reader, "length")?.ToString() ?? "";

                    txtWidth.Text = DbSafe.D(reader, "width")?.ToString() ?? "";

                    txtHeight.Text = DbSafe.D(reader, "height")?.ToString() ?? "";

                    txtVolume.Text = DbSafe.D(reader, "volume")?.ToString() ?? "";

                    txtDensity.Text = DbSafe.D(reader, "density")?.ToString() ?? "";
                }
            }
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
            INSERT INTO cargo
            (
                contract_id,
                cargo_name,
                additional_info,
                cargo_сondition,
                package_count,
                marking,
                packaging_type,
                packing_method,
                gross_weight,
                net_weight,
                length,
                width,
                height,
                volume,
                density
            )
            VALUES
            (
                @contract_id,
                @cargo_name,
                @additional_info,
                @cargo_condition,
                @package_count,
                @marking,
                @packaging_type,
                @packing_method,
                @gross_weight,
                @net_weight,
                @length,
                @width,
                @height,
                @volume,
                @density
            )";
                }
                else
                {
                    sql = @"
            UPDATE cargo
            SET
                cargo_name=@cargo_name,
                additional_info=@additional_info,
                cargo_сondition=@cargo_condition,
                package_count=@package_count,
                marking=@marking,
                packaging_type=@packaging_type,
                packing_method=@packing_method,
                gross_weight=@gross_weight,
                net_weight=@net_weight,
                length=@length,
                width=@width,
                height=@height,
                volume=@volume,
                density=@density
            WHERE cargo_id=@id";
                }

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue(
                    "@cargo_name",
                    txtCargoName.Text);

                cmd.Parameters.AddWithValue(
                    "@additional_info",
                    string.IsNullOrWhiteSpace(txtAdditionalInfo.Text)
                        ? (object)DBNull.Value
                        : txtAdditionalInfo.Text);

                cmd.Parameters.AddWithValue(
                    "@cargo_condition",
                    string.IsNullOrWhiteSpace(txtCargoCondition.Text)
                        ? (object)DBNull.Value
                        : txtCargoCondition.Text);

                cmd.Parameters.AddWithValue(
                    "@package_count",
                    string.IsNullOrWhiteSpace(txtPackageCount.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txtPackageCount.Text));

                cmd.Parameters.AddWithValue(
                    "@marking",
                    string.IsNullOrWhiteSpace(txtMarking.Text)
                        ? (object)DBNull.Value
                        : txtMarking.Text);

                cmd.Parameters.AddWithValue(
                    "@packaging_type",
                    string.IsNullOrWhiteSpace(txtPackagingType.Text)
                        ? (object)DBNull.Value
                        : txtPackagingType.Text);

                cmd.Parameters.AddWithValue(
                    "@packing_method",
                    string.IsNullOrWhiteSpace(txtPackingMethod.Text)
                        ? (object)DBNull.Value
                        : txtPackingMethod.Text);

                cmd.Parameters.AddWithValue(
                    "@gross_weight",
                    Convert.ToDecimal(txtGrossWeight.Text));

                cmd.Parameters.AddWithValue(
                    "@net_weight",
                    string.IsNullOrWhiteSpace(txtNetWeight.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtNetWeight.Text));

                cmd.Parameters.AddWithValue(
                    "@length",
                    string.IsNullOrWhiteSpace(txtLength.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtLength.Text));

                cmd.Parameters.AddWithValue(
                    "@width",
                    string.IsNullOrWhiteSpace(txtWidth.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtWidth.Text));

                cmd.Parameters.AddWithValue(
                    "@height",
                    string.IsNullOrWhiteSpace(txtHeight.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtHeight.Text));

                cmd.Parameters.AddWithValue(
                    "@volume",
                    Convert.ToDecimal(txtVolume.Text));

                cmd.Parameters.AddWithValue(
                    "@density",
                    string.IsNullOrWhiteSpace(txtDensity.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtDensity.Text));


                if (mode == "add")
                {
                    cmd.Parameters.AddWithValue(
                        "@contract_id",
                        contractId);
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

        /*private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("contract"));
        }*/

        private void GoBack()
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.GoBack();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }


        private void btnCargoState_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                MessageBox.Show(
                    "Сначала сохраните груз"
                );

                return;
            }

            MainForm main =
                (MainForm)this.FindForm();

            main.NavigateTo(
                new CrudView("cargo_state", id)
            );
        }
    }
}
