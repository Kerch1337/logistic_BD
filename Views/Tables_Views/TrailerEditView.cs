using logistic_BD.logistic_BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic_BD
{
    public partial class TrailerEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public TrailerEditView(string mode, int id, Action refreshAction)
        {
            InitializeComponent();

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

                string sql = "SELECT * FROM trailer WHERE trailer_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    txtId.Text = reader.GetInt("trailer_id")?.ToString();

                    txtBrand.Text = reader.GetString("brand");
                    txtRegNumber.Text = reader.GetString("reg_number");
                    txtParkingPlace.Text = reader.GetString("parking_place");
                }
            }
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("trailer"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO trailer (brand, reg_number, parking_place)
                         VALUES (@brand, @reg_number, @parking_place)";
                }
                else
                {
                    sql = @"UPDATE trailer 
                        SET brand=@brand, reg_number=@reg_number, parking_place=@parking_place
                        WHERE trailer_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@reg_number", txtRegNumber.Text);
                cmd.Parameters.AddWithValue("@parking_place", txtParkingPlace.Text);


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
    }
}
