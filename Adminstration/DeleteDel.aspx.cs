using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteDel : System.Web.UI.Page
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
            ddlmaerke.Items.Add(new ListItem("--VÆLG!--", "0"));
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
        ddlAargang.Items.Clear();
        if (ddlStoerelse.SelectedValue != "0")
        {
            DataTable dt = new DataTable();
            dt = objcarfac.hentAargang(ddlStoerelse.SelectedValue);

            pnlSelectedMotorStoerelse.Visible = true;
            ddlAargang.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlAargang.Items.Add(new ListItem(dr["fldAargang"].ToString(), dr["fldAargangID"].ToString()));
            }
        }
        else
        {
            pnlSelectedMotorStoerelse.Visible = false;
        }
    }
    protected void ddlAargang_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlDel.Items.Clear();
        if (ddlAargang.SelectedValue != "0")
        {
            DataTable dt = new DataTable();
            dt = objcarfac.hentDel(ddlAargang.SelectedValue);

            pnlSelectedAargang.Visible = true;
            ddlDel.Items.Add(new ListItem("--VÆLG--", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                ddlDel.Items.Add(new ListItem(dr["fldDelNavn"].ToString(), dr["fldDelID"].ToString()));

            }

        }
        else
        {
            pnlSelectedAargang.Visible = false;
        }
    }
    protected void ddlDel_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDel.SelectedValue != "0")
        {
            //her fyldes textboxene op med data om delen med hjælp fra delens id
            DataTable dt = new DataTable();
            dt = objcarfac.hentDelFraId(ddlDel.SelectedValue);


            litmsg.Text = "<h4>Navn:</h4> " + dt.Rows[0]["fldDelNavn"].ToString() + @"</br>
                           <h4>Beskrivelse:</h4> " + dt.Rows[0]["fldDelTekst"].ToString() + @"</br>
                           <h4>Billede:</h4> " + dt.Rows[0]["fldDelBillede"].ToString() + @"</br>
                           <h4>Antal:</h4> " + dt.Rows[0]["fldDelAntal"].ToString() + @"</br>
                           <h4>Pris:</h4> " + dt.Rows[0]["fldDelPris"].ToString() + "</br>";
        }
        else
        {
        }
    }
    protected void btnRedigerDelSubmit_Click(object sender, EventArgs e)
    {
        objcarfac.DeleteDele(int.Parse(ddlDel.SelectedValue.ToString()));

        Response.Redirect("Default.aspx");
    }
}