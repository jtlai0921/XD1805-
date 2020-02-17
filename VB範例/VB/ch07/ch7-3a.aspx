<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch7-3a.aspx.vb" Inherits="ch7_3a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="輸入成績" />
        <br />
    <p>
        國文成績：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        英文成績：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        平均成績：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    
    </div>
    </form>
</body>
</html>
