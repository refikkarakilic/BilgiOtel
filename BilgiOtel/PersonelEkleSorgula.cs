using DAL_BilgiHotel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class PersonelEkleSorgula : Form
    {
        public PersonelEkleSorgula()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonelEkleSorgula_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=Z36-03;Database=DB_Bilgi_Hotel;Integrated Security=true");
            SqlCommand com = new SqlCommand("Select [IlAd],[IlId]IlceAd from tbl_Il", con);
            SqlCommand com1 = new SqlCommand("select [UlkeAd] from tbl_Ulke", con);
            SqlCommand com2 = new SqlCommand("SELECT [CinsiyetId],CinsiyetAd FROM tbl_Cinsiyet", con);
            SqlCommand com3 = new SqlCommand("SELECT [GorevAd] FROM tbl_Gorevler", con);
            SqlCommand com4 = new SqlCommand("SELECT [YetkiId],[YetkiAd],[YetkiAciklama],[YetkiGuvenlikKod],[YetkiAccessKod]  FROM [dbo].[tbl_Yetkiler]",con);


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

                        comboBox5.Items.Add(okuyucu3["CinsiyetAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu3.Close();

                SqlDataReader okuyucu4 = com3.ExecuteReader();
                if (okuyucu4.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu4.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...

                        comboBox6.Items.Add(okuyucu4["GorevAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu4.Close();
                SqlDataReader okuyucu5 = com4.ExecuteReader();
                if (okuyucu5.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                {
                    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                    while (okuyucu5.Read())
                    {
                        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...

                        comboBox7.Items.Add(okuyucu5["YetkiAd"].ToString());
                        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                        // veya Dizi Mantığı kullanarak yapılır
                        //comboBox1.Items.Add(okuyucu[0].ToString());
                    }
                }
                okuyucu5.Close();

                comboBox4.Items.Add("Türk");
                comboBox4.Items.Add("Yabancı");





            }
            else if (con.State == ConnectionState.Open)
            {
                //Baglantiyi kapatmak icin;
                con.Close();

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void kaydet(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[tbl_Personel]([PersonelAd],[PersonelSoyad],[PersonelTcKimlik],[PersonelDogumTarihi],[PersonelUyrukId],[PersonelEposta],[PersonelTelefon],[PersonelPasaportNo],[CinsiyetId],[PersonelIseGirisTarihi],[PersonelIstenCikisTarihi],[PersonelSaatlikUcret],[PersonelMaas],[PersonelSicilNo],[GorevId],[YetkiId],[PersonelEngelDurumu],[PersonelHesKodu],[IlId],[IlceId],[UlkeId],[PersonelAdres],[PersonelAcilDurumKisiAd],[PersonelAcilDurumKisiTelefon],[ResimId])     VALUES(@PersonelAd, @PersonelSoyad, @PersonelTcKimlik, @PersonelDogumTarihi, @PersonelUyrukId, @PersonelEposta, @PersonelTelefon,@PersonelPasaportNo, @CinsiyetId, @PersonelIseGirisTarihi, @PersonelIstenCikisTarihi, @PersonelSaatlikUcret, @PersonelMaas, @PersonelSicilNo,@GorevId, @YetkiId, @PersonelEngelDurumu, @PersonelHesKodu, @IlId, @IlceId, @UlkeId, @PersonelAdres, @PersonelAcilDurumKisiAd, @PersonelAcilDurumKisiTelefon, @ResimId)", con);

            cmd1.Parameters.AddWithValue("@PersonelAd", textBox1.Text);
            cmd1.Parameters.AddWithValue("@PersonelSoyad", textBox2.Text);
            cmd1.Parameters.AddWithValue("@PersonelTcKimlik", textBox3.Text);
            cmd1.Parameters.AddWithValue("@PersonelDogumTarihi", dateTimePicker1.Value);
            cmd1.Parameters.AddWithValue("@PersonelUyrukId", comboBox4.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@PersonelPasaportNo", textBox4.Text);
            cmd1.Parameters.AddWithValue("@PersonelEposta", textBox5.Text);
            cmd1.Parameters.AddWithValue("@PersonelTelefon", textBox6.Text);
            cmd1.Parameters.AddWithValue("@CinsiyetId", comboBox5.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@PersonelIseGirisTarihi", dateTimePicker2.Value);
            cmd1.Parameters.AddWithValue("@PersonelIstenCikisTarihi", dateTimePicker3.Value);
            cmd1.Parameters.AddWithValue("@PersonelSaatlikUcret",Convert.ToDecimal(textBox7.Text));
            cmd1.Parameters.AddWithValue("@PersonelMaas", Convert.ToDecimal(textBox8.Text));//
            cmd1.Parameters.AddWithValue("@PersonelSicilNo", textBox9.Text);
            cmd1.Parameters.AddWithValue("@GorevId", comboBox6.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@YetkiId", comboBox7.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@PersonelEngelDurumu", checkBox1.Checked);
            cmd1.Parameters.AddWithValue("@PersonelHesKodu", textBox12.Text);
            cmd1.Parameters.AddWithValue("@IlId", comboBox1.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@IlceId", comboBox2.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@PersonelAdres", textBox16.Text);
            cmd1.Parameters.AddWithValue("@PersonelAcilDurumKisiAd", textBox13.Text);
            cmd1.Parameters.AddWithValue("@PersonelAcilDurumKisiTelefon", textBox14.Text);
            cmd1.Parameters.AddWithValue("@ResimId", Convert.ToInt32(textBox15.Text));//



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

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            SqlCommand cmd = new SqlCommand("select * from tbl_Personel where PersonelId = @PersonelId", con);
            SqlCommand cmd2 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId1", con);

            cmd.Parameters.AddWithValue("@PersonelId", Convert.ToInt32(textBox10.Text));




            if (con.State == ConnectionState.Closed)
            {
                con.Open();


                int ilID = 0, ilceID = 0;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        

                        textBox1.Text = dr["PersonelAd"].ToString();
                        textBox2.Text = dr["PersonelSoyad"].ToString();
                        textBox3.Text = dr["PersonelTcKimlik"].ToString();
                        //dateTimePicker1.Value = dr["PersonelDogumTarihi"];
                        comboBox4.SelectedIndex = Convert.ToInt32(dr["PersonelUyrukId"]) - 1;
                        textBox4.Text = dr["PersonelPasaportNo"].ToString();
                        textBox5.Text = dr["PersonelEposta"].ToString();
                        textBox6.Text = dr["PersonelTelefon"].ToString();
                        textBox13.Text = dr["PersonelAcilDurumKisiAd"].ToString();
                        textBox14.Text = dr["PersonelAcilDurumKisiTelefon"].ToString();
                        textBox12.Text = dr["PersonelHesKodu"].ToString();
                        textBox9.Text = dr["PersonelSicilNo"].ToString();
                        
                        comboBox5.SelectedIndex = Convert.ToInt32(dr["CinsiyetId"]) - 1;
                        
                        comboBox1.SelectedIndex = Convert.ToInt32(dr["IlId"]) - 1;
                        ilID = Convert.ToInt32(dr["IlId"]);
                        ilceID = Convert.ToInt32(dr["IlceId"]);
                        comboBox3.SelectedIndex = Convert.ToInt32(dr["UlkeId"]) - 1;

                        comboBox6.SelectedIndex = Convert.ToInt32(dr["GorevId"]) - 1;
                        comboBox7.SelectedIndex = Convert.ToInt32(dr["YetkiId"]) - 1;
                        




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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            //SqlCommand cmd = new SqlCommand("sp_personelupdate", con);
            //SqlCommand cmd2 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId1", con);

            //cmd.CommandType = CommandType.StoredProcedure;

            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //        con.Open();

            SqlParameter[] cmd = new SqlParameter[26];

            cmd[0] = new SqlParameter("@PersonelId", textBox10.Text);
            cmd[1] = new SqlParameter("@PersonelAd", textBox1.Text);
            cmd[2] = new SqlParameter("@PersonelSoyad", textBox2.Text);
            cmd[3] = new SqlParameter("@PersonelTcKimlik", textBox3.Text);
            cmd[4] = new SqlParameter("@PersonelDogumTarihi", dateTimePicker1.Value);
            cmd[5] = new SqlParameter("@PersonelUyrukId", comboBox4.SelectedIndex + 1);
            cmd[6] = new SqlParameter("@PersonelPasaportNo", textBox4.Text);
            cmd[7] = new SqlParameter("@PersonelEposta", textBox5.Text);
            cmd[8] = new SqlParameter("@PersonelTelefon", textBox6.Text);
            cmd[9] = new SqlParameter("@CinsiyetId", comboBox5.SelectedIndex + 1);
            cmd[10] = new SqlParameter("@PersonelIseGirisTarihi", dateTimePicker2.Value);
            cmd[11] = new SqlParameter("@PersonelIstenCikisTarihi", dateTimePicker3.Value);
            cmd[12] = new SqlParameter("@PersonelSaatlikUcret", Convert.ToDecimal(textBox7.Text));
            cmd[13] = new SqlParameter("@PersonelMaas", Convert.ToDecimal(textBox8.Text));//
            cmd[14] = new SqlParameter("@PersonelSicilNo", textBox9.Text);
            cmd[15] = new SqlParameter("@GorevId", comboBox6.SelectedIndex + 1);
            cmd[16] = new SqlParameter("@YetkiId", comboBox7.SelectedIndex + 1);
            cmd[17] = new SqlParameter("@PersonelEngelDurumu", checkBox1.Checked);
            cmd[18] = new SqlParameter("@PersonelHesKodu", textBox12.Text);
            cmd[19] = new SqlParameter("@IlId", comboBox1.SelectedIndex + 1);
            cmd[20] = new SqlParameter("@IlceId", comboBox2.SelectedIndex + 1);
            cmd[21] = new SqlParameter("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd[22] = new SqlParameter("@PersonelAdres", textBox16.Text);
            cmd[23] = new SqlParameter("@PersonelAcilDurumKisiAd", textBox13.Text);
            cmd[24] = new SqlParameter("@PersonelAcilDurumKisiTelefon", textBox14.Text);
            cmd[25] = new SqlParameter("@ResimId", Convert.ToInt32(textBox15.Text));

            HelperSql.SqlOkuyucuDondurWithSp("sp_personelupdate", true, cmd);

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
    }


}

