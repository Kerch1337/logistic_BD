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
    public partial class DriverConsignmentNoteListView : UserControl
    {
        public DriverConsignmentNoteListView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        cn.*
                    FROM consignment_note cn
                    JOIN waybill w
                        ON cn.waybill_id =
                           w.waybill_id
                    WHERE w.driver_id = @driver";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@driver",
                    Session.DriverId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id =
                Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells[
                        "consignment_note_id"
                    ].Value
                );

            MainForm main =
                (MainForm)this.FindForm();

            main.NavigateTo(
                new DriverConsignmentNoteView(id)
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main =
                (MainForm)this.FindForm();

            main.GoBack();
        }
    }
}
