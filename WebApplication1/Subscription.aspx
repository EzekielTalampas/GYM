<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subscription.aspx.cs" Inherits="WebApplication1.Subscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="customerStyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="container">
    <h2>Subscription</h2>

    <table class="table">
        <thead>
            <tr>
                <th>ID</th>
                <th>Subscription Name</th>
                <th>Payment</th>
                <th>Duration</th>
                <th>Created At</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            
        </tbody>
    </table>
</div>
</asp:Content>
