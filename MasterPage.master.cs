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


public partial class MasterPage : System.Web.UI.MasterPage
{
    public string backgroundImage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        dateLabel.Text = "Last Refreshed  as on " + DateTime.Now.ToString();
        if (!IsPostBack)
        {

            if (Request.CurrentExecutionFilePath.ToLower().Contains("worldsignal"))
            {
                backgroundImage = "";
            }
            else
            {
                backgroundImage = "whitemap.png";
            }
        }      

    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        Response.Redirect("Alerts.aspx");

    }

   
}
