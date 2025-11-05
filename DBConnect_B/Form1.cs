using Microsoft.Data.SqlClient;
using System.Data;
namespace DBConnect_B
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-520STTO;Initial Catalog=2025_2026_ProjectDB_B;user ID=sa; password=123456;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tbl_Ogrenci", connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Tbl_Ogrenci (Adi, Soyadi,Yas) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')", connection);

            connection.Open();  
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
