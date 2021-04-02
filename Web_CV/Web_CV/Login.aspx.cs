using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Web_CV
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=BlogWebDb;User ID=sa;Password=123");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from ADMIN where KullaniciAdi=@P1 and Sifre=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");
            }
            else
            {
                Response.Write("Hatalı kullanıcı adı yada şifre");
            }
            baglanti.Close();
        }
    }
}