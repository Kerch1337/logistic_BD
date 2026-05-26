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
    public partial class DriverClientView : UserControl
    {
        private int clientId;

        public DriverClientView(int clientId)
        {
            InitializeComponent();

            this.clientId = clientId;

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM client WHERE client_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", clientId);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "client_id")?.ToString() ?? "";
                    txtInn.Text = DbSafe.S(reader, "inn");
                    txtOrgName.Text = DbSafe.S(reader, "org_name");
                    txtAddress.Text = DbSafe.S(reader, "address");
                    txtPhone.Text = DbSafe.S(reader, "phone");

                    txtLN.Text = DbSafe.S(reader, "first_name");
                    txtFN.Text = DbSafe.S(reader, "last_name");
                    txtPatr.Text = DbSafe.S(reader, "patronymic");
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
