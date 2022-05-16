using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmKullanicilar : Form
    {
        public FrmKullanicilar()
        {
            InitializeComponent();
        }



        public string UserType;  // Kullanıcı türüne göre datagried doldurulacak

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            if(UserType == "Öğrenciler")
            { 
                SqlDataAdapter da = new SqlDataAdapter("Select UserName as 'Kullanıcı Adı',Name as'İsim',Surname as 'Soyisim',Mail From tblUsers where UserTypeID=3", bgl.Baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridOgrenciler.DataSource = dt;
                lblUserType.Text = UserType;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select UserName as 'Kullanıcı Adı',Name as'İsim',Surname as 'Soyisim',Mail From tblUsers where UserTypeID=2", bgl.Baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridOgrenciler.DataSource = dt;
                lblUserType.Text = UserType;
            } 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAdminAnaMenu frmAdminAnaMenu = new FrmAdminAnaMenu();
            this.Hide();
            frmAdminAnaMenu.Show();
        }
    }
}
