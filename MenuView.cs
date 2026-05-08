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
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }


        private void btnOrg_Click_1(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("organization"));
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("client"));
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("vehicle"));
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("worker"));
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("trailer"));
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("driver"));
        }

        private void btnHealthWorker_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();

            main.ShowView(new CrudView("health_worker"));
        }
    }

}
