using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OpretMaerke : System.Web.UI.Page
{
    CarFac objcarfac = new CarFac();
    Tjek objTjek = new Tjek();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (txtinput.Text != "")
        {
            objcarfac.OpretMearke(txtinput.Text); 
            litMsg.Text = "<b style='color: green'>Mærket er oprettet! (Siden refresher om 3 sekunder)</b>";
            string url = Request.RawUrl;
            Response.AddHeader("REFRESH", "3;URL=" + url + "");
        }
        else
        {
            litMsg.Text = "<b style='color: red'>Du skal udfylde feltet!</b>";
        }
    }
}