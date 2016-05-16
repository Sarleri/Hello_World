<%@ Page Title="" Language="C#"  MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoadStatus.aspx.cs" Inherits="LoadStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br/>
<br/>
        <table style="margin: 1px; border-style: solid; border-width: thin; border-color: #000000; color: #000000; border-collapse: collapse; width:100%; table-layout: auto; width: 100%; margin-top: 1px; margin-right: 1px; margin-left: 1px; margin-bottom: 1px; border-bottom-style: solid; border-bottom-color: #000000; border-left-color: #000000; border-right-color: #000000; border-top-color: #000000;">
         
        <tr>
                
                <td  >
                    <asp:GridView Width="100%"  ID="gv_LoadStatus" runat="server" BorderStyle="Solid" BorderWidth="1px" RowStyle-BorderWidth="1" RowStyle-BorderColor="black" 
                        GridLines="Both"  onrowdatabound="gv_LoadStatus_RowDataBound" Font-Size="Small">
                       <RowStyle BorderColor="Black" BorderWidth="1px"></RowStyle>

                       
                      </asp:GridView> 
                </td>
            
                </tr>

        </table>
</asp:Content>


