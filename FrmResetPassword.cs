using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmResetPassword : Form
    {
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        public string userName2;
        public string ad;
        public string mail;
        public string eskiSifre;
        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlBaglantisi bgl = new SqlBaglantisi();
            
            SqlCommand sqlCommand = new SqlCommand("Select * from tblUsers where UserName=@p1", bgl.Baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                ad = dr["UserName"].ToString();
                mail = dr["Mail"].ToString();
                eskiSifre = dr["Password"].ToString();
            }
            

            if(txtKullaniciAdi.Text != ad || txtMail.Text != mail || txtEskiSifre.Text!=eskiSifre)
            {
                MessageBox.Show("Girdiğiniz bilgiler kayıtlarımız ile eşleşmemektedir");
            }
            else
            {
                if (txtYeniSifre.Text == txtYeniTekrar.Text)
                {

                    SqlCommand komut = new SqlCommand("UPDATE tblUsers set Password='" + txtYeniSifre.Text + "' WHERE UserName='" + txtKullaniciAdi.Text + "' AND Mail='" + txtMail.Text + "'", bgl.Baglanti());
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();
                    MessageBox.Show("Şifreniz değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giridiğiniz şifreler aynı değil");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtYeniSifre.UseSystemPasswordChar = false;
            txtYeniTekrar.UseSystemPasswordChar = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgrenciAnaMenu frmOgrenciAnaMenu = new FrmOgrenciAnaMenu();
            frmOgrenciAnaMenu.userName = userName2;
            this.Hide();
            frmOgrenciAnaMenu.Show();
        }

        private void FrmResetPassword_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = userName2;
        }
    }
}
