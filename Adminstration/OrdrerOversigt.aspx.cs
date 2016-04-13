using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OrdrerOversigt : System.Web.UI.Page
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

        foreach (DataRow dr in dt.Rows)
        {
            litResult.Text += "<tr>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldOrdrerID"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += Convert.ToDateTime(dr["fldDato"].ToString()).ToString("dd.MMM yyy");
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldNavn"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldAdresse"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldPostnr"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldBy"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldMail"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldAntal"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='OrdrerDetaljer.aspx?id=" + dr["fldOrdrerID"].ToString() + "'>" + dr["fldDelNavn"].ToString() + " [Klik for detaljer]</a>";
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='?afslut=" + dr["fldOrdrerID"].ToString() +
                "' onclick=\"javascript:return confirm('Er du sikker på, at du vil Afslutte denne order? Dette vil slette ordren!')\">Afslut</a>";
            litResult.Text += "</td>";

            litResult.Text += "</tr>";

            if (!string.IsNullOrEmpty(Request.QueryString["afslut"]))
            {
                AfslutOrder();
            }
        }
    }

    protected void AfslutOrder()
    {
        int sletID = Convert.ToInt32(Request.QueryString["afslut"]);
        int numRows = objOrd.AfslutOrder(sletID);

        if (numRows > 0)
        {
            Response.Redirect("OrdrerOversigt.aspx");
        }
        else
        {
            litResult.Text = "Noget gik galt, order'en blev ikke afsluttet!";
        }
    }
}