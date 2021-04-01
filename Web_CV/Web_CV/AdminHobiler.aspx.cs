using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminHobiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBILERTableAdapter dt = new DataSet1TableAdapters.HOBILERTableAdapter();
            Repeater1.DataSource = dt.HobiListele();
            Repeater1.DataBind();
        }
    }
}