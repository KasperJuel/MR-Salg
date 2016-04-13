using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produkt : System.Web.UI.Page
{
    CarFac objCar = new CarFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objCar.HentAltUdFraID(Convert.ToInt32(Request.QueryString["id"]));

        litProdukt.Text += "<div class='prod-oversigt'>";

        foreach (DataRow dr in dt.Rows)
        {
            litProdukt.Text += "<div class='prod-info-left'>";
            litProdukt.Text += "<img src='Images/Dele/" + dr["fldDelBillede"] + "' alt='" + dr["fldDelNavn"] + "' class='img-overview'>";
            litProdukt.Text += "</div>";

            litProdukt.Text += "<div class='prod-info-right'>";
            litProdukt.Text += "<h1>" + dr["fldDelNavn"].ToString() + "</h1>";
            litProdukt.Text += "<p><b>Bil mærke: " + dr["fldMaerkeNavn"] + "</b></p>";
            litProdukt.Text += "<p><b>Model: " + dr["fldModelNavn"] + "</b></p>";
            litProdukt.Text += "<p>Motor: " + dr["fldMotorStoerelse"] + "</p>";
            litProdukt.Text += "<p>Del navn: " + dr["fldDelNavn"] + "</p>";
            litProdukt.Text += "<p><b>Pris: " + dr["fldDelPris"] + ",-</b></p><br />";
            litProdukt.Text += "<p>Om del: " + dr["fldDelTekst"] + "</p>";
            litProdukt.Text += "<a href='Bestilling.aspx?bestillingsid=" + dr["fldDelID"] + "' class='btn-bestil-del'>Bestil her</a>";
            litProdukt.Text += "</div>";        
        }

        litProdukt.Text += "</div>";
    }
}