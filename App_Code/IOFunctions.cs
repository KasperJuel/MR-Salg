using System;
using System.Collections.Generic;

using System.Web;
using System.IO;

/// <summary>
/// Summary description for IOFunctions
/// </summary>
public class IOFunctions
{
    public static void DeleteFile(string path) 
    {
        File.Delete(path);
    }
}
