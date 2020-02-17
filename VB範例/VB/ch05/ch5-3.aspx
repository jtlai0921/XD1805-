<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-3.aspx.vb" Inherits="ch5_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        請選擇您的性別<br />
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
            GroupName="Sex" Text="男" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
            GroupName="Sex" Text="女" />
        <br />
        <br />
        您的性別是：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
