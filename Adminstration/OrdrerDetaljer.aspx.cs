using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OrdrerDetaljer : System.Web.UI.Page
{
    OrdrerFac objOrd = new OrdrerFac();

    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }

        dt = objOrd.HentOrder();
        DataRow dr = dt.Rows[0];

        litDetajler.Text += "<h3>Kunde detaljer</h3>";
        litDetajler.Text += "<b>Kunde navn: </b>" + dr["fldNavn"].ToString() + "<br />";
        litDetajler.Text += "<b>Adresse: </b>" + dr["fldAdresse"].ToString() + "<br />";
        litDetajler.Text += "<b>Postnummer: </b>" + dr["fldPostnr"].ToString() + "<br />";
        litDetajler.Text += "<b>By: </b>" + dr["fldBy"].ToString() + "<br />";
        litDetajler.Text += "<b>E-Mail </b>" + dr["fldMail"].ToString() + "<br />";

        litDetajler.Text += "<h3>Produkt detaljer</h3>";
        litDetajler.Text += "<img src='../Images/Dele/" + dr["fldDelBillede"].ToString() + "'><br />";
        litDetajler.Text += "<b>Del navn: </b>" + dr["fldDelNavn"].ToString() + "<br />";
        litDetajler.Text += "<b>Del tekst: </b>" + dr["fldDelTekst"].ToString() + "<br />";
        litDetajler.Text += "<b>Pris: </b>" + dr["fldDelPris"].ToString();
    }
}