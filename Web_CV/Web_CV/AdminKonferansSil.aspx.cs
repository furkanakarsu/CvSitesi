using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminKonferansSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32 (Request.QueryString["ID"]);
            DataSet1TableAdapters.KONFERANSTableAdapter dt = new DataSet1TableAdapters.KONFERANSTableAdapter();
            dt.KonferansSil(id);
            Response.Redirect("AdminKonferanslar.aspx");

        }
    }
}