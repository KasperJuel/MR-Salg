using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_DeleOversigt : System.Web.UI.Page
{
    CarFac objCar = new CarFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }

        DataTable dtCars = objCar.HentAlt();

        // Bliver udskrevet i jQuery plugin'et DataTables
        foreach (DataRow dr in dtCars.Rows)
        {
            litResult.Text += "<tr>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldMaerkeNavn"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldModelNavn"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldAargang"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldMotorStoerelse"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldDelNavn"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='Edit.aspx?edit=" + dr["fldDelID"].ToString() + "'>Rediger Del</a>";
            litResult.Text += "</td>";

            litResult.Text += "</tr>";
        }
    }
}