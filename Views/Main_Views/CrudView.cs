using logistic_BD.Views.Doc_Views;
using logistic_BD.Views.Subdoc_Views;
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
    public partial class CrudView : UserControl
    {
        private string tableName;

        private int parentId = 0;

        public CrudView(string table)
        {
            InitializeComponent();
            tableName = table;
            LoadData();
        }

        public CrudView(string table, int parentId)
        {
            InitializeComponent();

            tableName = table;

            this.parentId = parentId;

            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;


                if (tableName == "cargo" && parentId != 0)
                {
                    sql =
                    "SELECT * FROM cargo WHERE contract_id = @id";
                }
                else if (tableName == "cargo_state" && parentId != 0)
                {
                    sql =
                    "SELECT * FROM cargo_state WHERE cargo_id = @id";
                }
                else
                {
                    sql = $"SELECT * FROM {tableName}";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                if (
                    (tableName == "cargo" ||
                     tableName == "cargo_state")
                    && parentId != 0
                )
                {
                    adapter.SelectCommand.Parameters
                        .AddWithValue("@id", parentId);
                }

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        /*private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new MenuView());
        }*/

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.GoBack();
        }

        private UserControl CreateEditView(string mode, int id)
        {
            switch (tableName)
            {
                case "organization":
                    return new OrganizationEditView(mode, id, LoadData);

                case "client":
                    return new ClientEditView(mode, id, LoadData);

                case "vehicle":
                    return new VehicleEditView(mode, id, LoadData);

                case "trailer":
                    return new TrailerEditView(mode, id, LoadData);

                case "driver":
                    return new DriverEditView(mode, id, LoadData);

                case "health_worker":
                    return new HealthWorkerEditView(mode, id, LoadData);

                case "worker":
                    return new WorkerEditView(mode, id, LoadData);

                case "contract":
                    return new ContractEditView(mode, id, LoadData);

                case "cargo":
                    return new CargoEditView(mode, id, parentId, LoadData);

                case "cargo_state":
                    return new CargoStateEditView(mode,id,parentId,LoadData);

                case "waybill":
                    return new WaybillEditView(mode, id, LoadData);

                default:
                    throw new Exception("Unknown table");
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            MainForm main = (MainForm)this.FindForm();

            main.ShowView(CreateEditView("edit", id));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(CreateEditView("add", 0));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show(
                "Удалить запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = $"DELETE FROM {tableName} WHERE {tableName}_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            LoadData();
        }
    }
}
