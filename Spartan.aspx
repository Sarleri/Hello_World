<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Spartan.aspx.cs" Inherits="Spartan" AspCompat="true"%>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <tr>
        <td>    <table width="95%">
    <tr>
        <td align="center" style="border:solid; border-color:black; border-bottom-width:1px;" >
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" BorderColor="Black" BorderStyle="Solid" border-bottom-width="1px" BackColor="white" Width="525">Self Serve Run Time Stats - Last 2 Weeks (Spartan)</asp:Label>
            <br />
              <asp:Image ImageAlign="Middle" ID="imgRTSpartan" runat="server"  Width="525" Height="525" Visible="true" onclick="return jsPop1('enlargecharts.aspx?url=http://192.168.22.40/display/LMGSelfServe/Spartan+Runtime+Stats+-+Last+2+Weeks+%28Graph%29', 'win02', 775, 575);" />
        </td>
     
<td align="center" style="border:solid; border-color:black; border-bottom-width:1px;">
            <br />
            <asp:Label ID="Label9" runat="server" Text="Label" BorderColor="Black" BorderStyle="Solid" border-bottom-width="1px" BackColor="white" Width="525">Spartan- Pending reports  </asp:Label>
            <br />
        <asp:Image  ImageAlign="Middle" ID="imgPCSpartan"  runat="server" Height="525" Width="525" Visible="true" onclick="return jsPop1('enlargecharts.aspx?url=http://192.168.22.40/x/bAMSBg', 'win02', 775, 575);"  /></td>

     </tr>
    </table>
        </td>
    </tr>
</asp:Content> 