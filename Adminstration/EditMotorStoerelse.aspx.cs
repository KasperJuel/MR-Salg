using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_EditMotorStoerelse : System.Web.UI.Page
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
            ddlmaerke.Items.Add(new ListItem("--VÆLG!!--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlmaerke.Items.Add(new ListItem(dr["fldMaerkeNavn"].ToString(), dr["fldMaerkeID"].ToString()));

            }
        }
    }
    
    protected void ddlmaerke_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlmodel.Items.Clear();
        if (ddlmaerke.SelectedValue != "0")
        {
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
        ddlStoerelse.Items.Clear();
        if (ddlmodel.SelectedValue != "0")
        {
            DataTable dt = new DataTable();
            dt = objcarfac.hentMotorStoerelse(ddlmodel.SelectedValue);

            pnlselectedModel.Visible = true;
            ddlStoerelse.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlStoerelse.Items.Add(new ListItem(dr["fldMotorStoerelse"].ToString(), dr["fldMotorStoerelseID"].ToString()));
            }
        }
        else
        {
            pnlselectedModel.Visible = false;
        }
    }
    protected void ddlStoerelse_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlStoerelse.SelectedValue != "0")
        {
            pnlSelectedMotorStoerelse.Visible = true;
        }
        else 
        {
            pnlSelectedMotorStoerelse.Visible = false;
        }
    }
    protected void btnRedigerMotorstoerelseSubmit_Click(object sender, EventArgs e)
    {
        if (txtRedigerMotorstoerelse.Text != null)
        {
            objcarfac.RedigerMotorstoerelse(txtRedigerMotorstoerelse.Text, int.Parse(ddlStoerelse.SelectedValue));
            litmsg.Text = "<b style='color: green'>Størrelsen er blever rettet! (siden refresher om 3 sekunder)</b>";
            string url = Request.RawUrl;
            Response.AddHeader("REFRESH", "3;URL=" + url + "");
        }
        else
        {
            litmsg.Text = "<b style='color: red'>Du skal udfylde feltet!</b>";
        }
    }
}