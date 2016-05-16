<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RamUsage.aspx.cs" Inherits="RamUsage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            height: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr style="border-style: solid; border-width: 2px">
            <td style="border-style: solid; border-width: 2px; text-align: center" class="auto-style2">
                <strong style="text-align: center; font-size:medium;">CURRENT RAM USAGE</strong></td>
        </tr>
            </table>
    <asp:Table id="tab1" style="width:100%;" runat="server" CellPadding="10">
       
        
                <asp:TableRow style="border-style: solid; border-width: 1px">
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SAINS_SS</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SSL03_PROD3</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SSL04_PROD4</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">CVS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">CVS02</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SOBEYS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">MADISON01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SPARTAN01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">MIGROS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SONAE01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">AEON01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">ICA01</asp:TableCell>

                </asp:TableRow>
           
        
            <asp:TableRow style="border-style: solid; border-width: 1px">
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center" ><asp:HyperLink Id="sains01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=1"></asp:HyperLink> </asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"> <asp:HyperLink Id="sains02" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=2"></asp:HyperLink></asp:TableCell>
             <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sains03" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=3"></asp:HyperLink></asp:TableCell>
             <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=4" ></asp:HyperLink></asp:TableCell>
             <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs02" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=5" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center" > <asp:HyperLink Id="sobeys01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=6" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"> <asp:HyperLink Id="madison01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=7"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"> <asp:HyperLink Id="spartan01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=8"></asp:HyperLink></asp:TableCell>
           <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">  <asp:HyperLink Id="migros01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=9"></asp:HyperLink></asp:TableCell>
           <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">  <asp:HyperLink Id="sonae01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=10"></asp:HyperLink></asp:TableCell>
         <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">    <asp:HyperLink Id="aeon01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=11" ></asp:HyperLink></asp:TableCell>
          <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">   <asp:HyperLink Id="ica01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=12" ></asp:HyperLink></asp:TableCell>
             </asp:TableRow>
        
        
    </asp:Table>


    <%--<table style="width:100%;">
        <tr style="border-style: solid; border-width: 2px">
            <td style="border-style: solid; border-width: 2px; text-align: center" class="auto-style2">
                <strong style="text-align: center; font-size:medium;">CURRENT DISK USAGE</strong></td>
        </tr>
            </table>
    <asp:Table id="Table1" style="width:100%;" runat="server" CellPadding="10">
       
        
                <asp:TableRow style="border-style: solid; border-width: 1px">
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SAINS_SS</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SSL03_PROD3</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SSL04_PROD4</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">CVS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">CVS02</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SOBEYS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">MADISON01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SPARTAN01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">MIGROS01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">SONAE01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">AEON01</asp:TableCell>
                    <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center">ICA01</asp:TableCell>

                </asp:TableRow>
           
        
            <asp:TableRow style="border-style: solid; border-width: 1px">
            <asp:TableCell  style="border-style: solid; border-width: 2px; text-align: center" ><asp:HyperLink Id="sains01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=1">sains_ss</asp:HyperLink> </asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sains02_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=2">sslo3</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sains_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=3" >sslo4</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=4" >cvs01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs02_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=5" >cvs02</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center" ><asp:HyperLink Id="sobeys01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=6" >sobeys01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="madison01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=7">madison01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="spartan01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=8">spartan01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="migros01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=9">migros01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sonae01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=10">sonae01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="aeon01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=11" >aeon01</asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="ica01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=12" >ica01</asp:HyperLink></asp:TableCell>
            </asp:TableRow>
        
        
    </asp:Table>--%>
    
    </asp:Content>