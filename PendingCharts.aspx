
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PendingCharts.aspx.cs" Inherits="CVS" AspCompat="true"%>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript" type="text/javascript">
      function myFunction(elmnt, clr) {
          document.getElementById('<%= Name.ClientID %>').innerHTML = clr;
      }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%"><tr><td align="left" style="width:25%; "></td><td style="width:75%; color: #6666FF;" align="center" ><asp:Label id="Name" runat="server"></asp:Label></td></tr></table>
  <div style="border: 1px solid rgb(0, 0, 1); overflow:hidden; margin: LEFT; max-width: 100%; max-height:100%">
 <table style="margin:5px;">
 <tr><td align="left" style="width:25%">
<p><a href="http://192.168.22.40/display/LMGSelfServe/Madison+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'MADISON-PENDING REPORTS')">Madison-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/CVS+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'CVS-PENDING REPORTS')">CVS-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/LSS-+Pending+reports" target="iframe_a" onclick="myFunction(this, 'LSS-PENDING REPORTS')">LSS-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Migros+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'Migros-PENDING REPORTS')">Migros-Pending Reports</a></p>

<!--<p><a href="http://192.168.22.40/display/LMGSelfServe/Coles+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'Coles-PENDING REPORTS')">Coles-Pending Reports</a></p>-->
<p><a href="http://192.168.22.40/display/LMGSelfServe/ICA-+Pending+reports" target="iframe_a" onclick="myFunction(this, 'ICA-PENDING REPORTS')">ICA-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'Sainsburys-PENDING REPORTS')">Sainsburys-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Sobeys+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'Sobeys-PENDING REPORTS')">Sobeys-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/Spartan+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'Spartan-PENDING REPORTS')">Spartan-Pending Reports</a></p>
<p><a href="http://192.168.22.40/display/LMGSelfServe/AEON+-+Pending+Reports" target="iframe_a" onclick="myFunction(this, 'AEON-PENDING REPORTS')">AEON-Pending Reports</a></p>

</td> <td style="width:75%">
<iframe scrolling="no" src="http://192.168.22.40/display/LMGSelfServe/Sainsburys+Pending+Reports" style="border: 0px none; margin-left: 0px; height: 815px; margin-top: -245px; width: 995px;" name="iframe_a"></iframe>

</td>

           
</tr>

</table>
</div>
</asp:Content>  
