<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="AirlineSurveys2.Survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Airline Survey</title>
    <link rel="stylesheet" type="text/css" href="AirlineSurvey.css" />
</head>
<body>
    <h1>Please enter your survey</h1>


    <form id="form1" runat="server">

        <asp:ListBox ID="ListBox1" runat="server" CssClass="asp_ListBox">
        </asp:ListBox>

        <table runat="server" id="table">
            <tr><td>Cleanliness</td> <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_cleanliness"    RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Friendliness</td><td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_friendly"       RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Noise</td>       <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_noise"     RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Space</td>       <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_space" RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
            <tr><td>Comfort</td>     <td><asp:RadioButtonList runat="server" SelectedIndexChanged="HandleClick" ID="R_comfort"       RepeatDirection="Horizontal" AutoPostBack="true"></asp:RadioButtonList></td></tr>
        </table>

        <div id="debug_div" runat="server">
                <h1>State Information</h1>
                <asp:ListBox ID = "lbDebug" runat="server" CssClass="asp_debug_listBox">
                </asp:ListBox>
                <h1>Survey Click Current Value</h1>
                <asp:Label ID = "lbl_survey_current_selection" runat="server"></asp:Label>
        </div>
    </form>


    <footer>
        <asp:Label ID="Label_Feeback" runat="server"></asp:Label>
    </footer>
</body>
</html>
