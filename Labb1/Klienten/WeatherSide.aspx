<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherSide.aspx.cs" Inherits="Klienten.WeatherSide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="PredictWeatherBtn" runat="server" OnClick="PredictWeatherBtn_Click" Text="Förutsäg vädret imorgon" />
        <asp:Label ID="ResultLabel" runat="server" Text="Resultat"></asp:Label>
    
    </div>
    </form>
</body>
</html>
