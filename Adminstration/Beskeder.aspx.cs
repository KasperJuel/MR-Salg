using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_Beskeder : System.Web.UI.Page
{
    KontaktFac objKon = new KontaktFac();

    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }

        dt = objKon.HentAlleBeskeder();

        foreach (DataRow dr in dt.Rows)
        {
            litResult.Text += "<tr>";

            litResult.Text += "<td>";
            litResult.Text += Convert.ToDateTime(dr["fldDato"].ToString()).ToString("dd.MMM yyy");
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldNavn"].ToString();
            litResult.Text += "</td>";


            litResult.Text += "<td>";
            litResult.Text += dr["fldMail"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldBesked"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='?del=" + dr["fldKontaktID"].ToString() +
                "' onclick=\"javascript:return confirm('Er du sikker på, at du vil SLETTE denne besked?')\">Slet</a>";
            litResult.Text += "</td>";

            litResult.Text += "</tr>";

            if (!string.IsNullOrEmpty(Request.QueryString["del"]))
            {
                SletBesked();
            }
        }
    }

    protected void SletBesked()
    {
        int sletID = Convert.ToInt32(Request.QueryString["del"]);
        int numRows = objKon.SletBesked(sletID);

        if (numRows > 0)
        {
            Response.Redirect("Beskeder.aspx");
        }
        else
        {
            litResult.Text = "Noget gik galt, beskeden blev ikke slettet!";
        }
    }

}