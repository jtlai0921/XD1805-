<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-10.aspx.vb" Inherits="ch5_10" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="410px">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    使用者登入介面<br /> 帳號：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    密碼：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="登入" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    歡迎光臨<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="登出" />
                </asp:View>
            </asp:MultiView>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
