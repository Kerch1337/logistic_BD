using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic_BD.Views.Doc_Views
{
    public partial class ContractEditView : UserControl
    {
        private string mode;
        private int id;
        private Action refresh;

        public ContractEditView(string mode, int id, Action refreshAction)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoadingContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
