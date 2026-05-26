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
    public partial class DriverTrailerView : UserControl
    {
        private int trailerId;

        public DriverTrailerView(int trailerId)
        {
            InitializeComponent();
            this.trailerId = trailerId;

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM trailer WHERE trailer_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", trailerId);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "trailer_id")?.ToString() ?? "";
                    txtBrand.Text = DbSafe.S(reader, "brand");
                    txtRegNumber.Text = DbSafe.S(reader, "reg_number");
                    txtParkingPlace.Text = DbSafe.S(reader, "parking_place");
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
                if (c is TextBox) c.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }
    }
}
