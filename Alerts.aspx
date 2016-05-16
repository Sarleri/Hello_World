<%@ Page AutoEventWireup="true" CodeFile="Alerts.aspx.cs" Inherits="Alerts" Language="C#" MasterPageFile="~/MasterPage.master" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server" >

    <style type="text/css"> 
        .grid
        {
            border-style: solid;
            border-width: 1px;
                width:16.66%;
        }
        .subheading
        {
            border-color: #000000;
            border-style: solid;
            border-width: 1px;
            width: 16.66%;
            text-align: center;
            font-weight: bold;
        }
        .table
        {
            border-style:solid;
            margin: 1px;
            width: 100%;
            border: 1px;
        }
        .Summary
        {
            border-color: #000000;
            margin: 1px;
            text-align: center;
            border-bottom-color: #000000;
            border-left-color: #000000;
            border-right-color: #000000;
            border-top-color: #000000;
            margin-right: 1px;
          
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table">
        <tr>
            <td style="border-color: #000000; border-style: solid; border-width: 2px; text-align: center; " colspan="6" >
                <h4 style="margin-bottom: 0; margin-top: 0"><strong>NAGIOS</strong></h4>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="border-color: #000000; text-align: center; border-style:solid; border-width: 1px;" >
                <strong>Application</strong>
            </td>
            <td colspan="3" style="border-bottom-color: #FF0000; border-color: #000000; text-align: center; border-style:solid; border-width: 1px;">
                <strong>Data warehouse</strong>
            </td>
        </tr>
        <tr>
            <td class="subheading">Swap Memory Usage
            </td>
            <td class="subheading">Heap Memory Usage
            </td>
            <td class="subheading">Others
            </td>
            <td class="subheading">Disk Space Usage
            </td>
            <td class="subheading">RAM Usage
            </td>
            <td class="subheading">Others
            </td>
        </tr>
        <tr>
            <td class="grid">
                <asp:GridView ID="GridviewSwap" runat="server"  
                AutoGenerateColumns="False" CssClass="Summary" 
                CellPadding="4" CellSpacing="2"
                Height="16px" onrowdatabound="GridviewSwap_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Critical" >
                        <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#"  style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=SWAP&CW=CRITICAL', 'win01', 300, 400);">
                            <%# DataBinder.Eval(Container.DataItem, "Critical")  %></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Warning" >
                    <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=SWAP&CW=WARNING', 'win01', 700, 600);">
                            <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                        </ItemTemplate>
                    </asp:TemplateField></Columns>
                </asp:GridView>
             </td>
            <td class="grid">
                 <asp:GridView ID="GridviewHeap" runat="server"  
                 AutoGenerateColumns="False" CssClass="Summary" BackColor="" 
                 CellPadding="4" CellSpacing="2"
                 Height="16px" onrowdatabound="GridviewHeap_RowDataBound">
                 <Columns>
                     <asp:TemplateField HeaderText="Critical">
                     <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=HEAP&CW=CRITICAL', 'win01', 300, 400);">
                            <%# DataBinder.Eval(Container.DataItem, "Critical")%></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Warning">
                    <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=HEAP&CW=WARNING', 'win01', 700, 600);">
                            <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                        </ItemTemplate>
                    </asp:TemplateField></Columns>
                </asp:GridView>
            </td>
            <td class="grid">
              <asp:GridView ID="GridviewOthers" runat="server"  
               AutoGenerateColumns="False" CssClass="Summary" 
               CellPadding="4" CellSpacing="2"
               Height="16px" onrowdatabound="GridviewOthers_RowDataBound">
               <Columns>
                <asp:TemplateField HeaderText="Critical">
                <ItemStyle  Width="8.33%" />
                    <ItemTemplate>
                        <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=OthersAPP&CW=CRITICAL', 'win01', 300, 400);">
                        <%# DataBinder.Eval(Container.DataItem, "Critical")%></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Warning">
                <ItemStyle Width="8.33%" />
                    <ItemTemplate>
                         <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&SHO=OthersAPP&CW=WARNING', 'win01', 700, 600);">
                        <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                    </ItemTemplate>
                </asp:TemplateField></Columns>
                </asp:GridView>
            </td>
            <td class="grid">
                <asp:GridView ID="GridviewDisk" runat="server"  
                AutoGenerateColumns="False" CssClass="Summary"  
                CellPadding="4" CellSpacing="2"
                Height="16px" onrowdatabound="GridviewDisk_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Critical">
                    <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=DiskSpaceUsage&CW=CRITICAL', 'win01', 300, 400);">
                            <%# DataBinder.Eval(Container.DataItem, "Critical")%></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Warning">
                    <ItemStyle Width="8.33%" />
                        <ItemTemplate>
                            <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=DiskSpaceUsage&CW=WARNING', 'win01', 700, 600);">
                            <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                        </ItemTemplate>
                    </asp:TemplateField></Columns>
                </asp:GridView>
            </td>
            <td class="grid">
               <asp:GridView ID="GridviewRAM" runat="server"  
                AutoGenerateColumns="False" CssClass="Summary" 
                CellPadding="4" CellSpacing="2"
                Height="16px" onrowdatabound="GridviewRAM_RowDataBound">
                <Columns>
                <asp:TemplateField HeaderText="Critical">
                <ItemStyle Width="8.33%" />
                    <ItemTemplate>
                        <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=RAMUsage&CW=CRITICAL', 'win01', 300, 400);">
                        <%# DataBinder.Eval(Container.DataItem, "Critical")%></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Warning">
                <ItemStyle Width="8.33%" />
                    <ItemTemplate>
                        <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=RAMUsage&CW=WARNING', 'win01', 700, 600);">
                        <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                    </ItemTemplate>
                </asp:TemplateField></Columns>
                </asp:GridView>
            </td>
            <td class="grid">
                <asp:GridView ID="Gridviewdwhothers" runat="server"  
                AutoGenerateColumns="False" CssClass="Summary" 
                CellPadding="4" CellSpacing="2"
                Height="16px" onrowdatabound="Gridviewdwhothers_RowDataBound">
                <Columns>
                <asp:TemplateField HeaderText="Critical">
                <ItemStyle Width="8.33%" />
                    <ItemTemplate>
                        <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=OthersDWH&CW=CRITICAL', 'win01', 300, 400);">
                        <%# DataBinder.Eval(Container.DataItem, "Critical")%></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Warning">
                <ItemStyle Width="8.33%" />
                    <ItemTemplate>
                        <a href = "#" style="color:Black;" onclick="return jsPop('Childwindow.aspx?Alerttype=Nagios&DRO=OthersDWH&CW=WARNING', 'win01', 700, 600);">
                        <%# DataBinder.Eval(Container.DataItem, "Warning")%></a>
                    </ItemTemplate>
                </asp:TemplateField></Columns>
                </asp:GridView></td>
        </tr>
    </table>
    <br />
    <table class="table">
       <tr >
           <td style="border-color: #000000; border-style: solid; border-width: 2px; text-align: center; " colspan="6" >
                <h4 style="margin-bottom: 0; margin-top: 0"><strong>Alerts Summary - Production </strong></h4>
            </td>
        </tr>
        <tr >
            <td style="border-style: solid; border-width: 0px">
             <asp:GridView ID="GridView1" runat="server"  
            AutoGenerateColumns="False" CssClass="Summary" 
            CellPadding="4" CellSpacing="2"
            Height="16px" width="100%"
            onselectedindexchanged="GridView1_SelectedIndexChanged" HorizontalAlign="Center" >
           <Columns>   
            <asp:TemplateField>
            <ItemTemplate>
             <div>
                <%# DataBinder.Eval(Container.DataItem, "Header")%>
             </div>
             </ItemTemplate>
            <HeaderStyle Font-Size="Small" HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="AEON01"  ItemStyle-CssClass="grid" >
            <ItemTemplate>
                <div>
                    <%# DataBinder.Eval(Container.DataItem, "AEON01")%>
                </div>
            </ItemTemplate>
            </asp:TemplateField>
<%--            <asp:TemplateField HeaderText="COLES02"  ItemStyle-CssClass="grid" >
            <ItemTemplate>
                <div>
                <%# DataBinder.Eval(Container.DataItem, "COLES02")%>
                </div>
        </ItemTemplate>
        </asp:TemplateField>--%>
        <asp:TemplateField HeaderText="CVS01"  ItemStyle-CssClass="grid">
        <ItemTemplate>
            <div>
            <%# DataBinder.Eval(Container.DataItem, "CVS01")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CVS02" ItemStyle-CssClass="grid">
        <ItemTemplate>
            <div>
            <%# DataBinder.Eval(Container.DataItem, "CVS02")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="MIGROS01" ItemStyle-CssClass="grid">
        <ItemTemplate>
            <div>
               <%# DataBinder.Eval(Container.DataItem, "MIGROS01")%>
            </div>
        </ItemTemplate> 
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="MADISON01" ItemStyle-CssClass="grid">
        <ItemTemplate>
            <div>
            <%# DataBinder.Eval(Container.DataItem, "MADISON01")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SOBEYS01" ItemStyle-CssClass="grid" >
        <ItemTemplate>
        <div >
            <%# DataBinder.Eval(Container.DataItem, "SOBEYS01")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SPARTAN01" ItemStyle-CssClass="grid" >
        <ItemTemplate>
        <div >
            <%# DataBinder.Eval(Container.DataItem, "SPARTAN01")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SAINS_SS" ItemStyle-CssClass="grid" >
        <ItemTemplate>
        <div >
            <%# DataBinder.Eval(Container.DataItem, "SAINS_SS")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SSL03" ItemStyle-CssClass="grid">
        <ItemTemplate>
        <div >
            <%# DataBinder.Eval(Container.DataItem, "SSL03")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SSL04" ItemStyle-CssClass="grid" >
        <ItemTemplate>
            <div >
                    <%# DataBinder.Eval(Container.DataItem, "SSL04")%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SONAE01" ItemStyle-CssClass="grid">
        <ItemTemplate>
        <div >
            <%# DataBinder.Eval(Container.DataItem, "SONAE01")%>
        </div>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
     </asp:GridView>
            </td>
        </tr>
        <tr><td colspan="6"><br /></td></tr>
        <tr >
           <td style="border-color: #000000; border-style: solid; border-width: 2px; text-align: center; " colspan="6" >
                 <h4 style="margin-bottom: 0; margin-top: 0"><strong>Alerts Summary - Test </strong></h4>
            </td>
        </tr>
        <tr>
            <td style="border-style: solid; border-width: 0px">
             <asp:GridView ID="GridView2" runat="server"  AutoGenerateColumns="False" 
        CssClass="Summary"   
        CellPadding="4"  CellSpacing="2" width="100%"
        Height="16px" onselectedindexchanged="GridView1_SelectedIndexChanged" HorizontalAlign="Center">
        <Columns>
        <asp:TemplateField HeaderText="" >
            <ItemTemplate>
            <div style="width:14.28%">
                <%# DataBinder.Eval(Container.DataItem, "Header")%>
                </a>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="AEONT1" ItemStyle-CssClass="grid" >
            <ItemTemplate>
            <div>
                <a href = "#" style="color:Black; text-decoration:none !important; cursor:default;">
                <%# DataBinder.Eval(Container.DataItem, "AEONT1")%>
                </a>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="MIGROST1" ItemStyle-CssClass="grid"   >
            <ItemTemplate>
                <div>
                <a href = "#"  style="color:Black; text-decoration:none !important; cursor:default;">
                <%# DataBinder.Eval(Container.DataItem, "MIGROST1")%>
                </a>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="MADISONT1" ItemStyle-CssClass="grid"  >
            <ItemTemplate>
                <div>
                <a href = "#" style="color:Black; text-decoration:none !important; cursor:default;">
                <%# DataBinder.Eval(Container.DataItem, "MADISONT1")%>
                </a>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SOBEYST1" ItemStyle-CssClass="grid" >
        <ItemTemplate>
        <div>
            <a href = "#" style="color:Black; text-decoration:none !important; cursor:default;">
            <%# DataBinder.Eval(Container.DataItem, "SOBEYST1")%>
            </a>
            </div>
        </ItemTemplate>
        </asp:TemplateField>    
        <asp:TemplateField HeaderText="SPARTANT1" ItemStyle-CssClass="grid" >
        <ItemTemplate>
        <div>
            <a href = "#" style="color:Black; text-decoration:none !important; cursor:default;">
            <%# DataBinder.Eval(Container.DataItem, "SPARTANT1")%>
            </a></div>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SSLT1" ItemStyle-CssClass="grid">
        <ItemTemplate>
            <div>
            <a href = "#" style="color:Black; text-decoration:none !important; text-decoration:none !important; cursor:default;">
            <%# DataBinder.Eval(Container.DataItem, "SSLT1")%>
            </a>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        </asp:GridView>
            </td>
        </tr>  
</table>
</asp:Content>
            
