using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineSinavSistemi
{
    public partial class FrmOgrenciAnaMenu : Form
    {

        public string kullaniciAdi;
        public FrmOgrenciAnaMenu()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAylar frmAylar = new FrmAylar();
            frmAylar.userName = userName;
            this.Hide();
            frmAylar.Show();


            /*
             * FrmSınavGiris frmSınavGiris = new FrmSınavGiris();
            frmSınavGiris.userName2 = this.Text;
            this.Hide();
            frmSınavGiris.Show();
            */
        }

        public string userName;
        private void FrmOgrenciAnaMenu_Load(object sender, EventArgs e)
        {
            this.Text = userName;
        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            List<int> yanlisCozulenSorular2 = new List<int>();
            SqlCommand sqlCommand = new SqlCommand("select * from tblSinavsonuc where D_Y='Yanlış'", bgl.Baglanti());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string x = reader["SoruID"].ToString(); 
                yanlisCozulenSorular2.Add(Convert.ToInt32(x));
            }

            FrmYanlisCozulenSorular frmYanlisCozulenSorular = new FrmYanlisCozulenSorular();
            if(yanlisCozulenSorular2.Count==0)
            { 
                MessageBox.Show("Yanlış çözülen soru bulunmamaktadır");              
            }
            else
            {
                this.Hide();
                frmYanlisCozulenSorular.userName3 = this.Text;
                frmYanlisCozulenSorular.Show();
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmSinavRaporu frmSinavRaporu = new FrmSinavRaporu();
            frmSinavRaporu.sinavRaporuUserName = this.Text;
            this.Hide();
            frmSinavRaporu.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            this.Hide();
            frmAnaMenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmResetPassword frmResetPassword = new FrmResetPassword();
            frmResetPassword.userName2 = userName;
            this.Hide();
            frmResetPassword.Show();

        }
    }
}
