using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace OnlineSinavSistemi
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        public string userName;
        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            this.Text = userName;
        }

        public string Password;
        public string Email;
        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand cmd2 = new SqlCommand("select Password , Mail from tblUsers where UserName=@veri2", bgl.Baglanti());
            cmd2.Parameters.AddWithValue("@veri2", txtKullaniciAdi.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                Password = dr["Password"].ToString();
                Email = dr["Mail"].ToString();
            }

            SqlCommand komut = new SqlCommand("Select * From tblUsers Where UserName='" + txtKullaniciAdi.Text+ "'and Mail= '" + txtEPosta.Text + "'", bgl.Baglanti());    
            SqlDataReader oku = komut.ExecuteReader();


            if (oku.Read())
            {
                try
                {
                    if (bgl.Baglanti().State == ConnectionState.Closed)
                    {
                        bgl.Baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();

                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("halilyln1903@gmail.com");
                    Password = ("Yigitx.0");
                    string smptpsrvr = "smtp.gmail.com";
                    Email = (oku["Mail"].ToString());
                    string konu = ("Şifre hatırlatma maili");
                    string yaz = ("Sayın " + oku["Name"].ToString() + oku["UserName"].ToString() + "\n" + "Bizden " + tarih + " Tarihinde Şifre Hatrılarma Talebinde Bulundunuz" + "\n" + "Parolaniz:" + oku["Password"].ToString() + "\nİyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, Password);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(Email);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Şifreniz mail adresinize gönderilmistir.");
                    this.Hide();
                    FrmAnaMenu frmAna = new FrmAnaMenu();
                    frmAna.Show();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Mail Gonderme Hatasi!", hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgilere ait kullanıcı bulunamadı");
            }                          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnaMenu fr = new FrmAnaMenu();
            this.Hide();
            fr.Show();
        }
    }
}
