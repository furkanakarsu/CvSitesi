using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminKonferanslar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KONFERANSTableAdapter dt = new DataSet1TableAdapters.KONFERANSTableAdapter();
            Repeater1.DataSource = dt.KonferansListele();
            Repeater1.DataBind();
        }
    }
}