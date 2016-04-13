using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_Edit : System.Web.UI.Page
{
    CarFac objCar = new CarFac();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        if (!IsPostBack)
        {

            if (!String.IsNullOrEmpty(Request.QueryString["edit"]))
            {
                if (!IsPostBack)
                {
                    DataTable dt = objCar.HentAltUdFraID(Convert.ToInt32(Request.QueryString["edit"]));

                    DataRow dr = dt.Rows[0];

                    txtMaerke.Text = dr["fldMaerkeNavn"].ToString();
                    txtModel.Text = dr["fldModelNavn"].ToString();
                    txtMotorStoerlse.Text = dr["fldMotorStoerelse"].ToString();
                    txtAargang.Text = dr["fldAargang"].ToString();

                    txtDelNavn.Text = dr["fldDelNavn"].ToString();
                    txtDelTekst.Text = dr["fldDelTekst"].ToString().Replace("<br />", Environment.NewLine);
                    currentImg.ImageUrl = "../Images/Dele/" + dt.Rows[0]["fldDelBillede"].ToString();            

                    txtDelAntal.Text = dr["fldDelAntal"].ToString();
                    txtDelPris.Text = dr["fldDelPris"].ToString(); 
                }
            }
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (fuImg.HasFile)
        {
            foreach (var file in fuImg.PostedFiles)
            {
                string imgName = PictureSave.SavePicture(file, "Images/Dele/", 80);
                PictureSave.SavePicture(file, "Images/Dele/", 400, imgName);

                // Dele Update
                objCar._editDelID = Convert.ToInt32(Request.QueryString["edit"]);
                objCar._editDelNavn = txtDelNavn.Text;
                objCar._editDelTekst = txtDelTekst.Text.Replace(Environment.NewLine, "<br />");
                objCar._editDelBillede = imgName;
                objCar._editDelAntal = Convert.ToInt32(txtDelAntal.Text);
                objCar._editDelPris = Convert.ToInt32(txtDelPris.Text);

                objCar.Dele();
            }
            litResult.Text = "<b style='color: green'>Indholdet er rettet! (siden refresher om 3 sekunder)</b>";
            Response.AddHeader("REFRESH", "3;URL=" + Request.RawUrl);
        }
        else
        {
            litResult.Text = "<b style='color: red;'>OBS! Du skal uploade et billede!</b>";
        }
    }
}