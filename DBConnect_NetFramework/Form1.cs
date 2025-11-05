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

namespace DBConnect_NetFramework
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogrenci", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Ogrenci (Adi,Soyadi,Yas) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
