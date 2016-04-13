using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Handelsbetingelser : System.Web.UI.Page
{
    SideFac objSide = new SideFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        dt = objSide.HentHandelsbetingelse();

        litHandel.Text = "<p>" + dt.Rows[0]["fldTekst"].ToString() + "</p>";
    }
}