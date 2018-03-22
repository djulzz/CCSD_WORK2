<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add a new student<br />
            <asp:Button ID="Button_GoToEnrollStudentPage" runat="server" Text="Add new student" OnClick="GoToEnrollStudentPage" />
        </div>
    </form>
</body>
</html>
