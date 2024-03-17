﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/Site.Master" AutoEventWireup="true" CodeBehind="Subscription.aspx.cs" Inherits="MaxFitnessGym.Subscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="pagestyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="container">
    <h2>Subscription</h2>

    <table class="table">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Payment</th>
                <th>Duration</th>
            </tr>
        </thead>
        <tbody>
            <% foreach (MaxFitnessGym.App_Code.SubscriptionData subscription in MaxFitnessGym.App_Code.SubscriptionData.List) { %>
                <tr>
                    <th><%= subscription.ID %></th>
                    <th><%= subscription.Name %></th>
                    <th><%= subscription.Payment %></th>
                    <th><%= subscription.Duration %></th>
                </tr>
            <% } %>
        </tbody>
    </table>
</div>
</asp:Content>
