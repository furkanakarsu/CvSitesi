using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();
                txtYetenek.Text = dt.YetenekGetir(Convert.ToInt32(id))[0].Yetenek;
                
            }
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.YETENEKLERTableAdapter dt = new DataSet1TableAdapters.YETENEKLERTableAdapter();

            dt.YetenekGuncelle(txtYetenek.Text, Convert.ToInt32(txtID.Text));
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}