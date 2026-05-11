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

namespace logistic_BD
{
    public partial class HealthWorkerEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public HealthWorkerEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.refresh = refreshAction;

            if (mode == "edit")
                LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM health_worker WHERE health_worker_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader["health_worker_id"].ToString();
                    txtFullName.Text = reader["full_name"].ToString();
                    txtPosition.Text = reader["position"].ToString();
                    txtMedOrgName.Text = reader["med_org_name"].ToString();
                }
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("health_worker"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO health_worker (full_name, position, med_org_name)
                        VALUES (@full_name, @position, @med_org_name)";
                }
                else
                {
                    sql = @"UPDATE health_worker 
                        SET full_name=@full_name, position=@position, med_org_name=@med_org_name
                        WHERE health_worker_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                cmd.Parameters.AddWithValue("med_org_name", txtMedOrgName.Text);

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
