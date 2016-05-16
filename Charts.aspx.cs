using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using GetWebSiteThumb;


public partial class Charts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { }
    
//        //Bitmap bmp = ClassWSThumb.GetWebSiteThumbnail("http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports", 1024,
//        //     768, 250,
//        //    250);
//        //using (MemoryStream stream = new MemoryStream())
//        //{
//        //    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//        //    byte[] bytes = stream.ToArray();
//        //    imgSelfServeSainsbury.Visible = true;
//        //    imgSelfServeSainsbury.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//        //}
//        //bmp.Save(Server.MapPath("~") + "/thumbnail.bmp");
//        //ImageBox.ImageUrl = "~/thumbnail.bmp";
       

//        CaptureSelfServeSainsbury();
//        CaptureSelfServeLSS();
//        CaptureSelfServeColes();
//        CaptureSelfServeCVS();
//        CaptureSelfServeMadison();
//        CaptureSelfServeMigros();
//        CaptureSelfServeSobeys();
//        CaptureSelfServeSpartan();
       
//    }

//    protected void CaptureSelfServeSainsbury()
//    {

    
//        string url = "http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports";
         

//        Thread thread = new Thread(delegate()
//        {
//            using (WebBrowser browser = new WebBrowser())
//            {
//                browser.ScrollBarsEnabled = true;
//                browser.AllowNavigation = true;
//                browser.Navigate(url);
//                browser.Width = 1300;
//                browser.Height = 900;
//                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedSainsbury);
//                while (browser.ReadyState != WebBrowserReadyState.Complete)
//                {
//                    System.Windows.Forms.Application.DoEvents();
//                }
//            }
//        });
//        thread.SetApartmentState(ApartmentState.STA);
//        thread.Start();
//        thread.Join();
//    }


//    private void DocumentCompletedSainsbury(object sender, WebBrowserDocumentCompletedEventArgs e)
//    {
//        WebBrowser browser = sender as WebBrowser;
//        using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//        {
//            Graphics g = Graphics.FromImage(bitmap);

//            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

//            browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//            //added by preethi on 20/4/2015 begin
//            Bitmap croppedBitmap = new Bitmap(bitmap);
               
//            croppedBitmap = croppedBitmap.Clone(new Rectangle(325, 150, 800, 725),
//                          System.Drawing.Imaging.PixelFormat.DontCare);

//            System.Drawing.Image thumbnail = GenerateThumbnails(0.3, croppedBitmap);

//            //added by preethi on 20/4/2015 ends
//            using (MemoryStream stream = new MemoryStream())
//            {
//                thumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//                byte[] bytes = stream.ToArray();
//                imgSelfServeSainsbury.Visible = true;
//                imgSelfServeSainsbury.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//            }
//        }
//    }
// private System.Drawing.Image GenerateThumbnails(double scaleFactor, Bitmap croppedimage
//)
// {
     
//         // can given width of image as we want
//         var newWidth = (int)(croppedimage.Width * scaleFactor);
//         // can given height of image as we want
//         var newHeight = (int)(croppedimage.Height * scaleFactor);
//         var thumbnailImg = new Bitmap(newWidth, newHeight);
//         var thumbGraph = Graphics.FromImage(thumbnailImg);
//         thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
//         thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
//         thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
//         var imageRectangle = new Rectangle(0, 0, newWidth, newHeight);
//         thumbGraph.DrawImage(croppedimage, imageRectangle);
//         return thumbnailImg;
//     }
 
    
//    protected void CaptureSelfServeLSS()
//    {


//        string url = "http://192.168.22.40/display/LMGSelfServe/LSS+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";


