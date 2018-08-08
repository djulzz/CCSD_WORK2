<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tutorial2.aspx.cs" Inherits="AirlineSurveys3.Tutorial2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox runat="server" ID="FlightSelection">

        </asp:ListBox>
        Noise&nbsp;<asp:RadioButtonList ID ="R_Noise" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="Handle_Click"></asp:RadioButtonList>
        Cleanliness&nbsp;<asp:RadioButtonList ID ="R_Cleanliness" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="Handle_Click"></asp:RadioButtonList>
        Comfort&nbsp;<asp:RadioButtonList ID ="R_Comfort" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="Handle_Click"></asp:RadioButtonList>
        Friendliness&nbsp;<asp:RadioButtonList ID ="R_Friendliness" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="Handle_Click"></asp:RadioButtonList>
        Space&nbsp;<asp:RadioButtonList ID ="R_Space" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="Handle_Click"></asp:RadioButtonList>
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Review" Text="Submit Review" />
    </form>
</body>
</html>
