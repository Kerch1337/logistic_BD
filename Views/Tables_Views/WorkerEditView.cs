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
    public partial class WorkerEditView : UserControl
    {

        private string mode;
        private int id;
        private Action refresh;

        public WorkerEditView(string mode, int id, Action refreshAction)
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

                string sql = "SELECT * FROM worker WHERE worker_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader["worker_id"].ToString();
                    txtFullName.Text = reader["full_name"].ToString();
                    txtPosition.Text = reader["position"].ToString();
                    txtOrgName.Text = reader["org_name"].ToString();
                    txtPhone.Text = reader["phone"].ToString();
                }
            }
        }


        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("worker"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO worker (full_name, position, org_name, phone)
                        VALUES (@full_name, @position, @org_name, @phone)";
                }
                else
                {
                    sql = @"UPDATE worker 
                        SET full_name=@full_name, position=@position,
                            org_name=@org_name, phone=@phone
                        WHERE worker_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@org_name", txtOrgName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

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
