<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Oblig4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
          Login
    </title>
  

</head>
<body style="height: 295px">

    <h1>Login</h1>

    <form id="form1" runat="server">
        <div>
       
        
        <p>
            <asp:Label ID="brukernavnLabel" runat="server" Text="Username"></asp:Label>
        </p>
        <asp:TextBox ID="brukernavnTekstBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="brukernavnTekstBox" ErrorMessage="Must be length 3-10, can contain capital letters, letters and numbers" ForeColor="Red" ValidationExpression="^[A-Za-z0-9]{3,10}$"></asp:RegularExpressionValidator>
        <p>
            <asp:Label ID="passordLabel" runat="server" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="passordTekstBox" runat="server" TextMode="Password" OnTextChanged="passordTekstBox_TextChanged" Height="22px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="passordTekstBox" ErrorMessage="Must be length 5-20, can contain capital letters, letters and numbers" ForeColor="Red" ValidationExpression="^[A-Za-z0-9]{5,20}$"></asp:RegularExpressionValidator>
            </div>
        <p style="height: 461px">
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
