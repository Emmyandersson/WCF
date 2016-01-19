<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Namnsdagar.aspx.cs" Inherits="Klienten.Namnsdagar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kolla datum" />
        <p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
