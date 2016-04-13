using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OpretKategori : System.Web.UI.Page
{
    KatFac objKat = new KatFac();

    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        dt = objKat.HentKategori();

        foreach (DataRow dr in dt.Rows)
        {
            litResult.Text += "<tr>";

            litResult.Text += "<td>";
            litResult.Text += dr["fldKategori"].ToString();
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='Edit.aspx?edit=" + dr["fldKategoriID"].ToString() + "'>Rediger Kategori</a>";
            litResult.Text += "</td>";

            litResult.Text += "<td>";
            litResult.Text += "<a href='?del=" + dr["fldKategoriID"].ToString() +
                "' onclick=\"javascript:return confirm('Er du sikker på, at du vil SLETTE denne kategori?')\">Slet Kategori</a>";
            litResult.Text += "</td>";

            litResult.Text += "</tr>";
        }

        if (!string.IsNullOrEmpty(Request.QueryString["del"]))
        {
            SletKategori();
        }
    }
    protected void btnOpret_Click(object sender, EventArgs e)
    {
        if (txtKat.Text != "")
        {
            objKat.OpretKategori(txtKat.Text);

            litMsg.Text = "Kategorien blev oprettet!";

            Response.AddHeader("REFRESH", "2;URL=" + Request.RawUrl);
        }
        else
        {
            litMsg.Text = "Noget gik galt. Kategorien blev ikke oprettet!";
        }
    }

    protected void SletKategori()
    {
        int sletID = Convert.ToInt32(Request.QueryString["del"]);
        int numRows = objKat.SletKategori(sletID);

        if (numRows > 0)
        {
            Response.Redirect("OpretKategori.aspx");
        }
        else
        {
            litResult.Text = "Noget gik galt, order'en blev ikke afsluttet!";
        }
    }
}
