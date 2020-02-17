<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-6.aspx.vb" Inherits="ch5_6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        請選修您喜歡的課程：<br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>資料庫系統</asp:ListItem>
            <asp:ListItem>系統分析與設計</asp:ListItem>
            <asp:ListItem>ASP.NET程式設計</asp:ListItem>
            <asp:ListItem>伺服器管理</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        您已選的課程：<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
