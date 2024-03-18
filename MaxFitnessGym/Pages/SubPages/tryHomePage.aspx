<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master/Site.Master" AutoEventWireup="true" CodeBehind="tryHomePage.aspx.cs" Inherits="MaxFitnessGym.Pages.SubPages.tryHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="pagestyles.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="home-container">
     <div class="background">
         <img src="MAXLOGO2.jpg" alt="BG" />
     </div>
     <div class="left-section">
         <img src="MAXLOGO.png" alt="Image" />
     </div>
     <div class="right-section"> 
         <div class="image-container">
             <img src="Promo 1.png" alt="Image 1" />
         </div>
         <div class="image-container">
             <img src="Promo2.png" alt="Image 2" />
         </div>
         <div class="image-container">
             <img src="Promo3.png" alt="Image 3" />
         </div>
         <div class="image-container">
            <img src="Promo4.png" alt="Image 4" />
         </div>
     </div>
 </div>
</asp:Content>
