using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tjek
/// </summary>
public class Tjek
{
    DataAc da = new DataAc();
    DataTable dt = new DataTable();

    public int TjekMaerke(string _tjekmaerke)
    {
        string strSql = "SELECT fldMaerkeID from tblMaerke WHERE fldMaerkeNavn = @maerkenavn";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@maerkenavn", _tjekmaerke);

        dt = da.GetData(cmd);
        int count = dt.Rows.Count;
        return count;
    }
}