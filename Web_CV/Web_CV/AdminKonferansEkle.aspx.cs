using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminKonferansEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KONFERANSTableAdapter dt = new DataSet1TableAdapters.KONFERANSTableAdapter();
            dt.KonferansEkle(txtKonferans.Text);
            Response.Redirect("AdminKonferanslar.aspx");
        }
    }
}