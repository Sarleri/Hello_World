<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Childwindow.aspx.cs" Inherits="Childwindow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

        <script  type="text/javascript">
            function jsPop(jsURL, jsWindowNm, jsWidth, jsHeight) {
                var hdl;
                if (jsURL != "") {
                    var jsoption = "scrollbars=yes,resizable=no,dialogLeft:300;dialogTop:300;dialogbottom:300;center:yes,width=" + jsWidth + ",height=" + jsHeight;
                    // hdl = window.open(jsURL, jsWindowNm, jsoption);
                    hdl = window.showModalDialog(jsURL, jsWindowNm, jsoption);
                }
            }

    </script>
     <script type="text/jscript">

 </script>
</head>
<body>
    <form id="form1" runat="server">
  
    <div>
    <asp:GridView ID="gv_alert" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" 
        PageSize="20" CssClass="SummaryDetail" 
        BackColor="White" 
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4"
         Height="16px" Width="100%"  
       >
        <Columns>
          <asp:BoundField DataField="Alert" HeaderText="Alert"  
                ItemStyle-CssClass="DetailItemStyleAlert">
<ItemStyle CssClass="DetailItemStyle"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Date" HeaderText="Date"  
                ItemStyle-CssClass="DetailItemStyle" ApplyFormatInEditMode="False" >
<ItemStyle CssClass="DetailItemStyle"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="AlertType" HeaderText="AlertType"  
                ItemStyle-CssClass="DetailItemStyle" ApplyFormatInEditMode="False" >
<ItemStyle CssClass="DetailItemStyle"></ItemStyle>
            </asp:BoundField>
            
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#913696" BorderColor="#C6C6C5" BorderStyle="Solid" 
            ForeColor="#FFFFFF" Font-Bold="True" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="#ECECEC" ForeColor="#003399" />
      <%--   <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" /> --%>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
