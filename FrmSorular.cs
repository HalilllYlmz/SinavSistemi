using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmSorular : Form
    {



        public FrmSorular()
        {
            InitializeComponent();
        }


        public string userName3; //Kullanıcı Adı Veri Tabanına Eklemek İçin

        public int dakika = 9;
        public int saniye = 60;

        public int sayac = 1; // Soru saymak için

        public int SoruNo = 1;
        int DogruSayisi = 0;
        int yanlisSayisi = 0;

        public int gun = 0;

        public List<int> sayilar = new List<int>();

        public string Kontrol;

        public string ay;


        private void FrmSorular_Load(object sender, EventArgs e)
        {            
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", sayilar[i]);                      
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                radioButtonA.Text = dr["A"].ToString();
                radioButtonB.Text = dr["B"].ToString();
                radioButtonC.Text = dr["C"].ToString();
                radioButtonD.Text = dr["D"].ToString();
                pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                rchSoruMetin.Text = dr["SoruMetin"].ToString();
                Kontrol = dr["DogruCevap"].ToString();
            }

            SqlCommand soruKontrolKomutu = new SqlCommand("select * from tblSorular where SoruID=@KontrolCevap", bgl.Baglanti());
            soruKontrolKomutu.Parameters.AddWithValue("@KontrolCevap", sayilar[i]);
            SqlDataReader drSoruKontrol = soruKontrolKomutu.ExecuteReader();
            while (drSoruKontrol.Read())
            {
                Kontrol = drSoruKontrol["DogruCevap"].ToString();
            }

            bgl.Baglanti().Close();

            // Geri Sayım Sayacı

            timer1.Enabled = true;
            lblDakika.Text = dakika.ToString();

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            SoruCevapKontrol();
            
            i++;

            
            if (i == sayilar.Count)
            {
                btnSonraki.Enabled = false;
                sayilar.Clear();
            }

            else
            {             
                if (sayilar.Count - dogruSayaci2 <= i)
                {
                    sayac++;
                    lblSoruID.Text = sayac.ToString();
                    SqlBaglantisi bgl = new SqlBaglantisi();
                    SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());           
                    komut.Parameters.AddWithValue("@p1", sayilar[i]);    
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        radioButtonA.Text = dr["A"].ToString();
                        radioButtonB.Text = dr["B"].ToString();
                        radioButtonC.Text = dr["C"].ToString();
                        radioButtonD.Text = dr["D"].ToString();
                        pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                        rchSoruMetin.Text = dr["SoruMetin"].ToString();
                        Kontrol = dr["DogruCevap"].ToString();
                    }

                    SqlCommand soruKontrolKomutu = new SqlCommand("select * from tblSorular where SoruID=@p3", bgl.Baglanti());
                    soruKontrolKomutu.Parameters.AddWithValue("@p3", sayilar[i]);
                    SqlDataReader drSoruKontrol = soruKontrolKomutu.ExecuteReader();
                    while (drSoruKontrol.Read())
                    {
                        Kontrol = drSoruKontrol["DogruCevap"].ToString();
                    }
                    bgl.Baglanti().Close();
                }
                else
                {

                    SoruNo++;

                    sayac++;
                    lblSoruID.Text = sayac.ToString();


                    SqlBaglantisi bgl = new SqlBaglantisi();
                    SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", sayilar[i]);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        radioButtonA.Text = dr["A"].ToString();
                        radioButtonB.Text = dr["B"].ToString();
                        radioButtonC.Text = dr["C"].ToString();
                        radioButtonD.Text = dr["D"].ToString();
                        pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                        rchSoruMetin.Text = dr["SoruMetin"].ToString();
                        Kontrol = dr["DogruCevap"].ToString();
                    }

                    SqlCommand soruKontrolKomutu = new SqlCommand("select * from tblSorular where SoruID=@p3", bgl.Baglanti());
                    soruKontrolKomutu.Parameters.AddWithValue("@p3", sayilar[i]);
                    SqlDataReader drSoruKontrol = soruKontrolKomutu.ExecuteReader();
                    while (drSoruKontrol.Read())
                    {
                        Kontrol = drSoruKontrol["DogruCevap"].ToString();
                    }

                    bgl.Baglanti().Close();
                }
            }


        }




        public void SoruCevapKontrol()
        {
            

            if (lblSoruID.Text == "101")
            {
                MessageBox.Show("Sınavınız Sonlanmıştır");
                FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
                this.Hide();
                frmSınavGiris.Show();
            }
            else
            {
                if (radioButtonA.Checked == true)
                {
                    if (radioButtonA.Text == Kontrol)
                    {
                        DogruSayisi++;
                        DogruSoru();
                    }
                    else
                    {
                        yanlisSayisi++;
                        YanlisSoru();
                    }
                }

                if (radioButtonB.Checked == true)
                {
                    if (radioButtonB.Text == Kontrol)
                    {
                        DogruSayisi++;
                        DogruSoru();
                    }
                    else
                    {
                        yanlisSayisi++;
                        YanlisSoru();
                    }
                }

                if (radioButtonC.Checked == true)
                {
                    if (radioButtonC.Text == Kontrol)
                    {
                        DogruSayisi++;
                        DogruSoru();
                    }
                    else
                    {
                        yanlisSayisi++;
                        YanlisSoru();
                    }
                }

                if (radioButtonD.Checked == true)
                {
                    if (radioButtonD.Text == Kontrol)
                    {
                        DogruSayisi++;
                        DogruSoru();
                    }
                    else
                    {
                        yanlisSayisi++;
                        YanlisSoru();
                    }
                }

                userName3 = this.Text;

                
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("INSERT INTO tblSinavSonuc (UserName,SoruID,D_Y,Gun,SoruSira,Ay) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", userName3);
                komut.Parameters.AddWithValue("@p2", sayilar[i]);             
                komut.Parameters.AddWithValue("@p3", Kontrol);
                komut.Parameters.AddWithValue("@p4", gun);
                komut.Parameters.AddWithValue("@p5", sayac);
                komut.Parameters.AddWithValue("@p6", ay);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }
        }



        public void DogruSoru()
        {
            lblDogruSayisi.Text = DogruSayisi.ToString();
            Kontrol = "Doğru";
        }
        public void YanlisSoru()
        {
            lblYanlis.Text = yanlisSayisi.ToString();
            Kontrol = "Yanlış";
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSaniye.Text = saniye.ToString();
            if (saniye == 0)
            {
                dakika--;
                if (dakika == 0)
                {
                    timer1.Stop();
                    lblDakika.Text = dakika.ToString();
                    lblSaniye.Text = saniye.ToString();

                    MessageBox.Show("Sınav Süresi Dolmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    radioButtonA.Enabled = false;
                    radioButtonB.Enabled = false;
                    radioButtonC.Enabled = false;
                    radioButtonD.Enabled = false;
                }
                else
                {
                    lblDakika.Text = dakika.ToString();
                    saniye = 60;
                }

            }
        }

        public int dogruSayaci2 = 0;  // frmSoruGiris den veri taşımak için kullanılan değişken

        public int i = 0;

        

        private void btnSinaviBitir_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            userName3 = this.Text;
            SqlCommand komut = new SqlCommand("INSERT INTO tblOgrenciSinavSonuclari (UserName,SinavGunu,DogruSayisi,YanlisSayisi,Ay) VALUES (@p1,@p2,@p3,@p4,@p5)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", userName3);
            komut.Parameters.AddWithValue("@p2", gun);
            komut.Parameters.AddWithValue("@p3", lblDogruSayisi.Text);
            komut.Parameters.AddWithValue("@p4", lblYanlis.Text);
            komut.Parameters.AddWithValue("@p5", ay);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close(); 

            FrmSinavSonuc frmSinavSonuc = new FrmSinavSonuc();
            frmSinavSonuc.kullaniciAdi2 = this.Text;
            frmSinavSonuc.sinavAyi = ay;
            frmSinavSonuc.sinavGunu = gun;
            this.Hide();
            frmSinavSonuc.Show();
        }
    }
}




