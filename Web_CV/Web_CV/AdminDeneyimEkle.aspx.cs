using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CV
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtBaslik.Text != string.Empty && txtAltBaslik.Text != string.Empty && txtAciklama.Text != string.Empty && txtTarih.Text != string.Empty)
            {
                DataSet1TableAdapters.DENEYIMTableAdapter dt = new DataSet1TableAdapters.DENEYIMTableAdapter();
                dt.DeneyimEkle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtTarih.Text);
                Response.Redirect("AdminDeneyimler.aspx");
            }

            else
            {
                foreach (Control ctrl in Form.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl;

                        if (txt.Text == string.Empty)
                        {
                            txt.BackColor = Color.PaleVioletRed;
                        }
                        else
                        {
                            txt.BackColor = Color.White;

                        }
                    }
                }
            }
        }

    }
}