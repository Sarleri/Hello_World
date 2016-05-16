<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Avail.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        
       
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="width:100%;">
        <tr style="border-style: solid; border-width: 2px">
            <td style="border-style: solid; border-width: 2px; text-align: center">
                <strong style="text-align: center; font-size:medium;">APPLICATION AVAILABILITY</strong></td>
        </tr>
        <tr style="border-style: solid; border-width: 2px">
            <td style="border-style: solid; border-width: 2px">
    <asp:GridView ID="GridViewAvail" runat="server"  AutoGenerateColumns="False" 
         
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="2px" CellPadding="0"
        Height="61px" width="100%" style="margin-center:10px; margin-left: 0px; text-align: center; font-size:small;" 
         align="Center" onrowdatabound="GridViewAvail_RowDataBound">
    <Columns>

        <asp:TemplateField HeaderText="AEON"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                      <div>
                        <a  style="color:Black; text-align:center;" href = "http://galwiki/x/woBiBg" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "AEON")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>   

<ItemStyle ></ItemStyle>
                </asp:TemplateField>
 <asp:TemplateField HeaderText="ICA"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                      <div>
                        <a  style="color:Black; text-align:center;" href = "http://galwiki/x/FxEvBg" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "ICA")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>
      <asp:TemplateField HeaderText="SONAE"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                      <div>
                        <a  style="color:Black; text-align:center;" href = "http://galwiki/x/yQ8vBg" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "SONAE")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="SAINSBURY"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a  style="color:Black; text-align:center;" href = "http://galwiki/x/e4oAB" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "SAINSBURY")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

                   <%-- <asp:TemplateField HeaderStyle-Font-Size="Small" HeaderStyle-Width="5" HeaderText="LSS"
                        >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href ="http://192.168.22.40/x/jYoAB" target= "_blank">
                        <%# DataBinder.Eval(Container.DataItem, "LSS")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>--%>

                    <asp:TemplateField HeaderText="MIGROS"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href = "http://galwiki/x/g4oAB" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "MIGROS")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="MADISON"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href="http://192.168.22.40/x/9YB5BQ" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "MADISON")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="SPARTAN"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href ="http://galwiki/x/9YB5BQ" target= "_blank">
                        <%# DataBinder.Eval(Container.DataItem, "SPARTAN")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="SOBEYS"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href = "http://galwiki/x/j4oAB" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "SOBEYS")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>

<%--                    <asp:TemplateField HeaderText="COLES"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                    <div>
                        <a style="color:Black; text-align:center;" href ="http://192.168.22.40/x/iIoAB" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "COLES")%>
                        </a>
                        </div>
                    </ItemTemplate>

<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>

<ItemStyle ></ItemStyle>
                </asp:TemplateField>--%>
     <asp:TemplateField HeaderText="CVS"  HeaderStyle-Width="5" HeaderStyle-Font-Size="Small" >
                    <ItemTemplate>
                      <div>
                        <a  style="color:Black; text-align:center;" href = "http://galwiki/x/gIoAB" target="_blank">
                        <%# DataBinder.Eval(Container.DataItem, "CVS")%>
                        </a>
                        </div>
                    </ItemTemplate>
<HeaderStyle Font-Size="Small" Width="9.09%"></HeaderStyle>   
<ItemStyle ></ItemStyle>
                </asp:TemplateField>
    </Columns>
        </asp:GridView>
            </td>
        </tr>
    </table>
     <div style="border: 3px solid rgb(0, 0, 1); overflow:hidden; margin: left; max-width: 100%; max-height:500px">
         <table border ="0" align="center">
                <tr> 
                     <td align="center"><iframe scrolling="no" src="DQ_Report.png" style="border: 0px none;  height: 500px; margin-left: 25px; margin-top: 0px; width: 1080px;" name="iframe_a"></iframe>
                     </td>
                </tr>
         </table>
     </div>
</asp:Content>

