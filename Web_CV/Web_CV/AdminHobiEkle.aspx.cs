using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminHobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBILERTableAdapter dt = new DataSet1TableAdapters.HOBILERTableAdapter();
            dt.HobiEkle(txtHobi.Text);
            Response.Redirect("AdminHobiler.aspx");
        }
    }
}