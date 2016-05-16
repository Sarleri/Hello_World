using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using Microsoft.Office.Interop.Outlook;
using System.IO;
using System.Configuration;

using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;

public partial class Childwindow : System.Web.UI.Page
{

      string filepath = "";
      string filepath2 = "";
       // string conStr = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        string AlerType = ""; 
        string sho = "";
        string cw = "";
        string dro = "";
        
        DataTable AIMIAalert = new DataTable();
        AlerType = Request.QueryString["Alerttype"];
        sho=Request.QueryString["SHO"];
        cw = Request.QueryString["CW"];
        dro = Request.QueryString["DRO"];
        

        if (AlerType != null)
        {
            AIMIAalert = SelectedAlertGridView(AlerType,sho,cw,dro);


             if (AIMIAalert.Rows.Count != 0)
            {

                //lblalertHeading.Text = AlerType;
                DataView dv = new DataView(AIMIAalert);
                //dv.Sort = "Date Desc";
                //if ((AlerType == "Critical"))
                //{
                    gv_alert.DataSource = dv;
                    gv_alert.DataBind();
                //}
            
        
             //else ((AlerType1 == "APP"))
             //  {
             //      gv_alert.DataSource = dv;
             //      gv_alert.DataBind();
             //  }

             //   else((AlerType2 == "Critical"))
             //   {

             //      gv_alert.DataSource = dv;
             //      gv_alert.DataBind();
             //   }

             //     else((AlerType3 == "Warning"))
             //   {
             //      gv_alert.DataSource = dv;
             //      gv_alert.DataBind();
             //   }

             //     else((AlerType2 == "Others"))
             //   {
             //         gv_alert.DataSource = dv;
             //      gv_alert.DataBind();
             //   }
             }
        }
            
        //}
            //else
            //{
            //    lblAlert.Text = "Alert is not available for" + " " + AlerType;

            //    Page.Controls.Add(lblAlert);
            //}

        }


      public DataTable SelectedAlertGridView(string AlertType, string sho, string cw,string dro)
        {
            //conStr = ConfigurationManager.ConnectionStrings["XLSXConString"].ConnectionString;

            //Get the Folder Path
            double Timediff = double.Parse(ConfigurationManager.AppSettings["TimeDifference"]);
            filepath = ConfigurationManager.AppSettings[sho];
            filepath2 = ConfigurationManager.AppSettings[dro];
          
            DataTable tblFiltered = new DataTable();
            DataTable AIMIAalert = new DataTable();

            AIMIAalert.Columns.Add("Alert", typeof(string));
            AIMIAalert.Columns.Add("Date", typeof(DateTime));
            AIMIAalert.Columns.Add("AlertType", typeof(string));

            string selectedfilepath = filepath + filepath2+ cw;
          
            char[] delimiterChars = { '.' };
            DirectoryInfo di = new DirectoryInfo(selectedfilepath);
            FileInfo[] files = di.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {

                String date = files[i].LastWriteTime.ToString();
                DateTime currentdate = DateTime.Now;
                DateTime dt1 = currentdate.AddHours(Timediff);
                DateTime date1 = files[i].CreationTime;
                if (date1 >= dt1)
                {

                    String filename = files[i].Name.ToString();
                    DataRow dr = AIMIAalert.NewRow();
                   // string[] alerttype = filename.Split(new string[] { ".msg" }, StringSplitOptions.None);
                    int positionOfmsg = filename.IndexOf(".msg");
                    string newString = filename.ToString();  //.Substring(2,positionOfmsg-2);
                    //if (AlertType == "")
                    //{
                        dr["Alert"] = newString;

                        string[] severity = newString.Split(new string[] { "is" }, StringSplitOptions.None);
                        dr["AlertType"] = cw;

                        //foreach (string match in severity)
                        //{
                        //    if (match.Trim() == "CRITICAL")
                        //    {
                        //        dr["AlertType"] = match.Trim();
                        //    }
                        //    //if (match.Trim() == "OK")
                        //    //{
                        //    //    dr["AlertType"] = match.Trim();
                        //    //}
                        //    if (match.Trim() == "WARNING")
                        //    {
                        //        dr["AlertType"] = match.Trim();
                        //    }
                        //    //if (match.Trim() == "DOWN")
                        //    //{
                        //    //    dr["AlertType"] = match.Trim();
                        //    //}
                        //}
                    //}
                    //else if (AlertType == "PUM Offers Response")
                    //{
                    //    char[] space = { ' ' };
                    //    dr["Alert"] = newString;
                    //    string[] alerttypePUM = filename.Split(space);

                    //    if (alerttypePUM[1] == "Critical")
                    //    {
                    //        dr["AlertType"] = alerttypePUM[1];
                    //    }
                    //    if (alerttypePUM[1] == "Ok")
                    //    {
                    //        dr["AlertType"] = alerttypePUM[1];
                    //    }
                    //    if (alerttypePUM[1] == "Warning")
                    //    {
                    //        dr["AlertType"] = alerttypePUM[1];
                    //    }

                    //}

                    //else
                    //{
                    //    dr["Alert"] = newString;
                    //}

                        dr["Date"] = date;


                        AIMIAalert.Rows.Add(dr);


                }
            }

            return AIMIAalert;

        }
   
    }
