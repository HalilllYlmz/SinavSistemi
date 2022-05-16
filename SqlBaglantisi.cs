using System.Data.SqlClient;

namespace OnlineSinavSistemi
{
    public class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-ECB211I;Initial Catalog=OnlineSinavSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
