using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarFac
/// </summary>
public class CarFac
{
    // Instanser her
    DataAc objData = new DataAc();
    SqlCommand objcmd = new SqlCommand();

       
    //**********************************************//
    //               HENT METODER                   //
    //**********************************************//

    public DataTable HentAlt()
    {
        string strSql = @"SELECT * FROM tblDel
                        INNER JOIN
                        tblAargang ON fldAargangID = fk_fldAargangID
                        INNER JOIN
                        tblMotorStoerelse ON fldMotorStoerelseID = fk_fldMotorStoerelseID
                        INNER JOIN
                        tblModel ON fldModelID = fk_fldModelID
                        INNER JOIN
                        tblMaerke ON fldMaerkeID = fk_fldMaerkeID";
        SqlCommand cmd = new SqlCommand(strSql);

        return objData.GetData(cmd);
    }



    public DataTable HentAltUdFraID(int id)
    {
        string strSql = @"SELECT * FROM tblDel
                        INNER JOIN
                        tblAargang ON fldAargangID = fk_fldAargangID
                        INNER JOIN
                        tblMotorStoerelse ON fldMotorStoerelseID = fk_fldMotorStoerelseID
                        INNER JOIN
                        tblModel ON fldModelID = fk_fldModelID
                        INNER JOIN
                        tblMaerke ON fldMaerkeID = fk_fldMaerkeID
                        WHERE fldDelID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);

