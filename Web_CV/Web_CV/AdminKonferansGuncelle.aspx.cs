using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminKonferansGuncelle : System.Web.UI.Page
    {
        DataSet1TableAdapters.KONFERANSTableAdapter dt = new DataSet1TableAdapters.KONFERANSTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                txtKonferans.Text = dt.KonferansGetir(id)[0].Konferanslar;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt.KonferansGuncelle(txtKonferans.Text, Convert.ToInt32(txtID.Text));
            Response.Redirect("AdminKonferanslar.aspx");
        }
    }
}