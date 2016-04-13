using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SideFac
/// </summary>
public class SideFac
{
    DataAc da = new DataAc();

    public DataTable HentOmMRSalg()
    {
        string strSql = "SELECT * FROM tblOm";
        SqlCommand cmd = new SqlCommand(strSql);
        return da.GetData(cmd);

    }

    public DataTable HentHandelsbetingelse()
    {
        string strSql = "SELECT * FROM tblHandelsbetingelser";
        SqlCommand cmd = new SqlCommand(strSql);
        return da.GetData(cmd);
    }

    public void OpretHandelsbetingelser(string tekst)
    {
        string strSql = "INSERT INTO tblHandelsbetingelser (fldTekst) VALUES (@tekst)";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@tekst", tekst);
        da.ModifyData(cmd);
    }

    public void OpretOmMRSalg(string tekst, string billede)
    {
        string strSql = "INSERT INTO tblOm (fldTekst, fldBillede) VALUES (@tekst, @billede)";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@tekst", tekst);
        cmd.Parameters.AddWithValue("@billede", billede);
        da.ModifyData(cmd);
    }

    public void RedigerHandelsbetingelser(string tekst)
    {
        string strSql = "UPDATE tblHandelsbetingelser SET fldTekst = @tekst";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@tekst", tekst);
        da.ModifyData(cmd);
    }

    public void RedigerOmMRSalg(string tekst, string billede)
    {
        string strSql = "UPDATE tblOm SET fldTekst = @tekst, fldBillede = @billede";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@tekst", tekst);
        cmd.Parameters.AddWithValue("@billede", billede);
        da.ModifyData(cmd);
    }
}