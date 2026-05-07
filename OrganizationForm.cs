using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logistic_BD.Repositories;

namespace logistic_BD
{
    public partial class OrganizationForm : Form
    {
        private OrganizationRepository repo = new OrganizationRepository();

        public OrganizationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            dataGridView1.DataSource = repo.GetAll();
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
