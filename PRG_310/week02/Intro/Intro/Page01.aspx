<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page01.aspx.cs" Inherits="Intro.Page01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page 1</title>
    <link rel="stylesheet" href="Page01.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <h1>Page 1</h1>
        <p>
            <asp:Button ID="Button_GoToNextPage" runat="server" OnClick="GoToNextPage" Text="Go To Page 02" />
            <asp:Button ID="Button_Edit_Students" runat="server" OnClick="Edit_Students" Text="Edit Current Students" />
        </p>
    </form>
</body>
</html>
