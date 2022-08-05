<%@ Page Title="My Page" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsDemo.MyPage" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Page | WebForms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %>.</h3>
    
    <h2>Advanced ASP.NET Server Controls</h2>
    <h1>Create a list of events from calendar control using repeater.</h1>
    <div class="form-group">
        <label>Event Name</label>
        <asp:TextBox ID="txtEventName" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label>Event Date</label>
        <asp:Calendar ID="calendarEvents" runat="server" />
    </div>
    <%--<div class="message">
        <asp:Literal ID="ltlMessage" runat="server"/>
    </div>--%>
    <div>
        <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Submit" CssClass="btn btn-primary btn-large"/>
    </div>
    <h3>Repeater Events</h3>
    <div>
        <asp:Repeater ID="rptEvents" runat="server" >
            <ItemTemplate><h4><%# DataBinder.Eval(Container.DataItem,"EventDate") %>
                <small><%# DataBinder.Eval(Container.DataItem, "EventName") %></small>
                </h4>
            </ItemTemplate>
        </asp:Repeater>
    </div>
 
</asp:Content>
