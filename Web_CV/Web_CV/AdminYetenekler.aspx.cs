using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminYetenekler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListele();
            Repeater1.DataBind();
        }
    }
}