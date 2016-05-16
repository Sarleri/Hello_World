 using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Microsoft.Office;
using System.Data.OleDb;
using System.Configuration;
using System.Text;
using System.Net.Mail;
using System.Drawing.Design;
using System.Web.UI.WebControls.WebParts;
using System.Globalization;

public partial class LoadStatus : System.Web.UI.Page
{

    static DataTable dt = null;
   // DataTable dt1 = new DataTable();
    //DataTable dt2 = new DataTable();
    string filepath = "";
    
    char[] delimiterChars = { ' ' };
    string SAINS_SS = "SAINS_SS";
    string SSL03_PROD3 = "SSL03_PROD3";
    string SSL04_PROD4 = "SSL04_PROD4";
    string CVS01 = "CVS01";
    string CVS02 = "CVS02";
    string MIGROS = "MIGROS";
    string LESHOP = "LESHOP";
    string MIGROLINO = "MIGROLINO";
    string MIGROL = "MIGROL";
    string AEON01 = "AEON01";
    string COLES01 = "COLES01";
    string COLES02 = "COLES02";
    string SOBEYS01 = "SOBEYS01";
    string MADISON01 = "MADISON01";
    string SPARTAN01 = "SPARTAN01";
    string MIGROS01 = "MIGROS01";
    string SONAE01 = "SONAE01";
    string ICA01 = "ICA01";
    string BJS = "BJS";
    string WEGMANS = "WEGMANS";
    protected void Page_Load(object sender, EventArgs e)
    {     
            CreateDataTable();
    }

