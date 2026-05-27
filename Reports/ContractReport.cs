using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;

using System;
using System.IO;
using MySql.Data.MySqlClient;
using Xceed.Words.NET;
using System.Text;

namespace logistic_BD.Reports
{
    public static class ContractReport
    {
        public static void Export(int contractId)
        {
            Xceed.Words.NET.Licenser.LicenseKey = "WDN52-ARNFA-844M5-S4FA";

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                string sql = @"

                    SELECT

                    c.contract_num AS contract_contract_num,
                    c.contract_date AS contract_contract_date,

                    c.loading_address AS contract_loading_address,
                    c.loading_time AS contract_loading_time,

                    c.unloading_address AS contract_unloading_address,
                    c.unloading_time AS contract_unloading_time,

                    c.cost_services AS contract_cost_services,
                    c.payment_terms AS contract_payment_terms,


                    organization.name AS organization_name,
                    organization.address AS organization_address,
                    organization.phone AS organization_phone,


                    customer.org_name AS customer_org_name,
                    customer.inn AS customer_inn,
                    customer.address AS customer_address,
                    customer.phone AS customer_phone,
                    customer.first_name AS customer_first_name,
                    customer.last_name AS customer_last_name,
                    customer.patronymic AS customer_patronymic,


                    shipper.org_name AS shipper_org_name,
                    shipper.inn AS shipper_inn,
                    shipper.address AS shipper_address,
                    shipper.phone AS shipper_phone,
                    shipper.first_name AS shipper_first_name,
                    shipper.last_name AS shipper_last_name,
                    shipper.patronymic AS shipper_patronymic,


                    consignee.org_name AS consignee_org_name,
                    consignee.inn AS consignee_inn,
                    consignee.address AS consignee_address,
                    consignee.phone AS consignee_phone,
                    consignee.first_name AS consignee_first_name,
                    consignee.last_name AS consignee_last_name,
                    consignee.patronymic AS consignee_patronymic,


                    loading_contact.full_name AS loading_contact_full_name,
                    loading_contact.phone AS loading_contact_phone,

                    unloading_contact.full_name AS unloading_contact_full_name,
                    unloading_contact.phone AS unloading_contact_phone,


                    performer.name AS performer_name


                    FROM contract c

                    LEFT JOIN client customer
                    ON c.customer_id = customer.client_id

                    LEFT JOIN client shipper
                    ON c.shipper_id = shipper.client_id

                    LEFT JOIN client consignee
                    ON c.consignee_id = consignee.client_id

                    LEFT JOIN organization organization
                    ON c.organization_id =
                    organization.organization_id

                    LEFT JOIN organization performer
                    ON c.performer_id =
                    performer.organization_id

                    LEFT JOIN worker loading_contact
                    ON c.loading_contact_id =
                    loading_contact.worker_id

                    LEFT JOIN worker unloading_contact
                    ON c.unloading_contact_id =
                    unloading_contact.worker_id

                    WHERE c.contract_id=@id
                    ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", contractId);
                var reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return;

                string contractNum = reader["contract_contract_num"]?.ToString() ?? "";
                string contractDate = reader["contract_contract_date"]?.ToString() ?? "";
                string organizationName = reader["organization_name"]?.ToString() ?? "";
                string organizationAddress = reader["organization_address"]?.ToString() ?? "";
                string organizationPhone = reader["organization_phone"]?.ToString() ?? "";

                string customerOrgName = reader["customer_org_name"]?.ToString() ?? "";
                string customerInn = reader["customer_inn"]?.ToString() ?? "";
                string customerAddress = reader["customer_address"]?.ToString() ?? "";
                string customerPhone = reader["customer_phone"]?.ToString() ?? "";
                string customerFirstName = reader["customer_first_name"]?.ToString() ?? "";
                string customerLastName = reader["customer_last_name"]?.ToString() ?? "";
                string customerPatronymic = reader["customer_patronymic"]?.ToString() ?? "";

                string shipperOrgName = reader["shipper_org_name"]?.ToString() ?? "";
                string shipperInn = reader["shipper_inn"]?.ToString() ?? "";
                string shipperAddress = reader["shipper_address"]?.ToString() ?? "";
                string shipperPhone = reader["shipper_phone"]?.ToString() ?? "";
                string shipperFirstName = reader["shipper_first_name"]?.ToString() ?? "";
                string shipperLastName = reader["shipper_last_name"]?.ToString() ?? "";
                string shipperPatronymic = reader["shipper_patronymic"]?.ToString() ?? "";

                string consigneeOrgName = reader["consignee_org_name"]?.ToString() ?? "";
                string consigneeInn = reader["consignee_inn"]?.ToString() ?? "";
                string consigneeAddress = reader["consignee_address"]?.ToString() ?? "";
                string consigneePhone = reader["consignee_phone"]?.ToString() ?? "";
                string consigneeFirstName = reader["consignee_first_name"]?.ToString() ?? "";
                string consigneeLastName = reader["consignee_last_name"]?.ToString() ?? "";
                string consigneePatronymic = reader["consignee_patronymic"]?.ToString() ?? "";

                string loadingAddress = reader["contract_loading_address"]?.ToString() ?? "";
                string loadingTime = reader["contract_loading_time"]?.ToString() ?? "";
                string loadingContactName = reader["loading_contact_full_name"]?.ToString() ?? "";
                string loadingContactPhone = reader["loading_contact_phone"]?.ToString() ?? "";

                string unloadingAddress = reader["contract_unloading_address"]?.ToString() ?? "";
                string unloadingTime = reader["contract_unloading_time"]?.ToString() ?? "";
                string unloadingContactName = reader["unloading_contact_full_name"]?.ToString() ?? "";
                string unloadingContactPhone = reader["unloading_contact_phone"]?.ToString() ?? "";

                string costServices = reader["contract_cost_services"]?.ToString() ?? "";
                string paymentTerms = reader["contract_payment_terms"]?.ToString() ?? "";
                string performerName = reader["performer_name"]?.ToString() ?? "";

                reader.Close();

                string cargoSql = @"
                    SELECT 
                        GROUP_CONCAT(cargo_name SEPARATOR ', ') AS cargo_name,
                        GROUP_CONCAT(package_count SEPARATOR ', ') AS cargo_package_count,
                        GROUP_CONCAT(gross_weight SEPARATOR ', ') AS cargo_gross_weight,
                        GROUP_CONCAT(volume SEPARATOR ', ') AS cargo_volume,
                        GROUP_CONCAT(additional_info SEPARATOR ', ') AS cargo_additional_info
                    FROM cargo 
                    WHERE contract_id = @id";

                cmd = new MySqlCommand(cargoSql, conn);
                cmd.Parameters.AddWithValue("@id", contractId);
                var cargoReader = cmd.ExecuteReader();

                string cargoName = "";
                string cargoPackage = "";
                string cargoWeight = "";
                string cargoVolume = "";
                string cargoAdditional = "";

                if (cargoReader.Read())
                {
                    cargoName = cargoReader["cargo_name"]?.ToString() ?? "";
                    cargoPackage = cargoReader["cargo_package_count"]?.ToString() ?? "";
                    cargoWeight = cargoReader["cargo_gross_weight"]?.ToString() ?? "";
                    cargoVolume = cargoReader["cargo_volume"]?.ToString() ?? "";
                    cargoAdditional = cargoReader["cargo_additional_info"]?.ToString() ?? "";
                }
                cargoReader.Close();

                string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string template = Path.Combine(projectRoot, "logistic_BD/Templates", "Obrasec_Dogovor.docx");
                string output = $"Contract_Report_{contractId}.docx";

                var doc = DocX.Load(template);

                doc.ReplaceText("{contract_contract_num}", contractNum);
                doc.ReplaceText("{contract_contract_date}", contractDate);
                doc.ReplaceText("{organization_name}", organizationName);
                doc.ReplaceText("{organization_address}", organizationAddress);
                doc.ReplaceText("{organization_phone}", organizationPhone);

                doc.ReplaceText("{customer_org_name}", customerOrgName);
                doc.ReplaceText("{customer_inn}", customerInn);
                doc.ReplaceText("{customer_address}", customerAddress);
                doc.ReplaceText("{customer_phone}", customerPhone);
                doc.ReplaceText("{customer_first_name}", customerFirstName);
                doc.ReplaceText("{customer_last_name}", customerLastName);
                doc.ReplaceText("{customer_patronymic}", customerPatronymic);

                doc.ReplaceText("{shipper_org_name}", shipperOrgName);
                doc.ReplaceText("{shipper_inn}", shipperInn);
                doc.ReplaceText("{shipper_address}", shipperAddress);
                doc.ReplaceText("{shipper_phone}", shipperPhone);
                doc.ReplaceText("{shipper_first_name}", shipperFirstName);
                doc.ReplaceText("{shipper_last_name}", shipperLastName);
                doc.ReplaceText("{shipper_patronymic}", shipperPatronymic);

                doc.ReplaceText("{consignee_org_name}", consigneeOrgName);
                doc.ReplaceText("{consignee_inn}", consigneeInn);
                doc.ReplaceText("{consignee_address}", consigneeAddress);
                doc.ReplaceText("{consignee_phone}", consigneePhone);
                doc.ReplaceText("{consignee_first_name}", consigneeFirstName);
                doc.ReplaceText("{consignee_last_name}", consigneeLastName);
                doc.ReplaceText("{consignee_patronymic}", consigneePatronymic);

                doc.ReplaceText("{contract_loading_address}", loadingAddress);
                doc.ReplaceText("{contract_loading_time}", loadingTime);
                doc.ReplaceText("{loading_contact_full_name}", loadingContactName);
                doc.ReplaceText("{loading_contact_phone}", loadingContactPhone);

                doc.ReplaceText("{contract_unloading_address}", unloadingAddress);
                doc.ReplaceText("{contract_unloading_time}", unloadingTime);
                doc.ReplaceText("{unloading_contact_full_name}", unloadingContactName);
                doc.ReplaceText("{unloading_contact_phone}", unloadingContactPhone);

                doc.ReplaceText("{cargo_name}", cargoName);
                doc.ReplaceText("{cargo_package_count}", cargoPackage);
                doc.ReplaceText("{cargo_gross_weight}", cargoWeight);
                doc.ReplaceText("{cargo_volume}", cargoVolume);
                doc.ReplaceText("{cargo_additional_info}", cargoAdditional);

                doc.ReplaceText("{contract_cost_services}", costServices);
                doc.ReplaceText("{contract_payment_terms}", paymentTerms);
                doc.ReplaceText("{performer_name}", performerName);

                    doc.SaveAs(output);

                    MessageBox.Show($"Отчет Договор-Заявка успешно создан.\nФайл: {output}",
                                  "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета Договор-Заявки:\n\n{ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}