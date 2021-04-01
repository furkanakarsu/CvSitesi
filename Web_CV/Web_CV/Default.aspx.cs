using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HAKKIMDATableAdapter dt = new DataSet1TableAdapters.HAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();


            DataSet1TableAdapters.DENEYIMTableAdapter dt1 = new DataSet1TableAdapters.DENEYIMTableAdapter();
            Repeater2.DataSource = dt1.DeneyimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.EGITIMTableAdapter dt2 = new DataSet1TableAdapters.EGITIMTableAdapter();
            Repeater3.DataSource = dt2.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.YETENEKLERTableAdapter dt3 = new DataSet1TableAdapters.YETENEKLERTableAdapter();
            Repeater4.DataSource = dt3.YetenekListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.HOBILERTableAdapter dt4 = new DataSet1TableAdapters.HOBILERTableAdapter();
            Repeater5.DataSource = dt4.HobiListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.KONFERANSTableAdapter dt5 = new DataSet1TableAdapters.KONFERANSTableAdapter();
            Repeater6.DataSource = dt5.KonferansListele();
            Repeater6.DataBind();
        }
    }
}