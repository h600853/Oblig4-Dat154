<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Oblig4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       &nbsp;<asp:Label ID="sizeLabel" runat="server" Text="Size"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="bedsLabel" runat="server" Text="Beds"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="priceLabel" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="checkInLabel" runat="server" Text="Check-In Date"></asp:Label>
       &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="checkOutLabel" runat="server" Text="Check-Out Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
       <asp:DropDownList ID="sizeDropDownList" runat="server">
           <asp:ListItem>Big</asp:ListItem>
           <asp:ListItem>Small</asp:ListItem>
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="bedsDropDownList" runat="server" Width="119px">
           <asp:ListItem Value="1"></asp:ListItem>
           <asp:ListItem>2</asp:ListItem>
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList3" runat="server">
           <asp:ListItem>High</asp:ListItem>
           <asp:ListItem>Medium</asp:ListItem>
           <asp:ListItem>Low</asp:ListItem>
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="checkInTextBox" runat="server" OnTextChanged="fraDatoTekstBox_TextChanged"></asp:TextBox>
&nbsp;<asp:TextBox ID="checkOutTextBox" runat="server" OnTextChanged="tilDatoTekstBox_TextChanged"></asp:TextBox>
       &nbsp;&nbsp;
&nbsp;&nbsp;<asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" Width="90px" />
       &nbsp;
       <asp:Button ID="BookRoomButton" runat="server" OnClick="BookRoomButton_Click" Text="Book Room" Width="128px" />
       <br />
       <br />
       <asp:RangeValidator ID="CheckInValidator" runat="server" ControlToValidate="checkInTextBox" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="3000-01-1" Type="Date">Please type a valid Check-In Date: yyyy-MM-dd</asp:RangeValidator>
       <br />
       <asp:RangeValidator ID="CheckOutValidator" runat="server" ControlToValidate="checkOutTextBox" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="3000-01-1" Type="Date">Please type a valid Check-Out Date: yyyy-MM-dd</asp:RangeValidator>
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
   </div>

</asp:Content>
