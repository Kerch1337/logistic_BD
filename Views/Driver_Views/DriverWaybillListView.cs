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
                SELECT
                    w.waybill_id,
                    w.wb_number,
                    w.wb_date,
                    w.effective_date_from,
                    w.effective_date_untill,
                    w.transportation_type,
                    w.message_type,
                    w.arrival_time,
                    w.departure_time,
                    w.pre_trip_inspection_date,
                    w.pre_trip_inspection_time,

                    person.full_name AS person_filling_out,
                    mechanic.full_name AS mechanic,
                    controller.full_name AS vehicle_condition_controller,

                    v.reg_number AS vehicle_reg_number,
                    v.brand AS vehicle_brand,

                    d.personnel_number,
                    d.last_name AS driver_last_name,
                    d.first_name AS driver_first_name,
                    d.patronymic AS driver_patronymic,

                    org.name AS organization_filling_out,

                    c.org_name AS customer_org_name,
                    c.last_name AS customer_last_name,
                    c.first_name AS customer_first_name,
                    c.patronymic AS customer_patronymic

                FROM waybill w

                LEFT JOIN worker person
                    ON w.person_filling_out_id = person.worker_id

                LEFT JOIN worker mechanic
                    ON w.mechanic_id = mechanic.worker_id

                LEFT JOIN worker controller
                    ON w.vehicle_condition_controller_id = controller.worker_id

                LEFT JOIN vehicle v
                    ON w.vehicle_id = v.vehicle_id

                LEFT JOIN driver d
                    ON w.driver_id = d.driver_id

                LEFT JOIN organization org
                    ON w.organization_filling_out_id = org.organization_id

                LEFT JOIN client c
                    ON w.customer_id = c.client_id

                WHERE w.driver_id = @driver_id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@driver_id",
                    Session.DriverId
                );

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["waybill_id"].HeaderText = "Идентификатор";
                dataGridView1.Columns["wb_number"].HeaderText = "Номер ПЛ";
                dataGridView1.Columns["wb_date"].HeaderText = "Дата составления";
                dataGridView1.Columns["effective_date_from"].HeaderText = "Действителен с";
                dataGridView1.Columns["effective_date_untill"].HeaderText = "Действителен до";
                dataGridView1.Columns["transportation_type"].HeaderText = "Вид перевозки";
                dataGridView1.Columns["message_type"].HeaderText = "Вид сообщения";
                dataGridView1.Columns["arrival_time"].HeaderText = "Время прибытия";
                dataGridView1.Columns["departure_time"].HeaderText = "Время убытия";
                dataGridView1.Columns["pre_trip_inspection_date"].HeaderText = "Дата предрейсового контроля";
                dataGridView1.Columns["pre_trip_inspection_time"].HeaderText = "Время предрейсового контроля";

                dataGridView1.Columns["person_filling_out"].HeaderText = "ФИО лица, запол. ПЛ";

                dataGridView1.Columns["mechanic"].HeaderText = "ФИО механика";

                dataGridView1.Columns["vehicle_condition_controller"].HeaderText = "ФИО контроллера тех. состояния";

                dataGridView1.Columns["vehicle_reg_number"].HeaderText = "Рег. номер ТС";
                dataGridView1.Columns["vehicle_brand"].HeaderText = "Марка ТС";

                dataGridView1.Columns["personnel_number"].HeaderText = "Персональный номер водителя";
                dataGridView1.Columns["driver_last_name"].HeaderText = "Фамилия водителя";
                dataGridView1.Columns["driver_first_name"].HeaderText = "Имя водителя";
                dataGridView1.Columns["driver_patronymic"].HeaderText = "Отчество водителя";

                dataGridView1.Columns["organization_filling_out"].HeaderText = "Организация, запол. ПЛ";

                dataGridView1.Columns["customer_org_name"].HeaderText = "Организация заказчика";
                dataGridView1.Columns["customer_last_name"].HeaderText = "Фамилия заказчика";
                dataGridView1.Columns["customer_first_name"].HeaderText = "Имя заказчика";
                dataGridView1.Columns["customer_patronymic"].HeaderText = "Отчество заказчика";
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