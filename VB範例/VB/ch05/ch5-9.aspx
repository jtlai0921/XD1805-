<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-9.aspx.vb" Inherits="ch5_9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        成績單<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="詳細資料" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="簡易資料" />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            學號：E0001<br /> 姓名：洪瑞展<br /> 國文成績：75<br /> 數學成績：95<br /> 平均成績：85</asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server">
            學號：E0001<br /> 姓名：洪瑞展<br /> 平均成績：85</asp:Panel>
    
    </div>
    </form>
</body>
</html>
