<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspNetWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md" style="margin-bottom: 10px;  ">
            <a href="Demo.aspx" class="btn btn-primary btn-lg">Demo</a>
        </div>
        <div class="col-md">
            <a href="DemoEdit.aspx" class="btn btn-primary btn-lg">DemoEdit</a>
        </div>
    </div>

</asp:Content>
