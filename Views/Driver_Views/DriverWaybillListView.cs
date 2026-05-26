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

namespace logistic_BD.Views.Driver_Views
{
    public partial class DriverWaybillListView
        : UserControl
    {
        public DriverWaybillListView()
        {
            InitializeComponent();

            LoadWaybills();
        }

        private void LoadWaybills()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
            SELECT *
            FROM waybill
            WHERE driver_id = @driver_id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@driver_id",
                    Session.DriverId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }


        private void DriverWaybillListView_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;


            int id =
            Convert.ToInt32(
                dataGridView1
                .CurrentRow
                .Cells["waybill_id"]
                .Value
            );


            MainForm main =
                (MainForm)this.FindForm();


            main.NavigateTo(new DriverWaybillView(id));
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.GoBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}