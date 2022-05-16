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


namespace OnlineSinavSistemi
{
    public partial class FrmYanlisCozulenSorular : Form
    {
        public FrmYanlisCozulenSorular()
        {
            InitializeComponent();
        }


        int i = 0; // Lİstenin indir değeri

        public List<int> yanlisCozulenSorular = new List<int>();  // Yanlş çözülen soruların soru numarasının atılacağı liste

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string userName3;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            radioButtonA.ForeColor = Color.Black;
            radioButtonB.ForeColor = Color.Black;
            radioButtonC.ForeColor = Color.Black;
            radioButtonD.ForeColor = Color.Black;

            SoruKontrol();

            i++;
            if (i == yanlisCozulenSorular.Count)
            {
                btnSonraki.Enabled = false;
            }
            else
            {


                SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", yanlisCozulenSorular[i]);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    radioButtonA.Text = dr["A"].ToString();
                    radioButtonB.Text = dr["B"].ToString();
                    radioButtonC.Text = dr["C"].ToString();
                    radioButtonD.Text = dr["D"].ToString();
                    pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                    rchSoruMetin.Text = dr["SoruMetin"].ToString();
                    lblKontrol.Text = dr["DogruCevap"].ToString();
                    lblSoruNo.Text = dr["SoruID"].ToString();

                }

                SqlCommand soruKontrolKomutu = new SqlCommand("select * from tblSorular where SoruID=@p3", bgl.Baglanti());
                soruKontrolKomutu.Parameters.AddWithValue("@p3", yanlisCozulenSorular[i]);
                SqlDataReader drSoruKontrol = soruKontrolKomutu.ExecuteReader();
                while (drSoruKontrol.Read())
                {
                    lblKontrol.Text = drSoruKontrol["DogruCevap"].ToString();
                }

                bgl.Baglanti().Close();
            }
        }



        private void FrmYanlisCozulenSorular_Load(object sender, EventArgs e)
        {
            this.Text = userName3;

            SqlCommand sqlCommand = new SqlCommand("select * from tblSinavsonuc where D_Y='Yanlış'", bgl.Baglanti());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblSoruNo.Text = reader["SoruID"].ToString();
                yanlisCozulenSorular.Add(Convert.ToInt32(lblSoruNo.Text));
            }

            SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", yanlisCozulenSorular[i]);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                radioButtonA.Text = dr["A"].ToString();
                radioButtonB.Text = dr["B"].ToString();
                radioButtonC.Text = dr["C"].ToString();
                radioButtonD.Text = dr["D"].ToString();
                pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                rchSoruMetin.Text = dr["SoruMetin"].ToString();
                lblKontrol.Text = dr["DogruCevap"].ToString();
            }

            SqlCommand soruKontrolKomutu = new SqlCommand("select * from tblSorular where SoruID=@p3", bgl.Baglanti());
            soruKontrolKomutu.Parameters.AddWithValue("@p3", yanlisCozulenSorular[i]);
            SqlDataReader drSoruKontrol = soruKontrolKomutu.ExecuteReader();
            while (drSoruKontrol.Read())
            {
                lblKontrol.Text = drSoruKontrol["DogruCevap"].ToString();
            }

            bgl.Baglanti().Close();
        }
        private void btnSinaviBitir_Click_1(object sender, EventArgs e)
        {
            FrmYanlisCozulenSorularRapor frmYanlisCozulenSorularRapor = new FrmYanlisCozulenSorularRapor();
            frmYanlisCozulenSorularRapor.username4 = userName3;
            this.Hide();
            frmYanlisCozulenSorularRapor.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgrenciAnaMenu frmOgrenciAnaMenu = new FrmOgrenciAnaMenu();
            this.Hide();
            frmOgrenciAnaMenu.userName = userName3;
            frmOgrenciAnaMenu.Show();
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            CevapGoster();
        }


        public void SoruKontrol() // Sorunun doğru oluğ olmadığını kontrol eder ve veritabanına atar.
        {
            if (radioButtonA.Checked == true)
            {
                if (radioButtonA.Text == lblKontrol.Text)
                {
                    lblKontrol.Text = "Doğru";
                }
                else
                    lblKontrol.Text = "Yanlış";
            }

            if(radioButtonB.Checked == true)
            {
                if (radioButtonB.Text == lblKontrol.Text)
                {
                    lblKontrol.Text = "Doğru";
                }
                else
                    lblKontrol.Text = "Yanlış";
            }
            if (radioButtonC.Checked == true)
            {
                if (radioButtonC.Text == lblKontrol.Text)
                {
                    lblKontrol.Text = "Doğru";
                }
                else
                    lblKontrol.Text = "Yanlış";
            }
            if (radioButtonD.Checked == true)
            {
                if (radioButtonD.Text == lblKontrol.Text)
                {
                    lblKontrol.Text = "Doğru";
                }
                else
                    lblKontrol.Text = "Yanlış";
            }

            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("INSERT INTO tblYanlisCozulenSorular (UserName,SoruID,D_Y) VALUES (@p1,@p2,@p3)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", userName3);
            komut.Parameters.AddWithValue("@p2", lblSoruNo.Text);
            komut.Parameters.AddWithValue("@p3", lblKontrol.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        public void CevapGoster()
        {
            if (radioButtonA.Text == lblKontrol.Text)
            {
                radioButtonA.ForeColor = Color.Green;
                radioButtonA.Checked = true;
            }
            else
            {
                radioButtonA.ForeColor = Color.Red; ;
            }

            if (radioButtonB.Text == lblKontrol.Text)
            {
                radioButtonB.ForeColor = Color.Green;
                radioButtonB.Checked = true;
            }
            else
            {
                radioButtonB.ForeColor = Color.Red; ;
            }

            if (radioButtonC.Text == lblKontrol.Text)
            {
                radioButtonC.ForeColor = Color.Green;
                radioButtonC.Checked = true;
            }
            else
            {
                radioButtonC.ForeColor = Color.Red; ;
            }
            if (radioButtonD.Text == lblKontrol.Text)
            {
                radioButtonD.ForeColor = Color.Green;
                radioButtonD.Checked = true;
            }
            else
            {
                radioButtonD.ForeColor = Color.Red; ;
            }

            bgl.Baglanti().Close();
        }
    }
    
}
