<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Randomgiris.aspx.cs" Inherits="Projeodev.Randomgiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sifre Olustur" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 29px" Text="Devam et" />
    </form>
</body>
</html>
