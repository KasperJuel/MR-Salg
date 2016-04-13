using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Truncate
/// </summary>
public class Truncate
{
	public static string TruncateAtWord(string val, int length)
    {
        if (val == null || val.Length < length || val.IndexOf(" ", length) == -1)
        {
            return val;
        }

        return val.Substring(0, val.IndexOf(" ", length));
    }
}