        return objData.GetData(cmd);
    }

    public DataTable HentAlleMaerker()
    {
        string strSql = "SELECT * FROM tblMaerke ORDER BY fldMaerkeNavn ASC";
        SqlCommand cmd = new SqlCommand(strSql);
        return objData.GetData(cmd);
    }

    //henter alt data fra tlbmærke
    public DataTable hentmaerke()
    {
        string strSql = @"SELECT * FROM tblMaerke ORDER BY fldMaerkeNavn ASC";

        objcmd = new SqlCommand(strSql);
        return objData.GetData(objcmd);
    }

    //henter alt data fra tblModel
    public DataTable hentModel(string id)
    {
        string strSql = @"SELECT * FROM tblModel WHERE fk_fldMaerkeID = @id";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(objcmd);
    }

    //henter alt data fra tblMotorStørrelse
    public DataTable hentMotorStoerelse(string id)
    {
        string strSql = @"SELECT * FROM tblMotorStoerelse WHERE fk_fldModelID = @id";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(objcmd);
    }

    //henter alt data fra tblAargang
    public DataTable hentAargang(string id)
    {
        string strSql = @"SELECT * FROM tblAargang WHERE fk_fldMotorStoerelseID = @id";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(objcmd);
    }

    //henter alt data fra tblDel
    public DataTable hentDel(string id)
    {
        string strSql = @"SElECT * FROM tblDel WHERE fk_fldAargangID = @id";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(objcmd);
    }

    //henter én bestemt del ud fra id
    public DataTable hentDelFraId(string id)
    {
        string strSql = @"SElECT * FROM tblDel WHERE fldDelID = @id";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(objcmd);
    }

    public DataTable hentSenest()
    {
        string strSql = @"SELECT TOP 4 * FROM tblDel
                        INNER JOIN
                        tblAargang ON fldAargangID = fk_fldAargangID
                        INNER JOIN
                        tblMotorStoerelse ON fldMotorStoerelseID = fk_fldMotorStoerelseID
                        INNER JOIN
                        tblModel ON fldModelID = fk_fldModelID
                        INNER JOIN
                        tblMaerke ON fldMaerkeID = fk_fldMaerkeID
                        ORDER BY fldDelID DESC";
        objcmd = new SqlCommand(strSql);
        return objData.GetData(objcmd);
    }



    //**********************************************//
    //               INDSÆT METODER                 //
    //**********************************************//

   

    public void OpretBil(string Maerkenavn, string ModelNavn, string MotorStoerelse, int Aargang)
    {
        //opretter mærkenavn i den første tabel
        string strSql = @"INSERT
                          INTO
                          tblMaerke
                          (fldMaerkeNavn)
                          Values
                          (@maerkeNavn)";     
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@maerkeNavn", Maerkenavn);
        objData.ModifyData(objcmd);
        // trækker ID´et fra den sidste oprettede række i mærketabllen ud
        objcmd = new SqlCommand("SELECT TOP 1 (fldMaerkeID) FROM tblMaerke ORDER BY fldMaerkeID DESC");
        DataRow DrMId = objData.GetData(objcmd).Rows[0];

        int _MId = Convert.ToInt32(DrMId["fldMaerkeID"]);

        //insætter modelnavn og fk ID ind i modeltabellen
        objcmd = new SqlCommand(@"INSERT
                              INTO
                              tblModel
                              (fldModelNavn, fk_fldMaerkeID )
                              Values
                              (@ModelNavn, @fk_ModelNavn)");
        objcmd.Parameters.AddWithValue("@ModelNavn", ModelNavn);
        objcmd.Parameters.AddWithValue("@fk_ModelNavn", _MId);
        objData.ModifyData(objcmd);

        // trækker ID´et fra den sidste oprettede række i modeltabllen ud
        objcmd = new SqlCommand(@"SELECT TOP 1 (fldModelID) FROM tblModel ORDER BY fldModelID DESC");
        DataRow DrModelID = objData.GetData(objcmd).Rows[0];

        int _ModelID = Convert.ToInt32(DrModelID["fldModelID"]); 

        //indsætter motorstørrelse og fk id i tblMotorStoerelse
        objcmd = new SqlCommand(@"INSERT
                              INTO
                              tblMotorStoerelse
                              (fldMotorStoerelse, fk_fldModelID )
                              Values
                              (@MotorStoearelse, @fk_ModelID)");
        objcmd.Parameters.AddWithValue("@MotorStoearelse", MotorStoerelse);
        objcmd.Parameters.AddWithValue("@fk_ModelID", _ModelID);
        objData.ModifyData(objcmd);

        // trækker ID´et fra den sidste oprettede række i motorsteorelsetabllen ud
        objcmd = new SqlCommand(@"SELECT TOP 1 (fldMotorStoerelseID) FROM tblMotorStoerelse ORDER BY fldMotorStoerelseID DESC");
        DataRow DrMotorID = objData.GetData(objcmd).Rows[0];

        int _MotorID = Convert.ToInt32(DrMotorID["fldMotorStoerelseID"]); 

        //indsætter årgang og fk id i tblMotorStoerelse
        objcmd = new SqlCommand(@"INSERT
                              INTO
                              tblAargang
                              (fldAargang, fk_fldMotorStoerelseID )
                              Values
                              (@Aargang, @fk_MotorStoearelseID)");
        objcmd.Parameters.AddWithValue("@Aargang", Aargang);
        objcmd.Parameters.AddWithValue("@fk_MotorStoearelseID", _MotorID);
        objData.ModifyData(objcmd);
                        
    }


    //Opretter kun bilmærke
    public void OpretMearke(string MaerkeNavn)
    {
        string strSql = @"INSERT
                          INTO
                          tblMaerke
                          (fldMaerkeNavn)
                          Values
                          (@maerkeNavn)";

        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@maerkeNavn", MaerkeNavn);
        objData.ModifyData(objcmd);
    }
    //opretter kun model
    public void OpretModel(string ModelNavn, int fk_Maerke)
    {
        string strsql = @"INSERT
                        INTO
                        tblModel
                        (fldModelNavn, fk_fldMaerkeID)
                        VALUES
                        (@ModelNavn, @fk_MaerkeID)";
            objcmd = new SqlCommand(strsql);
        objcmd.Parameters.AddWithValue("@ModelNavn", ModelNavn);
        objcmd.Parameters.AddWithValue("@fk_MaerkeID", fk_Maerke);
        objData.ModifyData(objcmd);
    }
    
    //opretter kun motorstørrelse
    public void OpretMotorStoerelse(string MotorStoerelse, int fk_ModelID)
    {
    string strsql = @"INSERT
                   INTO
                   tblMotorStoerelse
                   (fldMotorStoerelse, fk_fldModelID)
                   VALUES
                   (@MotorStoerelse, @fk_ModelID)";
        objcmd = new SqlCommand(strsql);
        objcmd.Parameters.AddWithValue("@MotorStoerelse", MotorStoerelse); 
        objcmd.Parameters.AddWithValue("@fk_modelID", fk_ModelID);
        objData.ModifyData(objcmd);
        
    }

    //opretter kun årgang
    public void OpretAargang(string Aargang, int fk_MotorStoerelseID)
    {
        string strsql = @"INSERT
                       INTO
                       tblAargang
                       (fldAargang, fk_fldMotorStoerelseID)
                       VALUES
                       (@Aargang, @fk_MotorStoerelseID)";
        objcmd = new SqlCommand(strsql);
        objcmd.Parameters.AddWithValue("@Aargang", Aargang);
        objcmd.Parameters.AddWithValue("@fk_MotorStoerelseID", fk_MotorStoerelseID);
        objData.ModifyData(objcmd);

    }

    //opretter kun en del
    public void OpretDel(string navn, string tekst, int antal, int pris, string billede, int fk_fldAargangID)
    {
        string strSql = @"INSERT INTO tblDel
                        (fldDelNavn, fldDelTekst, fldDelAntal, fldDelPris, fldDelBillede, fk_fldAargangID)
                        VALUES
                        (@navn, @tekst, @antal, @pris, @billede, @fk_fldAargangID)";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@navn", navn);
        objcmd.Parameters.AddWithValue("@tekst", tekst);
        objcmd.Parameters.AddWithValue("@antal", antal);
        objcmd.Parameters.AddWithValue("@pris", pris);
        objcmd.Parameters.AddWithValue("@billede", billede);
        objcmd.Parameters.AddWithValue("@fk_fldAargangID", fk_fldAargangID);
        objData.ModifyData(objcmd);
    }

    
    
    //**********************************************//
    //              REDIGER METODER                 //
    //**********************************************//

    // *** Properties *** //

    // Maerke Properties
    public string _editMaerkeNavn { get; set; }
    public int _editMaerkeID { get; set; }

    // Model Properties
    public string _editModelNavn { get; set; }
    public int _editModelID { get; set; }

    // MotorStoerelse Properties
    public int _editMotorStoerelse { get; set; }
    public int _editMotorStoerelseID { get; set; }

    // Aargang Properties
    public string _editAargang { get; set; }
    public int _editAargangID { get; set; }


    // *** Rediger metoderne *** //

    //redigere et bilmærke
    public void RedigerMaerke(string MaerkeNavn, int maerkeid)
    {
        string strSql = @"UPDATE                          
                          tblMaerke
                          SET fldMaerkeNavn = @MaerkeNavn
                          WHERE fldMaerkeID = @maerkeid";

        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@maerkeNavn", MaerkeNavn);
        objcmd.Parameters.AddWithValue("@maerkeid", maerkeid);
        objData.ModifyData(objcmd);
    }

    //redigere en model
    public void RedigerModel(string ModelNavn, int Modelid)
    {
        string strSql = @"UPDATE                          
                          tblModel
                          SET fldModelNavn = @ModelNavn
                          WHERE fldModelID = @Modelid";

        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@ModelNavn", ModelNavn);
        objcmd.Parameters.AddWithValue("@Modelid", Modelid);
        objData.ModifyData(objcmd);
    }

    //redigere en motorstørrelse
    public void RedigerMotorstoerelse(string MotorstoerrelseNavn, int Motorstoerrelseid)
    {
        string strSql = @"UPDATE                          
                          tblMotorstoerelse
                          SET fldMotorStoerelse = @MotorstoerrelseNavn
                          WHERE fldMotorstoerelseID = @Motorstoerrelseid";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@MotorstoerrelseNavn", MotorstoerrelseNavn);
        objcmd.Parameters.AddWithValue("@Motorstoerrelseid", Motorstoerrelseid);
        objData.ModifyData(objcmd);
    }

    //redigere en Årgang
    public void RedigerAargang(string AargangNavn, int Aargangid)
    {
        string strSql = @"UPDATE                          
                          tblAargang
                          SET fldAargang = @AargangNavn
                          WHERE fldAargangID = @Aargangid";
        objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@AargangNavn", AargangNavn);
        objcmd.Parameters.AddWithValue("@Aargangid", Aargangid);
        objData.ModifyData(objcmd);
    }



    // tblMaerke
    public void Maerke()
    {
        string strSqlet = @"UPDATE tblMaerke
                            SET fldMaerkeNavn = @maerkenavn
                            WHERE fldMaerkeID = @maerkeid";
        SqlCommand cmdet = new SqlCommand(strSqlet);
        cmdet.Parameters.AddWithValue("@maerkenavn", _editMaerkeNavn);
        cmdet.Parameters.AddWithValue("@maerkeid", _editMaerkeID);
        objData.ModifyData(cmdet);
    }

    // tblModel
    public void Model()
    {
        string strSqlto = @"UPDATE tblModel
                            SET 
                            fldModelNavn = @modelnavn
                            WHERE 
                            fldModelID = @modelid";
        SqlCommand cmdto = new SqlCommand(strSqlto);
        cmdto.Parameters.AddWithValue("@modelnavn", _editModelNavn);
        cmdto.Parameters.AddWithValue("@modelid", _editModelID);
        objData.ModifyData(cmdto);
    }

    // tblMotorStoerelse
    public void MotorStoerelse()
    {
        string strSqltre = @"UPDATE tblMotorStoerelse
                            SET 
                            fldMotorStoerelse = @motorstoerelse
                            WHERE 
                            fldMotorStoerelseID = @motorstoerelseid";
        SqlCommand cmdtre = new SqlCommand(strSqltre);
        cmdtre.Parameters.AddWithValue("@motorstoerelse", _editMotorStoerelse);
        cmdtre.Parameters.AddWithValue("@motorstoerelseid", _editMotorStoerelseID);
        objData.ModifyData(cmdtre);
    }

    // tblAargang
    public void Aargang()
    {
        string strSqlfire = @"UPDATE tblAargang
                            SET 
                            fldAargang = @aargang
                            WHERE 
                            fldAargangID = @aargangid";
        SqlCommand cmdfire = new SqlCommand(strSqlfire);
        cmdfire.Parameters.AddWithValue("@aargang", _editAargang);
        cmdfire.Parameters.AddWithValue("@aargangid", _editAargangID);
        objData.ModifyData(cmdfire);
    }

    // Dele Properties
    public string _editDelNavn { get; set; }
    public string _editDelTekst { get; set; }
    public string _editDelBillede { get; set; }
    public int _editDelAntal { get; set; }
    public int _editDelPris { get; set; }
    public int _editDelID { get; set; }


    public void Dele()
    {
        string strSql = @"UPDATE tblDel
                            SET 
                            fldDelNavn = @delnavn,
                            fldDelTekst = @deltekst,
                            fldDelBillede = @delbillede,
                            fldDelAntal = @delantal,
                            fldDelPris = @delpris
                            WHERE 
                            fldDelID = @delid";
        SqlCommand objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@delnavn", _editDelNavn);
        objcmd.Parameters.AddWithValue("@deltekst", _editDelTekst);
        objcmd.Parameters.AddWithValue("@delbillede", _editDelBillede);
        objcmd.Parameters.AddWithValue("@delantal", _editDelAntal);
        objcmd.Parameters.AddWithValue("@delpris", _editDelPris);
        objcmd.Parameters.AddWithValue("@delid", _editDelID);
        objData.ModifyData(objcmd);
    }

    // tblDel
    public void updateDele(string navn, string tekst, string billed, int antal, int pris, int delId)
    {
        string strSql = @"UPDATE tblDel
                            SET 
                            fldDelNavn = @delnavn,
                            fldDelTekst = @deltekst,
                            fldDelBillede = @delbillede,
                            fldDelAntal = @delantal,
                            fldDelPris = @delpris
                            WHERE 
                            fldDelID = @delid";
        SqlCommand objcmd = new SqlCommand(strSql);
        objcmd.Parameters.AddWithValue("@delnavn", navn);
        objcmd.Parameters.AddWithValue("@deltekst", tekst);
        objcmd.Parameters.AddWithValue("@delbillede", billed);
        objcmd.Parameters.AddWithValue("@delantal", antal);
        objcmd.Parameters.AddWithValue("@delpris", pris);
        objcmd.Parameters.AddWithValue("@delid", delId);
        objData.ModifyData(objcmd);
    }


    //**********************************************//
    //                SLET METODER                  //
    //**********************************************//

    // Maerke delete
    public void DeleteMaerke(int id)
    {
        string strSql = @"DELETE FROM tblMaerke
                        WHERE fldMaerkeID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);
        objData.ModifyData(cmd);
    }

    // Model delete
    public void DeleteModel(int id)
    {
        string strSql = @"DELETE FROM tblModel
                        WHERE fldModelID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);
        objData.ModifyData(cmd);
    }

    // Motorstoerelse
    public void DeleteMotorStoerelse(int id)
    {
        string strSql = @"DELETE FROM tblMotorStoerelse
                        WHERE fldMotorStoerelseID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);
        objData.ModifyData(cmd);
    }

    // Aargang
    public void DeleteAargang(int id)
    {
        string strSql = @"DELETE FROM tblAargang
                        WHERE fldAargangID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);
        objData.ModifyData(cmd);
    }

    // Dele
    public void DeleteDele(int id)
    {
        string strSql = @"DELETE FROM tblDel
                        WHERE fldDelID = " + id;
        SqlCommand cmd = new SqlCommand(strSql);
        objData.ModifyData(cmd);
    }

    //**********************************************//
    //              SØGNING METODER                 //
    //**********************************************//

    public DataTable Soegning(string _key)
    {
        string strSql = @"SELECT MA.fldMaerkeID, MA.fldMaerkeNavn, MO.fldModelNavn, MS.fldMotorStoerelse, AA.fldAargang, D.fldDelID,
                        D.fldDelNavn, D.fldDelBillede
                        FROM tblMaerke AS MA         
                        INNER JOIN tblModel AS MO
                        ON 
                        MA.fldMaerkeID = MO.fk_fldMaerkeID
                        INNER JOIN tblMotorStoerelse AS MS
                        ON
                        MO.fldModelID = MS.fk_fldModelID
                        INNER JOIN tblAargang AS AA
                        ON
                        MS.fldMotorStoerelseID = AA.fk_fldMotorStoerelseID
                        INNER JOIN tblDel AS D
                        ON
                        AA.fldAargangID = D.fk_fldAargangID
                   
                        WHERE MA.fldMaerkeNavn LIKE @key
                        OR 
                        MO.fldModelNavn LIKE @key
                        OR
                        MS.fldMotorStoerelse LIKE @key
                        OR
                        AA.fldAargang LIKE @key
                        OR
                        D.fldDelNavn LIKE @key
                        OR
                        D.fldDelBillede LIKE @key";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@key", "%" + _key + "%");
        return objData.GetData(cmd);
    }

    public DataTable ddlSoegningUdFraFK(int id)
    {
        string strSql = @"SELECT * FROM tblDel
                        INNER JOIN
                        tblAargang ON fldAargangID = fk_fldAargangID
                        INNER JOIN
                        tblMotorStoerelse ON fldMotorStoerelseID = fk_fldMotorStoerelseID
                        INNER JOIN
                        tblModel ON fldModelID = fk_fldModelID
                        INNER JOIN
                        tblMaerke ON fldMaerkeID = fk_fldMaerkeID
                        WHERE fk_fldAargangID = @id";
        SqlCommand cmd = new SqlCommand(strSql);
        cmd.Parameters.AddWithValue("@id", id);
        return objData.GetData(cmd);
    }

}


