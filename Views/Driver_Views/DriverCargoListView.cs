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
    public partial class DriverCargoListView : UserControl
    {
        private int consignmentId;

        public DriverCargoListView(int consignmentId)
        {
            InitializeComponent();

            this.consignmentId = consignmentId;

            LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        c.cargo_id,

                        cn.cn_num AS consignment_note_number,
                        ct.contract_num AS contract_number,

                        c.cargo_name,
                        c.additional_info,
                        c.cargo_сondition,
                        c.package_count,
                        c.marking,
                        c.packaging_type,
                        c.packing_method,
                        c.gross_weight,
                        c.net_weight,
                        c.length,
                        c.width,
                        c.height,
                        c.volume,
                        c.density

                    FROM cargo c

                    LEFT JOIN consignment_note cn
                        ON c.consignment_note_id = cn.consignment_note_id

                    LEFT JOIN contract ct
                        ON c.contract_id = ct.contract_id

                    WHERE c.consignment_note_id = @id";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@id",
                    consignmentId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["cargo_id"].HeaderText = "Идентификатор груза";
                dataGridView1.Columns["cargo_name"].HeaderText = "Наименование груза";
                dataGridView1.Columns["additional_info"].HeaderText = "Доп. информация";
                dataGridView1.Columns["cargo_сondition"].HeaderText = "Состояние груза";
                dataGridView1.Columns["package_count"].HeaderText = "Количество грузовых мест";
                dataGridView1.Columns["marking"].HeaderText = "Маркировка";
                dataGridView1.Columns["packaging_type"].HeaderText = "Тип упаковки";
                dataGridView1.Columns["packing_method"].HeaderText = "Способ упаковки";
                dataGridView1.Columns["gross_weight"].HeaderText = "Масса брутто";
                dataGridView1.Columns["net_weight"].HeaderText = "Масса нетто";
                dataGridView1.Columns["length"].HeaderText = "Длина";
                dataGridView1.Columns["width"].HeaderText = "Ширина";
                dataGridView1.Columns["height"].HeaderText = "Высота";
                dataGridView1.Columns["volume"].HeaderText = "Объем";
                dataGridView1.Columns["density"].HeaderText = "Плотность";

                dataGridView1.Columns["consignment_note_number"].HeaderText = "Номер ТН";
                dataGridView1.Columns["contract_number"].HeaderText = "Номер договора-заявки";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id =
                Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["cargo_id"].Value
                );

            MainForm main =
                (MainForm)FindForm();

            main.NavigateTo(
                new DriverCargoView(id)
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main =
                (MainForm)FindForm();

            main.GoBack();
        }
    }
}
