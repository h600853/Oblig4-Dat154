<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Oblig4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <%
      
        List<Oblig4.Reservations> reservations = (List<Oblig4.Reservations>)Session["reservations"];
        //check if has made a reservation
        if(reservations == null)
            {
            Response.Redirect("~/Default.aspx");
            }
        %>

<h2>Your Reservations: </h2>

<% foreach (Oblig4.Reservations reservation in reservations) { %>
 
    <p>Reservation details:</p>
    <p> Room number:  <%= reservation.Room %></p>
    <p>Check in: <%= reservation.FromDate %></p>
    <p>Check out: <%= reservation.ToDate %></p>

<% } %>
</asp:Content>
