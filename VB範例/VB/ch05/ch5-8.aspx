﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-8.aspx.vb" Inherits="ch5_8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Ad.xml">
        </asp:XmlDataSource>
        <br />
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
    
    </div>
    </form>
</body>
</html>
