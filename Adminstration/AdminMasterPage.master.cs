using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstration_AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            pnlAdmin.Visible = true;
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("Martin.aspx");
    }
}
