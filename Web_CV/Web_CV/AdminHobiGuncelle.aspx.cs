using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack==false)
            {
                DataSet1TableAdapters.HOBILERTableAdapter dt = new DataSet1TableAdapters.HOBILERTableAdapter();
               txtHobi.Text=dt.HobiGetir(Convert.ToInt32(id))[0].Hobi;
            }
         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBILERTableAdapter dt = new DataSet1TableAdapters.HOBILERTableAdapter();
            dt.HobiGuncelle(txtHobi.Text, Convert.ToInt32(txtID.Text));
            Response.Redirect("AdminHobiler.aspx");
        }
    }
}