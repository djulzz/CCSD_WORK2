<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnterNewStudent.aspx.cs" Inherits="EnterNewStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Blue" Text="Please Enter a New Student"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_NameFirst" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_NameLast" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button_AddStudent" runat="server" OnClick="Add_Student" Text="Add Student" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
