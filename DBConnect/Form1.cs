using Microsoft.Data.SqlClient;
using System.Data;
namespace DBConnect
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-520STTO; database=2025_2026_ProjectDB; TrustServerCertificate=true; user id=sa; password=123456;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Tbl_Ogrenci", con);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            
            dataGridView1.DataSource = dataTable;
            con.Close();
        }
    }
}
