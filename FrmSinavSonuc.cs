using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmSinavSonuc : Form
    {
        public FrmSinavSonuc()
        {
            InitializeComponent();
        }

        public string kullaniciAdi2;
        public int sinavGunu;
        public string sinavAyi;
        private void FrmSinavSonuc_Load(object sender, EventArgs e)
        {
            this.Text = kullaniciAdi2;
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand sqlCommand = new SqlCommand("Select UserName as 'Kullanıcı Adı',SoruSira as 'Soru No',D_Y as 'Doğru-Yanlış' from tblSinavSonuc where UserName= @p1 and Gun=@p2 and Ay=@p3 order by SoruSira asc", bgl.Baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", kullaniciAdi2);
            sqlCommand.Parameters.AddWithValue("@p2", sinavGunu);
            sqlCommand.Parameters.AddWithValue("@p3", sinavAyi);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridViewSinavSonuc.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.userName2 = kullaniciAdi2;
            frmSınavGiris.ay = sinavAyi;
            this.Hide();
            frmSınavGiris.Show();
        }
    }
}
