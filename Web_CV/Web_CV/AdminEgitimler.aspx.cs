using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminEgitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EGITIMTableAdapter dt = new DataSet1TableAdapters.EGITIMTableAdapter();
            Repeater1.DataSource = dt.EgitimListele();
            Repeater1.DataBind();
        }
    }
}