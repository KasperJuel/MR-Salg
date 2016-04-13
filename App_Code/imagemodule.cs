using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for imagemodule
/// </summary>
public class imagemodule
{
    //public static string SavePicture(FileUpload FU, string GemHer, int Str)
    public static string SavePicture(HttpPostedFile FU, string GemHer, int Str)
    {
        //hest_2013081212.jpg   //DateTime gør så man kan have flere af det samme billede, men giver den et unikt id, så de ikke overskriver hindanden
        string NytFilNavn = Path.GetFileNameWithoutExtension(FU.FileName) + DateTime.Now.ToString("_yyMMddHHmmssffff") + Path.GetExtension(FU.FileName);
        return SavePicture(FU, GemHer, Str, NytFilNavn);
    }

    //public static string SavePicture(FileUpload FU, string GemHer, int Str, string NytFilNavn )
    public static string SavePicture(HttpPostedFile FU, string GemHer, int Str, string NytFilNavn)
    {
        // Eks. GemmesHer går fra eks. /gfx/big til C:\Marianne\asp.net\_CSHARP\Soda-Marianne\gfx/big
        string extension = Path.GetExtension(FU.FileName).ToLower(); //.jpg

        if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".png")
        {
            try
            {
                String TempImage;
                String NytImage;

                // TEMPIMAGE - arbejdsfilen - prefikses med _temp_, gemmes i mappen hvor det færdige billede skal gemmes, og bliver gjort til streamin for nye billede
                TempImage = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, GemHer) + "_temp_" + NytFilNavn;
                FU.SaveAs(TempImage);
                StreamReader StreamIn = new StreamReader(TempImage);
                // NYTIMAGE - måske flere placeringer - måske flere størrelser
                NytImage = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, GemHer) + NytFilNavn;
                StreamWriter StreamOut = new StreamWriter(NytImage);
                ResizeImage(Str, StreamIn.BaseStream, StreamOut.BaseStream);
                // LUK streams og slet TEMP-billede
                StreamOut.Close();
                StreamIn.Close();
                DeleteFile(TempImage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        else
        {
            NytFilNavn = "fotopaavej.jpg";
        }
        return NytFilNavn;
    }

    public static void DeleteFile(string path)
    {
        File.Delete(path);
    }

    //Resize image - Med med bredde og højde 
    public static void ResizeImage(int width, Stream fromStream, Stream toStream)
    {
        //Propertionelt AspectRation 
        float originalAspectRatio = (float)System.Drawing.Image.FromStream(fromStream).Width / (float)System.Drawing.Image.FromStream(fromStream).Height;
        float newWidth, newHeight;
        var image = System.Drawing.Image.FromStream(fromStream);

        //Hvis det billede der uploades er mindre end "resize" - bliver det ikke scaleret op.
        //Dette er for ikke at "pixelere" billederne
        if (width < (float)System.Drawing.Image.FromStream(fromStream).Width)
        {
            newWidth = width;
            newHeight = (float)width / (float)originalAspectRatio;
        }
        else
        {
            newWidth = (float)System.Drawing.Image.FromStream(fromStream).Width;
            newHeight = (float)System.Drawing.Image.FromStream(fromStream).Height;
        }

        Debug.Write("ASPECT: = " + newHeight);
        var thumpnailBitmap = new Bitmap((int)newWidth, (int)newHeight);
        var thumpnailGraph = Graphics.FromImage(thumpnailBitmap);
        thumpnailGraph.CompositingQuality = CompositingQuality.HighQuality;
        thumpnailGraph.SmoothingMode = SmoothingMode.HighQuality;
        thumpnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
        var imageRectangle = new Rectangle(0, 0, (int)newWidth, (int)newHeight);
        thumpnailGraph.DrawImage(image, imageRectangle);
        thumpnailBitmap.Save(toStream, image.RawFormat);
        thumpnailGraph.Dispose();
        thumpnailBitmap.Dispose();
        image.Dispose();
    }
}