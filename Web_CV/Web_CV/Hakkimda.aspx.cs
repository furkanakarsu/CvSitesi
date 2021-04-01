using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.HAKKIMDATableAdapter dt = new DataSet1TableAdapters.HAKKIMDATableAdapter();
                txtAd.Text = dt.HakkımdaListele()[0].Ad;
                txtSoyad.Text = dt.HakkımdaListele()[0].Soyad;
                txtAdres.Text = dt.HakkımdaListele()[0].Adres;
                txtMail.Text = dt.HakkımdaListele()[0].Mail;
                txtTelefon.Text = dt.HakkımdaListele()[0].Telefon;
                txtKisaNot.Text = dt.HakkımdaListele()[0].KisaNot;
                txtResim.Text = dt.HakkımdaListele()[0].Fotograf;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HAKKIMDATableAdapter dt1 = new DataSet1TableAdapters.HAKKIMDATableAdapter();
            dt1.HakkımdaGuncelle(txtAd.Text, txtSoyad.Text, txtAdres.Text, txtMail.Text, txtTelefon.Text, txtKisaNot.Text, txtResim.Text);
            Response.Redirect("Default.Aspx");
        }
    }
}