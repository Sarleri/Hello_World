using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Threading;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;

public partial class Sainsburys : System.Web.UI.Page
{  
    protected void Page_Load(object sender, EventArgs e)
    {
        GetruntimestatSainsburys();
        getpendingreportSainsburys();
    }
    protected void GetruntimestatSainsburys(){
        string url = "http://192.168.22.40/display/LMGSelfServe/Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
       
   

        
        //Thread thread = new Thread(delegate()
        //{
            using (WebBrowser browser = new WebBrowser())
            {
                browser.ScrollBarsEnabled = true;
                browser.AllowNavigation = true;
                browser.Navigate(url);
                browser.Width = 1300;
                browser.Height = 900;
                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedruntime);
               
                while (browser.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        //});
        //thread.SetApartmentState(ApartmentState.STA);
        //thread.Start();
        //thread.Join();
        
   }

     protected void getpendingreportSainsburys(){
         string url = "http://192.168.22.40/x/uwMSBg";
       
   
        //Thread thread = new Thread(delegate()
        //{
            using (WebBrowser browser = new WebBrowser())
            {
                browser.ScrollBarsEnabled = true;
                browser.AllowNavigation = true;
                browser.Navigate(url);
                browser.Width = 1300;
                browser.Height = 900;
                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedpending);
               
                while (browser.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        //});
        //thread.SetApartmentState(ApartmentState.STA);
        //thread.Start();
        //thread.Join();
        
   }

    private void DocumentCompletedruntime(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        WebBrowser browser = sender as WebBrowser;
        using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
        {
            Graphics g = Graphics.FromImage(bitmap);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
            //added by preethi on 20/4/2015 begin
            Bitmap croppedBitmap = new Bitmap(bitmap);

            croppedBitmap = croppedBitmap.Clone(new Rectangle(325, 150, 800, 725),
                          System.Drawing.Imaging.PixelFormat.DontCare);

            System.Drawing.Image thumbnail = GenerateThumbnails(0.7, croppedBitmap);
           
            //added by preethi on 20/4/2015 ends
            using (MemoryStream stream = new MemoryStream())
            {
                thumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] bytes = stream.ToArray();
              
                imgRTSainsburys.Visible = true;
                imgRTSainsburys.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
            }
        }
    }
          private void DocumentCompletedpending(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        WebBrowser browser = sender as WebBrowser;
        using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
        {
            Graphics g = Graphics.FromImage(bitmap);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
            //added by preethi on 20/4/2015 begin
            Bitmap croppedBitmap = new Bitmap(bitmap);

            croppedBitmap = croppedBitmap.Clone(new Rectangle(325, 150, 800, 725),
                          System.Drawing.Imaging.PixelFormat.DontCare);

            System.Drawing.Image thumbnail = GenerateThumbnails(0.7, croppedBitmap);
           
            //added by preethi on 20/4/2015 ends
            using (MemoryStream stream = new MemoryStream())
            {
                thumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] bytes = stream.ToArray();
              
                imgPCSainsburys.Visible = true;
                imgPCSainsburys.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
            }
        }
    }
    private System.Drawing.Image GenerateThumbnails(double scaleFactor, Bitmap croppedimage
   )
    {

        // can given width of image as we want
        var newWidth = (int)(croppedimage.Width * scaleFactor);
        // can given height of image as we want
        var newHeight = (int)(croppedimage.Height * scaleFactor);
        var thumbnailImg = new Bitmap(newWidth, newHeight);
        var thumbGraph = Graphics.FromImage(thumbnailImg);
        thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
        thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
        thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
        var imageRectangle = new Rectangle(0, 0, newWidth, newHeight);
        thumbGraph.DrawImage(croppedimage, imageRectangle);
        return thumbnailImg;
    }

}

