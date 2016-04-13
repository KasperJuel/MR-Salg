using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAc
/// </summary>
public class DataAc
{
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



    /// <summary>
    /// Denne metode kan indsætte data og returnere id'en på det netop indsatte
    /// </summary>
    /// <param name="CMD">SQL kommandoen til databasen</param>
    /// <returns>Returnerer et tal som er id på den netop oprettede post</returns> 
    public int InsertDataGetNewID(SqlCommand CMD)
    {
        SqlConnection objConn = new SqlConnection(strCon);
        int newid;
        try
        {
            CMD.Connection = objConn;
            objConn.Open();
            newid = Convert.ToInt32(CMD.ExecuteScalar());
        }
        finally
        {
            objConn.Close();
        }
        return newid;
    }
}