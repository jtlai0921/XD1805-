﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch6-3.aspx.vb" Inherits="ch6_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        設定您的密碼：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        請再輸入一次：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="確定" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox2" ControlToValidate="TextBox1" ErrorMessage="輸入密碼不一致" 
            ForeColor="Red"></asp:CompareValidator>
    
    </div>
    </form>
</body>
</html>
