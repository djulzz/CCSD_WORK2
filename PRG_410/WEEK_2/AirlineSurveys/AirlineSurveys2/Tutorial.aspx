<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tutorial.aspx.cs" Inherits="AirlineSurveys2.Tutorial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table runat="server" id="table">
            <tr><td>Cleanliness</td> <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_cleanliness"    RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Friendliness</td><td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_friendly"       RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Noise</td>       <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_noise"     RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Space</td>       <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_space" RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Comfort</td>     <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_comfort"       RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
        </table>
    </form>
</body>
</html>
