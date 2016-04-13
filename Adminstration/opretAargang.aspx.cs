using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_opretAargang : System.Web.UI.Page
{
    CarFac objcarfac = new CarFac();
    Create objcreate = new Create();
    int antal;
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
        #region plus knap
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
            makeRow(i);
        }
        #endregion

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
    //plus button adds 1 row to the existing rows
    protected void btnplus_Click(object sender, EventArgs e)
    {
        antal = 0;
        if (ViewState["add"] != null)
        {
            antal = Convert.ToInt32(ViewState["add"]);
        }

        makeRow((antal + 1));
        ViewState["add"] = antal + 1;
    }

    //minus button remove 1 row from the existing rows
    protected void btnminus_Click(object sender, EventArgs e)
    {
        antal = 0;
        if (ViewState["add"] != null)
        {
            antal = Convert.ToInt32(ViewState["add"]);
        }
        if (antal != 1)
        {
            removeRow((antal));
            ViewState["add"] = antal - 1;
        }

    }

    public void removeRow(int IDnr)
    {
        //this code needs to be in seperate foreach loops, because without the break statement (which breaks out of the code) the code does not work.
        if (IDnr != 1)
        {
          
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Titel_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "ReqTitel" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            
        }

    }

    //creates new controls with same same id numbers
    public void makeRow(int IDnr)
    {
        
        TextBox new_txtTitel = new TextBox();
        new_txtTitel.ID = "Titel_" + IDnr;
        new_txtTitel.Attributes.Add("placeholder", "Titel");
        new_txtTitel.Attributes.Add("Class", "form-control");
        new_txtTitel.TextMode = TextBoxMode.Number;

        RequiredFieldValidator txtReqTitel = new RequiredFieldValidator();
        txtReqTitel.ID = "ReqTitel" + IDnr;
        txtReqTitel.ValidationGroup = "validate";
        txtReqTitel.ControlToValidate = "Titel_" + IDnr;
        txtReqTitel.Attributes.Add("style", "color:red;");
        txtReqTitel.Display = ValidatorDisplay.Dynamic;
        txtReqTitel.ErrorMessage = "* udfyld dette felt";

        
        LiteralControl new_lit = new LiteralControl();
        new_lit.ID = "Start_literal_" + IDnr;

        

        LiteralControl new_lit3 = new LiteralControl();
        new_lit3.ID = "end_literal_" + IDnr;
        new_lit3.Text = "</td></tr>";

        new_lit.Text = "<tr><td>";
        pan_content.Controls.Add(new_lit);        
        pan_content.Controls.Add(new_txtTitel);
        pan_content.Controls.Add(txtReqTitel);        
        pan_content.Controls.Add(new_lit3);

    }


    //commits data to database
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        string _StrContent = "";
        for (int i = 1; i <= antal; i++)
        {

            TextBox txtTitel = (TextBox)pan_content.FindControl("Titel_" + i);         
           
            _StrContent = _StrContent + "('" + txtTitel.Text + "', '" + ddlStoerelse.SelectedValue.ToString() + "'),";

        }
        _StrContent = _StrContent.TrimEnd(',', ' ');
        objcreate.CreateRow(_StrContent);

        Response.AddHeader("REFRESH", "2;URL=" + Request.RawUrl);
    }
}