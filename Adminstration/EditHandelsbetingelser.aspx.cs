using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_EditHandelsbetingelser : System.Web.UI.Page
{
    SideFac objSide = new SideFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }

        RedigerHandelsbetingelser();
    }

    protected void RedigerHandelsbetingelser()
    {
        dt = objSide.HentHandelsbetingelse();

        if (!IsPostBack)
        {
            txtBetingelser.Text = dt.Rows[0]["fldTekst"].ToString().Replace("<br />", Environment.NewLine);
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        objSide.RedigerHandelsbetingelser(txtBetingelser.Text.Replace(Environment.NewLine, "<br />"));

        Response.Redirect(Request.RawUrl);
    }
}