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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Подключение успешно!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM contract";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
