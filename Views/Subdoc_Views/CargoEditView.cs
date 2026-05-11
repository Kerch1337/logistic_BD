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

namespace logistic_BD.Views.Subdoc_Views
{
    public partial class CargoEditView : UserControl
    {
        private int contractId;
        private string mode;
        private int id;
        private Action refresh;

        public CargoEditView(string mode, int id, int contractId, Action refresh)
        {
            InitializeComponent();

            this.mode = mode;
            this.id = id;
            this.contractId = contractId;
            this.refresh = refresh;

            if (mode == "edit")
                LoadData();
        }

        private void CargoEditView_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        { 
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql;

                if (mode == "add")
                {
                    sql = @"INSERT INTO cargo 
                    (contract_id, cargo_name, additional_info, cargo_condition, package_count,
                     gross_weight, net_weight, volume, length, width, height)
                    VALUES
                    (@contract_id, @cargo_name, @additional_info, @cargo_condition, @package_count,
                     @gross_weight, @net_weight, @volume, @length, @width, @height)";
                }
                else
                {
                    sql = @"UPDATE cargo 
                    SET cargo_name=@cargo_name,
                        additional_info=@additional_info,
                        cargo_condition=@cargo_condition,
                        package_count=@package_count,
                        gross_weight=@gross_weight,
                        net_weight=@net_weight,
                        volume=@volume,
                        length=@length,
                        width=@width,
                        height=@height
                    WHERE cargo_id=@id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cargo_name", txtCargoName.Text);
                cmd.Parameters.AddWithValue("@additional_info", txtAdditionalInfo.Text);
                cmd.Parameters.AddWithValue("@cargo_condition", txtCargoCondition.Text);

                cmd.Parameters.AddWithValue("@package_count",
                    string.IsNullOrWhiteSpace(txtPackageCount.Text) ? (object)DBNull.Value : Convert.ToInt32(txtPackageCount.Text));

                cmd.Parameters.AddWithValue("@gross_weight", Convert.ToDecimal(txtGrossWeight.Text));
                cmd.Parameters.AddWithValue("@net_weight", Convert.ToDecimal(txtNetWeight.Text));
                cmd.Parameters.AddWithValue("@volume", Convert.ToDecimal(txtVolume.Text));

                cmd.Parameters.AddWithValue("@length", Convert.ToDecimal(txtLength.Text));
                cmd.Parameters.AddWithValue("@width", Convert.ToDecimal(txtWidth.Text));
                cmd.Parameters.AddWithValue("@height", Convert.ToDecimal(txtHeight.Text));

                if (mode == "add")
                {
                    cmd.Parameters.AddWithValue("@contract_id", contractId);
                }

                if (mode == "edit")
                {
                    cmd.Parameters.AddWithValue("@id", id);
                }

                cmd.ExecuteNonQuery();
            }

            refresh?.Invoke();
            GoBack();
        }

        private void GoBack()
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("contract"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