    private void CreateDataTable()
    {

            string[] cols = { "CLIENTS", "DATABASE", "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN", "weekly-MON", "weekly-TUE", "weekly-SUN", "DASHBOARD", "OFFER ENGINE", "SEGMENTATION", "BACKUP", "RECLAIM" };
            dt = new DataTable();

            filepath = ConfigurationManager.AppSettings["DataLoadStatusPath"];
           

            string SAINS_SSpath = filepath + SAINS_SS;
            string SSL03_PROD3path = filepath + SSL03_PROD3;
            string SSL04_PROD4path = filepath + SSL04_PROD4;
            string CVS01path = filepath + CVS01;
            string CVS02path = filepath + CVS02;
            string MIGROSpath = filepath + MIGROS;
            string MIGROLINOpath = filepath + MIGROLINO;
            string MIGROLpath = filepath + MIGROL;
            string LESHOPpath = filepath + LESHOP;
            string COLES01path = filepath + COLES01;
            string COLES02path = filepath + COLES02;
            string SOBEYS01path = filepath + SOBEYS01;
            string MADISON01path = filepath + MADISON01;
            string SPARTAN01path = filepath + SPARTAN01;
            string SONAE01path = filepath + SONAE01;
            string ICA01path = filepath + ICA01;
            string BJSpath = filepath + BJS;
            string WEGMANSpath = filepath + WEGMANS;
            string AEONpath = filepath + AEON01;
         
            foreach (string str in cols)
                dt.Columns.Add(str);

            dt = Dls(AEONpath, AEON01);
            dt = Dls(CVS01path, CVS01);
            dt = Dls(CVS02path, CVS02);
        dt = Dls(BJSpath, BJS);
        dt = Dls(WEGMANSpath, WEGMANS);
        dt = Dls(MIGROSpath, MIGROS);
            dt = Dls(LESHOPpath, LESHOP);
            dt = Dls(MIGROLINOpath, MIGROLINO);
            dt = Dls(MIGROLpath, MIGROL);
        dt = Dls(ICA01path, ICA01);
        dt = Dls(SPARTAN01path, SPARTAN01);
        dt = Dls(SAINS_SSpath, SAINS_SS);
            dt = Dls(SSL03_PROD3path, SSL03_PROD3);
            dt = Dls(SSL04_PROD4path, SSL04_PROD4);
            //dt = Dls(COLES01path, COLES01);
            //dt = Dls(COLES02path, COLES02);
            dt = Dls(SOBEYS01path, SOBEYS01);
          //  dt = Dls(MADISON01path, MADISON01);
            dt = Dls(SONAE01path, SONAE01);
                gv_LoadStatus.DataSource = dt;

        gv_LoadStatus.DataBind();
    }
    public DataTable Dls(string filepath, string Sponsors)
    {
        string[] subdirEntries = Directory.GetDirectories(filepath);
        DataRow dr = dt.NewRow();

        if (Sponsors == "SAINS_SS")
        {
            dr["CLIENTS"] = "SAINSBURYS";
         
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "SSL03_PROD3")
        {
            dr["CLIENTS"] = "SAINSBURYS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "SSL04_PROD4")
        {
            dr["CLIENTS"] = "SAINSBURYS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "CVS01")
        {
            dr["CLIENTS"] = "CVS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "CVS02")
        {
            dr["CLIENTS"] = "CVS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "MIGROS")
        {
            dr["CLIENTS"] = "MIGROS";
            dr["DATABASE"] = Sponsors;
        }
         if (Sponsors == "LESHOP")
        {
            dr["CLIENTS"] = "MIGROS";
            dr["DATABASE"] = Sponsors;
        }
         if (Sponsors == "MIGROLINO")
        {
            dr["CLIENTS"] = "MIGROS";
            dr["DATABASE"] = Sponsors;
        }
         if (Sponsors == "MIGROL")
        {
            dr["CLIENTS"] = "MIGROS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "COLES01")
        {
            dr["CLIENTS"] = "COLES";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "COLES02")
        {
            dr["CLIENTS"] = "COLES";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "SOBEYS01")
        {
            dr["CLIENTS"] = "SOBEYS";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "MADISON01")
        {
            dr["CLIENTS"] = "MADISON";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "SPARTAN01")
        {
            dr["CLIENTS"] = "SPARTAN";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "SONAE01")
        {
            dr["CLIENTS"] = "SONAE";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "ICA01")
        {
            dr["CLIENTS"] = "ICA";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "BJS")
        {
            dr["CLIENTS"] = "MADISON";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "WEGMANS")
        {
            dr["CLIENTS"] = "MADISON";
            dr["DATABASE"] = Sponsors;
        }
        if (Sponsors == "AEON01")
        {
            dr["CLIENTS"] = "AEON";
            dr["DATABASE"] = Sponsors;
        }

        if ((Sponsors == "SAINS_SS") || (Sponsors == "SSL03_PROD3") ||(Sponsors == "SSL04_PROD4")||(Sponsors=="SOBEYS01"))
        {
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
                          
                            lastWrite = file.LastWriteTime;
                            lastWritenFile = file;

                            String filename = lastWritenFile.Name.ToString();
                            String filetime = lastWrite.ToString("dd/MM/yyyy");
                            string[] words = filename.Split(delimiterChars);
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if ((words[i].Contains("ERROR")))
                                {
                                    String replacedfilename1 = filename.Replace("WITH ERRORS", "SUCCESSFULLY");
                                    String replacedfilename2 = filename.Replace("ERRORS", "WARNINGS");
                                   // string path = filepath + "\\Daily Load\\" + replacedfilename1;
                                   // string path1 = filepath + "\\Daily Load\\" + replacedfilename2;
                                     string path = di + "\\" + replacedfilename1;
                                     string path1 = di + "\\" + replacedfilename2;
                                    FileInfo file1 = new FileInfo(path);
                                    FileInfo file2 = new FileInfo(path1);
                                    if ((file1.Exists) || (file2.Exists))
                                    {
                                        file.Delete();
                                        break;
                                    }

                                }
                            }
                            foreach (FileInfo filebr in files)
                            {
                                if (filebr.LastWriteTime > lastWrite)
                                {
                                    lastWrite = filebr.LastWriteTime;
                                    lastWritenFile = filebr;
                                }
                            }
                            String filenamebr = lastWritenFile.Name.ToString();
                            String filetimebr = lastWrite.ToString("dd/MM/yyyy");
                            string[] wordsbr = filenamebr.Split(delimiterChars);
                            for (int i = 0; i < (wordsbr.Length); i++)
                            {
                                 int Nooffiles = 0;
                                 if ((diname == "BACKUP" || diname == "RECLAIM") && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                 {
                            Nooffiles = Nooffiles + 1;
                            dr[diname] = "Completed on " + filetimebr;
                        
                                 }
                                 else if ((diname == "BACKUP" || diname == "RECLAIM") && wordsbr[i].Contains("ERROR"))
                                 {
                            Nooffiles = Nooffiles + 1;
                            dr[diname] = "Pending on " + filetimebr;
                                 }
                                 //else if(diname == "BACKUP"|| diname == "RECLAIM")
                                 // {
                                 //     dr[diname] = "Pending on" + filetime;
                                 //   }
                                 else if (diname == "OFFER ENGINE" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                 {
                                     dr[diname] = "Completed on " + filetimebr;
                                         Nooffiles = Nooffiles + 1;
                                   
                                 }
                                 else if (diname == "OFFER ENGINE" && (wordsbr[i].Contains("ERROR")))
                                 {
                                     dr[diname] = "Pending on " + filetimebr;
                                     Nooffiles = Nooffiles + 1;
                                 }
                                 else if (diname == "DASHBOARD" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                 {
                                     dr[diname] = "Completed on " + filetimebr;
                                     Nooffiles = Nooffiles + 1;

                                 }
                                 else if (diname == "DASHBOARD" && (wordsbr[i].Contains("ERROR")))
                                 {
                                     dr[diname] = "Pending on " + filetimebr;
                                     Nooffiles = Nooffiles + 1;
                                 }
                            }
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if ((words[i].StartsWith("20")) && (words[i].Length == 8))
                                {
                                    string date = words[i];
                                    DateTime d = DateTime.ParseExact(date, "yyyyMMdd", null);

                                    TimeSpan ts = DateTime.UtcNow.Date.Subtract(d);
                                    CultureInfo ciCurr = CultureInfo.CurrentCulture;
                                    int weekNum = ciCurr.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                    int nowweeknum = ciCurr.Calendar.GetWeekOfYear(DateTime.UtcNow.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                   
                                    if ((weekNum < nowweeknum) && ((diname == "DAILY LOAD")))
                                    {
                                        file.Delete();
                                        break;
                                    }
                                    else if(ts.Days>30)
                                    {
                                        file.Delete();
                                        break;

                                    }
                                    if ((diname == "WEEKLY REFRESH ON WX2") && (Sponsors != "SOBEYS01"))
                                    {
                                        d = d.AddDays(1);
                                    }
                                    
                                    string day = d.ToString("ddd").ToUpper();
                                    for (int j = i + 1; j < (words.Length); j++)
                                    {
                                        if (diname == "DAILY LOAD" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {

                                            dr[day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (diname == "WEEKLY REFRESH ON WX2" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {
                                          
                                            dr["weekly-" + day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;

                                        }
                                        
                                        else if (diname == "WEEKLY REFRESH ON WX2" && (words[j].Contains("ERROR")))
                                        {
                                            dr["weekly-" + day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (words[j].Contains("ERROR"))
                                        {

                                            dr[day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else
                                        {
                                          
                                        }
                                    }
                                    break;
                                }
                            
                                else
                                {

                                }
                                }
                            
                        }
                    }

                    else
                    {
                       
                    }
                }
            }
        
        if ((Sponsors == "COLES01") || (Sponsors == "COLES02")||(Sponsors == "MIGROS") || (Sponsors == "MIGROLINO") || (Sponsors == "MIGROL")|| (Sponsors == "LESHOP"))
        {
            foreach (string subDir in subdirEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subDir);
                FileInfo[] files = di.GetFiles();
                DateTime lastWrite = DateTime.MinValue;
                FileInfo lastWritenFile = null;
                String diname = di.Name.ToString();
                if (((diname == "BACKUP") || (diname == "RECLAIM")) && ((Sponsors == "MIGROS") || (Sponsors == "MIGROLINO") || (Sponsors == "MIGROL") || (Sponsors == "LESHOP")))
                {
                   
                    string filepath1 = ConfigurationManager.AppSettings["DataLoadStatusPath"];
                    di = new DirectoryInfo(filepath1 + MIGROS + "//" + diname);
                    files = di.GetFiles();

                }
                int count = 0;

                count = files.Length;

                if (count != 0)
                {
                    foreach (FileInfo file in files)
                    {
                        
                            lastWrite = file.LastWriteTime;
                            lastWritenFile = file;


                            String filename = lastWritenFile.Name.ToString();
                            String filetime = lastWrite.ToString("dd/MM/yyyy");
                            string[] words = filename.Split(delimiterChars);
                            foreach (FileInfo filebr in files)
                            {
                                if (filebr.LastWriteTime > lastWrite)
                                {
                                    lastWrite = filebr.LastWriteTime;
                                    lastWritenFile = filebr;
                                }
                            }
                            String filenamebr = lastWritenFile.Name.ToString();
                            String filetimebr = lastWrite.ToString("dd/MM/yyyy");
                            string[] wordsbr = filenamebr.Split(delimiterChars);
                            for (int i = 0; i < (wordsbr.Length); i++)
                            {
                                int Nooffiles = 0;
                                if ((diname == "BACKUP" || diname == "RECLAIM") && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {
                                    Nooffiles = Nooffiles + 1;
                                    dr[diname] = "Completed on " + filetimebr;
                                }
                                else if ((diname == "BACKUP" || diname == "RECLAIM") && wordsbr[i].Contains("ERROR"))
                                {
                                    Nooffiles = Nooffiles + 1;
                                    dr[diname] = "Pending on " + filetimebr;
                                }
                                //else if(diname == "BACKUP"|| diname == "RECLAIM")
                                // {
                                //     dr[diname] = "Pending on" + filetime;
                                //   }
                                else if (diname == "OFFER ENGINE" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {
                                    dr[diname] = "Completed on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;

                                }
                                else if (diname == "OFFER ENGINE" && (wordsbr[i].Contains("ERROR")))
                                {
                                    dr[diname] = "Pending on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;
                                }
                                else if (diname == "DASHBOARD" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {
                                    dr[diname] = "Completed on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;

                                }
                                else if (diname == "DASHBOARD" && (wordsbr[i].Contains("ERROR")))
                                {
                                    dr[diname] = "Pending on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;
                                }
                                if ((wordsbr[i].Contains("ERROR")))
                                {
                                    String replacedfilename1 = filename.Replace("WITH ERRORS", "SUCCESSFULLY");
                                    String replacedfilename2 = filename.Replace("ERRORS", "WARNINGS");
                                    string path = di + "\\" + replacedfilename1;
                                    string path1 = di + "\\" + replacedfilename2;

                                    FileInfo file1 = new FileInfo(path);
                                    FileInfo file2 = new FileInfo(path1);
                                    if ((file1.Exists) || (file2.Exists))
                                    {
                                        file.Delete();
                                        break;
                                    }

                                }

                            }
                            
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if ((words[i].StartsWith("20")) && (words[i].Length == 8))
                                {
                                    string date = words[i];
                                    DateTime d = DateTime.ParseExact(date, "yyyyMMdd", null);

                                    TimeSpan ts = DateTime.UtcNow.Date.Subtract(d);
                                    CultureInfo ciCurr = CultureInfo.CurrentCulture;
                                    int weekNum = ciCurr.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                    int nowweeknum = ciCurr.Calendar.GetWeekOfYear(DateTime.UtcNow.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                    
                                    if ((diname == "WEEKLY REFRESH ON WX2") && ((Sponsors == "COLES01") || (Sponsors == "COLES02")))
                                    {
                                         weekNum = ciCurr.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Tuesday);
                                         nowweeknum = ciCurr.Calendar.GetWeekOfYear(DateTime.UtcNow.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Tuesday);
                                    }
                                   
                                   
                                    if ((weekNum < nowweeknum) && ((diname == "DAILY LOAD") || (diname == "WEEKLY REFRESH ON WX2")))
                                    {
                                        file.Delete();
                                        break;
                                    }
                                    else if (ts.Days > 30)
                                    {
                                        file.Delete();
                                        break;

                                    }

                                    //if (diname == "WEEKLY REFRESH ON WX2")
                                    //{
                                    //    d = d.AddDays(1);
                                    //}
                                    string day = d.ToString("ddd").ToUpper();
                                    for (int j = i + 1; j < (words.Length); j++)
                                    {
                                        if (diname == "DAILY LOAD" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {

                                            dr[day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (diname == "WEEKLY REFRESH ON WX2" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {
                                            dr["weekly-" + day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;

                                        }

                                        else if (diname == "WEEKLY REFRESH ON WX2" && (words[j].Contains("ERROR")))
                                        {
                                            dr["weekly-" + day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (diname == "SEGMENTATION" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {
                                            dr[diname] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;

                                        }
                                        else if (diname == "SEGMENTATION" && (words[j].Contains("ERROR")))
                                        {
                                            dr[diname] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (words[j].Contains("ERROR"))
                                        {

                                            dr[day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                }
                            }
                        }
                        //  }
                    
                }
                else
                {

                }
            }
        }
        if ((Sponsors == "CVS01") || (Sponsors == "CVS02") || (Sponsors == "AEON01") || (Sponsors == "SPARTAN01")||(Sponsors=="SONAE01")||(Sponsors=="ICA01")||(Sponsors=="BJS")||(Sponsors=="WEGMANS"))
        {
            
            foreach (string subDir in subdirEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subDir);
                FileInfo[] files = di.GetFiles();
                DateTime lastWrite = DateTime.MinValue;
                FileInfo lastWritenFile = null;
                String diname = di.Name.ToString();

                if (((diname == "BACKUP") || (diname == "RECLAIM") || (diname == "WEEKLY REFRESH ON WX2")) && ((Sponsors == "BJS") || (Sponsors == "WEGMANS")))
                {
                    string filepath1 = ConfigurationManager.AppSettings["DataLoadStatusPath"];
                    di = new DirectoryInfo(filepath1 + MADISON01 + "//" + diname);
                    files = di.GetFiles();

                }
              
                int count = 0;

                count = files.Length;

                if (count != 0)
                {
                    foreach (FileInfo file in files)
                    {
                        //if (file.LastWriteTime > lastWrite)
                        //{
                            lastWrite = file.LastWriteTime;
                            lastWritenFile = file;
                       // }

                        String filename = lastWritenFile.Name.ToString();
                        String filetime = lastWrite.ToString("dd/MM/yyyy");
                        string[] words = filename.Split(delimiterChars);
                        string Both = "NO";
                        if (diname == "WEEKLY REFRESH ON WX2")
                        {
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if ((words[i].Contains("PUBLISH")))
                                {
                                        Both = "yes";
                                }
                            }
                        } 
                   else
                        {
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if ((words[i].Contains("TIDY")))
                                {
                                    String replacedfilename1 = filename.Replace("TIDY SH", "FTP SCRIPT");
                                    string path = filepath + "\\DAILY LOAD\\" + replacedfilename1;
                                    FileInfo file1 = new FileInfo(path);
                                    if (file1.Exists)
                                    {
                                        Both = "yes";
                                    }
                                    else 
                                    {
                                        Both = "one";
                                    }

                                }
                                else if ((words[i].Contains("FTP")))
                                {
                                    String replacedfilename1 = filename.Replace("FTP SCRIPT", "TIDY SH");
                                    string path = filepath + "\\DAILY LOAD\\" + replacedfilename1;
                                    FileInfo file1 = new FileInfo(path);
                                    if (file1.Exists)
                                    {
                                        Both = "yes";
                                    }
                                    else
                                    {
                                        Both = "one";
                                    }
                                }
                                if ((words[i].Contains("ERROR")))
                                {
                                    String replacedfilename1 = filename.Replace("WITH ERRORS", "SUCCESSFULLY");
                                    String replacedfilename2 = filename.Replace("ERRORS", "WARNINGS");
                                    string path = di + "\\" + replacedfilename1;
                                    string path1 = di + "\\" + replacedfilename2;

                                    FileInfo file1 = new FileInfo(path);
                                    FileInfo file2 = new FileInfo(path1);
                                    if ((file1.Exists) || (file2.Exists))
                                    {
                                        file.Delete();
                                        break;
                                    }

                                }
                            }
                        }

                        foreach (FileInfo filebr in files)
                        {
                            if (filebr.LastWriteTime > lastWrite)
                            {
                                lastWrite = filebr.LastWriteTime;
                                lastWritenFile = filebr;
                            }
                        }
                        String filenamebr = lastWritenFile.Name.ToString();
                        String filetimebr = lastWrite.ToString("dd/MM/yyyy");
                        string[] wordsbr = filenamebr.Split(delimiterChars);
                            for (int i = 0; i < (wordsbr.Length); i++)
                            {
                                int Nooffiles = 0;
                                if ((diname == "BACKUP" || diname == "RECLAIM") && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {

                                    Nooffiles = Nooffiles + 1;
                                    dr[diname] = "Completed on " + filetimebr;
                                }
                                else if ((diname == "BACKUP" || diname == "RECLAIM") && wordsbr[i].Contains("ERROR"))
                                {
                                    Nooffiles = Nooffiles + 1;
                                    dr[diname] = "Pending on " + filetimebr;
                                }
                                //else if (diname == "BACKUP" || diname == "RECLAIM")
                                //{
                                //    dr[diname] = "Pending on" + filetime;
                                //}
                                else if (diname == "OFFER ENGINE" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {
                                    dr[diname] = "Completed on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;

                                }
                                else if (diname == "OFFER ENGINE" && (wordsbr[i].Contains("ERROR")))
                                {
                                    dr[diname] = "Pending on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;
                                }
                                else if (diname == "DASHBOARD" && ((wordsbr[i].Contains("SUCCESS")) || (wordsbr[i].Contains("WARNING"))))
                                {
                                    dr[diname] = "Completed on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;

                                }
                                else if (diname == "DASHBOARD" && (wordsbr[i].Contains("ERROR")))
                                {
                                    dr[diname] = "Pending on " + filetimebr;
                                    Nooffiles = Nooffiles + 1;
                                }
                         
                               
                           
                        }
                            for (int i = 0; i < (words.Length - 1); i++)
                        {

                            if ((words[i].StartsWith("20")) && (words[i].Length == 8))
                            {
                                string date = words[i];
                                DateTime d = DateTime.ParseExact(date, "yyyyMMdd", null);

                                TimeSpan ts = DateTime.UtcNow.Date.Subtract(d);
                                CultureInfo ciCurr = CultureInfo.CurrentCulture;
                                int weekNum = ciCurr.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                int nowweeknum = ciCurr.Calendar.GetWeekOfYear(DateTime.UtcNow.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                                if ((weekNum < nowweeknum) && ((diname == "DAILY LOAD") || (diname == "WEEKLY REFRESH ON WX2")))
                                {
                                    file.Delete();
                                    break;
                                }
                                else if (ts.Days > 30)
                                {
                                    file.Delete();
                                    break;

                                }

                                //  d = d.AddDays(1);
                                //if ((Sponsors == "BJS") || (Sponsors == "WEGMANS"))
                                //{
                                //    d = d.AddDays(-2);
                                //}
                                string day = d.ToString("ddd").ToUpper();
                                if ((Both == "yes"))
                                {
                                    for (int j = i + 1; j < (words.Length); j++)
                                    {
                                        if (diname == "DAILY LOAD" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {

                                            dr[day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (diname == "WEEKLY REFRESH ON WX2" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {
                                            if ((Sponsors == "BJS") || (Sponsors == "WEGMANS"))
                                            {
                                                day = "TUE";
                                            }
                                            dr["weekly-" + day] = "Completed on " + d.Day + "-" + d.Month + "-" + d.Year;

                                        }

                                        else if (diname == "WEEKLY REFRESH ON WX2" && (words[j].Contains("ERROR")))
                                        {
                                            dr["weekly-" + day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (words[j].Contains("ERROR"))
                                        {

                                            dr[day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else
                                        {
                                            //dr[day] = "NA";
                                            //if ((day == "MON") || (day == "TUE") || (day == "SUN")) {
                                            //    dr["weekly-" + day] = "NA";
                                            //}
                                        }
                                    }
                                    break;
                                }
                                else if ((Both == "one"))
                                {
                                    for (int j = i + 1; j < (words.Length); j++)
                                    {
                                        if (diname == "DAILY LOAD" && ((words[j].Contains("SUCCESS")) || (words[j].Contains("WARNING"))))
                                        {

                                            dr[day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else if (words[j].Contains("ERROR"))
                                        {

                                            dr[day] = "Pending on " + d.Day + "-" + d.Month + "-" + d.Year;
                                        }
                                        else
                                        {
                                            //dr[day] = "NA";
                                            //if ((day == "MON") || (day == "TUE") || (day == "SUN")) {
                                            //    dr["weekly-" + day] = "NA";
                                            //}
                                        }
                                    }
                                    break;

                                }
                            }
                            else if ((diname == "DAILY LOAD") && ((Sponsors == "BJS") || (Sponsors == "WEGMANS")))
                            {
                                for (i = 0; i < (words.Length); i++)
                                {
                                    if ((diname == "DAILY LOAD") && ((Sponsors == "BJS") || (Sponsors == "WEGMANS")) && ((words[i].Contains("SUCCESS")) || (words[i].Contains("WARNING"))))
                                    {
                                        dr["TUE"] = "Completed on " + filetime;

                                    }
                                    else if ((diname == "DAILY LOAD") && ((Sponsors == "BJS") || (Sponsors == "WEGMANS")) && (words[i].Contains("ERROR")))
                                    {
                                        dr["TUE"] = "Pending on " + filetime;
                                    }
                                }
                                break;
                            }
                            
                        }
                    }
                    //  }
                }
                else
                {
                 
                }
            }
        }
        dt.Rows.Add(dr);
        return dt;
    }
   

    protected void gv_LoadStatus_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      
        GridViewRow gvRow = e.Row;
        
        if (gvRow.RowType == DataControlRowType.Header)
        {
            if (gvRow.Cells[0].Text == "CLIENTS")
            {
                gvRow.Cells.Remove(gvRow.Cells[0]);
                
                GridViewRow gvHeader = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell0 = new TableCell()
                {
                    Text = "CLIENTS",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan = 3,
                    BorderWidth=1
                    
                      
                };

                gvRow.Cells.Remove(gvRow.Cells[0]);
              
              //  GridViewRow gvHeader7 = new GridViewRow(0,0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell1 = new TableCell()
                {
                   
                    Text = "DATABASE",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan = 3,
                    BorderWidth=1
                  
                    
                };
                
                TableCell headerCell2 = new TableCell()
                {
                    Text = "Data Loads - Job Status",
                    HorizontalAlign = HorizontalAlign.Center,
                    ColumnSpan = 10,
                    BorderWidth = 1
                };
                TableCell headerCell8 = new TableCell()
                {
                    Text = "Other Job Status",
                    HorizontalAlign = HorizontalAlign.Center,
                    ColumnSpan = 3,
                    BorderWidth = 1
                };
                TableCell headerCell9 = new TableCell()
                {
                    Text = "Maintenance Job Status",
                    HorizontalAlign = HorizontalAlign.Center,
                    ColumnSpan = 2,
                    BorderWidth = 1
                };

              //  gvRow.Cells.Remove(gvRow.Cells[0]);
               
              //  GridViewRow gvHeader8 = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell10 = new TableCell()
                {
                    Text = "DAILY LOAD",
                    HorizontalAlign = HorizontalAlign.Center,
                    ColumnSpan=7,
                    BorderWidth = 1,
                    
                };
             //   gvRow.Cells.Remove(gvRow.Cells[0]);
                TableCell headerCell11 = new TableCell()
                {
                    Text = "WEEKLY",
                    HorizontalAlign = HorizontalAlign.Center,
                    ColumnSpan = 3,
                    BorderWidth =1
                };
             
                gvRow.Cells.Remove(gvRow.Cells[11]);
              
                GridViewRow gvHeader1 = new GridViewRow(1, 0, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell3 = new TableCell()
                {
                    Text = "Batch(Dashboard)",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan=2,
                    BorderWidth = 1
                };
                gvRow.Cells.Remove(gvRow.Cells[11]);
          //      GridViewRow gvHeader2 = new GridViewRow(0, 11, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell4 = new TableCell()
                {
                    Text = "Offer Engine",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan = 2,
                    BorderWidth = 1
                    
                };
                gvRow.Cells.Remove(gvRow.Cells[11]);
             //   GridViewRow gvHeader3 = new GridViewRow(0, 11, DataControlRowType.Header, DataControlRowState.Insert);
                TableCell headerCell5 = new TableCell()
                {
                    Text = "Segmentation*",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan =2,
                    BorderWidth = 1
                };
                gvRow.Cells.Remove(gvRow.Cells[11]);
              //  GridViewRow gvHeader4 = new GridViewRow(0, 11, DataControlRowType.Header, DataControlRowState.Insert);            
                TableCell headerCell6 = new TableCell()
                {
                    
               
                    Text = "BACKUP",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan = 2,
                    BorderWidth = 1
                };
                gvRow.Cells.Remove(gvRow.Cells[10]);
               
             //   GridViewRow gvHeader5 = new GridViewRow(0, 10, DataControlRowType.Header, DataControlRowState.Insert);      
                TableCell headerCell7 = new TableCell()
                {
                    Text = "RECLAIM",
                    HorizontalAlign = HorizontalAlign.Center,
                    RowSpan = 2,
                    BorderWidth = 1
                    
                };
                for (int i = 0; i < 10;i++ )
                {
                    gvRow.Cells[i].BorderWidth = 1;
                    gvRow.Cells[i].Style["font-size"] = "11pt";
                }
                    gvHeader.Font.Bold = true;
                gvHeader1.Font.Bold = true;
                gvHeader1.Style["font-size"] = "11pt";
                gvHeader.Style["font-size"] = "11pt";
                gvHeader.Cells.Add(headerCell0);
                gvHeader.Cells.Add(headerCell1);
                gvHeader.Cells.Add(headerCell2);
                gvHeader.Cells.Add(headerCell8);
                gvHeader.Cells.Add(headerCell9);
                gvHeader1.Cells.Add(headerCell10);
                gvHeader1.Cells.Add(headerCell11);
                gvHeader1.Cells.Add(headerCell3);
                gvHeader1.Cells.Add(headerCell4);
                gvHeader1.Cells.Add(headerCell5);
                gvHeader1.Cells.Add(headerCell6);
                gvHeader1.Cells.Add(headerCell7);
              
               
                gv_LoadStatus.Controls[0].Controls.AddAt(0, gvHeader);
                gv_LoadStatus.Controls[0].Controls.AddAt(1, gvHeader1);
          //      gv_LoadStatus.Controls[0].Controls.AddAt(1, gvHeader8);
              
            }
           
        }
        else if (e.Row.RowType == DataControlRowType.DataRow)
        {
            for (int i = 0; i < 17; i++) {
               
                e.Row.Cells[i].BorderWidth = 1;
                e.Row.Cells[i].Width = 100;
                e.Row.Cells[i].Height = 50;
                e.Row.Cells[i].Style["font-size"] = "10pt";
                
             
            }
            if ((DataBinder.Eval(e.Row.DataItem, "MON")) is DBNull)
            {
                e.Row.Cells[2].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "MON"))).StartsWith("Completed"))
            {
                e.Row.Cells[2].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "MON"))).StartsWith("Pending"))
            {
                e.Row.Cells[2].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "MON")) == "NA")
            {
                e.Row.Cells[2].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "TUE")) is DBNull)
            {
                e.Row.Cells[3].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "TUE"))).StartsWith("Completed"))
            {
                e.Row.Cells[3].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "TUE"))).StartsWith("Pending"))
            {
                e.Row.Cells[3].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "TUE")) == "NA")
            {
                e.Row.Cells[3].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }

            if ((DataBinder.Eval(e.Row.DataItem, "WED")) is DBNull)
            {
                e.Row.Cells[4].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "WED"))).StartsWith("Completed"))
            {
                e.Row.Cells[4].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "WED"))).StartsWith("Pending"))
            {
                e.Row.Cells[4].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "WED")) == "NA")
            {
                e.Row.Cells[4].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "THU")) is DBNull)
            {
                e.Row.Cells[5].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "THU"))).StartsWith("Completed"))
            {
                e.Row.Cells[5].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "THU"))).StartsWith("Pending"))
            {
                e.Row.Cells[5].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "THU")) == "NA")
            {
                e.Row.Cells[5].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }

            if ((DataBinder.Eval(e.Row.DataItem, "FRI")) is DBNull)
            {
                e.Row.Cells[6].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "FRI"))).StartsWith("Completed"))
            {
                e.Row.Cells[6].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "FRI"))).StartsWith("Pending"))
            {
                e.Row.Cells[6].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "FRI")) == "NA")
            {
                e.Row.Cells[6].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "SAT")) is DBNull)
            {
                e.Row.Cells[7].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SAT"))).StartsWith("Completed"))
            {
                e.Row.Cells[7].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SAT"))).StartsWith("Pending"))
            {
                e.Row.Cells[7].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "SAT")) == "NA")
            {
                e.Row.Cells[7].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "SUN")) is DBNull)
            {
                e.Row.Cells[8].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SUN"))).StartsWith("Completed"))
            {
                e.Row.Cells[8].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SUN"))).StartsWith("Pending"))
            {
                e.Row.Cells[8].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "SUN")) == "NA")
            {
                e.Row.Cells[8].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "weekly-MON")) is DBNull)
            {
                e.Row.Cells[9].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-MON"))).StartsWith("Completed on"))
            {
                e.Row.Cells[9].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-MON"))).StartsWith("Pending"))
            {
                e.Row.Cells[9].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "weekly-MON")) == "NA")
            {
                e.Row.Cells[9].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "weekly-TUE")) is DBNull)
            {
                e.Row.Cells[10].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-TUE"))).StartsWith("Completed on"))
            {
                e.Row.Cells[10].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-TUE"))).StartsWith("Pending"))
            {
                e.Row.Cells[10].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "weekly-TUE")) == "NA")
            {
                e.Row.Cells[10].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            //if ((DataBinder.Eval(e.Row.DataItem, "weekly-THU")) is DBNull)
            //{
            //    e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            //}
            //else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-THU"))).StartsWith("Completed on"))
            //{
            //    e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#54C571");
            //}
            //else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-THU"))).StartsWith("Pending"))
            //{
            //    e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#FFC68D");
            //}
            //else if ((string)(DataBinder.Eval(e.Row.DataItem, "weekly-THU")) == "NA")
            //{
            //    e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            //}
            if ((DataBinder.Eval(e.Row.DataItem, "weekly-SUN")) is DBNull)
            {
                e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-SUN"))).StartsWith("Completed on"))
            {
                e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "weekly-SUN"))).StartsWith("Pending"))
            {
                e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "weekly-SUN")) == "NA")
            {
                e.Row.Cells[11].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "BACKUP")) is DBNull)
            {
                e.Row.Cells[15].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "BACKUP"))).StartsWith("Completed on"))
            {
                e.Row.Cells[15].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "BACKUP"))).StartsWith("Pending"))
            {
                e.Row.Cells[15].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "BACKUP")) == "NA")
            {
                e.Row.Cells[15].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "RECLAIM")) is DBNull)
            {
                e.Row.Cells[16].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "RECLAIM"))).StartsWith("Completed on"))
            {
                e.Row.Cells[16].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "RECLAIM"))).StartsWith("Pending"))
            {
                e.Row.Cells[16].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "RECLAIM")) == "NA")
            {
                e.Row.Cells[16].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "OFFER ENGINE")) is DBNull)
            {
                e.Row.Cells[13].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "OFFER ENGINE"))).StartsWith("Completed on"))
            {
                e.Row.Cells[13].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "OFFER ENGINE"))).StartsWith("Pending"))
            {
                e.Row.Cells[13].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "OFFER ENGINE")) == "NA")
            {
                e.Row.Cells[13].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "DASHBOARD")) is DBNull)
            {
                e.Row.Cells[12].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "DASHBOARD"))).StartsWith("Completed on"))
            {
                e.Row.Cells[12].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "DASHBOARD"))).StartsWith("Pending"))
            {
                e.Row.Cells[12].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "DASHBOARD")) == "NA")
            {
                e.Row.Cells[12].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            if ((DataBinder.Eval(e.Row.DataItem, "SEGMENTATION")) is DBNull)
            {
                e.Row.Cells[14].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SEGMENTATION"))).StartsWith("Completed on"))
            {
                e.Row.Cells[14].BackColor = System.Drawing.Color.FromName("#54C571");
            }
            else if (((string)(DataBinder.Eval(e.Row.DataItem, "SEGMENTATION"))).StartsWith("Pending"))
            {
                e.Row.Cells[14].BackColor = System.Drawing.Color.FromName("#FFC68D");
            }
            else if ((string)(DataBinder.Eval(e.Row.DataItem, "SEGMENTATION")) == "NA")
            {
                e.Row.Cells[14].BackColor = System.Drawing.Color.FromName("#BCC6CC");
            }
        }
    }
    protected void gv_LoadStatus_Init(object sender, EventArgs e)
    {
        Response.CacheControl = "no-cache";
    }
  
}
