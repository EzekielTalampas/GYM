<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="MaxFitnessGym.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="pagestyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="container">
        <h2>List of Clients</h2>
        <div class="button-container">
            <asp:Button ID="btnNewClient" runat="server" Text="New Client" CssClass="btn btn-primary btn-sm" OnClick="btnNewClient_Click" />
            <asp:TextBox ID="txtSearch" runat="server" CssClass="search-box" placeholder="Search..." OnTextChanged="Page_Load" AutoPostBack="true" />
        </div>
        <asp:Repeater ID="rptCustomers" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Phone Number</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("FirstName") %></td>
                    <td><%# Eval("LastName") %></td>
                    <td><%# Eval("PhoneNumber") %></td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary btn-sm" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-primary btn-sm" OnClick="btnDelete_Click" CommandArgument='<%# Eval("ID") %>' />
                    </td>   
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
