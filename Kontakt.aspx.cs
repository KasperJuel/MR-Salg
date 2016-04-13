using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kontakt : System.Web.UI.Page
{
    KontaktFac objKon = new KontaktFac();

    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {


        if (txtNavn.Text != "")
        {
            if (txtMail.Text != "")
            {
                if (txtBesked.Text != "")
                {
                    if (txtBesked.Text.Length <= 1000)
                    {
                        objKon._navn = txtNavn.Text;
                        objKon._mail = txtMail.Text;
                        objKon._dato = DateTime.Now;
                        objKon._besked = txtBesked.Text.Replace(Environment.NewLine, "<br />");

                        objKon.SendBesked();

                        litMsg.Text = "<b>Din besked blev sendt</b>";
                        Response.AddHeader("REFRESH", "2;URL=" + Request.RawUrl);
                    }
                    else
                    {
                        litMsg.Text = "<b style='color:red;'>Din besked var for lang! Max 1000 tegn<p></p></b>";
                    }
                }
                else
                {
                    txtBesked.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    litMsg.Text = "<b style='color:red;'>Udfyld en besked<p></p></b>";

                }
            }
            else
            {
                txtMail.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                litMsg.Text = "<b style='color:red;'>Udfyld din e-mail<p></p></b>";

            }
        }
        else
        {
            txtNavn.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            litMsg.Text = "<b style='color:red;'>Udfyld dit navn<p></p></b>";
        }
    }
}