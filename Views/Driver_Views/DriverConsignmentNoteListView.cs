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
                        cn.consignment_note_id,
                        cn.cn_num,
                        cn.cn_date,

                        wb.wb_number,

                        consignee.org_name AS consignee_org_name,
                        consignee.last_name AS consignee_last_name,
                        consignee.first_name AS consignee_first_name,
                        consignee.patronymic AS consignee_patronymic,

                        shipper.org_name AS shipper_org_name,
                        shipper.last_name AS shipper_last_name,
                        shipper.first_name AS shipper_first_name,
                        shipper.patronymic AS shipper_patronymic,

                        carrier.name AS carrier_name,

                        loading_owner.name AS loading_point_owner_name,

                        loader.full_name AS loader_person,

                        cn.loading_adress,
                        cn.actual_loading_date,
                        cn.stated_loading_date,
                        cn.actual_departure_date_load,

                        cn.unloading_adress,
                        cn.actual_unloading_date,
                        cn.stated_unloading_date,
                        cn.actual_departure_date_unload,

                        representative.full_name AS carriers_representative

                    FROM consignment_note cn

                    JOIN waybill wb
                        ON cn.waybill_id = wb.waybill_id

                    LEFT JOIN client consignee
                        ON cn.consignee_id = consignee.client_id

                    LEFT JOIN client shipper
                        ON cn.shipper_id = shipper.client_id

                    LEFT JOIN organization carrier
                        ON cn.carrier_id = carrier.organization_id

                    LEFT JOIN organization loading_owner
                        ON cn.loading_point_owner_id = loading_owner.organization_id

                    LEFT JOIN worker loader
                        ON cn.loader_person_id = loader.worker_id

                    LEFT JOIN worker representative
                        ON cn.carriers_representative_id = representative.worker_id

                    WHERE wb.driver_id = @driver";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@driver",
                    Session.DriverId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["consignment_note_id"].HeaderText = "Идентификатор ТН";
                dataGridView1.Columns["cn_num"].HeaderText = "Номер ТН";
                dataGridView1.Columns["cn_date"].HeaderText = "Дата составления";
                dataGridView1.Columns["wb_number"].HeaderText = "Номер ПЛ";

                dataGridView1.Columns["consignee_org_name"].HeaderText = "Организация грузополучателя";
                dataGridView1.Columns["consignee_last_name"].HeaderText = "Фамилия грузополучателя";
                dataGridView1.Columns["consignee_first_name"].HeaderText = "Имя грузополучателя";
                dataGridView1.Columns["consignee_patronymic"].HeaderText = "Отчество грузополучателя";

                dataGridView1.Columns["shipper_org_name"].HeaderText = "Организация грузоотправителя";
                dataGridView1.Columns["shipper_last_name"].HeaderText = "Фамилия грузоотправителя";
                dataGridView1.Columns["shipper_first_name"].HeaderText = "Имя грузоотправителя";
                dataGridView1.Columns["shipper_patronymic"].HeaderText = "Отчество грузоотправителя";

                dataGridView1.Columns["carrier_name"].HeaderText = "Наименование перевозчика";

                dataGridView1.Columns["loading_point_owner_name"].HeaderText = "Владелец точки загрузки";

                dataGridView1.Columns["loader_person"].HeaderText = "Контактное лицо загрузки";

                dataGridView1.Columns["loading_adress"].HeaderText = "Адрес загрузки";
                dataGridView1.Columns["actual_loading_date"].HeaderText = "Фактическая дата загрузки";
                dataGridView1.Columns["stated_loading_date"].HeaderText = "Запланированная дата загрузки";
                dataGridView1.Columns["actual_departure_date_load"].HeaderText = "Фактическая дата отбытия (загрузка)";

                dataGridView1.Columns["unloading_adress"].HeaderText = "Адрес разгрузки";
                dataGridView1.Columns["actual_unloading_date"].HeaderText = "Фактическая дата разгрузки";
                dataGridView1.Columns["stated_unloading_date"].HeaderText = "Запланированная дата разгрузки";
                dataGridView1.Columns["actual_departure_date_unload"].HeaderText = "Фактическая дата отбытия (разгрузки)";

                dataGridView1.Columns["carriers_representative"].HeaderText = "Представитель перевлзчика";
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
