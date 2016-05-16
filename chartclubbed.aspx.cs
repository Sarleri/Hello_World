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

public partial class chartclubbed : System.Web.UI.Page
{
    string dropvalue = "";
    string value = "";
    public void Page_Load(object sender, EventArgs e)
    {
        Chart1.Legends.Add(new Legend("Legend2"));
        Chart1.Legends["Legend2"].Docking = Docking.Right;

        getcharts();
    }
    public void getcharts()
    {
        
        if (dropvalue == "" && value=="") {
            dropvalue = "F2";
            value = "R";
        }
        Chart1.Titles["Report"].Text = DropDownList1.Text;
        DataSet dataset = CsvToDataTable();
        DataSet dataset1 = CsvToDataTable1();
        DataSet dataset2 = CsvToDataTable2();
        for (int i = 0; i < 9; i++)
        {
            Chart1.Series["Series" + i].ChartType = SeriesChartType.Line;
            Chart1.Series["Series" + i].BorderWidth = 3;
            Chart1.Series["Series" + i].IsValueShownAsLabel = false;
            Chart1.Series["Series" + i]["DrawingStyle"] = "Emboss";
            Chart1.Series["Series" + i].LegendText = dataset.Tables[i].TableName;
            Chart1.Series["Series" + i].IsVisibleInLegend = true;
            if (value == "R")
            {
                Chart1.Series["Series" + i].Points.DataBindXY(dataset.Tables[i].DefaultView, "NoName", dataset.Tables[i].DefaultView, dropvalue);
            }
            else if (value == "S")
            {
                Chart1.Series["Series" + i].Points.DataBindXY(dataset1.Tables[i].DefaultView, "NoName", dataset1.Tables[i].DefaultView, dropvalue);
            }
            else if (value == "F")
            {
                Chart1.Series["Series" + i].Points.DataBindXY(dataset2.Tables[i].DefaultView, "NoName", dataset2.Tables[i].DefaultView, dropvalue);
            }
        }
    }
    static DataSet CsvToDataTable()
    {

        string[] file = new string[9] { "sainscfg.csv", "madisoncfg.csv", "migroscfg.csv", "colescfg.csv", "cvscfg.csv", "spartancfg.csv", "sobeyscfg.csv", "icacfg.csv", "sonaecfg.csv" };

        string dir = "C:\\ISSCC\\ISS\\charts";
            DataSet set = new DataSet("clients");
            DataTable sains = new DataTable("sains");
            DataTable madison = new DataTable("madison");
            DataTable migros = new DataTable("migros");
            DataTable coles = new DataTable("coles");
            DataTable cvs = new DataTable("cvs");
            DataTable spartan = new DataTable("spartan");
            DataTable sobeys = new DataTable("sobeys");
            DataTable ica = new DataTable("ica");
            DataTable sonae = new DataTable("sonae");
            set.Tables.Add(sains);
            set.Tables.Add(madison);
            set.Tables.Add(migros);
            set.Tables.Add(coles);
            set.Tables.Add(cvs);
            set.Tables.Add(spartan);
            set.Tables.Add(sobeys);
            set.Tables.Add(ica);
            set.Tables.Add(sonae);
        for(int i=0;i<8;i++)
        {       using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
        {
            conn.Open();
            string strQuery = "SELECT * FROM [" + file[i] + "]";
            OleDbDataAdapter adapter =
                new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            adapter.Fill(set.Tables[i]);
            conn.Close();
            set.Tables[i].Rows[1].Delete();
            set.Tables[i].Rows[0].Delete();
            set.Tables[i].AcceptChanges();
        }
        }

        return set;
    }
    static DataSet CsvToDataTable1()
    {

        string[] file1 = new string[9] { "sainsScheduledcfg.csv", "madisonScheduledcfg.csv", "migrosScheduledcfg.csv", "colesScheduledcfg.csv", "cvsScheduledcfg.csv", "spartanScheduledcfg.csv", "sobeysScheduledcfg.csv", "icaScheduledcfg.csv", "sonaeScheduledcfg.csv" };


        string dir1 = "C:\\ISSCC\\ISS\\charts";
        DataSet set1 = new DataSet("clients");
        DataTable sains = new DataTable("sains");
        DataTable madison = new DataTable("madison");
        DataTable migros = new DataTable("migros");
        DataTable coles = new DataTable("coles");
        DataTable cvs = new DataTable("cvs");
        DataTable spartan = new DataTable("spartan");
        DataTable sobeys = new DataTable("sobeys");
        DataTable ica = new DataTable("ica");
        DataTable sonae = new DataTable("sonae");
        set1.Tables.Add(sains);
        set1.Tables.Add(madison);
        set1.Tables.Add(migros);
        set1.Tables.Add(coles);
        set1.Tables.Add(cvs);
        set1.Tables.Add(spartan);
        set1.Tables.Add(sobeys);
        set1.Tables.Add(ica);
        set1.Tables.Add(sonae);
        for (int i = 0; i < 8; i++)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir1 + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
            {
                conn.Open();
                string strQuery = "SELECT * FROM [" + file1[i] + "]";
                OleDbDataAdapter adapter =
                    new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
                adapter.Fill(set1.Tables[i]);
                conn.Close();
                set1.Tables[i].Rows[1].Delete();
                set1.Tables[i].Rows[0].Delete();
                set1.Tables[i].AcceptChanges();
            }
        }

