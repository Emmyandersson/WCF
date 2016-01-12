<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateTwoNumbers.aspx.cs" Inherits="Klienten.CalculateTwoNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 160px">
    
        <asp:Label ID="Num1" runat="server" Text="Enter a number"></asp:Label>
        <asp:TextBox ID="Num1Tbx" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Num2lbl" runat="server" Text="Enter a second number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Num2Tbx" runat="server"></asp:TextBox>
        <asp:Button ID="CalculateButton" runat="server" OnClick="CalculateButton_Click" Text="Calculate the sum" />
        <asp:Label ID="SumLbl" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
