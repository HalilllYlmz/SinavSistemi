using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            if(type == 2)
            {
                button1.Text = "Ekle";
                this.Text = "Sınav Sorumlusu EKle";
            }
            this.tblUsersTableAdapter.Fill(this.onlineSinavSistemiDataSet.tblUsers);
        }

        public string userType;

        public int type;  // Veritabanına sayı ile kayıtlı 1 = Admin // 2 = Sınav Sorumlusu // 3 = Öğrenci
        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            if (userType == "Sınav Sorumlusu")
            {
                type = 2;
                this.Text = "Sınav Sorumlusu Ekle";
            }
            else
            {
                type = 3;
                this.Text = "Kayıt Ol";
            }

            SqlCommand komut = new SqlCommand("INSERT INTO tblUsers (UserName,Name,Surname,Mail,Password,UserTypeID) VALUES ('" + txtUserName.Text + "','" + txtName.Text + "','" + txtSurname.Text + "','" + txtMail.Text + "','" + txtPassword.Text + "','" + type + "')", bgl.Baglanti());
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }
        void Temizle()
        {
            txtUserName.Text = " ";
            txtName.Text = " ";
            txtSurname.Text = " ";
            txtMail.Text = " ";
            txtPassword.Text = " ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (type == 2)
            {
                FrmAdminAnaMenu frmAdminAnaMenu = new FrmAdminAnaMenu();
                this.Hide();
                frmAdminAnaMenu.Show();
            }
            else
            {
                FrmOgrenciGiris fr = new FrmOgrenciGiris();
                this.Hide();
                fr.Show();
            }

        }
    }
}
