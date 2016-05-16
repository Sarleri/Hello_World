
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RuntimeCharts.aspx.cs" Inherits="CVS" AspCompat="true"%>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <script language="javascript" type="text/javascript">
      function myFunction(elmnt, clr) {
          document.getElementById('<%= Name.ClientID %>').innerHTML = clr;
      }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%"><tr><td align="left" style="width:25%"></td><td style="width:75%" align="center"><asp:Label id="Name" runat="server"></asp:Label></td></tr></table>
    <div style="border: 1px solid rgb(0, 0, 1); overflow:hidden; margin: LEFT; max-width: 100%; max-height:100%">
 <table>
 <tr><td align="left" style="width:25%">
<p><a href="http://192.168.22.40/display/LMGSelfServe/Madison+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'MADISON-RUNTIME STATS')">Madison-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/CVS+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'CVS-RUNTIME STATS')">CVS-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/LSS+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'LSS-RUNTIME STATS')">LSS-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Migros+-+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'Migros-RUNTIME STATS')">Migros-Runtime stats</a></p>

<!--<p><a href="http://192.168.22.40/display/LMGSelfServe/Coles+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'Coles-RUNTIME STATS')">Coles-Runtime stats</a></p>-->
<p><a href="http://192.168.22.40/display/LMGSelfServe/ICA+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'ICA-RUNTIME STATS')">ICA-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'Sainsburys-RUNTIME STATS')">Sainsburys-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Sobeys+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'Sobeys-RUNTIME STATS')">Sobeys-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Spartan+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'Spartan-RUNTIME STATS')">Spartan-Runtime stats</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/AEON+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" target="iframe_a" onclick="myFunction(this, 'AEON-RUNTIME STATS')">AEON-Runtime stats</a></p>

</td> <td style="width:75%">
<iframe scrolling="no" 
             src="http://192.168.22.40/display/LMGSelfServe/Madison+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" 
             style="border: 0px none; margin-left: 0px; height: 815px; margin-top: -245px; width: 995px;" 
             name="iframe_a" id="iframe_a"></iframe>

</td>

           
</tr>

</table>
</div>
</asp:Content>  
