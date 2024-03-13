<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/Site.Master" AutoEventWireup="true" CodeBehind="NewClient.aspx.cs" Inherits="MaxFitnessGym.NewClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="newclientstyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container">
        <h2>New Client</h2>
        <div class="form-group">
            <label for="txtLastName">Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFirstName">First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPhone">Phone:</label>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="ddlMembershipType">Membership Type:</label>
            <asp:DropDownList ID="ddlMembershipType" runat="server" CssClass="form-control">
                <asp:ListItem Text="Session" Value="Session"></asp:ListItem>
                <asp:ListItem Text="Weekly" Value="Weekly"></asp:ListItem>
                <asp:ListItem Text="Bi-Monthly" Value="Bi-Monthly"></asp:ListItem>
                <asp:ListItem Text="Monthly" Value="Monthly"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="txtPayment">Payment:</label>
            <asp:TextBox ID="txtPayment" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="btn-container">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
        </div>
    </div>


</asp:Content>
