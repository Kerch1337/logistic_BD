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
    }

}
