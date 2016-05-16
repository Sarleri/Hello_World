using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Configuration;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Xml;


public partial class worldsignal : System.Web.UI.Page
{
    string filepath = "";
    char[] delimiterChars = { ' ' };
   
    int spartan = 1;
    int sobeys = 1;
    int cvs = 1;
    int coles = 1;
    int aeon =1;
    int sonae = 1;
    int mig = 1;
    int sains = 1;
    int ica = 1;
    int madison = 1;
    int madisonBJ = 1;
    int madisonWg = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
         AvailabilityStatus();
         dailyloadStatus();
         Readexcel();
         getsignal();
    }

    private void AvailabilityStatus()
    {
      filepath = ConfigurationManager.AppSettings["Availability"];

      string[] subdirEntries = Directory.GetDirectories(filepath);
  
      foreach (string subDir in subdirEntries)
       {
          DirectoryInfo di = new DirectoryInfo(subDir);
            if (di.Name.Equals("COLES") || di.Name.Equals("LSS"))
            {
                continue;
            }
            else
            { 
          FileInfo[] files = di.GetFiles();
          DateTime lastWrite = DateTime.MinValue;
          FileInfo lastWritenFile = null;
          String diname = di.Name.ToString();

          int count = 0;
        
              count = files.Length;
              if (count != 0)
              {
                  foreach (FileInfo file in files)
                  {
                      DateTime lastWritedelete = file.LastWriteTime;

                      TimeSpan ts = DateTime.UtcNow.Date.Subtract(file.LastWriteTime.Date);

                      if (ts.Days > 7)
                      { file.Delete(); }
                      if ((file.LastWriteTime > lastWrite) && (file.LastWriteTime.Date == DateTime.UtcNow.Date))
                      {
                          lastWrite = file.LastWriteTime;
                          lastWritenFile = file;
                      }
                      if (lastWritenFile != null)
                      {
                          String filename1 = lastWritenFile.Name.ToString();
                          string[] wordsf = filename1.Split(delimiterChars);

                          for (int i = 0; i < (wordsf.Length); i++)
                          {
                              if ((wordsf[i].Contains("20")) && (wordsf[i].Length == 11))
                              {
                                  string date = wordsf[i];
                                  DateTime d = DateTime.ParseExact(date, "dd-MMM-yyyy", null);

                                  TimeSpan ts1 = DateTime.UtcNow.Date.Subtract(d);

                                  if (ts1.Days > 0)
                                  {
                                      file.Delete();
                                      break;
                                  }
                              }
                          }
                      }
                  }
                  if (lastWritenFile != null)
                  {
                      String filename = lastWritenFile.Name.ToString();
                      string[] words = filename.Split(delimiterChars);


                      switch (diname)
                      {
                          
                          case "SPARTAN":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      spartan = spartan + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      spartan = spartan + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      spartan = spartan + 2;
                                  }
                              }

                              break;
                          case "SOBEYS":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      sobeys = sobeys + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      sobeys = sobeys + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      sobeys = sobeys + 2;
                                  }
                              }

                              break;
                          case "CVS":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      cvs = cvs + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      cvs = cvs + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      cvs = cvs + 2;
                                  }
                              }
                              break;

                          case "COLES":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      coles = coles + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      coles = coles + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      coles = coles + 2;
                                  }
                              }
                              break;

                          case "AEON":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      aeon = aeon + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      aeon = aeon + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      aeon = aeon + 2;
                                  }
                              }
                              break;

                          case "MIGROS":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      mig = mig + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      mig = mig + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      mig = mig + 2;
                                  }
                              }
                              break;
                          case "MADISON":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                    madison = madison + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                    madison = madison + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                    madison = madison + 2;
                                  }
                              }
                              break;
                          case "SAINSBURY":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      sains = sains + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      sains = sains + 10;

                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      sains = sains + 2;
                                  }
                              }
                              break;
                          case "ICA":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      ica = ica + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      ica = ica + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      ica = ica + 2;
                                  }
                              }
                              break;
                          case "SONAE":

                              for (int i = 0; i < (words.Length); i++)
                              {
                                  if (words[i].IndexOf("OK") == 0)
                                  {
                                      sonae = sonae + 1;
                                  }
                                  else if (words[i].IndexOf("CRITICAL") == 0)
                                  {
                                      sonae = sonae + 10;
                                  }
                                  else if (words[i].IndexOf("WARNING") == 0)
                                  {
                                      sonae = sonae + 2;
                                  }
                              }
                              break;
                      }

                  }
              }
              else
              {
              }
          }
          }
    }


    private void dailyloadStatus()
    {
        filepath = ConfigurationManager.AppSettings["DataLoadStatusPath"];

        string[] subdirEntries = Directory.GetDirectories(filepath);

        foreach (string subDir in subdirEntries)
        {
            DirectoryInfo di = new DirectoryInfo(subDir);
            FileInfo[] files = di.GetFiles();
            DateTime lastWrite = DateTime.MinValue;
            FileInfo lastWritenFile = null;
            String diname = di.Name.ToString();

            int count = 0;

                count = files.Length;
                if (count != 0)
                {
                    foreach (FileInfo file in files)
                    {
                        DateTime lastWritedelete = file.LastWriteTime;

                        TimeSpan ts = DateTime.UtcNow.Date.Subtract(file.LastWriteTime.Date);

                        if (ts.Days > 7)
                        { file.Delete(); }
                        if ((file.LastWriteTime > lastWrite) && (file.LastWriteTime.Date == DateTime.UtcNow.Date))
                        {
                            lastWrite = file.LastWriteTime;
                            lastWritenFile = file;
                        }
                        if (lastWritenFile != null)
                        {
                            String filename1 = lastWritenFile.Name.ToString();
                            string[] wordsf = filename1.Split(delimiterChars);

                            for (int i = 0; i < (wordsf.Length); i++)
                            {
                                if ((wordsf[i].Contains("20")) && (wordsf[i].Length == 11))
                                {
                                    string date = wordsf[i];
                                    DateTime d = DateTime.ParseExact(date, "dd-MMM-yyyy", null);

                                    TimeSpan ts1 = DateTime.UtcNow.Date.Subtract(d);

                                    if (ts1.Days == 0)
                                    {


                                        switch (diname)
                                        {
                                           
                                            case "SPARTAN":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        spartan = spartan + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        spartan = spartan + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        spartan = spartan + 2;
                                                    }
                                                }
                                                break;
                                            case "SOBEYS":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        sobeys = sobeys + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        spartan = spartan + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        spartan = spartan + 2;
                                                    }
                                                }
                                                break;
                                            case "CVS":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        cvs = cvs + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        cvs = cvs + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        cvs = cvs + 2;
                                                    }
                                                }
                                                break;
                                            case "COLES":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        coles = coles + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        coles = coles + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        coles = coles + 2;
                                                    }
                                                }
                                                break;

                                            case "AEON":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        aeon = aeon + 1;
                                                        break;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        aeon = aeon + 10;
                                                        break;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        aeon = aeon + 2;
                                                        break;
                                                    }
                                                }
                                                break;
                                            case "MIGROS":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        mig = mig + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        mig = mig + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        mig = mig + 2;
                                                    }
                                                }
                                                break;
                                            case "MADISON":
                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                    madison = madison + 1;

                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                    madison = madison + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                    madison = madison + 2;
                                                    }
                                                }
                                                break;
                                            case "SAINSBURY":
                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        sains = sains + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        sains = sains + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        sains = sains + 2;
                                                    }
                                                }
                                                break;
                                            case "ICA":
                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        ica = ica + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        ica = ica + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        ica = ica + 2;
                                                    }
                                                }
                                                break;
                                            case "SONAE":

                                                for (int j = i; j < (wordsf.Length); j++)
                                                {
                                                    if (wordsf[j].IndexOf("SUCCESSFULLY") == 0)
                                                    {
                                                        sonae = sonae + 1;
                                                    }
                                                    else if (wordsf[j].IndexOf("CRITICAL") == 0)
                                                    {
                                                        sonae = sonae + 10;
                                                    }
                                                    else if (wordsf[j].IndexOf("WARNING") == 0)
                                                    {
                                                        sonae = sonae + 2;
                                                    }
                                                }
                                                break;
                                           
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        
    }

    public void Readexcel()
    {

        string filelocation = ConfigurationManager.AppSettings["DWHEXCELFILEPATH"];


        //create the Application object we can use in the member functions.
        Microsoft.Office.Interop.Excel.Application _excelApp = new Microsoft.Office.Interop.Excel.Application();
        _excelApp.Visible = false;


        string fileName = filelocation + "\\Open P1s.xls";

        //open the workbook
        Workbook workbook = _excelApp.Workbooks.Open(fileName,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

        //select the first sheet        
        Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

        //find the used range in worksheet
        Range excelRange = worksheet.UsedRange;

        //get an object array of all of the cells in the worksheet (their values)
        object[,] valueArray = (object[,])excelRange.get_Value(
                    XlRangeValueDataType.xlRangeValueDefault);

        int col = 7;
        for (int row = 1; row <= worksheet.UsedRange.Rows.Count; ++row)
        {

            //access each cell

            if (valueArray[row, col] != null)
            {
                if (valueArray[row, col].ToString().ToUpper() == "ISS SPARTAN - GLOBAL")
                {
                    spartan = spartan + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS SOBEYS - GLOBAL")
                {
                    sobeys = sobeys + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS CVS - GLOBAL")
                {
                    cvs = cvs + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS AEON - GLOBAL")
                {
                    aeon = aeon + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS COLES - GLOBAL")
                {
                    coles = coles + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS SAINSBURYS - GLOBAL")
                {
                    sains = sains + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS MIGROS - GLOBAL")
                {
                    mig = mig + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS ICA - GLOBAL")
                {
                    ica = ica + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS SONAE - GLOBAL")
                {
                    sonae = sonae + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS MADISON(BJ) - GLOBAL")
                {
                    madisonBJ = madisonBJ + 50;
                    madison = madison + 50;
                }
                else if (valueArray[row, col].ToString().ToUpper() == "ISS MADISON(WEGMANS) - GLOBAL")
                {
                    madisonWg = madisonWg + 50;
                    madison = madison + 50;

                }
            }
        }


        //clean up stuffs
        workbook.Close(false, Type.Missing, Type.Missing);
        _excelApp.Workbooks.Close();
        Marshal.ReleaseComObject(excelRange);
        Marshal.ReleaseComObject(worksheet);
        Marshal.ReleaseComObject(workbook);
        _excelApp.Application.Quit();

        while (Marshal.ReleaseComObject(workbook) > 0) ;
        while (Marshal.ReleaseComObject(_excelApp) > 0) ;

        workbook = null;
        _excelApp = null;

        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        //return null;
    }

    private void getsignal()
    {
        
        if (spartan > 0 && spartan <= 10)
        {     
   
            pos_spartan.Visible = true;
            greenspartan.Visible = true;
            redspartan.Visible = false;
            yellowspartan.Visible = false;
            pos_spartan.Style["position"] = "absolute";
            pos_spartan.Style["top"] = "410px";
            pos_spartan.Style["left"] = "50px";
            pos_spartan.Style["z-index"] = "0";
            pos_spartan.Style["opacity"] = "0.7";

        }
        else if (spartan > 10 && spartan <= 20)
        {
            pos_spartan.Visible = true;
            yellowspartan.Visible = true;
            greenspartan.Visible = false;
            redspartan.Visible = false;
            pos_spartan.Style["position"] = "absolute";
            pos_spartan.Style["top"] = "410px";
            pos_spartan.Style["left"] = "50px";
            pos_spartan.Style["z-index"] = "0";
            pos_spartan.Style["opacity"] = "0.7";
        }
        else if (spartan > 21)
        {
            pos_spartan.Visible = true;
            redspartan.Visible = true;
            greenspartan.Visible = false;
            yellowspartan.Visible = false;
            pos_spartan.Style["position"] = "absolute";
            pos_spartan.Style["top"] = "410px";
            pos_spartan.Style["left"] = "50px";
            pos_spartan.Style["z-index"] = "0";
            pos_spartan.Style["opacity"] = "0.7";
        }
        else
        {
            pos_spartan.Visible = true;
            nullspartan.Visible = true;
            redspartan.Visible = false;
            greenspartan.Visible = false;
            yellowspartan.Visible = false;
            pos_spartan.Style["position"] = "absolute";
            pos_spartan.Style["top"] = "410px";
            pos_spartan.Style["left"] = "50px";
            pos_spartan.Style["z-index"] = "0";
            pos_spartan.Style["opacity"] = "0.7";

        }
        if (cvs > 0 && cvs <= 10)
        {    
            pos_cvs.Visible = true;
            greencvs.Visible = true;
            redcvs.Visible = false;
            yellowcvs.Visible = false;
            pos_cvs.Style["position"] = "absolute";
            pos_cvs.Style["top"] = "400px";
            pos_cvs.Style["left"] = "300px";
            pos_cvs.Style["z-index"] = "0";
            pos_cvs.Style["opacity"] = "0.7";
        }
        else if (cvs > 10 && cvs <= 20)
        {
            pos_cvs.Visible = true;
            yellowcvs.Visible = true;
            greencvs.Visible = false;
            redcvs.Visible = false;
            pos_cvs.Style["position"] = "absolute";
            pos_cvs.Style["top"] = "400px";
            pos_cvs.Style["left"] = "300px";
            pos_cvs.Style["z-index"] = "0";
            pos_cvs.Style["opacity"] = "0.7";
        }
        else if (cvs > 21)
        {
            pos_cvs.Visible = true;
            redcvs.Visible = true;
            greencvs.Visible = false;
            yellowcvs.Visible = false;
            pos_cvs.Style["position"] = "absolute";
            pos_cvs.Style["top"] = "400px";
            pos_cvs.Style["left"] = "300px";
            pos_cvs.Style["z-index"] = "0";
            pos_cvs.Style["opacity"] = "0.7";
        }
        else
        {
            pos_cvs.Visible = true;
            nullcvs.Visible = true;
            redcvs.Visible = false ;
            greencvs.Visible = false;
            yellowcvs.Visible = false;
            pos_cvs.Style["position"] = "absolute";
            pos_cvs.Style["top"] = "400px";
            pos_cvs.Style["left"] = "300px";
            pos_cvs.Style["z-index"] = "0";
            pos_cvs.Style["opacity"] = "0.7";

        }
        if (sobeys > 0 && sobeys <= 10)
        {   
            pos_sobeys.Visible = true;
            greensobeys.Visible = true;
            redsobeys.Visible = false;
            yellowsobeys.Visible = false;
            pos_sobeys.Style["position"] = "absolute";
            pos_sobeys.Style["top"] = "200px";
            pos_sobeys.Style["left"] = "270px";
            pos_sobeys.Style["z-index"] = "0";
            pos_sobeys.Style["opacity"] = "0.7";

        }
        else if (sobeys > 10 && sobeys <= 20)
        {
            pos_sobeys.Visible = true;
            yellowsobeys.Visible = true;
            greensobeys.Visible = false;
            redsobeys.Visible = false;
            pos_sobeys.Style["position"] = "absolute";
            pos_sobeys.Style["top"] = "200px";
            pos_sobeys.Style["left"] = "270px";
            pos_sobeys.Style["z-index"] = "0";
            pos_sobeys.Style["opacity"] = "0.7";
        }
        else if (sobeys > 21)
        {
            pos_sobeys.Visible = true;
            redsobeys.Visible = true;
            greensobeys.Visible = false;
            yellowsobeys.Visible = false;
            pos_sobeys.Style["position"] = "absolute";
            pos_sobeys.Style["top"] = "200px";
            pos_sobeys.Style["left"] = "270px";
            pos_sobeys.Style["z-index"] = "0";
            pos_sobeys.Style["opacity"] = "0.7";
        }
        else
        {
            pos_sobeys.Visible = true;
            nullsobeys.Visible = true;
            redsobeys.Visible = false;
            greensobeys.Visible = false;
            yellowsobeys.Visible = false;
            pos_sobeys.Style["position"] = "absolute";
            pos_sobeys.Style["top"] = "200px";
            pos_sobeys.Style["left"] = "270px";
            pos_sobeys.Style["z-index"] = "0";
            pos_sobeys.Style["opacity"] = "0.7";

        }
      /*  if (coles > 0 && coles <= 10)
        {
            pos_coles.Visible = true;
            greencoles.Visible = true;
            redcoles.Visible = false;
            yellowcoles.Visible = false;
            pos_coles.Style["position"] = "absolute";
            pos_coles.Style["top"] = "670px";
            pos_coles.Style["left"] = "1075px";
            pos_coles.Style["z-index"] = "0";
            pos_coles.Style["opacity"] = "0.7";
        }
        else if (coles > 10 && coles <= 20)
        {
            pos_coles.Visible = true;
            yellowcoles.Visible = true;
            greencoles.Visible = false;
            redcoles.Visible = false;
            pos_coles.Style["position"] = "absolute";
            pos_coles.Style["top"] = "670px";
            pos_coles.Style["left"] = "1075px";
            pos_coles.Style["z-index"] = "0";
            pos_coles.Style["opacity"] = "0.7";
        }
        else if (coles > 21)
        {
            pos_coles.Visible = true;
            redcoles.Visible = true;
            greencoles.Visible = false;
            yellowcoles.Visible = false;
            pos_coles.Style["position"] = "absolute";
            pos_coles.Style["top"] = "670px";
            pos_coles.Style["left"] = "1075px";
            pos_coles.Style["z-index"] = "0";
            pos_coles.Style["opacity"] = "0.7";
        }
        else
        {
            pos_coles.Visible = true;
            nullcoles.Visible = true;
            redcoles.Visible = false;
            greencoles.Visible = false;
            yellowcoles.Visible = false;
            pos_coles.Style["position"] = "absolute";
            pos_coles.Style["top"] = "670px";
            pos_coles.Style["left"] = "1075px";
            pos_coles.Style["z-index"] = "0";
            pos_coles.Style["opacity"] = "0.7";

        }*/
        if (aeon > 0 && aeon <= 10)
        {
            pos_aeon.Visible = true;
            greenaeon.Visible = true;
            redaeon.Visible = false;
            yellowaeon.Visible = false;
            pos_aeon.Style["position"] = "absolute";
            pos_aeon.Style["top"] = "350px";
            pos_aeon.Style["left"] = "1035px";
            pos_aeon.Style["z-index"] = "0";
            pos_aeon.Style["opacity"] = "0.7";

        }
        else if (aeon > 10 && aeon <= 20)
        {
            pos_aeon.Visible = true;
            yellowaeon.Visible = true;
            greenaeon.Visible = false;
            redaeon.Visible = false;
            pos_aeon.Style["position"] = "absolute";
            pos_aeon.Style["top"] = "350px";
            pos_aeon.Style["left"] = "1035px";
            pos_aeon.Style["z-index"] = "0";
            pos_aeon.Style["opacity"] = "0.7";
        }
        else if (aeon > 21)
        {
            pos_aeon.Visible = true;
            redaeon.Visible = true;
            greenaeon.Visible = false;
            yellowaeon.Visible = false;
            pos_aeon.Style["position"] = "absolute";
            pos_aeon.Style["top"] = "350px";
            pos_aeon.Style["left"] = "1035px";
            pos_aeon.Style["z-index"] = "0";
            pos_aeon.Style["opacity"] = "0.7";
        }
        else
        {
            pos_aeon.Visible = true;
            nullaeon.Visible = true;
            redaeon.Visible = false;
            greenaeon.Visible = false;
            yellowaeon.Visible = false;
            pos_aeon.Style["position"] = "absolute";
            pos_aeon.Style["top"] = "350px";
            pos_aeon.Style["left"] = "1035px";
            pos_aeon.Style["z-index"] = "0";
            pos_aeon.Style["opacity"] = "0.7";

        }
        if (mig > 0 && mig <= 10)
        {
            pos_mig.Visible = true;
            greenmig.Visible = true;
            redmig.Visible = false;
            yellowmig.Visible = false;
            pos_mig.Style["position"] = "absolute";
            pos_mig.Style["top"] = "390px";
            pos_mig.Style["left"] = "610px";
            pos_mig.Style["z-index"] = "0";
            pos_mig.Style["opacity"] = "0.7";
        }
        else if (mig > 10 && mig <= 20)
        {
            pos_mig.Visible = true;
            yellowmig.Visible = true;
            greenmig.Visible = false;
            redmig.Visible = false;
            pos_mig.Style["position"] = "absolute";
            pos_mig.Style["top"] = "390px";
            pos_mig.Style["left"] = "610px";
            pos_mig.Style["z-index"] = "0";
            pos_mig.Style["opacity"] = "0.7";
        }
        else if (mig > 21)
        {
            pos_mig.Visible = true;
            redmig.Visible = true;
            greenmig.Visible = false;
            yellowmig.Visible = false;
            pos_mig.Style["position"] = "absolute";
            pos_mig.Style["top"] = "390px";
            pos_mig.Style["left"] = "610px";
            pos_mig.Style["z-index"] = "0";
            pos_mig.Style["opacity"] = "0.7";
        }
        else
        {
            pos_mig.Visible = true;
            nullmig.Visible = true;
            redmig.Visible = false;
            greenmig.Visible = false;
            yellowmig.Visible = false;
            pos_mig.Style["position"] = "absolute";
            pos_mig.Style["top"] = "390px";
            pos_mig.Style["left"] = "610px";
            pos_mig.Style["z-index"] = "0";
            pos_mig.Style["opacity"] = "0.7";

        }
       
        if (ica > 0 && ica <= 10)
        {
            pos_ica.Visible = true;
            greenica.Visible = true;
            redica.Visible = false;
            yellowica.Visible = false;
            pos_ica.Style["position"] = "absolute";
            pos_ica.Style["top"] = "220px";
            pos_ica.Style["left"] = "640px";
            pos_ica.Style["z-index"] = "0";
            pos_ica.Style["opacity"] = "0.7";
        }
        else if (ica > 10 && ica <= 20)
        {
            pos_ica.Visible = true;
            yellowica.Visible = true;
            greenica.Visible = false;
            redica.Visible = false;
            pos_ica.Style["position"] = "absolute";
            pos_ica.Style["top"] = "220px";
            pos_ica.Style["left"] = "640px";
            pos_ica.Style["z-index"] = "0";
            pos_ica.Style["opacity"] = "0.7";
        }
        else if (ica > 21)
        {
            pos_ica.Visible = true;
            redica.Visible = true;
            greenica.Visible = false;
            yellowica.Visible = false;
            pos_ica.Style["position"] = "absolute";
            pos_ica.Style["top"] = "220px";
            pos_ica.Style["left"] = "640px";
            pos_ica.Style["z-index"] = "0";
            pos_ica.Style["opacity"] = "0.7";
        }
        else
        {
            pos_ica.Visible = true;
            nullica.Visible = true;
            redica.Visible = false;
            greenica.Visible = false;
            yellowica.Visible = false;
            pos_ica.Style["position"] = "absolute";
            pos_ica.Style["top"] = "220px";
            pos_ica.Style["left"] = "640px";
            pos_ica.Style["z-index"] = "0";
            pos_ica.Style["opacity"] = "0.7";

        }
        if (sains > 0 && sains <= 10)
        {

            pos_sains.Visible = true;
            greensains.Visible = true;
            redsains.Visible = false;
            yellowsains.Visible = false;
            pos_sains.Style["position"] = "absolute";
            pos_sains.Style["top"] = "280px";
            pos_sains.Style["left"] = "450px";
            pos_sains.Style["z-index"] = "0";
            pos_sains.Style["opacity"] = "0.7";

        }
        else if (sains > 10 && sains <= 20)
        {
            pos_sains.Visible = true;
            yellowsains.Visible = true;
            greensains.Visible = false;
            redsains.Visible = false;
            pos_sains.Style["position"] = "absolute";
            pos_sains.Style["top"] = "280px";
            pos_sains.Style["left"] = "450px";
            pos_sains.Style["z-index"] = "0";
            pos_sains.Style["opacity"] = "0.7";
        }
        else if (sains > 21)
        {
            pos_sains.Visible = true;
            redsains.Visible = true;
            greensains.Visible = false;
            yellowsains.Visible = false;
            pos_sains.Style["position"] = "absolute";
            pos_sains.Style["top"] = "280px";
            pos_sains.Style["left"] = "450px";
            pos_sains.Style["z-index"] = "0";
            pos_sains.Style["opacity"] = "0.7";
        }
        else
        {
            pos_sains.Visible = true;
            nullsains.Visible = true;
            redsains.Visible = false;
            greensains.Visible = false;
            yellowsains.Visible = false;
            pos_sains.Style["position"] = "absolute";
            pos_sains.Style["top"] = "280px";
            pos_sains.Style["left"] = "450px";
            pos_sains.Style["z-index"] = "0";
            pos_sains.Style["opacity"] = "0.7";

        }
        if (sonae > 0 && sonae <= 10)
        {
            pos_sonae.Visible = true;
            greensonae.Visible = true;
            redsonae.Visible = false;
            yellowsonae.Visible = false;
            pos_sonae.Style["position"] = "absolute";
            pos_sonae.Style["top"] = "380px";
            pos_sonae.Style["left"] = "405px";
            pos_sonae.Style["z-index"] = "0";
            pos_sonae.Style["opacity"] = "0.7";
        }
        else if (sonae > 10 && sonae <= 20)
        {
            pos_sonae.Visible = true;
            yellowsonae.Visible = true;
            greensonae.Visible = false;
            redsonae.Visible = false;
            pos_sonae.Style["position"] = "absolute";
            pos_sonae.Style["top"] = "380px";
            pos_sonae.Style["left"] = "405px";
            pos_sonae.Style["z-index"] = "0";
            pos_sonae.Style["opacity"] = "0.7";
        }
        else if (sonae > 21)
        {
            pos_sonae.Visible = true;
            redsonae.Visible = true;
            greensonae.Visible = false;
            yellowsonae.Visible = false;
            pos_sonae.Style["position"] = "absolute";
            pos_sonae.Style["top"] = "380px";
            pos_sonae.Style["left"] = "405px";
            pos_sonae.Style["z-index"] = "0";
            pos_sonae.Style["opacity"] = "0.7";
        }
        else
        {
            pos_sonae.Visible = true;
            nullsonae.Visible = true;
            redsonae.Visible = false;
            greensonae.Visible = false;
            yellowsonae.Visible = false;
            pos_sonae.Style["position"] = "absolute";
            pos_sonae.Style["top"] = "380px";
            pos_sonae.Style["left"] = "405px";
            pos_sonae.Style["z-index"] = "0";
            pos_sonae.Style["opacity"] = "0.7";

        }

        if (madisonWg > 0 && madisonWg <= 10)
        {
            pos_wegmans.Visible = true;
            greenwegmans.Visible = true;
            redwegmans.Visible = false;
            yellowwegmans.Visible = false;
            pos_wegmans.Style["position"] = "absolute";
            pos_wegmans.Style["top"] = "300px";
            pos_wegmans.Style["left"] = "60px";
            pos_wegmans.Style["z-index"] = "0";
            pos_wegmans.Style["opacity"] = "0.7";
        }
        else if (madisonWg > 10 && madisonWg <= 20)
        {
            pos_wegmans.Visible = true;
            greenwegmans.Visible = false;
            redwegmans.Visible = false;
            yellowwegmans.Visible = true;
            pos_wegmans.Style["position"] = "absolute";
            pos_wegmans.Style["top"] = "300px";
            pos_wegmans.Style["left"] = "60px";
            pos_wegmans.Style["z-index"] = "0";
            pos_wegmans.Style["opacity"] = "0.7";
        }
        else if (madisonWg > 21)
        {
            pos_wegmans.Visible = true;
            greenwegmans.Visible = false;
            redwegmans.Visible = true;
            yellowwegmans.Visible = false;
            pos_wegmans.Style["position"] = "absolute";
            pos_wegmans.Style["top"] = "300px";
            pos_wegmans.Style["left"] = "60px";
            pos_wegmans.Style["z-index"] = "0";
            pos_wegmans.Style["opacity"] = "0.7";
        }
        else
        {
            pos_wegmans.Visible = true;
            greenwegmans.Visible = false;
            redwegmans.Visible = false;
            yellowwegmans.Visible = false;
            nullwegmans.Visible = true;
            pos_wegmans.Style["position"] = "absolute";
            pos_wegmans.Style["top"] = "300px";
            pos_wegmans.Style["left"] = "60px";
            pos_wegmans.Style["z-index"] = "0";
            pos_wegmans.Style["opacity"] = "0.7";
        }

        if (madisonBJ > 0 && madisonBJ <= 10)
        {
            pos_bjs.Visible = true;
            greenbjs.Visible = true;
            redbjs.Visible = false;
            yellowbjs.Visible = false;
            pos_bjs.Style["position"] = "absolute";
            pos_bjs.Style["top"] = "215px";
            pos_bjs.Style["left"] = "70px";
            pos_bjs.Style["z-index"] = "0";
            pos_bjs.Style["opacity"] = "0.7";
        }
        else if (madisonBJ > 10 && madisonBJ <= 20)
        {
            pos_bjs.Visible = true;
            greenbjs.Visible = false;
            redbjs.Visible = false;
            yellowbjs.Visible = true;
            pos_bjs.Style["position"] = "absolute";
            pos_bjs.Style["top"] = "215px";
            pos_bjs.Style["left"] = "70px";
            pos_bjs.Style["z-index"] = "0";
            pos_bjs.Style["opacity"] = "0.7";
        }
        else if (madisonBJ > 21)
        {
            pos_bjs.Visible = true;
            greenbjs.Visible = false;
            redbjs.Visible = true;
            yellowbjs.Visible = false;
            pos_bjs.Style["position"] = "absolute";
            pos_bjs.Style["top"] = "215px";
            pos_bjs.Style["left"] = "70px";
            pos_bjs.Style["z-index"] = "0";
            pos_bjs.Style["opacity"] = "0.7";
        }
        else
        {

            pos_bjs.Visible = true;
            greenbjs.Visible = false;
            redbjs.Visible = false;
            yellowbjs.Visible = false;
            nullbjs.Visible = true;
            pos_bjs.Style["position"] = "absolute";
            pos_bjs.Style["top"] = "215px";
            pos_bjs.Style["left"] = "70px";
            pos_bjs.Style["z-index"] = "0";
            pos_bjs.Style["opacity"] = "0.7";
        }

    }
    
}

