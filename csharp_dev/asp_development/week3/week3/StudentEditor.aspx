<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentEditor.aspx.cs" Inherits="StudentEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 91px;
        }
        .auto-style2 {
            width: 174px;
        }
        .auto-style3 {
            width: 468px;
        }
        .auto-style4 {
            width: 46%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="m_TextBox_student_id" runat="server" OnTextChanged="Text_Changed_student_id"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="m_TextBox_FirstName" runat="server" OnTextChanged="Text_Changed_FirstName"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="m_TextBox_lastName" runat="server" OnTextChanged="Text_Changed_LastName"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="m_Button_Validate_Changes" runat="server" OnClick="Validate_Changes" Text="Validate Changes" />
    </form>
</body>
</html>