        return set1;
    }
    static DataSet CsvToDataTable2()
    {

        string[] file = new string[9] { "sainsFailedcfg.csv", "madisonFailedcfg.csv", "migrosFailedcfg.csv", "colesFailedcfg.csv", "cvsFailedcfg.csv", "spartanFailedcfg.csv", "sobeysFailedcfg.csv", "icaFailedcfg.csv", "sonaeFailedcfg.csv" };


        string dir = "C:\\ISSCC\\ISS\\charts";
        DataSet set2 = new DataSet("clients");
        DataTable sains = new DataTable("sains");
        DataTable madison = new DataTable("madison");
        DataTable migros = new DataTable("migros");
        DataTable coles = new DataTable("coles");
        DataTable cvs = new DataTable("cvs");
        DataTable spartan = new DataTable("spartan");
        DataTable sobeys = new DataTable("sobeys");
        DataTable ica = new DataTable("ica");
        DataTable sonae = new DataTable("sonae");
        set2.Tables.Add(sains);
        set2.Tables.Add(madison);
        set2.Tables.Add(migros);
        set2.Tables.Add(coles);
        set2.Tables.Add(cvs);
        set2.Tables.Add(spartan);
        set2.Tables.Add(sobeys);
        set2.Tables.Add(ica);
        set2.Tables.Add(sonae);
        for (int i = 0; i < 8; i++)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
            {
                conn.Open();
                string strQuery = "SELECT * FROM [" + file[i] + "]";
                OleDbDataAdapter adapter =
                    new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
                adapter.Fill(set2.Tables[i]);
                conn.Close();
                set2.Tables[i].Rows[1].Delete();
                set2.Tables[i].Rows[0].Delete();
                set2.Tables[i].AcceptChanges();
            }
        }

        return set2;
    }
    protected void ddmanu_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        if (DropDownList1.Text == "Number of Reports")
        {
            dropvalue = "F2";
            value = "R";
        }
        else if (DropDownList1.Text == "DB_Runtime")
        {
            dropvalue = "F3";
            value = "R";
        }
        else if (DropDownList1.Text == "APP_Run_Time")
        {
            dropvalue = "F4";
            value = "R";
        }
        else if (DropDownList1.Text == "ScheduledReport")
        {
            dropvalue = "F2";
            value = "S";
        }
        else if (DropDownList1.Text == "FailedReport")
        {
            dropvalue = "F2";
            value = "F";
        }
        getcharts();
    }
   
   
}
       
            
   