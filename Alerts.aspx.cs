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


public partial class Alerts : System.Web.UI.Page
{
    System.Data.DataTable dt = new System.Data.DataTable();
    System.Data.DataTable dt1 = new System.Data.DataTable();
    System.Data.DataTable dtcl = new System.Data.DataTable();
    System.Data.DataTable dtc2 = new System.Data.DataTable();
    System.Data.DataTable dtCSV = new System.Data.DataTable();
    System.Data.DataTable dtCSV1 = new System.Data.DataTable();
    int flag = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
      //GridView2.Visible = false;
      // GridView1.Visible = false;
        loadalertsswap();
        loadalertsheap();
        loadalertsothers();
        loadalertsDWHdisk();
        loadalertsDWHRAM();
        loadalertsDWHothers();

        //ReadExcel();
        ReadCSV();
        ReadCSV1();



    }




    public void ReadCSV()
    {

        string filelocation = ConfigurationManager.AppSettings["DWHEXCELFILEPATH"];
        System.Data.DataTable dtAlertByClient = new System.Data.DataTable();

        dtAlertByClient.Columns.Add("Header", typeof(string));
        //Coles Decom change
        //dtAlertByClient.Columns.Add("COLES01", typeof(string));
        //dtAlertByClient.Columns.Add("COLES02", typeof(string));
        dtAlertByClient.Columns.Add("CVS01", typeof(string));
        dtAlertByClient.Columns.Add("CVS02", typeof(string));
        dtAlertByClient.Columns.Add("MIGROS01", typeof(string));
        dtAlertByClient.Columns.Add("MADISON01", typeof(string));
        dtAlertByClient.Columns.Add("SOBEYS01", typeof(string));
        dtAlertByClient.Columns.Add("SPARTAN01", typeof(string));
        dtAlertByClient.Columns.Add("SAINS_SS", typeof(string));
        dtAlertByClient.Columns.Add("SSL03", typeof(string));
        dtAlertByClient.Columns.Add("SSL04", typeof(string));
        dtAlertByClient.Columns.Add("SONAE01", typeof(string));
        dtAlertByClient.Columns.Add("AEON01", typeof(string));

        //create the Application object we can use in the member functions.
        Microsoft.Office.Interop.Excel.Application _excelApp = new Microsoft.Office.Interop.Excel.Application();
        _excelApp.Visible = false;

        string month = System.DateTime.Now.ToString("MMM");
        string fileName = filelocation+"\\Alert_Tracker_" + month + ".xls";

        //open the workbook
        Workbook workbook;
        workbook = _excelApp.Workbooks.Open(fileName,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

        //select the first sheet        
        Worksheet worksheet = (Worksheet)workbook.Worksheets["Resume"];

        //find the used range in worksheet
        Range excelRange = worksheet.UsedRange;

        //get an object array of all of the cells in the worksheet (their values)
        object[,] valueArray = (object[,])excelRange.get_Value(
                    XlRangeValueDataType.xlRangeValueDefault);

        //access the cells
        DateTime cur_date = System.DateTime.Now.Date;
        int coltoget = 0;
        string clientName = "";
        int datarow = 0;
        bool isDaterowMatched = false;

        int[,] AlertCounts = new int[18, 2];



        for (int row = 1; row <= worksheet.UsedRange.Rows.Count; ++row)
        {
            for (int col = 1; col <= worksheet.UsedRange.Columns.Count; ++col)
            {
                //access each cell
            
                if (valueArray[row, col] != null)
                {
                    if (cur_date.ToString() == valueArray[row, col].ToString())
                    {
                        coltoget = col;
                        datarow = row;
                        isDaterowMatched = true;
                    }

                    if (row > datarow && isDaterowMatched)
                    {
                        clientName = valueArray[row, col].ToString();
                        switch (clientName)
                        {
                            //case "COLES01":
                            //    AlertCounts[0, 0] = int.Parse(valueArray[row, coltoget].ToString());
                            //    AlertCounts[0, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                            //    break;
                            //case "COLES02":
                            //    AlertCounts[1, 0] = int.Parse(valueArray[row, coltoget].ToString());
                            //    AlertCounts[1, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                            //    break;

                            case "CVS01":
                                AlertCounts[0, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[0, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "CVS02":
                                AlertCounts[1, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[1, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "MIGROS01":
                                AlertCounts[2, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[2, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;

                            case "MADISON01":
                                AlertCounts[3, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[3, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                      
                            case "SOBEYS01":
                                AlertCounts[4, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[4, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                     
                            case "SPARTAN01":
                                AlertCounts[5, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[5, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                       
                            case "SAINS_SS":
                                AlertCounts[6, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[6, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "SSL03":
                                AlertCounts[7, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[7, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "SSL04":
                                AlertCounts[8, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[8, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                        
                            case "SONAE01":
                                AlertCounts[9, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[9, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "AEON01":
                                AlertCounts[10, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[10, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;


                        }
                        break;
                    }

                }
            }
        }


        //1ST ROW

        DataRow drnew = dtAlertByClient.NewRow();
        drnew["Header"] = "Total Alerts";
        drnew["CVS01"] = AlertCounts[0, 0];
        drnew["CVS02"] = AlertCounts[1, 0];
        drnew["MIGROS01"] = AlertCounts[2, 0];
        drnew["MADISON01"] = AlertCounts[3, 0];
        drnew["SOBEYS01"] = AlertCounts[4, 0];
        drnew["SPARTAN01"] = AlertCounts[5, 0];
        drnew["SAINS_SS"] = AlertCounts[6, 0];
        drnew["SSL03"] = AlertCounts[7, 0];
        drnew["SSL04"] = AlertCounts[8, 0];
        drnew["SONAE01"] = AlertCounts[9, 0];
        drnew["AEON01"] = AlertCounts[10, 0];
       // drnew["SONAE01"] = AlertCounts[11, 0];
        dtAlertByClient.Rows.Add(drnew);


        //2ND ROW


        DataRow drnew1 = dtAlertByClient.NewRow();
        drnew1["Header"] = "Action Needed";
        drnew1["CVS01"] = AlertCounts[0, 1];
        drnew1["CVS02"] = AlertCounts[1, 1];
        drnew1["MIGROS01"] = AlertCounts[2, 1];
        drnew1["MADISON01"] = AlertCounts[3, 1];
        drnew1["SOBEYS01"] = AlertCounts[4, 1];
        drnew1["SPARTAN01"] = AlertCounts[5, 1];
        drnew1["SAINS_SS"] = AlertCounts[6, 1];
        drnew1["SSL03"] = AlertCounts[7, 1];
        drnew1["SSL04"] = AlertCounts[8, 1];
        drnew1["SONAE01"] = AlertCounts[9, 1];
        drnew1["AEON01"] = AlertCounts[10, 1];
       // drnew1["SONAE01"] = AlertCounts[11, 1];
        dtAlertByClient.Rows.Add(drnew1);



        GridView1.DataSource = dtAlertByClient;
        GridView1.DataBind();

        //clean up stuffs
        workbook.Close(false, Type.Missing, Type.Missing);
        _excelApp.Workbooks.Close();
        Marshal.ReleaseComObject(excelRange);
        Marshal.ReleaseComObject(worksheet);
        Marshal.ReleaseComObject(workbook);
        _excelApp.Application.Quit();
        _excelApp.Quit();
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




    //IMPLEMENTING FROM 2ND ROW

    public void ReadCSV1()
    {

        string filelocation = ConfigurationManager.AppSettings["DWHEXCELFILEPATH"];
        System.Data.DataTable dtAlertByClient1 = new System.Data.DataTable();

        dtAlertByClient1.Columns.Add("Header", typeof(string));
        dtAlertByClient1.Columns.Add("AEONT1", typeof(string));
        dtAlertByClient1.Columns.Add("MIGROST1", typeof(string));
        dtAlertByClient1.Columns.Add("MADISONT1", typeof(string));
        dtAlertByClient1.Columns.Add("SOBEYST1", typeof(string));
        dtAlertByClient1.Columns.Add("SPARTANT1", typeof(string));
        dtAlertByClient1.Columns.Add("SSLT1", typeof(string));

        //create the Application object we can use in the member functions.
        Microsoft.Office.Interop.Excel.Application _excelApp = new Microsoft.Office.Interop.Excel.Application();
        _excelApp.Visible = false;
        string month = System.DateTime.Now.ToString("MMM");
        string fileName = filelocation+"\\Alert_Tracker_" + month + ".xls";

        //open the workbook
        Workbook workbook;
        workbook = _excelApp.Workbooks.Open(fileName,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

        //select the first sheet        
        Worksheet worksheet = (Worksheet)workbook.Worksheets["Resume"];

        //find the used range in worksheet
        Range excelRange = worksheet.UsedRange;

        //get an object array of all of the cells in the worksheet (their values)
        object[,] valueArray = (object[,])excelRange.get_Value(
                    XlRangeValueDataType.xlRangeValueDefault);

        //access the cells
        DateTime cur_date = System.DateTime.Now.Date;
        int coltoget = 0;
        string clientName = "";
        int datarow = 0;
        bool isDaterowMatched = false;

        int[,] AlertCounts = new int[18, 2];



        for (int row = 1; row <= worksheet.UsedRange.Rows.Count; ++row)
        {
            for (int col = 1; col <= worksheet.UsedRange.Columns.Count; ++col)
            {
                //access each cell
                //Debug.Print(valueArray[row, col].ToString());
                if (valueArray[row, col] != null)
                {
                    if (cur_date.ToString() == valueArray[row, col].ToString())
                    {
                        coltoget = col;
                        datarow = row;
                        isDaterowMatched = true;
                    }

                    if (row > datarow && isDaterowMatched)
                    {
                        clientName = valueArray[row, col].ToString();
                        switch (clientName)
                        {
                            case "AEONT1":
                                AlertCounts[0, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[0, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "MIGROST1":
                                AlertCounts[1, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[1, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "MADISONT1":
                                AlertCounts[2, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[2, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "SOBEYST1":
                                AlertCounts[3, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[3, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "SPARTANT1":
                                AlertCounts[4, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[4, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;
                            case "SSLT1":
                                AlertCounts[5, 0] = int.Parse(valueArray[row, coltoget].ToString());
                                AlertCounts[5, 1] = int.Parse(valueArray[row, coltoget + 1].ToString());
                                break;


                        }
                        break;
                    }

                }
            }
        }

       
        //1ST ROW of grid 2

        DataRow drnew2 = dtAlertByClient1.NewRow();
        drnew2["Header"] = "Total Alerts";
        drnew2["AEONT1"] = AlertCounts[0, 0];
        drnew2["MIGROST1"] = AlertCounts[1, 0];
        drnew2["MADISONT1"] = AlertCounts[2, 0];
        drnew2["SOBEYST1"] = AlertCounts[3, 0];
        drnew2["SPARTANT1"] = AlertCounts[4, 0];
        drnew2["SSLT1"] = AlertCounts[5, 0];
        dtAlertByClient1.Rows.Add(drnew2);

        //2ND ROW

        DataRow drnew3 = dtAlertByClient1.NewRow();
        drnew3["Header"] = "Action Needed";
        drnew3["AEONT1"] = AlertCounts[0, 1];
        drnew3["MIGROST1"] = AlertCounts[1, 1];
        drnew3["MADISONT1"] = AlertCounts[2, 1];
        drnew3["SOBEYST1"] = AlertCounts[3, 1];
        drnew3["SPARTANT1"] = AlertCounts[4, 1];
        drnew3["SSLT1"] = AlertCounts[5, 1];
        dtAlertByClient1.Rows.Add(drnew3);

        GridView2.DataSource = dtAlertByClient1;
        GridView2.DataBind();

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


    //public void ReadExcel()
    //{
    //    //Get the Folder Path
    //    string filelocation = ConfigurationManager.AppSettings["DWHEXCELFILEPATH"];
    //    string[] newfilepath = Directory.GetFiles(filelocation);


    //    DataRow dr = dtcl.NewRow();


    //    if (newfilepath != null)
    //    {
    //        for (int i = 0; i < newfilepath.Length; i++)
    //        {
    //            flag = 1;
    //            dt = ReadCSV(newfilepath[i], flag);
    //            dt1 = ReadCSV1(newfilepath[i], flag);

    //        }
    //    }

    //}
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        Response.Redirect("Alerts.aspx");
    }
    protected void gv_Summary_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    public int Alert(string filepath, string AlertType)
    {
        double Timediff = double.Parse(ConfigurationManager.AppSettings["TimeDifference"]);

        int count = 0;

        string Newfilepath = filepath + AlertType;
        

        string[] filePaths = Directory.GetFiles(Newfilepath);
       
        DirectoryInfo di = new DirectoryInfo(Newfilepath);
        FileInfo[] files = di.GetFiles();
        for (int i = 0; i < files.Length; i++)
        {
            String filename = files[i].Name.ToString();
          
           

            string path = filepath;
            string path1 = filepath;
            string path2 = filepath;
            if(filename.Contains("CRITICAL")){
            String replacedfilename = filename.Replace("CRITICAL", "WARNING");
               path = filepath + "Warning\\" + replacedfilename;
               String replacedfilename1 = filename.Replace("CRITICAL", "OK");
               String replacedfilename2 = replacedfilename1.Replace("PROBLEM", "RECOVERY");
               path1 = filepath + "OK\\" + replacedfilename2;
            }
            else if(filename.Contains("DOWN")){
            String replacedfilename = filename.Replace("DOWN", "WARNING");
            path = filepath + "Warning\\" + replacedfilename;
            String replacedfilename1 = filename.Replace("DOWN", "OK");
            String replacedfilename2 = replacedfilename1.Replace("PROBLEM", "RECOVERY");
            path1 = filepath + "OK\\" + replacedfilename2;
            }
            else if (filename.Contains("WARNING"))
            {
               
                String replacedfilename1 = filename.Replace("WARNING", "OK");
                String replacedfilename2 = replacedfilename1.Replace("PROBLEM", "RECOVERY");
                path1 = filepath + "OK\\" + replacedfilename2;

            }
            if (filename.Contains("WARNING")) { path2 = filepath + "WARNING\\" + filename; }
            else if ((filename.Contains("CRITICAL")))
            { path2 = filepath + "CRITICAL\\" + filename; }
            FileInfo file = new FileInfo(path);
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path2);
            if (file.Exists)//check file exsit or not
            {
                file.Delete();
             
            }
            if (file1.Exists)//check file exsit or not
            {
                file1.Delete();
                if (file2.Exists) { 
                file2.Delete();
                count = count - 1;
                }
                else if (file.Exists)//check file exsit or not
                {
                    file.Delete();

                }
            }
          
            String date = files[i].CreationTime.ToString();
         
            DateTime currentdate = DateTime.Now;
            DateTime dt1 = currentdate.AddHours(Timediff);
            DateTime date1 = files[i].CreationTime;
            if (date1 >= dt1)
            {

                count = count + 1;
            }
        }

        return count;
    }


    private void loadalertsswap()
    {
        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();

        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["SWAP"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";
       
        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);
       
        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;
       
        dtc2.Rows.Add(drnew);

        GridviewSwap.DataSource = dtc2;
        GridviewSwap.DataBind();

    }

    private void loadalertsheap()
    {

        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["HEAP"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";

        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);

        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;

        dtc2.Rows.Add(drnew);

        GridviewHeap.DataSource = dtc2;
        GridviewHeap.DataBind();
    }

    private void loadalertsothers()
    {
        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();

        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["OthersAPP"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";

        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);

        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;

        dtc2.Rows.Add(drnew);

        GridviewOthers.DataSource = dtc2;
        GridviewOthers.DataBind();
    }


    private void loadalertsDWHdisk()
    {

        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();

        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["DiskSpaceUsage"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";

        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);

        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;

        dtc2.Rows.Add(drnew);

        GridviewDisk.DataSource = dtc2;
        GridviewDisk.DataBind();
    }

    private void loadalertsDWHRAM()
    {

        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();

        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["RAMUsage"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";

        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);

        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;

        dtc2.Rows.Add(drnew);

        GridviewRAM.DataSource = dtc2;
        GridviewRAM.DataBind();
    }


    private void loadalertsDWHothers()
    {

        System.Data.DataTable dtc2 = new System.Data.DataTable();
        string filepath;
        int CriticalCount = 0;
        int WarningCount = 0;

        System.Data.DataTable dt = new System.Data.DataTable();

        //Get the Folder Path
        filepath = ConfigurationManager.AppSettings["OthersDWH"];

        dtc2.Columns.Add("Critical", typeof(string));
        dtc2.Columns.Add("Warning", typeof(string));

        string CriticalAlert = "Critical";
        string WarningAlert = "Warning";

        CriticalCount = Alert(filepath, CriticalAlert);
        WarningCount = Alert(filepath, WarningAlert);

        DataRow drnew = dtc2.NewRow();
        drnew["Critical"] = CriticalCount;
        drnew["Warning"] = WarningCount;

        dtc2.Rows.Add(drnew);

        Gridviewdwhothers.DataSource = dtc2;
        Gridviewdwhothers.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
 
    }

    protected void GridviewSwap_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

    protected void GridviewHeap_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

    protected void GridviewOthers_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

    protected void GridviewDisk_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

    protected void GridviewRAM_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

    protected void Gridviewdwhothers_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.DataItem != null)
        {

            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) <= 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#0060ff");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Critical").ToString())) > 0)
            {
                e.Row.Cells[0].BackColor = System.Drawing.Color.FromName("#992500");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) <= 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
            if (int.Parse((DataBinder.Eval(e.Row.DataItem, "Warning").ToString())) > 0)
            {
                e.Row.Cells[1].BackColor = System.Drawing.Color.FromName("Green");
            }
        }

    }

}
