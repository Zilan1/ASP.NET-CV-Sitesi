using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminSertifikalarGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if(Page.IsPostBack==false)
            {
                DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
                TxtSertifika.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].SERTIFIKA;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaGuncelle(TxtSertifika.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}