using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_OpretDel : System.Web.UI.Page
{
    CarFac objCar = new CarFac();
    KatFac objKat = new KatFac();
    Create objcreate = new Create();
    PictureSave objpic = new PictureSave();
    int antal;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        DataTable dt = new DataTable();
        dt = objCar.hentmaerke();

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
            dt = objCar.hentModel(ddlmaerke.SelectedValue);

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
            dt = objCar.hentMotorStoerelse(ddlmodel.SelectedValue);

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
            dt = objCar.hentAargang(ddlStoerelse.SelectedValue);

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
        if (ddlAargang.SelectedValue != "0")
        {
            pnlselectedAargang.Visible = true;
        }
        else
        {
            pnlselectedAargang.Visible = false;
        }

    }
    protected void ddlKat_SelectedIndexChanged(object sender, EventArgs e)
    {

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

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Beskrivelse_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "ReqBeskrivelse" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Antal_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "ReqAntal" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Pris_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "ReqPris" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "billed_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }
            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "ReqFileuploader" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Start_literal_" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Middle_literal_1" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Middle_literal_2" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Middle_literal_3" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "Middle_literal_4" + IDnr)
                {
                    pan_content.Controls.Remove(item);
                    break; //important step
                }
            }

            foreach (Control item in pan_content.Controls)
            {
                if (item.ID == "end_literal_" + IDnr)
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

        RequiredFieldValidator txtReqTitel = new RequiredFieldValidator();
        txtReqTitel.ID = "ReqTitel" + IDnr;
        txtReqTitel.ValidationGroup = "validate";
        txtReqTitel.ControlToValidate = "Titel_" + IDnr;
        txtReqTitel.Attributes.Add("style", "color:red;");
        txtReqTitel.Display = ValidatorDisplay.Dynamic;
        txtReqTitel.ErrorMessage = "* udfyld dette felt";

        TextBox new_txtBeskrivelse = new TextBox();
        new_txtBeskrivelse.ID = "Beskrivelse_" + IDnr;
        new_txtBeskrivelse.Attributes.Add("placeholder", "Beskrivelse");
        new_txtBeskrivelse.Attributes.Add("Class", "form-control");
        new_txtBeskrivelse.TextMode = TextBoxMode.MultiLine;

        RequiredFieldValidator txtReqbeskrivelse = new RequiredFieldValidator();
        txtReqbeskrivelse.ID = "ReqBeskrivelse" + IDnr;
        txtReqbeskrivelse.ValidationGroup = "validate";
        txtReqbeskrivelse.ControlToValidate = "Beskrivelse_" + IDnr;
        txtReqbeskrivelse.Attributes.Add("style", "color:red;");
        txtReqbeskrivelse.Display = ValidatorDisplay.Dynamic;
        txtReqbeskrivelse.ErrorMessage = "* udfyld dette felt";

        TextBox new_txtAntal = new TextBox();
        new_txtAntal.ID = "Antal_" + IDnr;
        new_txtAntal.Attributes.Add("placeholder", "Antal");
        new_txtAntal.Attributes.Add("Class", "form-control");
        new_txtAntal.TextMode = TextBoxMode.Number;

        RequiredFieldValidator txtReqAntal = new RequiredFieldValidator();
        txtReqAntal.ID = "ReqAntal" + IDnr;
        txtReqAntal.ValidationGroup = "validate";
        txtReqAntal.ControlToValidate = "Antal_" + IDnr;
        txtReqAntal.Attributes.Add("style", "color:red;");
        txtReqAntal.Display = ValidatorDisplay.Dynamic;
        txtReqAntal.ErrorMessage = "* udfyld dette felt";

        TextBox new_txtPris = new TextBox();
        new_txtPris.ID = "Pris_" + IDnr;
        new_txtPris.Attributes.Add("placeholder", "Pris");
        new_txtPris.Attributes.Add("Class", "form-control");
        new_txtPris.TextMode = TextBoxMode.Number;

        RequiredFieldValidator txtReqPris = new RequiredFieldValidator();
        txtReqPris.ID = "ReqPris" + IDnr;
        txtReqPris.ValidationGroup = "validate";
        txtReqPris.ControlToValidate = "Pris_" + IDnr;
        txtReqPris.Attributes.Add("style", "color:red;");
        txtReqPris.Display = ValidatorDisplay.Dynamic;
        txtReqTitel.ErrorMessage = "* udfyld dette felt";

        FileUpload new_txtbilled = new FileUpload();
        new_txtbilled.ID = "billed_" + IDnr;
        new_txtbilled.Attributes.Add("placeholder", "billed");
        new_txtbilled.Attributes.Add("Class", "form-control");

        RequiredFieldValidator ReqFileuploader = new RequiredFieldValidator();
        ReqFileuploader.ID = "ReqFileuploader" + IDnr;
        ReqFileuploader.ValidationGroup = "validate";
        ReqFileuploader.ControlToValidate = "billed_" + IDnr;
        ReqFileuploader.Attributes.Add("style", "color:red;");
        ReqFileuploader.Display = ValidatorDisplay.Dynamic;
        ReqFileuploader.ErrorMessage = "* udfyld dette felt";

        LiteralControl new_lit = new LiteralControl();
        new_lit.ID = "Start_literal_" + IDnr;
        new_lit.Text = "<tr><td>";

        LiteralControl new_midlit_1 = new LiteralControl();
        new_midlit_1.ID = "Middle_literal_1" + IDnr;
        new_midlit_1.Text = "</td><td>";

        LiteralControl new_midlit_2 = new LiteralControl();
        new_midlit_2.ID = "Middle_literal_2" + IDnr;
        new_midlit_2.Text = "</td><td>";

        LiteralControl new_midlit_3 = new LiteralControl();
        new_midlit_3.ID = "Middle_literal_3" + IDnr;
        new_midlit_3.Text = "</td><td>";

        LiteralControl new_midlit_4 = new LiteralControl();
        new_midlit_4.ID = "Middle_literal_4" + IDnr;
        new_midlit_4.Text = "</td><td>";

        LiteralControl new_lit3 = new LiteralControl();
        new_lit3.ID = "end_literal_" + IDnr;
        new_lit3.Text = "</td></tr>";

        
        pan_content.Controls.Add(new_lit);        
        pan_content.Controls.Add(new_txtTitel);
        pan_content.Controls.Add(txtReqTitel);
        pan_content.Controls.Add(new_midlit_1);
        pan_content.Controls.Add(new_txtBeskrivelse);
        pan_content.Controls.Add(txtReqbeskrivelse);
        pan_content.Controls.Add(new_midlit_2);
        pan_content.Controls.Add(new_txtAntal);
        pan_content.Controls.Add(txtReqAntal);
        pan_content.Controls.Add(new_midlit_3);
        pan_content.Controls.Add(new_txtPris);
        pan_content.Controls.Add(txtReqPris);
        pan_content.Controls.Add(new_midlit_4);
        pan_content.Controls.Add(new_txtbilled);
        pan_content.Controls.Add(ReqFileuploader);
        pan_content.Controls.Add(new_lit3);

    }


    //commits data to database
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        string _StrContent = "";
        for (int i = 1; i <= antal; i++)
        {

            TextBox txtTitel = (TextBox)pan_content.FindControl("Titel_" + i);
            TextBox txtBeskrivelse = (TextBox)pan_content.FindControl("Beskrivelse_" + i);
            TextBox txtPris = (TextBox)pan_content.FindControl("Pris_" + i);            
            TextBox txtAntal = (TextBox)pan_content.FindControl("Antal_" + i);
            FileUpload txtbilled = (FileUpload)pan_content.FindControl("billed_" + i);

            string imgName = imagemodule.SavePicture(txtbilled.PostedFile, "Images/Dele/", 520);

            litMsg.Text += txtTitel.Text + "<br />";
            litMsg.Text += txtBeskrivelse.Text + "<br />";
            litMsg.Text += txtPris.Text + "<br />";
            litMsg.Text += txtAntal.Text + "<br />";
            litMsg.Text += imgName + "<br />";

            _StrContent = _StrContent + "('" + txtTitel.Text + "', '" + txtBeskrivelse.Text.Replace(Environment.NewLine, "<br />") + "', '" + txtAntal.Text + "', '" + txtPris.Text + "', '" + imgName + "', '" + ddlAargang.SelectedValue.ToString() + "'),";

        }
        _StrContent = _StrContent.TrimEnd(',', ' ');
        objcreate.Createdel(_StrContent);

        Response.Redirect(Request.Url.AbsolutePath);
    }
    
}