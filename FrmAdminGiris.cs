using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("SELECT * FROM tblUsers WHERE UserName=@p1 AND Password=@p2 AND UserTypeID=1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAdminAnaMenu fr = new FrmAdminAnaMenu();
                this.Hide();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.Baglanti().Close();
        }

        private void lnklabelSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum fr = new FrmSifremiUnuttum();
            fr.userName = txtKullaniciAdi.Text;
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            this.Hide();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false; 
        }
    }
}
