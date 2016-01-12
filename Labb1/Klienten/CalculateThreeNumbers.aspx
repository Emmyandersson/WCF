<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateThreeNumbers.aspx.cs" Inherits="Klienten.CalculateThreeNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter a number:"></asp:Label>
        <asp:TextBox ID="num1Tbx" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Enter a second number"></asp:Label>
        <asp:TextBox ID="tbxNum2" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Enter a third number"></asp:Label>
        <asp:TextBox ID="tbxNum3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSumOfThree" runat="server" OnClick="btnSumOfThree_Click" Text="Calculate the Sum" />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
