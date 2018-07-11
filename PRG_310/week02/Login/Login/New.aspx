<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="Login.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="generic.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NEW<br />
        </div>
        <asp:Table ID="ThatTableThough" runat="server">

        </asp:Table>
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
        <br />
        <asp:Button ID="Button_EnterNewUser" runat="server" OnClick="Add_New_User" Text="Add New User" placeholder="Click here if this is your first time"/>
    </form>
    <footer>
        <asp:Label ID="Label_Exception" runat="server"></asp:Label>
    </footer>
</body>
</html>
