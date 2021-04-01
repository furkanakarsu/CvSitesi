using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);

            DataSet1TableAdapters.DENEYIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMTableAdapter();
            dt.DeneyimSil(id);
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}