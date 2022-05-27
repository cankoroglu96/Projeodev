<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Odeme.aspx.cs" CodeFile ="Odeme.aspx.cs" Inherits="Projeodev.Odeme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 229px;
        }
        .auto-style5 {
            display: block;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
        .auto-style6 {
            width: 259px;
        
            
        }
        .renk{
            background-color: #ffA500;
        }
        .fotograf {
            background-image: url("b574a7f53d82fa9e064561fb066ccbd7e35993da_plc_170c5c9f1bb3bf235a47dba2c24970a2.jpg");
            background-repeat: no-repeat;
            background-position: top;
        }
      
    </style>
</head>
    <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
<body style="height: 671px; " class="renk fotograf">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="yemek_id" DataSourceID="SqlDataSource1" Width="1419px">
            <Columns>
                <asp:BoundField DataField="yemek_id" HeaderText="yemek_id" ReadOnly="True" SortExpression="yemek_id" />
                <asp:BoundField DataField="yemek_cesitleri" HeaderText="yemek_cesitleri" SortExpression="yemek_cesitleri" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HesapSistemiConnectionString %>" SelectCommand="SELECT * FROM [Yemekler]"></asp:SqlDataSource>
        <br />
    <div class="container">
</div>

    <div class="container">
  <h2>&nbsp;</h2>
  <p>&nbsp;</p>            
  <table class="table table-dark text-align: center" style="width: 40%; text-align: center;">
    <thead>
    </thead>
    <tbody>
      <tr>
        <td class="auto-style6">&nbsp;Müşteri Ad:<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5" Width="345px"></asp:TextBox>
          </td>
        <td class="auto-style4">Yemek Çeşidi:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Seç</asp:ListItem>
            <asp:ListItem>Çorba</asp:ListItem>
            <asp:ListItem>Salata</asp:ListItem>
        </asp:DropDownList>
          </td>
      </tr>
      <tr>
        <td class="auto-style6">Müşteri Soyad:<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5" Width="346px"></asp:TextBox>
          </td>
        <td class="auto-style4">Yemek Adı:<asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
          </td>
      </tr>
      <tr>
        <td class="auto-style6">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ekle" CssClass="btn btn-success" />
          </td>
        <td class="auto-style4">
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click1"  Text="Devam" CssClass="btn btn-success" />
          </td>
      </tr>
    </tbody>
  </table>
</div>

    
    </form>
    
    
</body>
</html>
