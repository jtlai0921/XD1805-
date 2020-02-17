<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch12-3_3.aspx.vb" Inherits="ch12_ch12_3_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
            </asp:Menu>
            <br />
        </div>
    </form>
</body>
</html>
