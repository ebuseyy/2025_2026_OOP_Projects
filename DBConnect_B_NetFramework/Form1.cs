using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DBConnect_B_NetFramework
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-520STTO;Initial Catalog=2025_2026_ProjectDB_B;user ID=sa; password=123456;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from Tbl_Ogrenci", connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void GS_Click(object sender, EventArgs e)
        {

        }
    }
}
