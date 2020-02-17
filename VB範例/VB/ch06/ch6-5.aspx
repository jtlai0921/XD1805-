<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch6-5.aspx.vb" Inherits="ch6_5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        請輸入身分證字號：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="確定" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="您的ID輸入錯誤！" ForeColor="Red" 
            ValidationExpression="[a-zA-z]\d{9}"></asp:RegularExpressionValidator>
    
    </div>
    </form>
</body>
</html>
