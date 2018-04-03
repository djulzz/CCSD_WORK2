<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css"/>
<%--    <style type="text/css">
        .auto-style1 {
            width: 206px;
        }
    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Available Options<br />
        </div>
        <asp:Label ID="m_label_current_roster" runat="server" Text="Current Roster"></asp:Label>
        <asp:Table ID="Table1" runat="server" BackColor="#FF6600" Height="105px" Width="144px">
        </asp:Table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
            <asp:Button ID="Button_GoToEnrollStudentPage" runat="server" Text="Add new student" OnClick="GoToEnrollStudentPage" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
