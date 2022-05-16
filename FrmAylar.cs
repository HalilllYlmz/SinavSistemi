using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmAylar : Form
    {
        public FrmAylar()
        {
            InitializeComponent();
        }

        public string userName;

        private void FrmAylar_Load(object sender, EventArgs e)
        {
            this.Text = userName;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Ocak";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnSubat_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Şubat";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnMart_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Mart";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnNisan_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Nisan";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnMayis_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Mayıs";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnHaziran_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Haziran";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnTemmuz_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Temmuz";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnAgustos_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Ağustos";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnEylul_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Eylül";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnEkim_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Ekim";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnKasim_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Kasım";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void btnAralik_Click(object sender, EventArgs e)
        {
            FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.ay = "Aralık";
            frmSınavGiris.userName2 = userName;
            this.Hide();
            frmSınavGiris.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgrenciAnaMenu frmOgrenciAnaMenu = new FrmOgrenciAnaMenu();
            frmOgrenciAnaMenu.userName=userName;
            this.Hide();
            frmOgrenciAnaMenu.Show();
        }
    }
}
