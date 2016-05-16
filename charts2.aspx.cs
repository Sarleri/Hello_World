using System;
using System.Collections.Generic;
using System.Linq;
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



public partial class Charts2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Bitmap bmp = ClassWSThumb.GetWebSiteThumbnail("http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports", 1024,
        //     768, 250,
        //    250);
        //using (MemoryStream stream = new MemoryStream())
        //{
        //    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        //    byte[] bytes = stream.ToArray();
        //    imgSelfServeSainsbury.Visible = true;
        //    imgSelfServeSainsbury.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
        //}
        //bmp.Save(Server.MapPath("~") + "/thumbnail.bmp");
        //ImageBox.ImageUrl = "~/thumbnail.bmp";


        CaptureSelfServeSainsbury();
        CaptureSelfServeLSS();
        CaptureSelfServeColes();
        CaptureSelfServeCVS();
        CaptureSelfServeMadison();
        CaptureSelfServeMigros();
        CaptureSelfServeSobeys();
        CaptureSelfServeSpartan();

    }
    protected void CaptureSelfServeSainsbury()
    {
        string Url = "http://192.168.22.40/display/LMGSelfServe/Madison+Runtime+Stats+-+Last+2+Weeks+%28Graph%29";
        Bitmap bmp = ClassWSThumb.GetWebSiteThumbnail(Url, 1024,
           768, 200,
          200);
        using (MemoryStream stream = new MemoryStream())
        {
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = stream.ToArray();
            imgSelfServeSainsbury.Visible = true;
            imgSelfServeSainsbury.ImageUrl = "data:image/Png;base64," + Convert.ToBase64String(bytes);
        }
    }
  
    
    protected void CaptureSelfServeLSS()
    {
    }
    protected void CaptureSelfServeColes()
    {
    }
    protected void CaptureSelfServeCVS()
    {
    }
    protected void CaptureSelfServeMadison()
    {
    }
    protected void CaptureSelfServeMigros()
    {
    }
    protected void CaptureSelfServeSobeys()
    {
    }
    protected void CaptureSelfServeSpartan()
    { }
 
    
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {



    }

}