using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.DENEYIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMTableAdapter();
                txtBaslik.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].Baslik;
                txtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].AltBaslik;
                txtAciklama.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].Aciklama;
                txtTarih.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].Tarih;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DENEYIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMTableAdapter();
            dt.DeneyimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtTarih.Text, Convert.ToInt32(txtID.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}