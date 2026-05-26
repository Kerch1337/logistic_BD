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
    public partial class DriverOrganizationView : UserControl
    {
        private int organizationId;

        public DriverOrganizationView(int organizationId)
        {
            InitializeComponent();

            this.organizationId = organizationId;

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM organization WHERE organization_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", organizationId);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "organization_id")?.ToString() ?? "";
                    txtInn.Text = DbSafe.S(reader, "inn");
                    txtName.Text = DbSafe.S(reader, "name");
                    txtAddress.Text = DbSafe.S(reader, "address");
                    txtPhone.Text = DbSafe.S(reader, "phone");
                }
            }
        }

        private void DisableEditing()
        {
            foreach (Control c in Controls)
                if (c is TextBox tb)
                    tb.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }
    }
}
