using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logistic_BD.logistic_BD;
using MySql.Data.MySqlClient;
using static logistic_BD.logistic_BD.DbReaderExtensions;

namespace logistic_BD.Views.Admin_Views
{
    public partial class UserEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;
        private bool isSystem;

        public UserEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();
            this.mode = mode;
            this.id = id;
            this.refresh = refreshAction;
            LoadCombos();

            if (mode == "edit")
                LoadData();
        }

        private void LoadCombos()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                cmbRole.Items.Add("root");
                cmbRole.Items.Add("manager");
                cmbRole.Items.Add("driver");

                chkIsSystem.Enabled = false;

                DataTable workers = new DataTable();
                new MySqlDataAdapter("SELECT NULL AS worker_id, NULL AS full_name UNION SELECT worker_id, full_name FROM worker", conn).Fill(workers);
                cmbWorker.DataSource = workers;
                cmbWorker.DisplayMember = "full_name";
                cmbWorker.ValueMember = "worker_id";

                DataTable drivers = new DataTable();
                new MySqlDataAdapter("SELECT NULL AS driver_id, NULL AS personnel_number UNION SELECT driver_id, personnel_number FROM driver", conn).Fill(drivers);
                cmbDriver.DataSource = drivers;
                cmbDriver.DisplayMember = "personnel_number";
                cmbDriver.ValueMember = "driver_id";
            }
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM user WHERE user_id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = DbSafe.I(reader, "user_id")?.ToString();
                    txtLogin.Text = DbSafe.S(reader, "login");
                    cmbRole.Text = DbSafe.S(reader, "role");

                    if (reader["worker_id"] != DBNull.Value)
                        cmbWorker.SelectedValue = DbSafe.I(reader, "worker_id");

                    if (reader["driver_id"] != DBNull.Value)
                        cmbDriver.SelectedValue = DbSafe.I(reader, "driver_id");

                    isSystem = Convert.ToBoolean(reader["is_system"]);
                    chkIsSystem.Checked = isSystem;
                }
            }

            ApplySystemLock();
        }

        private void ApplySystemLock()
        {
            if (!isSystem)
                return;

            txtLogin.ReadOnly = true;
            txtPassword.ReadOnly = true;
            cmbRole.Enabled = false;
            cmbWorker.Enabled = false;
            cmbDriver.Enabled = false;
            chkIsSystem.Enabled = false;
            btnSave.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ok = DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql;

                    if (mode == "add")
                    {
                        sql = @"
                        INSERT INTO user
                        (
                            login,
                            password_hash,
                            role,
                            worker_id,
                            driver_id,
                            is_system
                        )
                        VALUES
                        (
                            @login,
                            SHA2(@password, 256),
                            @role,
                            @worker,
                            @driver,
                            @system
                        )";
                    }
                    else
                    {
                        sql = @"
                        UPDATE user SET
                            login=@login,
                            role=@role,
                            worker_id=@worker,
                            driver_id=@driver
                        WHERE user_id=@id";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.Parameters.AddWithValue("@worker", cmbWorker.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@driver", cmbDriver.SelectedValue ?? (object)DBNull.Value);

                    if (mode == "add")
                    {
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@system", chkIsSystem.Checked);
                    }

                    if (mode == "edit")
                        cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
            {
                refresh?.Invoke();
                GoBack();
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("user"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
