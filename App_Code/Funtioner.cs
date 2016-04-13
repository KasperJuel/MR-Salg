using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Funtioner
/// </summary>
public class Funtioner
{
    public static string CreateNiceUrl(string NotNiceUrl)
    {
        string niceUrl = NotNiceUrl.ToLower().Trim();

        niceUrl = niceUrl.Replace(" ", "-")
            .Replace(",", "-").Replace(".", "-").Replace("+", "-")
            .Replace("/", "-").Replace("$", "-").Replace("§", "-")
            .Replace("\"", "").Replace("%", "pct").Replace("'", "")
            .Replace("*", "").Replace("(", "").Replace(")", "")
            .Replace("&", "og").Replace("---", "-").Replace("--", "-")
            .Replace("æ", "ae").Replace("ø", "o").Replace("å", "aa")
            .Replace("ü", "u").Replace("ä", "a").Replace("ö", "o");

        return niceUrl;
    }
}