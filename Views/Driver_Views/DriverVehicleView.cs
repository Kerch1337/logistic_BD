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
    public partial class DriverVehicleView : UserControl
    {
        private int waybillId;

        public DriverVehicleView(int waybillId)
        {
            InitializeComponent();

            this.waybillId = waybillId;

            LoadOwnershipTypes();

            LoadData();
            DisableEditing();
        }

        private void LoadOwnershipTypes()
        {
            cmbOwnership.Items.AddRange(new string[]
            {
                "Собственность",
                "Совместная собственность супругов",
                "Аренда",
                "Лизинг",
                "Безвозмездное пользование"
            });
        }


        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT v.*
                    FROM vehicle v
                    JOIN waybill w
                        ON v.vehicle_id = w.vehicle_id
                    WHERE w.waybill_id = @id
                    AND w.driver_id = @driver_id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    waybillId);

                cmd.Parameters.AddWithValue(
                    "@driver_id",
                    Session.DriverId);

                var reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text =
                        DbSafe.I(reader, "vehicle_id")
                        ?.ToString() ?? "";

                    txtRegNumber.Text =
                        DbSafe.S(reader, "reg_number");

                    txtType.Text =
                        DbSafe.S(reader, "type");

                    txtBrand.Text =
                        DbSafe.S(reader, "brand");

                    txtModel.Text =
                        DbSafe.S(reader, "model");

                    txtCapacity.Text =
                        DbSafe.D(reader, "capacity")
                        ?.ToString() ?? "";

                    txtLoadCapacity.Text =
                        DbSafe.D(reader, "load_capacity")
                        ?.ToString() ?? "";

                    cmbOwnership.SelectedItem =
                        DbSafe.S(reader, "ownership_type");
                }
            }
        }



        private void DisableEditing()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Enabled = false;
                }
            }
        }




        private void DriverVehicleView_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }

    }
}