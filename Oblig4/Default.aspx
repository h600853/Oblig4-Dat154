<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Oblig4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       &nbsp;<asp:Label ID="Label1" runat="server" Text="Size"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label2" runat="server" Text="Beds"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label4" runat="server" Text="Days"></asp:Label>
&nbsp;&nbsp;&nbsp;
       <br />
       <asp:DropDownList ID="DropDownList1" runat="server">
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList2" runat="server" Width="119px">
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList3" runat="server">
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList4" runat="server">
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
&nbsp;&nbsp;&nbsp;
       <asp:Button ID="BookRoomButton" runat="server" OnClick="BookRoomButton_Click" Text="Book Room" />
       <br />
       <br />
       <asp:Label ID="Label5" runat="server" Text="Available Rooms: "></asp:Label>
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
   </div>

</asp:Content>
