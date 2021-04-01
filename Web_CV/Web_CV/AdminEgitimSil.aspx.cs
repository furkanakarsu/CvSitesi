using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
            dt.EgitimSil(Convert.ToInt32(id));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}