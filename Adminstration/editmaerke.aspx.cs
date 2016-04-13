using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_editmaerke : System.Web.UI.Page
{
    CarFac objcarfac = new CarFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        DataTable dt = new DataTable();
        dt = objcarfac.hentmaerke();

        if (!IsPostBack)
        {
            ddlmearke.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlmearke.Items.Add(new ListItem(dr["fldMaerkeNavn"].ToString(), dr["fldMaerkeID"].ToString()));
                 
            }
        }
    }
    
    protected void ddlmearke_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnlSelectedeMaerke.Visible = true;
    }
    protected void btnSubmitMaerke_Click(object sender, EventArgs e)
    {
        if (txtredigermaerke.Text != "")
        {
            objcarfac.RedigerMaerke(txtredigermaerke.Text, int.Parse(ddlmearke.SelectedValue));
            litmsg.Text = "<b style='color: green'>Mærke er blever rettet! (siden refresher om 3 sekunder)</b>";
            string url = Request.RawUrl;
            Response.AddHeader("REFRESH", "3;URL=" + url + "");
        }
        else
        {
            litmsg.Text = "<b style='color: red'>Du skal udfylde tekstfeltet!</b>";
        }
    }
}