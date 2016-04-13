using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class CreateUser : System.Web.UI.UserControl
{
    SqlCommand objcmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text != "" || txtCheckPassword.Text != "" || txtPassword.Text != "")
        {
            if (txtPassword.Text == txtCheckPassword.Text)
            {
                if (exist(txtUsername.Text))
                {
                   string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");
                   litMsg.Text = CreateNewUser(txtUsername.Text, password);

                }
                else
                {
                    litMsg.Text = "Username findes, vælg et andet";
                }
            }
            else
            {
                litMsg.Text = "password passer ikke sammen";
            }
        }
        else
        {
            litMsg.Text = "du skal udfylde alle felter";
        }
    }
    #region metoder
    public Boolean exist(string Username)
    {       
        objcmd = new SqlCommand(@"SELECT Username FROM tblUser WHERE Username = @Username");
        objcmd.Parameters.AddWithValue("@Username", Username);
         DataTable dt = new DataTable();
        dt = GetData(objcmd);
        int i = dt.Rows.Count;
        if (i > 0)
        {
            return false;
        }
        else
        {
            return true;
        }

      

    }
     public string CreateNewUser(string username, string password)
     {
         objcmd = new SqlCommand(@"INSERT
                        INTO
                        tblUser
                        (Username, Password)
                        VALUES
                        (@Username, @Password)");
         objcmd.Parameters.AddWithValue("@Username", username);
         objcmd.Parameters.AddWithValue("@Password", password);
         ModifyData(objcmd);
         return "brugeren er oprettet";
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
    /// <summary>
    /// Ændrer i data - insert, update, delete
    /// </summary>
    /// <param name="CMD">SQL kommandoen til databasen</param>
    /// <returns>Returnerer det antal rækker, som er blevet ændret i databasen</returns>
    public int ModifyData(SqlCommand CMD)
    {
        SqlConnection objConn = new SqlConnection(strCon);
        int rowsaffected = 0;
        try
        {
            CMD.Connection = objConn;
            objConn.Open();
            rowsaffected = CMD.ExecuteNonQuery();
        }
        finally
        {
            objConn.Close();
        }

        return rowsaffected;
    }
    #endregion
}