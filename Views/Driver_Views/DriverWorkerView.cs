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
    public partial class DriverWorkerView : UserControl
    {
        private int workerId;


        public DriverWorkerView(int workerId)
        {
            InitializeComponent();

            this.workerId = workerId;

            LoadData();
            DisableEditing();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM worker WHERE worker_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", workerId);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "worker_id")?.ToString() ?? "";
                    txtFullName.Text = DbSafe.S(reader, "full_name");
                    txtPosition.Text = DbSafe.S(reader, "position");
                    txtOrgName.Text = DbSafe.S(reader, "org_name");
                    txtPhone.Text = DbSafe.S(reader, "phone");
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



        private void DriverWorkerView_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.GoBack();
        }
    }
}
