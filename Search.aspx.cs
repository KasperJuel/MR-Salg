using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    CarFac objCar = new CarFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["result"]))
        {
            dt = objCar.Soegning(Request.QueryString["result"]);

            if (dt.Rows.Count > 0)
            {
                litSearch.Text += "<ul class='ul-search'>";
                foreach (DataRow dr in dt.Rows)
                {
                    litSearch.Text += "<li class='prod-search'>";

                    litSearch.Text += "<div class='center-cropped'>";
                    litSearch.Text += "<a href='Bestilling.aspx?bestillingsid=" + dr["fldDelID"] + "'>" + "<img src='Images/Dele/" + dr["fldDelBillede"] + "' alt='" + dr["fldDelNavn"] + "' /></a>";
                    litSearch.Text += "</div>";

                    litSearch.Text += "<div class='prod-search-info'>";
                    litSearch.Text += "<a href='Bestilling.aspx?bestillingsid=" + dr["fldDelID"] + "'style=' color:#000;' >" + "<h2>" + dr["fldDelNavn"] + "</h2></a>";
                    litSearch.Text += "<p><b>Bil Mærke: " + dr["fldMaerkeNavn"] + "</b></p>";
                    litSearch.Text += "<p><b>Model: " + dr["fldModelNavn"] + "</b></p>";
                    litSearch.Text += "<p>Motor: " + dr["fldMotorStoerelse"] + "</p>";
                    litSearch.Text += "<p>Årgang: " + dr["fldAargang"] + "</p>";
                    litSearch.Text += "<p>Del: " + dr["fldDelNavn"] + "</p>";
                    litSearch.Text += "</div>";

                    litSearch.Text += "</li>";
                }
                //litSearch.Text += "<div class='clear'></div>";
                litSearch.Text += "</ul>";
            }
            else
            {
                litSearch.Text = "Der var ingen matches i din søgning. Hvis du ikke kan finde hvad du leder efter her, er du velkommen til at kontakte mig, og så vil jeg skaffe delen hjem inden for 1-2 hverdage. Udfyld formen med dine informationer og hvilken del du søger ved at klikke <a href='Kontakt.aspx' style='color: #000; font-weight: bold;'>her</a>.";
            }
        }

        if (!string.IsNullOrEmpty(Request.QueryString["ddlresult"]))
        {
            dt = objCar.ddlSoegningUdFraFK(Convert.ToInt32(Request.QueryString["ddlresult"]));

            if (dt.Rows.Count > 0)
            {
                litSearch.Text += "<ul class='ul-search'>";
                foreach (DataRow dr in dt.Rows)
                {
                    litSearch.Text += "<li class='prod-search'>";

                    litSearch.Text += "<div class='center-cropped'>";
                    litSearch.Text += "<a href='Bestilling.aspx?bestillingsid=" + dr["fldDelID"] + "'>" + "<img src='Images/Dele/" + dr["fldDelBillede"] + "' alt='" + dr["fldDelNavn"] + "' /></a>";
                    litSearch.Text += "</div>";

                    litSearch.Text += "<div class='prod-search-info'>";
                    litSearch.Text += "<a href='Bestilling.aspx?bestillingsid=" + dr["fldDelID"] + "'style=' color:#000;' >" + "<h2>" + dr["fldDelNavn"] + "</h2></a>"; ;
                    litSearch.Text += "<p><b>Bil Mærke: " + dr["fldMaerkeNavn"] + "</b></p>";
                    litSearch.Text += "<p><b>Model: " + dr["fldModelNavn"] + "</b></p>";
                    litSearch.Text += "<p>Motor: " + dr["fldMotorStoerelse"] + "</p>";
                    litSearch.Text += "<p>Årgang: " + dr["fldAargang"] + "</p>";
                    litSearch.Text += "<p>Del: " + dr["fldDelNavn"] + "</p>";
                    litSearch.Text += "</div>";

                    litSearch.Text += "</li>";
                }
                //litSearch.Text += "<div class='clear'></div>";
                litSearch.Text += "</ul>";
            }
            else
            {
                litSearch.Text = "Der var ingen matches i din søgning";
            }
        }
    }
}