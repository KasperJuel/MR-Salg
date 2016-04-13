using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KontaktFac
/// </summary>
public class KontaktFac
{
    DataAc da = new DataAc();

    public DataTable HentAlleBeskeder()
    {
        string strSql = "SELECT * FROM tblKontakt";
        SqlCommand cmd = new SqlCommand(strSql);
        return da.GetData(cmd);
    }

    public DataTable HentBeskedUdfraId(int id)
    {
        string strSql = "SELECT * FROM tblKontakt WHERE fldKontaktID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", id);
        return da.GetData(cmd);
    }

    public string _navn { get; set; }
    public string _mail { get; set; }
    public string _besked { get; set; }
    public DateTime _dato { get; set; }

    public void SendBesked()
    {
        string strSql = "INSERT INTO tblKontakt (fldNavn, fldMail, fldBesked, fldDato) VALUES (@navn, @mail, @besked, @dato)";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@navn", _navn);
        cmd.Parameters.AddWithValue("@mail", _mail);
        cmd.Parameters.AddWithValue("@besked", _besked);
        cmd.Parameters.AddWithValue("@dato", _dato);
        da.ModifyData(cmd);
    }

    public int SletBesked(int id)
    {
        string strSql = @"DELETE FROM tblKontakt WHERE fldKontaktID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", id);
        return da.ModifyData(cmd);
    }
}