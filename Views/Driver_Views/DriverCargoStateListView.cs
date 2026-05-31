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

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverCargoStateListView : UserControl
    {
        private int cargoId;

        public DriverCargoStateListView(int cargoId)
        {
            InitializeComponent();
            this.cargoId = cargoId;
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT *
                    FROM cargo_state
                    WHERE cargo_id = @id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", cargoId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["cargo_state_id"].HeaderText = "Идентификатор состояния груза";
                dataGridView1.Columns["cargo_id"].HeaderText = "Идентификатор груза";
                dataGridView1.Columns["state_type"].HeaderText = "Тип состояния";
                dataGridView1.Columns["actual_state"].HeaderText = "Фактическое состояние";
                dataGridView1.Columns["actual_package_count"].HeaderText = "Фактическое количество грузовых мест";
                dataGridView1.Columns["actual_gross_weight"].HeaderText = "Фактическая масса брутто";
                dataGridView1.Columns["actual_net_weight"].HeaderText = "Фактическая масса нетто";
                dataGridView1.Columns["actual_density"].HeaderText = "Фактическая плотность";
                dataGridView1.Columns["remarks"].HeaderText = "Замечания";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["cargo_state_id"].Value);
            MainForm main = (MainForm)FindForm();
            main.NavigateTo(new DriverCargoStateView(id));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)FindForm();
            main.GoBack();
        }
    }
}
