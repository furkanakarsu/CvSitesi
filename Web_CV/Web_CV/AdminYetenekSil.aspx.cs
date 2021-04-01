using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            dt.YetenekSil(id);
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}