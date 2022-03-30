using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class KampanyaEkleDuzenle : Form
    {
        public KampanyaEkleDuzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO[dbo].[tbl_Kampanyalar]([KampanyaBilgileri],[KampanyaIndirimOran],[KampanyaBaslangicZaman],[KampanyaBitisTarihi],[KampanyaTanim])VALUES(@KampanyaBilgileri,@KampanyaIndirimOran, @KampanyaBaslangicZaman, @KampanyaBitisTarihi, @KampanyaTanim) ", con);

            
            cmd1.Parameters.AddWithValue("@KampanyaBaslangicZaman", dateTimePicker1.Value);
            cmd1.Parameters.AddWithValue("@KampanyaBitisTarihi", dateTimePicker2.Value);
            cmd1.Parameters.AddWithValue("@KampanyaBilgileri",textBox1.Text);
            cmd1.Parameters.AddWithValue("@KampanyaIndirimOran",Convert.ToInt32( textBox2.Text));
            cmd1.Parameters.AddWithValue("@KampanyaTanim", textBox3.Text);
            
            
            

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                int ekle = cmd1.ExecuteNonQuery();
                MessageBox.Show(ekle + "kaydedildi");



            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }

        private void KampanyaEkleDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
