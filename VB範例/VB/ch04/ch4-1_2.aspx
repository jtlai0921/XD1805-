﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch4-1_2.aspx.vb" Inherits="ch4_1_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        帳號：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        密碼：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
    
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="確定" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="結束" />
    
    </div>
    </form>
</body>
</html>
