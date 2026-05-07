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
        public MainForm()
        {
            InitializeComponent();

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



        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
