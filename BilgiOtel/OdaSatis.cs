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
    public partial class OdaSatis : Form
    {
        public OdaSatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[tbl_Satis]           ([SatisOdaGirisTarihi],[SatisOdaCikisTarihi],[SatisIndirim],[KartId],[OdaId],[OdaSatisDurum],[OdaSatisTutar],[OdaSatisKDV],OdaSatisOdemeTipiId)     VALUES( @SatisOdaGirisTarihi, @SatisOdaCikisTarihi, @SatisIndirim, @KartId, @OdaId, @OdaSatisDurum, @OdaSatisTutar, @OdaSatisKDV, @OdaSatisOdemeTipiId )", con);

            cmd1.Parameters.AddWithValue("@SatisOdaGirisTarihi", dateTimePicker1.Value);
            cmd1.Parameters.AddWithValue("@SatisOdaCikisTarihi", dateTimePicker2.Value);
            cmd1.Parameters.AddWithValue("@SatisIndirim", Convert.ToInt32( textBox1.Text));
            cmd1.Parameters.AddWithValue("@KartId", Convert.ToInt32(textBox2.Text));
            cmd1.Parameters.AddWithValue("@OdaId", Convert.ToInt32(textBox3.Text));
            cmd1.Parameters.AddWithValue("@OdaSatisTutar", Convert.ToDecimal(textBox4.Text));
            cmd1.Parameters.AddWithValue("@OdaSatisDurum", checkBox1.Checked);
            cmd1.Parameters.AddWithValue("@OdaSatisKDV", Convert.ToInt32(textBox5.Text));
            cmd1.Parameters.AddWithValue("@OdaSatisOdemeTipiId",comboBox2.SelectedIndex+1);

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

        private void OdaSatis_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=Z36-03;Database=DB_Bilgi_Hotel;Integrated Security=true");
            SqlCommand com3 = new SqlCommand("SELECT [OdaSatisTip],[OdaSatisTipAd],[OdaSatisTipAciklama]FROM [dbo].[tbl_OdaSatisTip]", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader okuyucu4 = com3.ExecuteReader();
                if (okuyucu4.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu4.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...
                        comboBox2.Items.Add(okuyucu4["OdaSatisTipAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu4.Close();

            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }
    }
}
