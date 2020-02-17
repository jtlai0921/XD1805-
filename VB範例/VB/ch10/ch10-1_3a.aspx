<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch10-1_3a.aspx.vb" Inherits="ch10_1_3a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/學生資料庫.mdb" 
            SelectCommand="SELECT [學號], [姓名] FROM [學生成績表]"></asp:AccessDataSource>
    
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="AccessDataSource1" DataTextField="姓名" DataValueField="學號" 
            AutoPostBack="True" AppendDataBoundItems="True" style="height: 19px">
            <asp:ListItem>請選擇學生名單</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
