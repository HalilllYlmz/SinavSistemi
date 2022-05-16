using System;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmSınavsorumlusuAnaMenu : Form
    {
        public FrmSınavsorumlusuAnaMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSoruEkle fr = new FrmSoruEkle();
            this.Hide();
            fr.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmOgrSnvSonuc frmOgrSnvSonuc = new FrmOgrSnvSonuc();
            this.Hide();
            frmOgrSnvSonuc.Show();
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            this.Hide();
            frmAnaMenu.Show();
        }
    }
}
