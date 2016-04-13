using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OpretBiler : System.Web.UI.Page
{
    CarFac objcarfac = new CarFac();
    public int _incrementingId = 1;
    int antal;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        //DataTable dt = new DataTable();
        //dt = objcarfac.hentmaerke();

        //if (!IsPostBack)
        //{
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ddlmearke.Items.Add(new ListItem(dr["fldmaerkeNavn"].ToString(), dr["fldmaerkeID"].ToString()));

        //    }
        //}

        //tjekker om der er en session for antal inputfelter ellers sættes antal til 1 så vi har mindst et felt
        if (ViewState["add"] != null)
        {
            antal = Convert.ToInt32(ViewState["add"]);
        }
        else
        {
            // Simuler et knap-klik
            btnplus_Click(null, null);
        }


        //opretter en asp:textbox i panel elementet og giver den et unikt id
        for (int i = 1; i <= antal; i++)
        {

            lavEnKnap(i);

        }


    }


    protected void btnsubmit_Click(object sender, EventArgs e)
    {


        
        for (int i = 1; i <= antal; i++)
        {


            TextBox txtMaerke = (TextBox)pan_content.FindControl("Maerke_" + i);
            TextBox txtModel = (TextBox)pan_content.FindControl("Model_" + i);
            TextBox txtMotorstoerelse = (TextBox)pan_content.FindControl("MotorStoearelse_" + i);
            TextBox txtAargang = (TextBox)pan_content.FindControl("Aargang_" + i);

            if (txtMaerke.Text != "" && txtModel.Text != "" && txtMotorstoerelse.Text != "" && txtAargang.Text != "")
            {
                objcarfac.OpretBil(txtMaerke.Text, txtModel.Text, txtMotorstoerelse.Text, Convert.ToInt32(txtAargang.Text));
                litmsg.Text = "Bilen er oprettet er oprettet!";
                string url = Request.RawUrl;
                Response.AddHeader("REFRESH", "2;URL=" + Request.RawUrl);
            }
            else
            { 
                litmsg.Text = "Du skal udfylde alle felter!";
            }

        }
        

    }

    protected void btnplus_Click(object sender, EventArgs e)
    {
        antal = 0;
        if (ViewState["add"] != null)
        {
            antal = Convert.ToInt32(ViewState["add"]);
        }

        lavEnKnap((antal + 1));
        ViewState["add"] = antal + 1;
    }

    protected void lavEnKnap(int IDnr)
    {
        TextBox new_txtMaerke = new TextBox();
        new_txtMaerke.ValidationGroup = "test";

        TextBox new_txtModel = new TextBox();
        TextBox new_txtMotorStoerelse = new TextBox();
        TextBox new_txtAargang = new TextBox();

     

        new_txtMaerke.ID = "Maerke_" + IDnr;
        new_txtMaerke.Attributes.Add("placeholder", "Mærke");
        new_txtModel.ID = "Model_" + IDnr;
        new_txtMotorStoerelse.ID = "MotorStoearelse_" + IDnr;
        new_txtAargang.ID = "Aargang_" + IDnr;


        RequiredFieldValidator txtreq1 = new RequiredFieldValidator();
        txtreq1.ID = "r" + IDnr;
        txtreq1.ValidationGroup = "test";
        txtreq1.ControlToValidate = "Maerke_" + IDnr;
        txtreq1.ErrorMessage = "*"; 


        pan_content.Controls.Add(new LiteralControl("<div>"));
     

        pan_content.Controls.Add(new_txtMaerke);
        pan_content.Controls.Add(txtreq1);
        pan_content.Controls.Add(new_txtModel);
        pan_content.Controls.Add(new_txtMotorStoerelse);
        pan_content.Controls.Add(new_txtAargang);

        

        pan_content.Controls.Add(new LiteralControl("<hr /></div>"));

    
    }
}