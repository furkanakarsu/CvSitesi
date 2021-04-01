using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DENEYIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMTableAdapter();
            Repeater1.DataSource = dt.DeneyimListele();
            Repeater1.DataBind();
        }
    }
}