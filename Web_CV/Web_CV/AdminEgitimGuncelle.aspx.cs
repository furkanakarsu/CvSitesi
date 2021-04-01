using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
                txtBaslik.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].Baslik;
                txtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].AltBaslik;
                txtAciklama.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].Aciklama;
                txtGenelNot.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].GenelNot;
                txtTarih.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].Tarih;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
            dt.EgitimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtGenelNot.Text, txtTarih.Text, Convert.ToInt32(txtID.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}