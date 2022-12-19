using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtId.Enabled = false;
            TxtId.Text = x.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new
                    DataSet1TableAdapters.TBLEGITIMTableAdapter();
                TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtGNot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
            }
        }
        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new
                    DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGNot.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}