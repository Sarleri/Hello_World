using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;
public partial class Test : System.Web.UI.Page
{
    string dir;
    string dir1;
    DataSet dataset;
    DateTime date1;
    DateTime date2;
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.QueryString["id"];
        dir = ConfigurationManager.AppSettings["Ramcharts"];
        Chart1.Legends.Add(new Legend("Legend2"));
        Chart1.Legends["Legend2"].Docking = Docking.Right;
        dataset = CsvToDataTable(Int32.Parse(id));
        
        getcharts();
    }
    public DataSet CsvToDataTable(int id)
    {

        string[] file = new string[12]{ "sains01Ramusage.csv", "ssl03Ramusage.csv", "ssl04Ramusage.csv", 
            "cvs01Ramusage.csv", "cvs02Ramusage.csv", "sobeys01Ramusage.csv", "madison01Ramusage.csv", "spartan01Ramusage.csv", 
            "migros01Ramusage.csv","sonae01Ramusage.csv", "aeon01Ramusage.csv" ,"ica01Ramusage.csv"};
        DataSet set = new DataSet("clients");
        switch (id)
        {
            case 1:
                DataTable sains = new DataTable("SAINS_SS");
                set.Tables.Add(sains);
                break;
            case 2:
                DataTable sslo3 = new DataTable("SSL03");
                set.Tables.Add(sslo3);
                break;
            case 3:
                DataTable sslo4 = new DataTable("SSL04");
                set.Tables.Add(sslo4);
                break;
            case 4:
                DataTable cvs01 = new DataTable("CVS01");
                set.Tables.Add(cvs01);
                break;
            case 5:
                DataTable cvs02 = new DataTable("CVS02");
                set.Tables.Add(cvs02);
                break;
            case 6:
                DataTable sobeys = new DataTable("SOBEYS01");
                set.Tables.Add(sobeys);
                break;
            case 7:
                DataTable madison = new DataTable("MADISON01");
                set.Tables.Add(madison);
                break;
            case 8:
                DataTable spartan = new DataTable("SPARTAN01");
                set.Tables.Add(spartan);
                break;
            case 9:
                DataTable migros = new DataTable("MIGROS01");
                set.Tables.Add(migros);
                break;
            case 10:
                DataTable sonae = new DataTable("SONAE01");
                set.Tables.Add(sonae);
                break;
            case 11:
                DataTable aeon = new DataTable("AEON01");
                set.Tables.Add(aeon);
                break;
            case 12:
                DataTable ica = new DataTable("ICA01");
                set.Tables.Add(ica);
                break;
        }
        int i = 0;
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
        {
            conn.Open();
            string strQuery = "SELECT * FROM [" + file[id - 1] + "]";
            OleDbDataAdapter adapter =
                new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            adapter.Fill(set.Tables[i]);
            conn.Close();
            // set.Tables[i].Rows[1].Delete();
            // set.Tables[i].Rows[0].Delete();
            set.Tables[i].AcceptChanges();
        }

        return set;
    }
    public void getcharts()
    {

        Chart1.Series["Series0"].ChartType = SeriesChartType.Line;
        Chart1.Series["Series0"].XValueType = ChartValueType.DateTime;
        Chart1.Series["Series0"].BorderWidth = 3;
        Chart1.Series["Series0"].IsValueShownAsLabel = false;
        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
        Chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
        Chart1.ChartAreas[0].AxisX.Interval = 1;
        Chart1.ChartAreas[0].AxisX.Title = "Current day's hours";
        Chart1.ChartAreas[0].AxisY.Title = "Used Ram (GB)";
        Chart1.Series["Series0"]["DrawingStyle"] = "Emboss";
        Chart1.Series["Series0"].LegendText = dataset.Tables[0].TableName;
        Chart1.Series["Series0"].IsVisibleInLegend = true;

        Chart1.Series["Series0"].Points.DataBindXY(dataset.Tables[0].DefaultView, "Timestamp", dataset.Tables[0].DefaultView, "Used GB");
        //Chart1.Series["Series1"].Points.AddXY(dataset);
    }

   
    protected void Button1_Click(object sender, EventArgs e)
    {
        label1.Text="";
      
        String id = Request.QueryString["id"];
        int i = Int32.Parse(id);
        dir1 = ConfigurationManager.AppSettings["Ramchartshistory"];

        if (To_Date.Text == string.Empty)
        {
            label1.Text = "To Date cannot be left empty!";
            //Response.Write("<font color=FF3300><span LEFT:16px; POSITION:absolute;BOTTOM:300px> To Date cannot be left empty!</span></font>");
        }
        if (From_Date.Text == string.Empty)
        {
            label1.Text = "From Date cannot be left empty!";
            //Response.Write("<font color=FF3300><span LEFT:16px; POSITION:absolute;BOTTOM:300px> From Date cannot be left empty!</span></font>");
        }
        if (To_Date.Text != string.Empty && From_Date.Text != string.Empty)
        {
            label1.Text = "";
            date1 = DateTime.ParseExact(To_Date.Text, "d/M/yyyy", null);
            date2 = DateTime.ParseExact(From_Date.Text, "d/M/yyyy", null);
            String to_date = DateTime.Parse(To_Date.Text).ToLongTimeString();
            String from_date = DateTime.Parse(From_Date.Text).ToLongTimeString();
        }
        
        string[] file1 = new string[12]{ "sains01Ramusagehistory.csv", "ssl03Ramusagehistory.csv", "ssl04Ramusagehistory.csv", 
            "cvs01Ramusagehistory.csv", "cvs02Ramusagehistory.csv", "sobeys01Ramusagehistory.csv", "madison01Ramusagehistory.csv", "spartan01Ramusagehistory.csv", 
            "migros01Ramusagehistory.csv","sonae01Ramusagehistory.csv", "aeon01Ramusagehistory.csv" ,"ica01Ramusagehistory.csv"};
        DataSet set1 = new DataSet("clients");
        DataSet set2 = new DataSet("Date");
        switch (i)
        {
            case 1:
                DataTable sainsHistory = new DataTable("SAINS_SS_History");
                set1.Tables.Add(sainsHistory);
                break;
            case 2:
                DataTable sslo3History = new DataTable("SSL03_History");
                set1.Tables.Add(sslo3History);
                break;
            case 3:
                DataTable sslo4History = new DataTable("SSL04_History");
                set1.Tables.Add(sslo4History);
                break;
            case 4:
                DataTable cvs01History = new DataTable("CVS01_History");
                set1.Tables.Add(cvs01History);
                break;
            case 5:
                DataTable cvs02History = new DataTable("CVS02_History");
                set1.Tables.Add(cvs02History);
                break;
            case 6:
                DataTable sobeysHistory = new DataTable("SOBEYS01_History");
                set1.Tables.Add(sobeysHistory);
                break;
            case 7:
                DataTable madisonHistory = new DataTable("MADISON01_History");
                set1.Tables.Add(madisonHistory);
                break;
            case 8:
                DataTable spartanHistory = new DataTable("SPARTAN01_History");
                set1.Tables.Add(spartanHistory);
                break;
            case 9:
                DataTable migrosHistory = new DataTable("MIGROS01_History");
                set1.Tables.Add(migrosHistory);
                break;
            case 10:
                DataTable sonaeHistory = new DataTable("SONAE01_History");
                set1.Tables.Add(sonaeHistory);
                break;
            case 11:
                DataTable aeonHistory = new DataTable("AEON01_History");
                set1.Tables.Add(aeonHistory);
                break;
            case 12:
                DataTable icaHistory = new DataTable("ICA01_History");
                set1.Tables.Add(icaHistory);
                break;
        }
        DataTable Da = new DataTable();
        set2.Tables.Add(Da);
       

      
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir1 + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
        {
            conn.Open();
           
            
            string strQuery = "SELECT * FROM [" + file1[i - 1] + "]";
            OleDbDataAdapter adapter =
                new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
           
            adapter.Fill(set1.Tables[0]);
            
            conn.Close();
         
            set1.Tables[0].AcceptChanges();
    
        }
        Session.Clear();
        Chart1.Series["Series0"].ChartType = SeriesChartType.Line;
        Chart1.Series["Series0"].XValueType=ChartValueType.DateTime;
        

        Chart1.ChartAreas[0].AxisX.Maximum=date1.ToOADate();
        Chart1.ChartAreas[0].AxisX.Minimum = date2.ToOADate();
        Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "d/M/yyyy HH:mm";
        Chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
        Chart1.ChartAreas[0].AxisX.Interval = 1;
        Chart1.ChartAreas[0].AxisX.Title = "Date Time";
        Chart1.ChartAreas[0].AxisY.Title = "Used Ram(GB)";
        Chart1.Series["Series0"].BorderWidth = 3;
        Chart1.Series["Series0"].IsValueShownAsLabel = false;
        Chart1.Series["Series0"]["DrawingStyle"] = "Emboss";
        Chart1.Series["Series0"].LegendText = set1.Tables[0].TableName;
        
        Chart1.Series["Series0"].IsVisibleInLegend = true;
        Chart1.Series["Series0"].Points.DataBindXY(set1.Tables[0].DefaultView,"Timestamp",set1.Tables[0].DefaultView,"Used GB");
        
    }
}