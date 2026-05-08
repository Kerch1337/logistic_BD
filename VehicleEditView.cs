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
    public partial class VehicleEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public VehicleEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

            cmbOwnership.Items.Add("Собственность");
            cmbOwnership.Items.Add("Совместная собственность супругов");
            cmbOwnership.Items.Add("Аренда");
            cmbOwnership.Items.Add("Лизинг");
            cmbOwnership.Items.Add("Безвозмездное пользование");

            this.mode = mode;
            this.id = id;
            this.refresh = refreshAction;

            if (mode == "edit")
                LoadData();
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM vehicle WHERE vehicle_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader["vehicle_id"].ToString();
                    txtRegNumber.Text = reader["reg_number"].ToString();
                    txtType.Text = reader["type"].ToString();
                    txtBrand.Text = reader["brand"].ToString();
                    txtModel.Text = reader["model"].ToString();
                    txtCapacity.Text = reader["capacity"].ToString();
                    txtLoadCapacity.Text = reader["load_capacity"].ToString();
                    cmbOwnership.SelectedItem = reader["ownership_type"].ToString();
                }
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("vehicle"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO vehicle (reg_number, type, brand, model, capacity, load_capacity, ownership_type)
                        VALUES (@reg_number, @type, @brand, @model, @capacity, @load_capacity, @ownership_type)";
                }
                else
                {
                    sql = @"UPDATE vehicle 
                        SET reg_number=@reg_number,
                            type=@type,
                            brand=@brand,
                            model=@model,
                            capacity=@capacity,
                            load_capacity=@load_capacity,
                            ownership_type=@ownership_type
                        WHERE vehicle_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@reg_number", txtRegNumber.Text);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);

                cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text);
                cmd.Parameters.AddWithValue("@load_capacity", txtLoadCapacity.Text);
                cmd.Parameters.AddWithValue("@ownership_type", cmbOwnership.SelectedItem.ToString());

                if (mode == "edit")
                    cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void cmbOwnership_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
