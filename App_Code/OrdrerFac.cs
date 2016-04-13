using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrdrerFac
/// </summary>
public class OrdrerFac
{
    DataAc da = new DataAc();

    public DataTable HentOrder()
    {
        string strSql = @"SELECT fldOrdrerID, fldNavn, fldAdresse, fldPostnr, fldBy, fldMail, fk_fldDelID, fldDato, fldAntal,
                        fldDelNavn, fldDelTekst, fldDelBillede, fldDelPris FROM tblOrdrer
                        INNER JOIN tblDel ON fk_fldDelID = fldDelID";
        SqlCommand cmd = new SqlCommand(strSql);
        return da.GetData(cmd);
    }

    public string _navn { get; set; }
    public string _adresse { get; set; }
    public int _postnr { get; set; }
    public string _by { get; set; }
    public string _mail { get; set; }
    public int _antal { get; set; }
    public int _id { get; set; }
    public DateTime _dato { get; set; }

    public void OpretOrder()
    {
        string strSql = @"INSERT INTO tblOrdrer (fldNavn, fldAdresse, fldPostnr, fldBy, fldMail, fldAntal, fk_fldDelID, fldDato) 
                        VALUES (@navn, @adresse, @postnr, @by, @mail, @bestil, @prodid, @dato)";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@navn", _navn);
        cmd.Parameters.AddWithValue("@adresse", _adresse);
        cmd.Parameters.AddWithValue("@postnr", _postnr);
        cmd.Parameters.AddWithValue("@by", _by);
        cmd.Parameters.AddWithValue("@mail", _mail);
        cmd.Parameters.AddWithValue("@bestil", _antal);
        cmd.Parameters.AddWithValue("@prodid", _id);
        cmd.Parameters.AddWithValue("@dato", _dato);
        da.ModifyData(cmd);
    }

    public int AfslutOrder(int id)
    {
        string strSql = @"DELETE FROM tblOrdrer WHERE fldOrdrerID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", id);
        return da.ModifyData(cmd);
    }
}