using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KatFac
/// </summary>
public class KatFac
{
    DataAc da = new DataAc();

    public DataTable HentKategori()
    {
        string strSql = "SELECT * FROM tblKategori";
        SqlCommand cmd = new SqlCommand(strSql);
        return da.GetData(cmd);
    }

    public DataTable HentKategoriUdfraId(string id)
    {
        string strSql = "SELECT * FROM tblKategori WHERE fk_fldAargangID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", id);
        return da.GetData(cmd);
    }

    public void OpretKategori(string _kat)
    {
        string strSql = "INSERT INTO tblKategori (fldKategori) VALUES (@kat)";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@kat", _kat);
        da.ModifyData(cmd);
    }

    public int SletKategori(int _id)
    {
        string strSql = "DELETE FROM tblKategori WHERE fldKategoriID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", _id);
        return da.ModifyData(cmd);
    }
}