//        Thread thread = new Thread(delegate()
//        {
//            using (WebBrowser browser = new WebBrowser())
//            {
//                browser.ScrollBarsEnabled = true;
//                browser.AllowNavigation = true;
//                browser.Navigate(url);
//                browser.Width = 1300;
//                browser.Height = 900;
//                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedLSS);
//                while (browser.ReadyState != WebBrowserReadyState.Complete)
//                {
//                    System.Windows.Forms.Application.DoEvents();
//                }
//            }
//        });
//        thread.SetApartmentState(ApartmentState.STA);
//        thread.Start();
//        thread.Join();
//    }


//    private void DocumentCompletedLSS(object sender, WebBrowserDocumentCompletedEventArgs e)
//    {
//        WebBrowser browser = sender as WebBrowser;
//        using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//        {
//            Graphics g = Graphics.FromImage(bitmap);

//            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

//            browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//            //added by preethi on 20/4/2015 begin
//            Bitmap croppedBitmap = new Bitmap(bitmap);

//            croppedBitmap = croppedBitmap.Clone(new Rectangle(325, 150, 800, 725),
//                          System.Drawing.Imaging.PixelFormat.DontCare);

//            System.Drawing.Image thumbnail = GenerateThumbnails(0.3, croppedBitmap);

//            //added by preethi on 20/4/2015 ends
//            using (MemoryStream stream = new MemoryStream())
//            {
//                thumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//                byte[] bytes = stream.ToArray();
//                imgSelfServeLSS.Visible = true;
//                imgSelfServeLSS.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//            }
//        }
//    }
//    protected void CaptureSelfServeColes()
//    {
//        string url = "http://192.168.22.40/display/LMGSelfServe/Coles+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//        Thread thread = new Thread(delegate()
//        {
//            using (WebBrowser browser = new WebBrowser())
//            {
//                browser.ScrollBarsEnabled = true;
//                browser.AllowNavigation = true;
//                browser.Navigate(url);
//                browser.Width = 1300;
//                browser.Height = 900;
//                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedcoles);
//                while (browser.ReadyState != WebBrowserReadyState.Complete)
//                {
//                    System.Windows.Forms.Application.DoEvents();
//                }
//            }
//        });
//        thread.SetApartmentState(ApartmentState.STA);
//        thread.Start();
//        thread.Join();
//    }


//    private void DocumentCompletedcoles(object sender, WebBrowserDocumentCompletedEventArgs e)
//    {
//        WebBrowser browser = sender as WebBrowser;
//        using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//        {
//            Graphics g = Graphics.FromImage(bitmap);

//            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

//            browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//            //added by preethi on 20/4/2015 begin
//            Bitmap croppedBitmap = new Bitmap(bitmap);

//            croppedBitmap = croppedBitmap.Clone(new Rectangle(325, 150, 800, 725),
//                          System.Drawing.Imaging.PixelFormat.DontCare);

//            System.Drawing.Image thumbnail = GenerateThumbnails(0.3, croppedBitmap);

//            //added by preethi on 20/4/2015 ends
//            using (MemoryStream stream = new MemoryStream())
//            {
//                thumbnail.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//                byte[] bytes = stream.ToArray();
//                imgSelfServeColes.Visible = true;
//                imgSelfServeColes.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//            }
//        }
//    }
//    protected void CaptureSelfServeCVS()
//    {
//    }
//    protected void CaptureSelfServeMadison()
//    {
//    }
//    protected void CaptureSelfServeMigros()
//    {
//    }
//    protected void CaptureSelfServeSobeys()
//    {
//    }
//    protected void CaptureSelfServeSpartan()
//    { }
//    //public bool ThumbnailCallback()
//    //{
//    //    return false;
//    //}
//    //protected void CaptureSelfServeSainsbury()
//    //{
       
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports";
      
//    //    Thread thread = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedSainsbury);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread.SetApartmentState(ApartmentState.STA);
//    //    thread.Start();
//    //   thread.Join();
//   // }

//    //protected void CaptureSelfServeLSS()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/LSS+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread1 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedLSS);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread1.SetApartmentState(ApartmentState.STA);
//    //    thread1.Start();
//    //    thread1.Join();
//    //}

