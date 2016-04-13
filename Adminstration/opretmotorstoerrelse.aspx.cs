using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_opretmotorstoerrelse : System.Web.UI.Page
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
            ddlmaerke.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlmaerke.Items.Add(new ListItem(dr["fldMaerkeNavn"].ToString(), dr["fldMaerkeID"].ToString()));

            }
        }

    }
    protected void btnstoerrelsesubmit_Click(object sender, EventArgs e)
    {
        if (txtstoerrelse.Text != "")
        {
            objcarfac.OpretMotorStoerelse(txtstoerrelse.Text, int.Parse(ddlmodel.SelectedValue));
            litMsg.Text = "<b style='color: green'>Størrelse er oprettet! (Siden refresher om 3 sekunder)</b>";
            string url = Request.RawUrl;
            Response.AddHeader("REFRESH", "3;URL=" + url + "");
        }
        else
        {
            litMsg.Text = "<b style='color: red>Du skal udfylde tekstfeltet!</b>";
        }
    }
    protected void ddlmaerke_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmaerke.SelectedValue != "0")
        {
            ddlmodel.Items.Clear();
            DataTable dt = new DataTable();
            dt = objcarfac.hentModel(ddlmaerke.SelectedValue);

            pnlselectedmaerke.Visible = true;
            ddlmodel.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlmodel.Items.Add(new ListItem(dr["fldModelNavn"].ToString(), dr["fldModelID"].ToString()));
            }
        } 
        else
        {
            pnlselectedmaerke.Visible = false;
        }
    }
    protected void ddlmodel_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlmodel.SelectedValue != "0")
        {
            pnlSelectedModel.Visible = true;            
        }
        else
        {
            pnlSelectedModel.Visible = false;
        }
    }
}