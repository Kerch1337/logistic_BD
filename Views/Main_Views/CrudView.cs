using logistic_BD.Views.Admin_Views;
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
                    sql = @"
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

                        WHERE c.contract_id = @id";
                }
                else if (tableName == "medical_exam" && parentId != 0)
                {
                    sql = @"
                    SELECT
                        me.medical_exam_id,
                        me.exam_type,
                        me.exam_datetime,
                        me.result,

                        wb.wb_number,

                        hw.full_name AS health_worker_full_name,
                        hw.position AS health_worker_position,
                        hw.med_org_name AS health_worker_org

                    FROM medical_exam me

                    LEFT JOIN waybill wb
                        ON me.waybill_id = wb.waybill_id

                    LEFT JOIN health_worker hw
                        ON me.health_worker_id = hw.health_worker_id

                    WHERE me.waybill_id = @id";
                }
                else if (tableName == "driver_vehicle_work" && parentId != 0)
                {
                    sql = @"
                    SELECT
                        d.work_id,
                        d.work_type,
                        d.scheduled_date,
                        d.scheduled_time,
                        d.actual_date,
                        d.actual_time,
                        d.zero_run,
                        d.odometer_reading,

                        wb.wb_number,

                        w.full_name AS authorized_person,
                        w.position AS authorized_person_position

                    FROM driver_vehicle_work d

                    LEFT JOIN worker w
                        ON d.authorized_person_id = w.worker_id

                    LEFT JOIN waybill wb
                        ON d.waybill_id = wb.waybill_id
                    WHERE d.waybill_id = @id";
                }
                else if (tableName == "contract")
                {
                    sql = @"
                    SELECT
                        c.contract_id,
                        c.contract_num,
                        c.contract_date,

                        cust.org_name AS customer_org,
                        cust.last_name AS customer_last_name,
                        cust.first_name AS customer_first_name,
                        cust.patronymic AS customer_patronymic,

                        cons.org_name AS consignee_org,
                        cons.last_name AS consignee_last_name,
                        cons.first_name AS consignee_first_name,
                        cons.patronymic AS consignee_patronymic,

                        ship.org_name AS shipper_org,
                        ship.last_name AS shipper_last_name,
                        ship.first_name AS shipper_first_name,
                        ship.patronymic AS shipper_patronymic,

                        org.name AS organization,
                        perf.name AS performer,

                        c.loading_address,
                        c.loading_time,
                        loadw.full_name AS loading_contact,

                        c.unloading_address,
                        c.unloading_time,
                        unloadw.full_name AS unloading_contact,

                        c.cost_services,
                        c.payment_terms

                        FROM contract c
                        LEFT JOIN client cust ON c.customer_id = cust.client_id
                        LEFT JOIN client cons ON c.consignee_id = cons.client_id
                        LEFT JOIN client ship ON c.shipper_id = ship.client_id
                        LEFT JOIN organization org ON c.organization_id = org.organization_id
                        LEFT JOIN organization perf ON c.performer_id = perf.organization_id
                        LEFT JOIN worker loadw ON c.loading_contact_id = loadw.worker_id
                        LEFT JOIN worker unloadw ON c.unloading_contact_id = unloadw.worker_id
                        ";
                }
                else if (tableName == "waybill")
                {
                    sql = @"
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
                    ";
                }
                else if (tableName == "consignment_note")
                {
                    sql = @"
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

                    LEFT JOIN waybill wb
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
                    ";
                }
                else if (tableName == "user")
                {
                    sql = @"
                    SELECT
                        u.user_id,
                        u.login,
                        u.password_hash,
                        u.role,

                        w.full_name AS worker_full_name,
                        w.position AS worker_position,

                        d.personnel_number,
                        d.last_name AS driver_last_name,
                        d.first_name AS driver_first_name,
                        d.patronymic AS driver_patronymic,

                        u.is_system

                    FROM user u

                    LEFT JOIN worker w
                        ON u.worker_id = w.worker_id

                    LEFT JOIN driver d
                        ON u.driver_id = d.driver_id
                    ";
                }
                else
                {
                    sql = $"SELECT * FROM {tableName}";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                if (
                    (tableName == "cargo" ||
                     tableName == "medical_exam" ||
                     tableName == "driver_vehicle_work")
                    && parentId != 0)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", parentId);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                if (tableName == "organization")
                {
                    dataGridView1.Columns["organization_id"].HeaderText = "Идентификатор организации";
                    dataGridView1.Columns["inn"].HeaderText = "ИНН";
                    dataGridView1.Columns["name"].HeaderText = "Наименование";
                    dataGridView1.Columns["address"].HeaderText = "Адрес";
                    dataGridView1.Columns["phone"].HeaderText = "Телефон";
                }
                else if (tableName == "client")
                {
                    dataGridView1.Columns["client_id"].HeaderText = "Идентификатор клиента";
                    dataGridView1.Columns["inn"].HeaderText = "ИНН";
                    dataGridView1.Columns["org_name"].HeaderText = "Наименование организации";
                    dataGridView1.Columns["address"].HeaderText = "Адрес";
                    dataGridView1.Columns["phone"].HeaderText = "Телефон";
                    dataGridView1.Columns["last_name"].HeaderText = "Фамилия";
                    dataGridView1.Columns["first_name"].HeaderText = "Имя";
                    dataGridView1.Columns["patronymic"].HeaderText = "Отчество";
                }
                else if (tableName == "vehicle")
                {
                    dataGridView1.Columns["vehicle_id"].HeaderText = "Идентификатор ТС";
                    dataGridView1.Columns["reg_number"].HeaderText = "Рег. номер";
                    dataGridView1.Columns["type"].HeaderText = "Тип";
                    dataGridView1.Columns["brand"].HeaderText = "Марка";
                    dataGridView1.Columns["model"].HeaderText = "Модель";
                    dataGridView1.Columns["capacity"].HeaderText = "Вместимость";
                    dataGridView1.Columns["load_capacity"].HeaderText = "Грузоподъемность";
                    dataGridView1.Columns["ownership_type"].HeaderText = "Тип владения";
                }
                else if (tableName == "trailer")
                {
                    dataGridView1.Columns["trailer_id"].HeaderText = "Идентификатор прицепа";
                    dataGridView1.Columns["brand"].HeaderText = "Марка";
                    dataGridView1.Columns["reg_number"].HeaderText = "Рег. номер";
                    dataGridView1.Columns["parking_place"].HeaderText = "Парковочное место";
                }
                else if (tableName == "driver")
                {
                    dataGridView1.Columns["driver_id"].HeaderText = "Идентификатор водителя";
                    dataGridView1.Columns["license_id"].HeaderText = "Вод. удостоверение";
                    dataGridView1.Columns["license_issue_date"].HeaderText = "Дата выдачи вод. удостоверения";
                    dataGridView1.Columns["snils"].HeaderText = "СНИЛС";
                    dataGridView1.Columns["phone"].HeaderText = "Телефон";
                    dataGridView1.Columns["personnel_number"].HeaderText = "Персональный номер";
                    dataGridView1.Columns["last_name"].HeaderText = "Фамилия";
                    dataGridView1.Columns["first_name"].HeaderText = "Имя";
                    dataGridView1.Columns["patronymic"].HeaderText = "Отчество";
                }
                else if (tableName == "health_worker")
                {
                    dataGridView1.Columns["health_worker_id"].HeaderText = "Идентификатор медработника";
                    dataGridView1.Columns["full_name"].HeaderText = "ФИО";
                    dataGridView1.Columns["position"].HeaderText = "Должность";
                    dataGridView1.Columns["med_org_name"].HeaderText = "Наименование медорганизации";
                }
                else if (tableName == "worker")
                {
                    dataGridView1.Columns["worker_id"].HeaderText = "Идентификатор работника";
                    dataGridView1.Columns["full_name"].HeaderText = "ФИО";
                    dataGridView1.Columns["position"].HeaderText = "Должность";
                    dataGridView1.Columns["org_name"].HeaderText = "Наименование организации";
                    dataGridView1.Columns["phone"].HeaderText = "Телефон";
                }
                else if (tableName == "cargo")
                {
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
                else if (tableName == "medical_exam")
                {
                    dataGridView1.Columns["medical_exam_id"].HeaderText = "Идентификатор медосмотра";
                    dataGridView1.Columns["wb_number"].HeaderText = "Номер ПЛ";
                    dataGridView1.Columns["exam_type"].HeaderText = "Тип медосмотра";
                    dataGridView1.Columns["exam_datetime"].HeaderText = "Дата медосмотра";
                    dataGridView1.Columns["result"].HeaderText = "Результат";

                    dataGridView1.Columns["health_worker_full_name"].HeaderText = "ФИО медработника";
                    dataGridView1.Columns["health_worker_position"].HeaderText = "Должность медработника";
                    dataGridView1.Columns["health_worker_org"].HeaderText = "Организация медработника";
                }
                else if (tableName == "driver_vehicle_work")
                {
                    dataGridView1.Columns["work_id"].HeaderText = "Идентификатор работы";
                    dataGridView1.Columns["wb_number"].HeaderText = "Номер ПЛ";
                    dataGridView1.Columns["work_type"].HeaderText = "Тип работы";
                    dataGridView1.Columns["scheduled_date"].HeaderText = "Заланированная дата";
                    dataGridView1.Columns["scheduled_time"].HeaderText = "Запланированное время";
                    dataGridView1.Columns["actual_date"].HeaderText = "Фактическая дата";
                    dataGridView1.Columns["actual_time"].HeaderText = "Фактическое время";
                    dataGridView1.Columns["zero_run"].HeaderText = "Нулевой пробег";
                    dataGridView1.Columns["odometer_reading"].HeaderText = "Показание одометра";

                    dataGridView1.Columns["authorized_person"].HeaderText = "ФИО уполномоченного лица";
                    dataGridView1.Columns["authorized_person_position"].HeaderText = "Должность уполномоченного лица";
                }
                else if (tableName == "contract")
                {
                    //dataGridView1.Columns["contract_id"].Visible = false;

                    dataGridView1.Columns["contract_id"].HeaderText = "Идентификатор";
                    dataGridView1.Columns["contract_num"].HeaderText = "Номер договора";
                    dataGridView1.Columns["contract_date"].HeaderText = "Дата";

                    dataGridView1.Columns["customer_org"].HeaderText = "организация Заказчик";
                    dataGridView1.Columns["customer_last_name"].HeaderText = "Фамилия заказчика";
                    dataGridView1.Columns["customer_first_name"].HeaderText = "Имя заказчика";
                    dataGridView1.Columns["customer_patronymic"].HeaderText = "Отчество заказчика";


                    dataGridView1.Columns["consignee_org"].HeaderText = "организация грузополучателя";
                    dataGridView1.Columns["consignee_last_name"].HeaderText = "Фамилия грузополучателя";
                    dataGridView1.Columns["consignee_first_name"].HeaderText = "Имя грузополучателя";
                    dataGridView1.Columns["consignee_patronymic"].HeaderText = "Отчество грузополучателя";


                    dataGridView1.Columns["shipper_org"].HeaderText = "организация грузоотправителя";
                    dataGridView1.Columns["shipper_last_name"].HeaderText = "Фамилия грузоотправителя";
                    dataGridView1.Columns["shipper_first_name"].HeaderText = "Имя грузоотправителя";
                    dataGridView1.Columns["shipper_patronymic"].HeaderText = "Отчество грузоотправителя";

                    dataGridView1.Columns["organization"].HeaderText = "Организация";
                    dataGridView1.Columns["performer"].HeaderText = "Исполнитель";

                    dataGridView1.Columns["loading_address"].HeaderText = "Адрес погрузки";
                    dataGridView1.Columns["loading_time"].HeaderText = "Время погрузки";

                    dataGridView1.Columns["loading_contact"].HeaderText = "Контакт погрузки";


                    dataGridView1.Columns["unloading_address"].HeaderText = "Адрес разгрузки";
                    dataGridView1.Columns["unloading_time"].HeaderText = "Время разгрузки";

                    dataGridView1.Columns["unloading_contact"].HeaderText = "Контакт разгрузки";


                    dataGridView1.Columns["cost_services"].HeaderText = "Стоимость";
                    dataGridView1.Columns["payment_terms"].HeaderText = "Условия оплаты";
                }
                else if (tableName == "waybill")
                {
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
                else if (tableName == "consignment_note")
                {
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
                else if (tableName == "user")
                {
                    dataGridView1.Columns["user_id"].HeaderText = "Идентификатор пользователя";
                    dataGridView1.Columns["login"].HeaderText = "Логин";
                    dataGridView1.Columns["password_hash"].HeaderText = "Пароль";
                    dataGridView1.Columns["role"].HeaderText = "Роль";

                    dataGridView1.Columns["worker_full_name"].HeaderText = "ФИО работника";
                    dataGridView1.Columns["worker_position"].HeaderText = "Должность работника";

                    dataGridView1.Columns["personnel_number"].HeaderText = "Персональный номер водителя";
                    dataGridView1.Columns["driver_last_name"].HeaderText = "Фамилия водителя";
                    dataGridView1.Columns["driver_first_name"].HeaderText = "Имя водителя";
                    dataGridView1.Columns["driver_patronymic"].HeaderText = "Отчество водителя";

                    dataGridView1.Columns["is_system"].HeaderText = "Системный пользователь";
                }
                else if (tableName == "cargo_state")
                {
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
                else
                {

                }
            }
        }

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

                case "medical_exam":
                    return new MedicalExamEditView(mode, id, parentId, LoadData);

                case "driver_vehicle_work":
                    return new DriverVehicleWorkEditView(mode, id, parentId, LoadData);

                case "consignment_note":
                    return new ConsignmentNoteEditView(mode, id, LoadData);

                case "user":
                    return new UserEditView(mode, id, LoadData);

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

            bool ok =
            DbErrorHelper.Execute(() =>
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql =
                        $"DELETE FROM {tableName} WHERE {tableName}_id = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            });

            if (ok)
            {
                LoadData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
