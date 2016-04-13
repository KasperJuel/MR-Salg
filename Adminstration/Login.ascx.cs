using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class login : System.Web.UI.UserControl
{
    SqlCommand objcmd = new SqlCommand();
    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            btnSubmit.Text = "Logout";
            litMsg.Text = Session["user"].ToString();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {

            Session.Abandon();
            Response.Redirect(Request.RawUrl);

        }

        // Læser hashing af password
        string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");

        DataTable dt = new DataTable();
        dt = GetAllData(txtUsername.Text, password);
        int i = dt.Rows.Count;
        if (i > 0)
        {
            Session["user"] = dt.Rows[0]["Username"].ToString();
            Response.Redirect("Default.aspx");
        }


    }

    public DataTable GetAllData(string username, string password)
    {
        objcmd = new SqlCommand(@"SELECT * FROM tblUser WHERE Username = @username AND Password = @password");
        objcmd.Parameters.AddWithValue("@username", username);
        objcmd.Parameters.AddWithValue("@password", password);
        return GetData(objcmd);
    }

    static string strCon = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;

    /// <summary>
    /// Hent data
    /// </summary>
    /// <param name="CMD">SQL kommandoen til databasen</param>
    /// <returns>Returnerer en datatabel med de udvalgte data</returns>
    public DataTable GetData(SqlCommand CMD)
    {
        SqlConnection objConn = new SqlConnection(strCon);
        DataTable dt = new DataTable();
        try
        {
            CMD.Connection = objConn;
            SqlDataAdapter objDA = new SqlDataAdapter();
            objDA.SelectCommand = CMD;
            objDA.Fill(dt);
        }
        catch (Exception)
        {
            throw;
        }
        return dt;
    }
}