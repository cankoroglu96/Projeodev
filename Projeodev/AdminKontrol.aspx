<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminKontrol.aspx.cs" Inherits="Projeodev.AdminKontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
  
  
    <title></title>
    <style>
        .fotograf{
            background-image: url("b574a7f53d82fa9e064561fb066ccbd7e35993da_plc_170c5c9f1bb3bf235a47dba2c24970a2.jpg");
            background-repeat: no-repeat;
          
            background-position: top;
        
        }
        .renk{
            background-color: #ffA500;
        }
    </style>
</head>
<body class="fotograf renk">
    <form id="form1" runat="server">
        <div class="container">
  <h2>&nbsp;</h2>
  <p>&nbsp;</p>            
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
  <table class="table table-dark table-striped">
    <thead>
      <tr>
        <th>Yemek Adı</th>
        <th>Fiyat</th>
        <th>Çeşit</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
          </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
          </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdown dropright" AutoPostBack="True">
                <asp:ListItem>Seçiniz</asp:ListItem>
                <asp:ListItem>Çorbalar</asp:ListItem>
                <asp:ListItem>Tostlar</asp:ListItem>
                <asp:ListItem>Yumurtalar</asp:ListItem>
            </asp:DropDownList>
          </td>
      </tr>
      <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-warning" OnClick="Button1_Click"/>
          </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="Çıkar" CssClass="btn btn-light " OnClick="Button2_Click"/>
          </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Güncelle" CssClass="btn btn-danger" />
          </td>
      </tr>
    </tbody>
  </table>
</div>
    </form>
</body>
</html>
