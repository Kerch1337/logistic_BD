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
        public CrudView(string table)
        {
            InitializeComponent();
            tableName = table;
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = $"SELECT * FROM {tableName}";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new MenuView());
        }

        private UserControl CreateEditView(string mode, int id)
        {
            switch (tableName)
            {
                case "organization":
                    return new OrganizationEditView(mode, id, LoadData);

                /*case "driver":
                    return new DriverEditView(mode, id, LoadData);

                case "client":
                    return new ClientEditView(mode, id, LoadData);*/

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
