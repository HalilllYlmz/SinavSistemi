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
    public partial class FrmSinavRaporu : Form
    {
        public FrmSinavRaporu()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl= new SqlBaglantisi();

        public string geciciAy;
        public string geciciGun;

        public string sinavRaporuUserName;
        private void FrmSinavRaporu_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand1 = new SqlCommand("Select Ay from tblSinavSonuc where UserName=@p1", bgl.Baglanti());
            sqlCommand1.Parameters.AddWithValue("@p1", sinavRaporuUserName);
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            while (dr.Read())
            {            
                geciciAy = dr["Ay"].ToString();
                if (!cmbAy.Items.Contains(geciciAy))
                {
                    cmbAy.Items.Add(geciciAy);
                }
            }

            this.Text = sinavRaporuUserName;

            radioButtonA.Visible=false;
            radioButtonB.Visible=false;
            radioButtonC.Visible=false;
            radioButtonD.Visible=false;
            pictureBox1.Visible=false;
            rchSoruMetin.Visible=false;

            bgl.Baglanti().Close();

        }

        private void dataGridViewSinavraporu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButtonA.Visible = true;
            radioButtonB.Visible = true;
            radioButtonC.Visible = true;
            radioButtonD.Visible = true;
            pictureBox1.Visible = true;
            rchSoruMetin.Visible = true;

            int secilen = dataGridViewSinavraporu.SelectedCells[0].RowIndex;

            string SoruNo = dataGridViewSinavraporu.Rows[secilen].Cells[0].Value.ToString();
            string SoruGun = dataGridViewSinavraporu.Rows[secilen].Cells[2].Value.ToString();
           

            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1",SoruNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                radioButtonA.Text = dr["A"].ToString();
                radioButtonB.Text = dr["B"].ToString();
                radioButtonC.Text = dr["C"].ToString();
                radioButtonD.Text = dr["D"].ToString();
                pictureBox1.ImageLocation = dr["SoruResim"].ToString();
                rchSoruMetin.Text = dr["SoruMetin"].ToString();
                lblKontrol.Text = dr["DogruCevap"].ToString();
            }

            if(radioButtonA.Text == lblKontrol.Text)
            {
                radioButtonA.ForeColor = Color.Green;
            }
            else
            {
                radioButtonA.ForeColor = Color.Red; ;
            }
            
            if (radioButtonB.Text == lblKontrol.Text)
            {
                radioButtonB.ForeColor = Color.Green;
            }
            else
            {
                radioButtonB.ForeColor = Color.Red; ;
            }
            
            if (radioButtonC.Text == lblKontrol.Text)
            {
                radioButtonC.ForeColor = Color.Green;
            }
            else
            {
                radioButtonC.ForeColor = Color.Red; ;
            }
            if (radioButtonD.Text == lblKontrol.Text)
            {
                radioButtonD.ForeColor = Color.Green;            
            }
            else
            {
                radioButtonD.ForeColor = Color.Red; ;
            }

            bgl.Baglanti().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgrenciAnaMenu frmOgrenciAnaMenu = new FrmOgrenciAnaMenu();
            frmOgrenciAnaMenu.userName = this.Text;
            this.Hide();
            frmOgrenciAnaMenu.Show();
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGun.Text = "";
            cmbGun.Items.Clear();
            SqlCommand sqlCommand2 = new SqlCommand("Select Gun from tblSinavSonuc where UserName=@p1 and Ay=@p2", bgl.Baglanti());
            sqlCommand2.Parameters.AddWithValue("@p1", sinavRaporuUserName);
            sqlCommand2.Parameters.AddWithValue("@p2", cmbAy.Text);
            SqlDataReader dr2 = sqlCommand2.ExecuteReader();
            while (dr2.Read())
            {
                geciciGun = dr2["Gun"].ToString();
                if (!cmbGun.Items.Contains(geciciGun))
                {
                    cmbGun.Items.Add(geciciGun);
                }
            }
        }

        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select SoruID as 'Soru No',D_Y as 'Doğru-Yanlış' , Gun as 'Soru Kaçıncı Gün Çözülmüştür' from tblSinavSonuc where UserName= @p1 and Ay=@p2 and Gun=@p3 order by SoruId asc", bgl.Baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", sinavRaporuUserName);
            sqlCommand.Parameters.AddWithValue("@p2", cmbAy.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbGun.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridViewSinavraporu.DataSource = dt;
            bgl.Baglanti().Close();
        }
    }
}
