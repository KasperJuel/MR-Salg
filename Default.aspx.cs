using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

public partial class _Default : System.Web.UI.Page
{
    CarFac objCar = new CarFac();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtSeneste = new DataTable();
        dtSeneste = objCar.hentSenest();

        if (!IsPostBack)
        {
            foreach (DataRow drSenest in dtSeneste.Rows)
            {
                //RouteValueDictionary parameters = new RouteValueDictionary
                //{
                //    { "id", drSenest["fldDelID"].ToString() },
                //    { "NiceUrl", Funtioner.CreateNiceUrl(drSenest["fldDelNavn"].ToString()) }
                //};

                //VirtualPathData vpd = RouteTable.Routes.GetVirtualPath(null, "Bestillingsiden", parameters);

                litSeneste.Text += "<div class='column-prod'>";
                litSeneste.Text += "<div class='seneste-prod'>";

                litSeneste.Text += "<a href='Produkt.aspx?id=" + drSenest["fldDelID"] + "'>" + "<img src='Images/Dele/" + drSenest["fldDelBillede"] + "' alt='" + drSenest["fldDelNavn"] + "' class='senest-img' style='margin-bottom: 5px;' ></a>";

                litSeneste.Text += "<h4>" + drSenest["fldDelNavn"] + "</h4>";
                litSeneste.Text += "<p><b>Mærke: " + drSenest["fldMaerkeNavn"] + "</b></p>";
                litSeneste.Text += "<p>" + Truncate.TruncateAtWord(drSenest["fldDelTekst"].ToString(), 118) + "</p>";

                litSeneste.Text += "<a href='Produkt.aspx?id=" + drSenest["fldDelID"] + "' class='btn-laesmere'>Se Produkt</a>";

                litSeneste.Text += "</div>";
                litSeneste.Text += "</div>";
            }

            DataTable dtMaerke = objCar.hentmaerke();
            ddlMaerke.Items.Add(new ListItem("-- Vælg Mærke --", "0"));

            foreach (DataRow drMaerke in dtMaerke.Rows)
            {
                ddlMaerke.Items.Add(new ListItem(drMaerke["fldMaerkeNavn"].ToString(), drMaerke["fldMaerkeID"].ToString()));
            }

        }
    }

    protected void ddlMaerke_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlModel.Items.Clear();

        if (ddlMaerke.SelectedValue != "0")
        {
            DataTable dt = objCar.hentModel(ddlMaerke.SelectedValue);

            pnlModel.Visible = true;
            ddlModel.Items.Add(new ListItem("-- Vælg Model --", "0"));

            foreach (DataRow dr in dt.Rows)
            {
                ddlModel.Items.Add(new ListItem(dr["fldModelNavn"].ToString(), dr["fldModelID"].ToString()));
            }
        }
        else
        {
            pnlModel.Visible = false;
        }
    }

    protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlMotorStoerelse.Items.Clear();

        if (ddlModel.SelectedValue != "0")
        {
            DataTable dt = objCar.hentMotorStoerelse(ddlModel.SelectedValue);

            pnlMotor.Visible = true;
            ddlMotorStoerelse.Items.Add(new ListItem("-- Vælg Motor --", "0"));

            foreach (DataRow dr in dt.Rows)
            {
                ddlMotorStoerelse.Items.Add(new ListItem(dr["fldMotorStoerelse"].ToString(), dr["fldMotorStoerelseID"].ToString()));
            }
        }
        else
        {
            pnlMotor.Visible = false;
        }
    }

    protected void ddlMotorStoerelse_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlAargang.Items.Clear();

        if (ddlMotorStoerelse.SelectedValue != "0" && ddlModel.SelectedValue != "0" && ddlMaerke.SelectedValue != "0")
        {
            DataTable dt = objCar.hentAargang(ddlMotorStoerelse.SelectedValue);

            pnlAargang.Visible = true;
            ddlAargang.Items.Add(new ListItem("-- Vælg Årgang --", "0"));

            foreach (DataRow dr in dt.Rows)
            {
                ddlAargang.Items.Add(new ListItem(dr["fldAargang"].ToString(), dr["fldAargangID"].ToString()));
            }
        }
        else
        {
            pnlAargang.Visible = false;
        }


    }

    protected void btnSoeg_Click(object sender, EventArgs e)
    {
        if (ddlMaerke.SelectedValue != "0" && ddlModel.SelectedValue != "0" && ddlMotorStoerelse.SelectedValue != "0" && ddlAargang.SelectedValue != "0")
        {
            Response.Redirect("Search.aspx?ddlresult=" + ddlAargang.SelectedValue.ToString());
        }
        else
        {
            litDdlError.Text = "<div style='color: #bb1d2c; margin-top: 5px;'><b>Du skal vælge alle felter</b></div>";
        }
    }

}