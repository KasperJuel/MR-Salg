using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bestilling : System.Web.UI.Page
{
    CarFac objCar = new CarFac();
    OrdrerFac objOrd = new OrdrerFac();

    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (!string.IsNullOrEmpty(Page.RouteData.Values["id"].ToString()))
            if (!string.IsNullOrEmpty(Request.QueryString["bestillingsid"]))
            {

                //dt = objCar.HentAltUdFraID(Int32.Parse(Page.RouteData.Values["id"].ToString()));
                int _Id = Convert.ToInt32(Request.QueryString["bestillingsid"]);
                dt = objCar.HentAltUdFraID(_Id);

                litBestilling.Text += "<table>";
                litBestilling.Text += "<thead>";

                litBestilling.Text += "<tr>";
                litBestilling.Text += "<th>Produkt</th>";
                litBestilling.Text += "<th>Pris</th>";

                litBestilling.Text += "</tr>";


                litBestilling.Text += "</thead>";
                litBestilling.Text += "<tbody>";

                foreach (DataRow dr in dt.Rows)
                {
                    litBestilling.Text += "<tr>";

                    litBestilling.Text += "<td class='produkt-left'>";

                    litBestilling.Text += "<img src='Images/Dele/" + dr["fldDelBillede"] + "' alt='" + dr["fldDelNavn"] + "' >";

                    litBestilling.Text += "<div class='product-desc'>";
                    litBestilling.Text += "<p>Del: " + dr["fldDelNavn"] + "</p>";
                    litBestilling.Text += "<p>Bil Mærke: " + dr["fldMaerkeNavn"] + "</p>";
                    litBestilling.Text += "<p>Motor: " + dr["fldMotorStoerelse"] + "</p>";
                    litBestilling.Text += "<p>Årgang: " + dr["fldAargang"] + "</p>";
                    litBestilling.Text += "</div>";

                    litBestilling.Text += "</td>";

                    litBestilling.Text += "<td>";
                    litBestilling.Text += "<p>Pris: " + dr["fldDelPris"] + ",-</p>";
                    litBestilling.Text += "</td>";
                    litBestilling.Text += "</tr>";
                }
                litBestilling.Text += "</tbody>";

                litBestilling.Text += "</table>";

            }
        }
    }
    protected void btnBestil_Click(object sender, EventArgs e)
    {

        if (txtNavn.Text != "")
        {
            txtNavn.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

            if (txtAdresse.Text != "")
            {
                txtAdresse.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

                if (txtPostnr.Text != "")
                {
                    txtPostnr.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

                    if (Convert.ToInt32(txtPostnr.Text) >= 1000 && Convert.ToInt32(txtPostnr.Text) <= 9999)
                    {
                        if (txtBy.Text != "")
                        {
                            txtBy.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

                            if (txtMail.Text != "")
                            {
                                txtMail.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

                                if (txtAntal.Text != "")
                                {
                                    txtAntal.BorderColor = System.Drawing.ColorTranslator.FromHtml("#244d60");

                                    objOrd._navn = txtNavn.Text;
                                    objOrd._adresse = txtAdresse.Text;
                                    objOrd._postnr = Convert.ToInt32(txtPostnr.Text);
                                    objOrd._by = txtBy.Text;
                                    objOrd._mail = txtMail.Text;
                                    objOrd._antal = Convert.ToInt32(txtAntal.Text);
                                    objOrd._id = Convert.ToInt32(Request.QueryString["bestillingsid"]);
                                    objOrd._dato = DateTime.Now;
                                    objOrd.OpretOrder();

                                    litMsg.Text = "<b>Order oprettet</b>";
                                    Response.AddHeader("REFRESH", "2;URL=" + "Tak.aspx");

                                } //txtAntal
                                else
                                {
                                    txtAntal.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                                    litMsg.Text = "<b style='color: red'>Vælg et antal</b>";
                                }
                            } //txtMail
                            else
                            {
                                txtMail.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                                litMsg.Text = "<b style='color: red'>Udfyld din mail</b>";
                            } //txtMail
                        } //txtBy
                        else
                        {
                            txtBy.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                            litMsg.Text = "<b style='color: red'>Udfyld din by</b>";
                        } //txtBy
                    }
                    else
                    {
                        txtPostnr.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                        litMsg.Text = "<b style='color: red'>Postnummer skal være mellem 1000 og 9999</b>";
                    }
                } //txtPostnr
                else
                {
                    txtPostnr.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    litMsg.Text = "<b style='color: red'>Udfyld dit postnummer</b>";
                }
            } //txtAdresse
            else
            {
                txtAdresse.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                litMsg.Text = "<b style='color: red'>Udfyld din adresse</b>";
            } //txtAdresse
        } //txtNavn
        else
        {
            txtNavn.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            litMsg.Text = "<b style='color: red'>Udfyld dit navn</b>";
        } //txtNavn


    }
}