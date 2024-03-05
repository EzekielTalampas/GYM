<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebApplication1.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="customerStyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="container">
        <h2>List of Clients</h2>
        <asp:Button ID="btnNewClient" runat="server" Text="New Client" CssClass="btn btn-primary btn-sm" OnClick="btnNewClient_Click" />



        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Phone</th>
                    <th>Created At</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                
            </tbody>
        </table>
    </div>
</asp:Content>
