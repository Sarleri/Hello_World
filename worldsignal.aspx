<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="worldsignal.aspx.cs" Inherits="worldsignal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <style type="text/css">
   
     #pos_relative
     {
         position:relative;
         
         z-index:-1;
     }
      </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="pos_relative" >
<img src="../images/ISS Clients MapsV2.png"  width="1260px" height="676px"
 />
</div>

<div id="pos_sobeys" runat="server" visible="false">
<img id="nullsobeys"  runat="server" src="../images/nullsobeys.png" visible="false"  />
<img  id="redsobeys" runat="server" src="../images/redsobeys.png" visible="false"  />
<img  id="yellowsobeys" runat="server" src="../images/yellowsobeys.png" visible="false"  />
<img  id="greensobeys" runat="server" src="../images/greensobeys.png" visible="false"  />
</div>
<div id="pos_spartan" runat="server" visible="false">
<img id="nullspartan"  runat="server" src="../images/nullspartan.png" visible="false"  />
<img  id="redspartan" runat="server" src="../images/redspartan.png" visible="false"  />
<img  id="yellowspartan" runat="server" src="../images/yellowspartan.png" visible="false"  />
<img  id="greenspartan" runat="server" src="../images/greenspartan.png" visible="false"  />
</div>
<div id="pos_cvs" runat="server" visible="false">
<img id="nullcvs" runat="server" src="../images/nullcvs.png" visible="false"  />
<img  id="redcvs" runat="server" src="../images/redcvs.png" visible="false"  />
<img  id="yellowcvs" runat="server" src="../images/yellowcvs.png" visible="false"  />
<img  id="greencvs" runat="server" src="../images/greencvs.png" visible="false"  />
</div>

<div id="pos_coles" runat="server" visible="false">
<img id="nullcoles"  runat="server" src="../images/nullcoles.png" visible="false"  />
<img  id="redcoles" runat="server" src="../images/redcoles.png" visible="false"  />
<img  id="yellowcoles" runat="server" src="../images/yellowcoles.png" visible="false"  />
<img  id="greencoles" runat="server" src="../images/greencoles.png" visible="false"  />
</div>
<div id="pos_aeon" runat="server" visible="false">
<img id="nullaeon" runat="server" src="../images/nullaeon.png" visible="false"  />
<img  id="redaeon" runat="server" src="../images/redaeon.png" visible="false"  />
<img  id="yellowaeon" runat="server" src="../images/yellowaeon.png" visible="false"  />
<img  id="greenaeon" runat="server" src="../images/greenaeon.png" visible="false"  />
</div>
</div>
<div id="pos_sains" runat="server" visible="false">
<img  id="nullsains" runat="server" src="../images/nullsains.png" visible="false"  />
<img  id="redsains" runat="server" src="../images/redsains.png" visible="false"  />
<img  id="yellowsains" runat="server" src="../images/yellowsains.png" visible="false"  />
<img  id="greensains" runat="server" src="../images/greensains.png" visible="false"  />
</div>
<div id="pos_sonae" runat="server" visible="false">
<img id="nullsonae"  runat="server" src="../images/nullsonae.png" visible="false"  />
<img  id="redsonae" runat="server" src="../images/redsonae.png" visible="false"  />
<img  id="yellowsonae" runat="server" src="../images/yellowsonae.png" visible="false"  />
<img  id="greensonae" runat="server" src="../images/greensonae.png" visible="false"  />
</div>
<div id="pos_mig" runat="server" visible="false">
<img id="nullmig"  runat="server" src="../images/nullmigros.png" visible="false"  />
<img  id="redmig" runat="server" src="../images/redmigros.png" visible="false"  />
<img  id="yellowmig" runat="server" src="../images/yellowmigros.png" visible="false"  />
<img  id="greenmig" runat="server" src="../images/greenmigros.png" visible="false"  />
</div>
<div id="pos_wegmans" runat="server" visible="false">
<img id="nullwegmans" runat="server" src="../images/nullwegmans.png" visible="false"  />
<img  id="redwegmans" runat="server" src="../images/redwegmans.png" visible="false"  />
<img  id="yellowwegmans" runat="server" src="../images/yellowwegmans.png" visible="false"  />
<img  id="greenwegmans" runat="server" src="../images/greenwegmans.png" visible="false"  />
</div>
<div id="pos_bjs" runat="server" visible="false">
<img id="nullbjs" runat="server" src="../images/nullbjs.png" visible="false"  />
<img  id="redbjs" runat="server" src="../images/redbjs.png" visible="false"  />
<img  id="yellowbjs" runat="server" src="../images/yellowbjs.png" visible="false"  />
<img  id="greenbjs" runat="server" src="../images/greenbjs.png" visible="false"  />
</div>
<div id="pos_ica" runat="server" visible="false">
<img id="nullica" runat="server" src="../images/nullica.png" visible="false"  />
<img  id="redica" runat="server" src="../images/redica.png" visible="false"  />
<img  id="yellowica" runat="server" src="../images/yellowica.png" visible="false"  />
<img  id="greenica" runat="server" src="../images/greenica.png" visible="false"  />
</div>
</asp:Content>

