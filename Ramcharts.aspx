<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ramcharts.aspx.cs" Inherits="Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
     <style type="text/css">
        .style1
        {
            width: 100%;
        }
        </style>
   </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Chart ID="Chart1" runat="server" Height="500px" Width="1105px" BorderDashStyle="Solid"
                BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2px"
                BorderColor="#1A3B69">
        <Series>
            <asp:Series Name="Series0" BorderColor="180, 26, 59, 105" ChartType="Line"/>
           
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
                    <AxisX  LineColor="64, 64, 64, 64" >
                        <LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold"  />
                        <MajorGrid LineColor="64, 64, 64, 64" />
                    </AxisX>
                </asp:ChartArea>
                </ChartAreas>
                </asp:Chart>

    
    <h1 style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:large; font-weight: 900; border-right-color: #C0C0C0;">Historic Chart Generator:</h1> 
    <h1 style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:medium; font-weight: 900; border-right-color: #C0C0C0;">Kindly enter the dates in the To Date,From Date Text Boxes in the shown format: d/m/yyyy i.e, 8/3/2016 to generate the customized graph</h1>
    <h1 style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:medium; font-weight: 900; border-right-color: #C0C0C0;">From Date:</h1>
    <asp:TextBox ID="From_Date" runat="server" ></asp:TextBox>
    <h1 id="from_date_empty"></h1>
     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"

                   ControlToValidate="From_Date" ValidationExpression="^(([1-9])|(0[1-9])|(1[0-2]))\/((0[1-9])|([1-31]))\/((19|20)\d\d)$" Display="Dynamic" SetFocusOnError="true" ErrorMessage="invalid date" ForeColor="Black">Invalid Date Format</asp:RegularExpressionValidator>
<h1 style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:medium; font-weight: 900; border-right-color: #C0C0C0;">To Date:</h1>    
    
    <asp:TextBox ID="To_Date" runat="server" ></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"

                   ControlToValidate="To_Date" ValidationExpression="^(([1-9])|(0[1-9])|(1[0-2]))\/((0[1-9])|([1-31]))\/((19|20)\d\d)$" Display="Dynamic" SetFocusOnError="true" ErrorMessage="invalid date" ForeColor="Black">Invalid Date Format</asp:RegularExpressionValidator>
    
    <asp:Button ID="Button1" runat="server" Text="Generate" OnClick="Button1_Click"/>
    <asp:Label ID="label1" runat="server" Enabled="false"></asp:Label>
       
   <asp:CompareValidator runat="server" ID="Date_Validate" ControlToValidate="From_Date" ControlToCompare="To_Date" Operator="LessThan" Type="Date" ForeColor="Black">From Date cannot be greater than To Date</asp:CompareValidator>
</asp:Content>
