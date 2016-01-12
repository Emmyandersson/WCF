<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubtractTwoNumbers.aspx.cs" Inherits="Klienten.SubtractTwoNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter a number"></asp:Label>
        <asp:TextBox ID="tbxNum1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Enter a second number"></asp:Label>
        <asp:TextBox ID="tbxNum2" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="Subtract" />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
