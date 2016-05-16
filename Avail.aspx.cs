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
using System.Drawing;


public partial class Default2 : System.Web.UI.Page
{
    DataTable dt1 = new DataTable();
    string filepath = "";
    char[] delimiterChars = { ' ' };

    protected void Page_Load(object sender, EventArgs e)
    {
        AvailabilityStatus();
    }

    private void AvailabilityStatus()
    {
        filepath = ConfigurationManager.AppSettings["Availability"];

        dt1.Columns.Add("AEON", typeof(string));
        dt1.Columns.Add("ICA", typeof(string));
        dt1.Columns.Add("SONAE", typeof(string));
        dt1.Columns.Add("SAINSBURY", typeof(string));
        dt1.Columns.Add("MIGROS", typeof(string));
        //dt1.Columns.Add("LSS", typeof(string));
        dt1.Columns.Add("MADISON", typeof(string));
        dt1.Columns.Add("SPARTAN", typeof(string));
        dt1.Columns.Add("SOBEYS", typeof(string));
        dt1.Columns.Add("CVS", typeof(string));
        //dt1.Columns.Add("COLES", typeof(string));

        string[] subdirEntries = Directory.GetDirectories(filepath);
        DataRow drnew = dt1.NewRow();
        foreach (string subDir in subdirEntries)
        {
            DirectoryInfo di = new DirectoryInfo(subDir);
           if (di.Name.Equals("COLES") || di.Name.Equals("LSS"))
           {
           continue;
           }
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
                        {
                            file.Delete();
                        }
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
                                if (ts1.Days > 1)
                                    {
                                        file.Delete();
                                        break;
                                    }
                                }
                            }   
                            String filename = lastWritenFile.Name.ToString();
                            string[] words = filename.Split(delimiterChars);
                            for (int i = 0; i < (words.Length); i++)
                            {
                                if (words[i].IndexOf("OK") == 0)
                                {
                                    drnew[diname] = "Available";
                                }
                                else if (words[i].IndexOf("Error") == 0 || words[i].IndexOf("CRITICAL") == 0)
                                {
                                    drnew[diname] = "Errors";
                                }
                                else if (words[i].IndexOf("WARNING") == 0)
                                {   
                                    drnew[diname] = "Warning";
                                }
                                else
                                {
                                    if (diname == "MADISON")
                                    {
                                        drnew[diname] = "ETA 9:55AM BST";
                                    }
                                    if (diname == "SPARTAN")
                                    {
                                        drnew[diname] = "ETA 10:55AM BST";
                                    }
                                    if (diname == "SOBEYS")
                                    {
                                        drnew[diname] = "ETA 10:55AM BST";
                                    }
                                    if (diname == "CVS")
                                    {
                                        drnew[diname] = "ETA 11:25AM BST";
                                    }
                                    if (diname == "COLES")
                                    {
                                        drnew[diname] = "ETA 21:00PM BST";
                                    }
                                    if (diname == "MIGROS")
                                    {
                                        drnew[diname] = "ETA 5:55AM BST";
                                    }   
                                    if (diname == "LSS")
                                    {
                                        drnew[diname] = "ETA 8:25AM BST";
                                    }
                                    if (diname == "SAINSBURY")
                                    {
                                        drnew[diname] = "ETA 5:45AM BST";
                                    }
                                    if (diname == "ICA")
                                    {
                                        drnew[diname] = "ETA 5:00AM BST";
                                    }
                                    if (diname == "SONAE")
                                    {
                                        drnew[diname] = "ETA 5:30AM BST";
                                    }
                                    if (diname == "AEON")
                                    {
                                        drnew[diname] = "ETA 23.00PM BST";
                                    }
                                }
                            }//closing For
                    }
                    else
                    {
                        if (diname == "MADISON")
                        {
                            drnew[diname] = "ETA 9:55AM BST";
                        }
                        if (diname == "SPARTAN")
                        {
                            drnew[diname] = "ETA 10:55AM BST";
                        }
                        if (diname == "SOBEYS")
                        {
                            drnew[diname] = "ETA 10:55AM BST";
                        }
                        if (diname == "CVS")
                        {
                            drnew[diname] = "ETA 11:25AM BST";
                        }
                        if (diname == "COLES")
                        {
                            drnew[diname] = "ETA 21:00PM BST";
                        }
                        if (diname == "MIGROS")
                        {
                            drnew[diname] = "ETA 5:55AM BST";
                        }
                        if (diname == "LSS")
                        {
                            drnew[diname] = "ETA 8:25AM BST";
                        }
                        if (diname == "SAINSBURY")
                        {
                            drnew[diname] = "ETA 5:45AM BST";
                        }
                        if (diname == "ICA")
                        {
                            drnew[diname] = "ETA 5:00AM BST";
                        }
                        if (diname == "SONAE")
                        {
                            drnew[diname] = "ETA 5:30AM BST";
                        }
                        if (diname == "AEON")
                        {
                            drnew[diname] = "ETA 23.00PM BST";
                        }
                    }
                }
            }
            else
            {
                if (diname == "MADISON")
                {
                    drnew[diname] = "ETA 9:55AM BST";
                }
                if (diname == "SPARTAN")
                {
                    drnew[diname] = "ETA 10:55AM BST";
                }
                if (diname == "SOBEYS")
                {
                    drnew[diname] = "ETA 10:55AM BST";
                }
                if (diname == "CVS")
                {
                    drnew[diname] = "ETA 11:25AM BST";
                }
                if (diname == "COLES")
                {
                    drnew[diname] = "ETA 21:00PM BST";
                }
                if (diname == "MIGROS")
                {
                    drnew[diname] = "ETA 5:55AM BST";
                }
                if (diname == "LSS")
                {
                    drnew[diname] = "ETA 8:25AM BST";
                }
                if (diname == "SAINSBURY")
                {
                    drnew[diname] = "ETA 5:45AM BST";
                }
                if (diname == "ICA")
                {
                    drnew[diname] = "ETA 5:00AM BST";
                }
                if (diname == "SONAE")
                {
                    drnew[diname] = "ETA 5:30AM BST";
                }
                if (diname == "AEON")
                {
                    drnew[diname] = "ETA 23.00PM BST";
                }
            }
        }
        dt1.Rows.Add(drnew);

        GridViewAvail.DataSource = dt1;
        GridViewAvail.DataBind();
     }

    protected void GridViewAvail_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((string)(DataBinder.Eval(e.Row.DataItem, "AEON")) == "Available")
            {
                e.Row.Cells[0].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "AEON")) == "Errors")
            {
                e.Row.Cells[0].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "AEON"))) == ("Warning"))
            {
                e.Row.Cells[0].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "AEON"))).StartsWith("ETA"))
            {
                e.Row.Cells[0].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "ICA")) == "Available")
            {
                e.Row.Cells[1].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "ICA")) == "Errors")
            {
                e.Row.Cells[1].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "ICA"))) == ("Warning"))
            {
                e.Row.Cells[1].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "ICA"))).StartsWith("ETA"))
            {
                e.Row.Cells[1].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SONAE")) == "Available")
            {
                e.Row.Cells[2].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SONAE")) == "Errors")
            {
                e.Row.Cells[2].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SONAE"))) == ("Warning"))
            {
                e.Row.Cells[2].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SONAE"))).StartsWith("ETA"))
            {
                e.Row.Cells[2].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SAINSBURY")) == "Available")
            {
                e.Row.Cells[3].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SAINSBURY")) == "Errors")
            {
                e.Row.Cells[3].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SAINSBURY"))) == ("Warning"))
            {
                e.Row.Cells[3].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SAINSBURY"))).StartsWith("ETA"))
            {
                e.Row.Cells[3].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "MIGROS")) == "Available")
            {
                e.Row.Cells[4].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "MIGROS")) == "Errors")
            {
                e.Row.Cells[4].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "MIGROS"))) == ("Warning"))
            {
                e.Row.Cells[4].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "MIGROS"))).StartsWith("ETA"))
            {
                e.Row.Cells[4].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "MADISON")) == "Available")
            {
                e.Row.Cells[5].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "MADISON")) == "Errors")
            {
                e.Row.Cells[5].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "MADISON"))) == ("Warning"))
            {
                e.Row.Cells[5].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "MADISON"))).StartsWith("ETA"))
            {
                e.Row.Cells[5].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SPARTAN")) == "Available")
            {
                e.Row.Cells[6].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SPARTAN")) == "Errors")
            {
                e.Row.Cells[6].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SPARTAN"))) == ("Warning"))
            {
                e.Row.Cells[6].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SPARTAN"))).StartsWith("ETA"))
            {
                e.Row.Cells[6].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SOBEYS")) == "Available")
            {
                e.Row.Cells[7].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "SOBEYS")) == "Errors")
            {
                e.Row.Cells[7].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SOBEYS"))) == ("Warning"))
            {
                e.Row.Cells[7].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "SOBEYS"))).StartsWith("ETA"))
            {
                e.Row.Cells[7].BackColor = Color.LightGray;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "CVS")) == "Available")
            {
                e.Row.Cells[8].BackColor = Color.Green;
            }
            if ((string)(DataBinder.Eval(e.Row.DataItem, "CVS")) == "Errors")
            {
                e.Row.Cells[8].BackColor = Color.Red;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "CVS"))) == ("Warning"))
            {
                e.Row.Cells[8].BackColor = Color.Yellow;
            }
            if (((string)(DataBinder.Eval(e.Row.DataItem, "CVS"))).StartsWith("ETA"))
            {
                e.Row.Cells[8].BackColor = Color.LightGray;
            }

        }

    }
}
