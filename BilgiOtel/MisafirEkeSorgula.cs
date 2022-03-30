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
    public partial class MisafirEkeSorgula : Form
    {
        public MisafirEkeSorgula()
        {
            InitializeComponent();
        }

        private void MisafirEkeSorgula_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=Z36-03;Database=DB_Bilgi_Hotel;Integrated Security=true");
            SqlCommand com = new SqlCommand("Select [IlAd] from tbl_Il", con);
            SqlCommand cmd1 = new SqlCommand("SELECT TOP (1000) [IlceId],[IlceAd],[IlceAciklama],[IlId]  FROM[DB_Bilgi_Hotel].[dbo].[tbl_Ilce]",con);
            SqlCommand com1 = new SqlCommand("select [UlkeAd] from tbl_Ulke", con);
            SqlCommand com2 = new SqlCommand("SELECT [CinsiyetId],CinsiyetAd FROM tbl_Cinsiyet", con);
            SqlCommand com3 = new SqlCommand("SELECT [DilId],[DilAd],[DilAciklama],[DilKod] FROM [dbo].[tbl_Diller]", con);


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
                //SqlDataReader okuyucu1 = cmd1.ExecuteReader();
                //if (okuyucu1.HasRows) //Eger "okuyucu" uzerinde kayit varsa, okuma islemi gerceklestirilir..
                //{
                //    //Okuyabildigi kadar ilerleme kaydedebilmek icin kullanacagimiz dongu "while" dongusudur... Read metodu size false donene kadar okuma islemini gerceklestirir...
                //    while (okuyucu1.Read())
                //    {
                //        //DataReader uzerinden veri cekerken,  Kolon adini vererek verilerinizi cekme imkanina sahip olursunuz. Avantaji, sorgunuza kolon ekleseniz bile index mantigiyla calismadiginiz icin burada bir degisiklik yapmaniza gerek kalmaz. Dezavantajı; bir unboxing islemi yapmak zorunda kalirsiniz cunku veri "object" tipinde size teslim edilir...
                //        comboBox2.Items.Add(okuyucu1["IlceAd"].ToString());

                //        //comboBox3.Items.Add(okuyucu["UlkeAd"].ToString());
                //        // veya Dizi Mantığı kullanarak yapılır
                //        //comboBox1.Items.Add(okuyucu[0].ToString());
                //    }
                //}//Okuyucu ile is bittigi icin, kapatilir..
                //okuyucu1.Close();

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
                comboBox4.Items.Add("Türk");
                comboBox4.Items.Add("Yabancı");

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

                        comboBox6.Items.Add(okuyucu4["DilAd"].ToString());
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[tbl_Misafir]([MisafirAd],[MisafirSoyad],[MisafirTcKimlik],[MisafirDogumTarihi],[MisafirUyrukId],[MisafirEposta],[MisafirTelefon],[MisafirPasaportNo],[CinsiyetId],[MisafirAdres],[IlId],[IlceId],[UlkeId],[MisafirAciklama],[MisafirHesKod],[dilId])VALUES(@MisafirAd, @MisafirSoyad, @MisafirTcKimlik, @MisafirDogumTarihi, @MisafirUyrukId,@MisafirEposta, @MisafirTelefon, @MisafirPasaportNo, @CinsiyetId,@MisafirAdres, @IlId, @IlceId, @UlkeId, @MisafirAciklama, @MisafirHesKod, @dilId)", con);

            cmd1.Parameters.AddWithValue("@MisafirAd", textBox1.Text);
            cmd1.Parameters.AddWithValue("@MisafirSoyad", textBox2.Text);
            cmd1.Parameters.AddWithValue("@MisafirTcKimlik", textBox3.Text);
            cmd1.Parameters.AddWithValue("@MisafirDogumTarihi", dateTimePicker1.Value);
            
            
            

            cmd1.Parameters.AddWithValue("@MisafirPasaportNo", textBox4.Text);
            cmd1.Parameters.AddWithValue("@MisafirEposta", textBox5.Text);
            cmd1.Parameters.AddWithValue("@MisafirTelefon", textBox6.Text);
            cmd1.Parameters.AddWithValue("@MisafirAdres", textBox7.Text);
            cmd1.Parameters.AddWithValue("@MisafirHesKod", textBox8.Text);
            
            cmd1.Parameters.AddWithValue("@MisafirAciklama", textBox10.Text);



            cmd1.Parameters.AddWithValue("@IlId", comboBox1.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@IlceId", ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key);
            cmd1.Parameters.AddWithValue("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@dilId", comboBox6.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@MisafirUyrukId", comboBox4.SelectedIndex + 1);
            cmd1.Parameters.AddWithValue("@CinsiyetId", comboBox5.SelectedIndex + 1);






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

            //SqlCommand cmd = new SqlCommand("select * from tbl_Misafir where MisafirId = @MisafirId", con);
            //SqlCommand cmd2 = new SqlCommand("select IlceAd from tbl_Ilce where IlId = @IlId1", con);

            //cmd.Parameters.AddWithValue("@MisafirId", Convert.ToInt32(textBox9.Text));




            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();


            //    int ilID = 0, ilceID = 0;

            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //SqlParameter[] dr = new SqlParameter[1];
            //dr[0] = new SqlParameter("@MisafirId", textBox9.Text);

           SqlDataReader reader=  HelperSql.SqlOkuyucuDondurWithSp("select * from tbl_Misafir where MisafirId =" +textBox9.Text, false,null);

            

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = reader["MisafirAd"].ToString();
                    textBox2.Text = reader["MisafirSoyad"].ToString();
                    textBox3.Text = reader["MisafirTcKimlik"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["MisafirDogumTarihi"].ToString());
                    comboBox4.SelectedIndex = Convert.ToInt32(reader["MisafirUyrukId"]) - 1;
                    textBox5.Text = reader["MisafirEposta"].ToString();
                    textBox6.Text = reader["MisafirTelefon"].ToString();
                    textBox4.Text = reader["MisafirPasaportNo"].ToString();
                    comboBox5.SelectedIndex = Convert.ToInt32(reader["CinsiyetId"]) - 1;
                    textBox7.Text = reader["MisafirAdres"].ToString();
                    comboBox1.SelectedIndex = Convert.ToInt32(reader["IlId"]) - 1;
                    comboBox2.SelectedValue = Convert.ToInt32(reader["IlceId"]);
                    comboBox3.SelectedIndex = Convert.ToInt32(reader["UlkeId"]) - 1;
                    textBox10.Text = reader["MisafirAciklama"].ToString();
                    textBox8.Text = reader["MisafirHesKod"].ToString();
                    comboBox6.SelectedIndex = Convert.ToInt32(reader["dilId"]) - 1;

                }

            }
            reader.Close();



            //        }

            //    }
            //    dr.Close();
            //SqlParameter[] sp = new SqlParameter[1];
            //sp[0] = new SqlParameter("@IlId1", ilceID);
            //sp[1] = new SqlParameter("@IlId", ilID);
           

            //}
            //else if (con.State == ConnectionState.Open)
            //{
            //    //Baglantiyi kapatmak icin;
            //    con.Close();

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server = Z36-03; Database = DB_Bilgi_Hotel; Trusted_Connection = True;");

            SqlParameter[] cmd = new SqlParameter[17];
            

            //cmd[0] = new SqlParameter("@MisafirId", textBox9.Text);



            cmd[0] = new SqlParameter("@MisafirId", textBox9.Text);
            cmd[1] = new SqlParameter("@MisafirAd", textBox1.Text);
            cmd[2] = new SqlParameter("@MisafirSoyad", textBox2.Text);
            cmd[3] = new SqlParameter("@MisafirTcKimlik", textBox3.Text);
            cmd[4] = new SqlParameter("@MisafirDogumTarihi", dateTimePicker1.Value);



            cmd[5] = new SqlParameter("@MisafirPasaportNo", textBox4.Text);
            cmd[6] = new SqlParameter("@MisafirEposta", textBox5.Text);
            cmd[7] = new SqlParameter("@MisafirTelefon", textBox6.Text);
            cmd[8] = new SqlParameter("@MisafirAdres", textBox7.Text);
            cmd[9] = new SqlParameter("@MisafirHesKod", textBox8.Text);

            cmd[10] = new SqlParameter("@MisafirAciklama", textBox10.Text);

            cmd[11] = new SqlParameter("@IlId", comboBox1.SelectedIndex + 1);
            cmd[12] = new SqlParameter("@IlceId", comboBox2.SelectedValue);
            cmd[13] = new SqlParameter("@UlkeId", comboBox3.SelectedIndex + 1);
            cmd[14] = new SqlParameter("@dilId", comboBox6.SelectedIndex + 1);
            cmd[15] = new SqlParameter("@MisafirUyrukId", comboBox4.SelectedIndex + 1);
            cmd[16] = new SqlParameter("@CinsiyetId", comboBox5.SelectedIndex + 1);

            try
            {
                HelperSql.SqlGeriDondurmezWithSp("sp_misafirUpdate", true, cmd);
                MessageBox.Show("güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("güncellenmedi");
            }
           
           
            


            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //    int ekle = cmd.ExecuteNonQuery();
            //    MessageBox.Show(ekle + "kaydedildi");



            //}
            //else if (con.State == ConnectionState.Open)
            //{
            //    //Baglantiyi kapatmak icin;
            //    con.Close();

            //}


        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.Items.Clear();
            SqlDataReader reader1 = HelperSql.SqlOkuyucuDondurWithSp("select IlceAd,IlceID from tbl_Ilce where IlId = " + (comboBox1.SelectedIndex+1) , false, null);

            
            //SqlDataReader dr1 = cmd2.ExecuteReader();
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    data.Add(new KeyValuePair<int, string>(Convert.ToInt32(reader1["IlceID"]), reader1["IlceAd"].ToString()));
                }
            }
            comboBox2.DataSource = new BindingSource(data, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
            reader1.Close();

        }

       
    }
}
