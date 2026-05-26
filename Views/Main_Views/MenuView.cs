using logistic_BD.Views.Driver_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logistic_BD.Views.Driver_Views;

namespace logistic_BD
{
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
            ApplyRoleRestrictions();
        }

        private void ApplyRoleRestrictions()
        {
            string role = Session.Role;

            if (role == "driver")
            {
                btnOrg.Visible = false;
                btnClient.Visible = false;
                btnVehicle.Visible = false;
                btnWorker.Visible = false;
                btnTrailer.Visible = false;
                btnHealthWorker.Visible = false;
                btnContract.Visible = false;
            }
            else if (role == "manager")
            {
            }
            else if (role == "root")
            {
            }
        }

        private void btnOrg_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("organization"));
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("client"));
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("vehicle"));
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("worker"));
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("trailer"));
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            MainForm main =
                (MainForm)this.FindForm();

            if (Session.Role == "driver")
            {
                main.NavigateTo(
                    new DriverProfileView()
                );
            }
            else
            {
                main.NavigateTo(
                    new CrudView("driver")
                );
            }
        }

        private void btnHealthWorker_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("health_worker"));
        }

        private void btnWaybill_Click(object sender, EventArgs e)
        {
            MainForm main =
                (MainForm)this.FindForm();

            if (Session.Role == "driver")
            {
                main.NavigateTo(
                    new DriverWaybillListView()
                );
            }
            else
            {
                main.NavigateTo(
                    new CrudView("waybill")
                );
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.NavigateTo(new CrudView("contract"));
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            if (Session.Role == "driver")
            {
                main.NavigateTo(
                    new DriverConsignmentNoteListView()
                );
            }
            else
            {
                main.NavigateTo(
                    new CrudView("consignment_note")
                );
            }
        }
    }

}
