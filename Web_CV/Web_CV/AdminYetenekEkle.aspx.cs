using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            dt.YetenekEkle(txtYetenek.Text);
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}