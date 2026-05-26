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
    public partial class DriverCargoView : UserControl
    {
        private int cargoId;

        public DriverCargoView(int cargoId)
        {
            InitializeComponent();
            this.cargoId = cargoId;
            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM cargo WHERE cargo_id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cargoId);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "cargo_id")?.ToString() ?? "";
                    txtCargoName.Text = DbSafe.S(reader, "cargo_name");
                    txtAdditionalInfo.Text = DbSafe.S(reader, "additional_info");
                    txtCargoCondition.Text = DbSafe.S(reader, "cargo_сondition");
                    txtPackageCount.Text = DbSafe.I(reader, "package_count")?.ToString() ?? "";
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

        private void DisableEditing()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Enabled = false;
            }
        }

        private void btnCargoState_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverCargoStateListView(cargoId));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.GoBack();
        }
    }
}