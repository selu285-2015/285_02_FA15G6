﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="Title" runat="server">
    <div class="jumbotron" style="background-color: #006600">
        <h1 class="text-center" style="color: #FFCC00; font-family: 'Century Schoolbook'; font-weight: normal"><em><strong>The Mane Attraction</strong></em></h1>
    </div>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-6">
            <h2>Let&#39;s Get Started</h2>
            <p>
                If you want to start your dating experience now you can click<a runat="server" href="~/Account/Register"> register </a>to go to our register screen.</p>
        </div>
        <div class="col-md-6">
            <h2>We&#39;re <em>Grrrrreat!</em></h2>
            <p>
                Lion&#39;s Pride is a FREE dating website run by Lions that will allow you to get together with other singles. After a quick look at our questionaire 
                you will be able to view the matches that qualify most with.<p>
                If they agree to your message then you can then view their profile and information.</div>

    </div>

</asp:Content>