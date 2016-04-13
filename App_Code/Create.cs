using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Create
/// </summary>
public class Create
{
    DataAc objdata = new DataAc();
    SqlCommand objcmd = new SqlCommand();
    public void CreateRow(string content)
    {
        objcmd = new SqlCommand(@"INSERT
                                INTO
                                tblAargang
                               (fldAargang, fk_fldMotorStoerelseID)
                                VALUES
                                " + content + ";");
        objdata.ModifyData(objcmd);
    }

    public void Createdel(string content)
    {
        objcmd = new SqlCommand(@"INSERT
                                INTO
                                tblDel
                               (fldDelNavn, fldDelTekst, fldDelAntal, fldDelPris, fldDelBillede, fk_fldAargangID)
                                VALUES
                                " + content + ";");
        objdata.ModifyData(objcmd);
    }
}