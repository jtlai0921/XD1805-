<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch4-3_2.aspx.vb" Inherits="ch4_3_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Literal ID="Literal1" runat="server" Text="使用者登入介面"></asp:Literal>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="請輸入帳號"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server">Benson</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="請輸入密碼"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