//    //protected void CaptureSelfServeColes()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Coles+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread2 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedColes);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread2.SetApartmentState(ApartmentState.STA);
//    //    thread2.Start();
//    //    thread2.Join();
//    //}

//    //protected void CaptureSelfServeCVS()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/CVS+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread3 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedCVS);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread3.SetApartmentState(ApartmentState.STA);
//    //    thread3.Start();
//    //    thread3.Join();
//    //}

//    //protected void CaptureSelfServeMadison()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Madison+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread4 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedMadison);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread4.SetApartmentState(ApartmentState.STA);
//    //    thread4.Start();
//    //    thread4.Join();
//    //}

//    //protected void CaptureSelfServeMigros()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Migros+-+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread5 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedMigros);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread5.SetApartmentState(ApartmentState.STA);
//    //    thread5.Start();
//    //    thread5.Join();
//    //}

//    //protected void CaptureSelfServeSobeys()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Sobeys+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread6 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedSobeys);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread6.SetApartmentState(ApartmentState.STA);
//    //    thread6.Start();
//    //    thread6.Join();
//    //}

//    //protected void CaptureSelfServeSpartan()
//    //{
//    //    string url = "http://192.168.22.40/display/LMGSelfServe/Spartan+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
//    //    Thread thread7 = new Thread(delegate()
//    //    {
//    //        using (WebBrowser browser = new WebBrowser())
//    //        {
//    //            browser.ScrollBarsEnabled = true;
//    //            browser.AllowNavigation = true;
//    //            browser.Navigate(url);
//    //            browser.Width = 1024;
//    //            browser.Height = 768;
//    //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompletedSpartan);
//    //            while (browser.ReadyState != WebBrowserReadyState.Complete)
//    //            {
//    //                System.Windows.Forms.Application.DoEvents();
//    //            }
//    //        }
//    //    });
//    //    thread7.SetApartmentState(ApartmentState.STA);
//    //    thread7.Start();
//    //    thread7.Join();
//    //}



//    //private void DocumentCompletedSainsbury(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        //added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            croppedBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeSainsbury.Visible = true;
//    //            imgSelfServeSainsbury.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedLSS(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 150, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        //added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeLSS.Visible = true;
//    //            imgSelfServeLSS.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedColes(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        //added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeColes.Visible = true;
//    //            imgSelfServeColes.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedCVS(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        //added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeCVS.Visible = true;
//    //            imgSelfServeCVS.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedMadison(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        ////added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeMadison.Visible = true;
//    //            imgSelfServeMadison.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedMigros(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        ////added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeMigros.Visible = true;
//    //            imgSelfServeMigros.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedSobeys(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        ////added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeSobeys.Visible = true;
//    //            imgSelfServeSobeys.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}

//    //private void DocumentCompletedSpartan(object sender, WebBrowserDocumentCompletedEventArgs e)
//    //{
//    //    WebBrowser browser = sender as WebBrowser;
//    //    using (Bitmap bitmap = new Bitmap(browser.Width, browser.Height))
//    //    {
//    //        browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
//    //        //added by preethi on 20/4/2015 begin

//    //        System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
//    //        Bitmap myBitmap = bitmap;
//    //        System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(250, 250, myCallback, IntPtr.Zero);


//    //        Bitmap croppedBitmap = new Bitmap(myThumbnail);

//    //        croppedBitmap = croppedBitmap.Clone(new Rectangle(80, 50, 170, 200),
//    //                    System.Drawing.Imaging.PixelFormat.DontCare);
//    //        //added by preethi on 20/4/2015 ends
//    //        using (MemoryStream stream = new MemoryStream())
//    //        {
//    //            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//    //            byte[] bytes = stream.ToArray();
//    //            imgSelfServeSpartan.Visible = true;
//    //            imgSelfServeSpartan.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
//    //        }
//    //    }
//    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {



    }

}