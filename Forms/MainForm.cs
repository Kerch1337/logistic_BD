using logistic_BD.Views.Doc_Views;
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
    public partial class MainForm : Form
    {
        private Stack<UserControl> viewHistory = new Stack<UserControl>();

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ShowView(new MenuView());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDriver_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ShowView(UserControl view)
        {
            pnlMain.Controls.Clear();
            view.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(view);
        }

        public void NavigateTo(UserControl newView)
        {
            if (pnlMain.Controls.Count > 0)
            {
                viewHistory.Push(
                    (UserControl)pnlMain.Controls[0]
                );
            }

            ShowView(newView);
        }

        public void GoBack()
        {
            if (viewHistory.Count > 0)
            {
                UserControl view =
                    viewHistory.Pop();

                ShowView(view);

                if (view is ContractEditView contractView)
                {
                    contractView.RefreshCombos();
                }
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
