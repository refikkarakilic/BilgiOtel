using DAL_BilgiHotel;
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
    public partial class MsteriEkleSorgula : Form
    {
        public MsteriEkleSorgula()
        {
            InitializeComponent();
        }

        private void MsteriEkleSorgula_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=Z36-03;Database=DB_Bilgi_Hotel;Integrated Security=true");
            SqlCommand com = new SqlCommand("Select [IlAd],[IlId]IlceAd from tbl_Il", con);
            SqlCommand com1 = new SqlCommand("select [UlkeAd] from tbl_Ulke", con);
            SqlCommand com2 = new SqlCommand("SELECT [DilId],[DilAd],[DilAciklama],[DilKod] FROM [dbo].[tbl_Diller]", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader okuyucu = com.ExecuteReader();



                if (okuyucu.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...
                        comboBox1.Items.Add(okuyucu["IlAd"].ToString());

                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }//Okuyucu ile is bittigi icin, kapatilir..
                okuyucu.Close();

                SqlDataReader okuyucu2 = com1.ExecuteReader();
                if (okuyucu2.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu2.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...

                        comboBox3.Items.Add(okuyucu2["UlkeAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu2.Close();
                SqlDataReader okuyucu3 = com2.ExecuteReader();
                if (okuyucu3.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu3.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...

                        comboBox4.Items.Add(okuyucu3["DilAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu3.Close();




            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO dbo.tbl_Musteriler           (MusteriAd, MusteriSoyad, MusteriTCKimlik, MusteriPasaportNo, MusteriUnvan, MusteriYetkiliAdSoyad, MusteriVergiNo, MusteriVergiDairesi, MusteriTelefon, MusteriPosta, MusteriAdres, IlID, IlceID, UlkeID, MusteriAciklama, MusteriKurumsalOK, DilID)     VALUES( @MusteriAd, @MusteriSoyad,@MusteriTCKimlik, @MusteriPasaportNo, @MusteriUnvan, @MusteriYetkiliAdSoyad, @MusteriVergiNo, @MusteriVergiDairesi, @MusteriTelefon, @MusteriPosta,@MusteriAdres, @IlID, @IlceID, @UlkeID, @MusteriAciklama, @MusteriKurumsalOK, @DilID)", con);

            cmd1.Parameters.AddWithValue("@MusteriAd", textBox1.Text);
            cmd1.Parameters.AddWithValue("@MusteriSoyad", textBox2.Text);
            cmd1.Parameters.AddWithValue("@MusteriTCKimlik", textBox3.Text);
            cmd1.Parameters.AddWithValue("@MusteriUnvan", textBox11.Text);
            cmd1.Parameters.AddWithValue("@MusteriKurumsalOK", checkBox1.Checked);


            cmd1.Parameters.AddWithValue("@MusteriPasaportNo", textBox4.Text);
            cmd1.Parameters.AddWithValue("@MusteriYetkiliAdSoyad", textBox5.Text);
            cmd1.Parameters.AddWithValue("@MusteriVergiNo", textBox6.Text);
            cmd1.Parameters.AddWithValue("@MusteriVergiDairesi", textBox7.Text);
            cmd1.Parameters.AddWithValue("@MusteriTelefon", textBox8.Text);
            cmd1.Parameters.AddWithValue("@MusteriAdres", textBox9.Text);
            cmd1.Parameters.AddWithValue("@MusteriAciklama", textBox10.Text);

            cmd1.Parameters.AddWithValue("@MusteriPosta", textBox12.Text);


            cmd1.Parameters.AddWithValue("@IlId", comboBox1.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@IlceId", comboBox2.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@DilID", comboBox4.SelectedIndex + 1);







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

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            //SqlCommand cmd = new SqlCommand("sp_musteriupdate", con);
            //SqlCommand cmd2 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId1", con);

            //cmd.CommandType = CommandType.StoredProcedure;

            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //        con.Open();
            SqlParameter[] cmd = new SqlParameter[18];

           


            cmd[0] = new SqlParameter("@MusteriID", textBox13.Text);
            cmd[1] = new SqlParameter("@MusteriAd", textBox1.Text);
            cmd[2] = new SqlParameter("@MusteriSoyad", textBox2.Text);
            cmd[3] = new SqlParameter("@MusteriTCKimlik", textBox3.Text);
            cmd[4] = new SqlParameter("@MusteriPasaportNo", textBox4.Text);
            cmd[5] = new SqlParameter("@MusteriUnvan", textBox11.Text);
            cmd[6] = new SqlParameter("@MusteriYetkiliAdSoyad", textBox5.Text);
            cmd[7] = new SqlParameter("@MusteriVergiNo", textBox6.Text);
            cmd[8] = new SqlParameter("@MusteriVergiDairesi", textBox7.Text);
            cmd[9] = new SqlParameter("@MusteriTelefon", textBox8.Text);
            cmd[10] = new SqlParameter("@MusteriPosta", textBox12.Text);
            cmd[11] = new SqlParameter("@MusteriAdres", textBox9.Text);
            cmd[12] = new SqlParameter("@IlId", comboBox1.SelectedIndex + 1);
            cmd[13] = new SqlParameter("@IlceId", comboBox2.SelectedIndex + 1);
            cmd[14] = new SqlParameter("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd[15] = new SqlParameter("@MusteriAciklama", textBox10.Text);
            cmd[16] = new SqlParameter("@MusteriKurumsalOK", checkBox1.Checked);
            cmd[17] = new SqlParameter("@DilID", comboBox4.SelectedIndex + 1);

            try
            {
                HelperSql.SqlGeriDondurmezWithSp("sp_musteriupdate", true, cmd);
                MessageBox.Show("güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu");
            }
            
            


            //    int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
            //    MessageBox.Show(etkilenenSatirSayisi > 0 ? "Kayıt başarıyla güncellendi" : "Kayıt güncellenemedi");

            //}
            //catch (SqlException hata)
            //{
            //    MessageBox.Show(hata.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            SqlCommand cmd = new SqlCommand("select * from tbl_Musteriler where MusteriID = @MusteriID ", con);
            SqlCommand cmd2 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId1", con);

            cmd.Parameters.AddWithValue("@MusteriID", Convert.ToInt32(textBox13.Text));




            if (con.State == ConnectionState.Closed)
            {
                con.Open();


                int ilID = 0, ilceID = 0;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        textBox1.Text = dr["MusteriAd"].ToString();
                        textBox2.Text = dr["MusteriSoyad"].ToString();
                        textBox3.Text = dr["MusteriTCKimlik"].ToString();
                        
                        comboBox4.SelectedIndex = Convert.ToInt32(dr["DilID"]) - 1;
                        textBox12.Text = dr["MusteriPosta"].ToString();
                        textBox8.Text = dr["MusteriTelefon"].ToString();
                        textBox4.Text = dr["MusteriPasaportNo"].ToString();
                        
                        textBox9.Text = dr["MusteriAdres"].ToString();
                        comboBox1.SelectedIndex = Convert.ToInt32(dr["IlId"]) - 1;
                        comboBox2.SelectedIndex = Convert.ToInt32(dr["IlceID"]) - 1;
                        comboBox3.SelectedIndex = Convert.ToInt32(dr["UlkeId"]) - 1;
                        textBox10.Text = dr["MusteriAciklama"].ToString();
                        
                        comboBox4.SelectedIndex = Convert.ToInt32(dr["dilId"]) - 1;

                    }

                }
                dr.Close();

                cmd2.Parameters.AddWithValue("@IlId1", ilID);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        comboBox2.Items.Add(dr1["IlceAd"].ToString());
                    }
                }
                comboBox2.SelectedIndex = ilceID;
                dr1.Close();


            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            SqlCommand cmd1 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId", con);
            int sayi = comboBox1.SelectedIndex + 1;
            cmd1.Parameters.AddWithValue("@IlId", sayi);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = cmd1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBox2.Items.Add(dr["IlceAd"].ToString());
                    }
                }
                dr.Close();
            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }
    }
}
