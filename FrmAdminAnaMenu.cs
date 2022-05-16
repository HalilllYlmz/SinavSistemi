using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace OnlineSinavSistemi
{

    
    public partial class FrmAdminAnaMenu : Form
    {
        public FrmAdminAnaMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKullanicilar frmOgrenciler = new FrmKullanicilar();
            frmOgrenciler.UserType = "Öğrenciler";
            this.Hide();
            frmOgrenciler.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            this.Hide();
            frmAnaMenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKullanicilar frmOgrenciler = new FrmKullanicilar();
            frmOgrenciler.UserType = "Sınav Sorumluları";
            this.Hide();
            frmOgrenciler.Show();
        }

        private void FrmAdminAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FrmKayitOl frmKayitOl = new FrmKayitOl();
            this.Hide();
            frmKayitOl.userType = "Sınav Sorumlusu";
            frmKayitOl.type = 2;
            frmKayitOl.Show();
        }
    }
}
