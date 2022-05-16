using System;
using System.Windows.Forms;

namespace OnlineSinavSistemi
{
    public partial class FrmAnaMenu : Form
    {


        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSinavSorumlusuGiris fr = new FrmSinavSorumlusuGiris();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris fr = new FrmOgrenciGiris();
            fr.Show();
            this.Hide();
        }
    }
}
