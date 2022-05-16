using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineSinavSistemi
{
    public partial class FrmOgrSnvSonuc : Form
    {
        public FrmOgrSnvSonuc()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmOgrSnvSonuc_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tblOgrenciSinavSonuclari", bgl.Baglanti());

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                string userName = dr["UserName"].ToString();
                if (!cmbOgrenciIsım.Items.Contains(userName))
                {
                    cmbOgrenciIsım.Items.Add(dr["UserName"]);
                }   
            }
            bgl.Baglanti().Close();
        }

        private void cmbOgrenciIsım_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            renk.BackColor = Color.Yellow;
            SqlCommand sqlCommand = new SqlCommand("Select UserName as 'Öğrenci Adı',DogruSayisi as 'Doğru Sayısı', YanlisSayisi as 'Yanlış Sayısı' ,SinavGunu as 'Sınav Günü' , Ay from tblOgrenciSinavSonuclari where UserName= @p1 order by SinavGunu asc", bgl.Baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", cmbOgrenciIsım.Text);    
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridViewSonuclar.DataSource = dt;

            for (int i = 0; i < dataGridViewSonuclar.Rows.Count - 1; i++)
            {
                dataGridViewSonuclar.Rows[i].DefaultCellStyle = renk;
                dataGridViewSonuclar.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSınavsorumlusuAnaMenu frmSınavsorumlusuAnaMenu = new FrmSınavsorumlusuAnaMenu();
            this.Hide();
            frmSınavsorumlusuAnaMenu.Show();
        }

     
    }
}
