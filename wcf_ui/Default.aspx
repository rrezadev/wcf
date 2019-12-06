<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RR_WCF_NWUI_1107._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>RR_WCF_11072019</h1>
        <p class="lead">WCF,Entity Framework, ASP.NET application accessing the Northwind database on SQL SERVER.</p>
        <p class="lead">1. Created Web Service</p>
        <p class="lead">2. Created Entity Framework model to access data.</p>
        <p class="lead">3. Created ASP.NET Web Form to retrieve data from a UI perspective.</p>
    </div>

    <div class="container">
        <p>
            <strong>ENTER PRODUCT NUMBER:&nbsp;</strong><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Click for Product Name" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </div>

</asp:Content>
