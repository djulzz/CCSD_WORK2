﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome New/Existing User<br />
            <asp:Button ID="Button_Returning" runat="server" OnClick="Handle_Click" Text="Returning User" />
            <asp:Button ID="Button_NewUser" runat="server" OnClick="Handle_Click" Text="Register" />
        </div>
        <div>
            <asp:Label ID="Label_Error" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
