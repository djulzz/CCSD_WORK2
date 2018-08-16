<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AirLineSurvey.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBox_Flights" runat="server">

        </asp:ListBox>
        <br />
        Noise<asp:RadioButtonList ID="R_Noise" runat="server" OnSelectedIndexChanged="Handle_Rating" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
        Space<asp:RadioButtonList ID="R_Space" runat="server" OnSelectedIndexChanged="Handle_Rating" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
        Comfort<asp:RadioButtonList ID="R_Comfort" runat="server" OnSelectedIndexChanged="Handle_Rating" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
        Clean<asp:RadioButtonList ID="R_Clean" runat="server" OnSelectedIndexChanged="Handle_Rating" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
        Friendly<asp:RadioButtonList ID="R_Friendly" runat="server" OnSelectedIndexChanged="Handle_Rating" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
    </form>
</body>
</html>
