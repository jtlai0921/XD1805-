<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-4.aspx.vb" Inherits="ch5_4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        請選擇您的血型：<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>O 型</asp:ListItem>
            <asp:ListItem>A 型</asp:ListItem>
            <asp:ListItem>B 型</asp:ListItem>
            <asp:ListItem Value="AB 型">AB 型</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        您的血型是：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
