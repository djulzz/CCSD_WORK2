<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="Login.EditUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="generic.css" />
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Login</td>
                <td><input type="text" id="login" runat="server"/></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><input type="text" id="password" runat="server"/></td>
            </tr>
            <tr>
                <td>Email</td>
                <td><input type="text" id="email" runat="server"/></td>
            </tr>
        </table>
    </form>
</body>
</html>
