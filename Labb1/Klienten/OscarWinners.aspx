<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OscarWinners.aspx.cs" Inherits="Klienten.OscarWinners" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Skriv ett årtal (2000-2009)"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Oscar Movies" />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
