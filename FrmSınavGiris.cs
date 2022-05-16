using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmSınavGiris : Form
    {
        public void btnKapat()
        {
            btn1.Enabled = false;
        }


        public FrmSınavGiris()
        {
            InitializeComponent();
        }

        public string userName2;

        public string ay;  // Hangi ay giriş yaptığı bilgisi tutulacak

        private void FrmSınavGiris_Load(object sender, EventArgs e)
        {
            this.Text = userName2;
        }

        string SoruID;

        SqlBaglantisi bgl = new SqlBaglantisi();

        public int dogruSayaci = 0;  // Doğru sayısını saydırmak için kullanılacak
        private void button2_Click(object sender, EventArgs e)
        {

            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            frmSorular.gun = 2;
            frmSorular.ay = ay;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay",ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            
            frmSorular.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {       
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();          
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if(ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=1 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.Text = this.Text;
            frmSorular.ay = ay;
            frmSorular.gun = 1;
            this.Hide();
            frmSorular.Show();
            
        }

        

        private void btn3_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=2 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }
            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 3;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=3 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            frmSorular.gun = 4;
            frmSorular.ay = ay;
            frmSorular.Show();
        

        
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }


            frmSorular.gun = 5;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=5 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 6;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=6 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand3.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr2 = sqlCommand.ExecuteReader();
                while (dr2.Read())
                {
                    SoruID = dr2["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 7;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=7 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =1 and UserName=@studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 8;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=8 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =2 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 9;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=9 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =3 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 10;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=10 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =4 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=11 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 11;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =12 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 12;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=12 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =6 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 13;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=13 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =7 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 14;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=14 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =8 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 15;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=15 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =9 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 16;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=16 and UserName = @studentName  and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =10 and UserName = @studentName2  and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 17;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=17 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =11 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 18;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=18 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =12 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 19;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=19 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =13 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 20;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=20 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =14 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 21;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=21 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =15 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 22;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=22 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =16 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 23;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=23 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =17 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=4 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 24;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=24 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =18 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 25;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=25 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =19 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 26;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=26 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =20 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 27;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=27 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =21 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 28;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=28 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =22 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 29;
            frmSorular.ay = ay;
            frmSorular.Show();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                frmSorular.sayilar.Add(random.Next(1, 100));
            }

            frmSorular.Text = this.Text;
            this.Hide();

            SqlCommand komut = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=29 and UserName = @studentName and Ay=@ay", bgl.Baglanti());
            komut.Parameters.AddWithValue("@studentName", userName2);
            komut.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SoruID = dr["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            SqlCommand komut2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun =23 and UserName = @studentName2 and Ay=@ay", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@studentName2", userName2);
            komut2.Parameters.AddWithValue("@ay", ay);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                SoruID = dr2["SoruID"].ToString();
                frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                frmSorular.dogruSayaci2++;
            }

            if (ay == "Şubat")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mart")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Nisan")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Mayıs")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Şubat'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

            }
            else if (ay == "Haziran")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Mart'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ocak'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Temmuz")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Nisan'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ağustos")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Mayıs'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Eylül")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Ekim")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }

                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Temmuz'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else if (ay == "Kasım")
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ekim'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Ağustos'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Kasım'", bgl.Baglanti());
                sqlCommand.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr4 = sqlCommand.ExecuteReader();
                while (dr4.Read())
                {
                    SoruID = dr4["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand2 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Eylül'", bgl.Baglanti());
                sqlCommand2.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr3 = sqlCommand2.ExecuteReader();
                while (dr3.Read())
                {
                    SoruID = dr3["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
                SqlCommand sqlCommand3 = new SqlCommand("select SoruID from tblSinavSonuc where D_Y='Doğru' and Gun=30 and UserName=@sName and Ay='Haziran'", bgl.Baglanti());
                sqlCommand3.Parameters.AddWithValue("@sName", userName2);
                SqlDataReader dr5 = sqlCommand3.ExecuteReader();
                while (dr5.Read())
                {
                    SoruID = dr5["SoruID"].ToString();
                    frmSorular.sayilar.Add(Convert.ToInt32(SoruID));
                    frmSorular.dogruSayaci2++;
                }
            }

            frmSorular.gun = 30;
            frmSorular.ay = ay;
            frmSorular.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAylar frmAylar = new FrmAylar();
            frmAylar.userName = userName2;
            this.Hide();
            frmAylar.Show();
        }
    }

}
