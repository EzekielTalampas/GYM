﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="MaxFitnessGym.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="pagestyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div id="container">
    <h2>Transaction</h2>

    <table class="table">
        <thead>
            <tr>
                <th>Transaciton ID</th>
                <th>Customer ID</th>
                <th>Subscription ID</th>
                <th>Date of Purchased</th>
                <th>Created At</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            
        </tbody>
    </table>
</div>
</asp:Content>