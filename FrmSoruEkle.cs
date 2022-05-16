using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmSoruEkle : Form
    {
        public FrmSoruEkle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("INSERT INTO tblSorular (SoruMetin,SoruResim,A,B,C,D,DogruCevap) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", rchSoruMetin.Text);
            komut.Parameters.AddWithValue("@p2", txtResim.Text);
            komut.Parameters.AddWithValue("@p3", txtA.Text);
            komut.Parameters.AddWithValue("@p4", txtB.Text);
            komut.Parameters.AddWithValue("@p5", txtC.Text);
            komut.Parameters.AddWithValue("@p6", txtD.Text);
            komut.Parameters.AddWithValue("@p7", txtDogruSecenek.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Soru Eklendi");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSınavsorumlusuAnaMenu frmSınavsorumlusuAnaMenu = new FrmSınavsorumlusuAnaMenu();
            this.Hide();
            frmSınavsorumlusuAnaMenu.Show();
        }
    }
}
