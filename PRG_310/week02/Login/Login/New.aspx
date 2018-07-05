<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="Login.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NEW<br />
        </div>
        <table>
            <tr>
                <td>
                    Login
                </td>
                <td>
                    <input type="text" id="login" />
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <input type="text" id="password" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button_EnterNewUser" runat="server" OnClick="Add_New_User" Text="Add New User" />
    </form>
</body>
</html>
