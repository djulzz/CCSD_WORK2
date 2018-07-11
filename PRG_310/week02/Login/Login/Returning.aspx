<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Returning.aspx.cs" Inherits="Login.Returning" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="generic.css" type="text/css" />
</head>
<body>
    <h1>Returning Customer</h1>
    <form id="form_returning_01" runat="server">
        <table id="table01">
            <tr><td>Login</td><td><input type="text" id="login" runat="server"/></td></tr>
            <tr><td>Password</td><td><input type="text" id="password" runat="server"/></td></tr>
            <tr><td>Email</td><td><input type="text" id="email" runat="server"/></td></tr>
        </table>
        <asp:Button ID="Log" Text="Login" OnClick="Process_Returning_Customer" runat="server"/>

    </form>
</body>
</html>
