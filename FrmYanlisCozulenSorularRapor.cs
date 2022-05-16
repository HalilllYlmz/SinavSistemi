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
    public partial class FrmYanlisCozulenSorularRapor : Form
    {
        public FrmYanlisCozulenSorularRapor()
        {
            InitializeComponent();
        }

        public string username4;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmYanlisCozulenSorularRapor_Load(object sender, EventArgs e)
        {
            this.Text = username4;
            radioButtonA.Visible = false;
            radioButtonB.Visible = false;
            radioButtonC.Visible = false;
            radioButtonD.Visible = false;
            rchSoruMetin.Visible = false;
            pictureBox1.Visible = false;

            SqlCommand sqlCommand = new SqlCommand("select  distinct(SoruID) as 'Soru No' , D_Y from tblYanlisCozulenSorular ", bgl.Baglanti());            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridViewSinavraporu.DataSource = dt;
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
        
            SqlCommand komut = new SqlCommand("select * from tblSorular where SoruID=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", SoruNo);
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

            if (radioButtonA.Text == lblKontrol.Text)
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
            SqlCommand sqlCommand = new SqlCommand("delete from tblYanlisCozulenSorular", bgl.Baglanti());
            sqlCommand.ExecuteNonQuery();
            bgl.Baglanti().Close();

            FrmOgrenciAnaMenu frmOgrenciAnaMenu = new FrmOgrenciAnaMenu();
            frmOgrenciAnaMenu.userName = username4;
            this.Hide();
            frmOgrenciAnaMenu.Show();
        }
    }
}
