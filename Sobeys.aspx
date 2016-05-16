<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sobeys.aspx.cs" Inherits="Sobeys" AspCompat="true"%>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="position: absolute; left: 0px; top: 0px; border: solid 2px #555; width:594px; height:332px;">
<div style="overflow: hidden; margin-top: -100px; margin-left: -25px;">
</div>
<iframe src="http://192.168.22.40/display/LMGSelfServe/Sobeys+Runtime+Stats+-+Last+2+Weeks+%28Graph%29" scrolling="no" style="height: 490px; border: 0px none; width: 619px; margin-top: -60px; margin-left: -24px; ">
</iframe>
</div>

</asp:Content>  


