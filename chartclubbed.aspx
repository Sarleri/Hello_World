<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="chartclubbed.aspx.cs" Inherits="chartclubbed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<%--
    <form id="form1" runat="server">
--%>
    <div>

        <table class="style1">
            <tr>
                <td style="text-align: right">
                    Report Measure</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        OnTextChanged="ddmanu_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Number of Reports</asp:ListItem>
                        <asp:ListItem>DB_Runtime</asp:ListItem>
                        <asp:ListItem>APP_Run_Time</asp:ListItem>
                        <asp:ListItem>ScheduledReport</asp:ListItem>  
                        <asp:ListItem>FailedReport</asp:ListItem>  
                        
                    </asp:DropDownList>
                </td>
            </tr>
            <tr align="center">
                <td colspan="2">

        <asp:Chart ID="Chart1" runat="server" Height="500px" Width="900px" BorderDashStyle="Solid"

            BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2px"

            BorderColor="#1A3B69" >

           <Titles>

                <asp:Title Name="Report" Text="Number of Reports" />

            </Titles>

            <Series>
                <asp:Series Name="Series0" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series1" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series2" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series3" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series4" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series5" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series6" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series7" BorderColor="180, 26, 59, 105" ChartType="Line"/>
                <asp:Series Name="Series8" BorderColor="180, 26, 59, 105" ChartType="Line"/>
            </Series>
           
            <ChartAreas>

                <asp:ChartArea Name="ChartArea1" BorderColor="white" BorderDashStyle="Solid"

                    BackSecondaryColor="White" BackColor="white" ShadowColor="Transparent"

                    BackGradientStyle="TopBottom">

                    <Area3DStyle Rotation="0" Perspective="0" Inclination="0" IsRightAngleAxes="False"

                        WallWidth="0" IsClustered="False"></Area3DStyle>

                    <AxisY LineColor="64, 64, 64, 64"  >

                      
                      <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
                        <MajorGrid LineColor="64, 64, 64, 64" />

                    </AxisY>
                    <AxisY LineColor="64, 64, 64, 64">

                 <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />

                        <MajorGrid LineColor="64, 64, 64, 64" />

                    </AxisY>
                    <AxisY LineColor="64, 64, 64, 64">

                  <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold"  />

                        <MajorGrid LineColor="64, 64, 64, 64" />

                    </AxisY>

                    <AxisX  LineColor="64, 64, 64, 64" >

                        <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold"  />

                        <MajorGrid LineColor="64, 64, 64, 64" />

                    </AxisX>

                </asp:ChartArea>

            </ChartAreas>

        </asp:Chart>
      
                </td>
            </tr>
        </table>
      
    </div>

<%--    </form>--%>

</asp:Content>

