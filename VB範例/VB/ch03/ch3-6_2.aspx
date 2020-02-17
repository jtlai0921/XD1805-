<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch3-6_2.aspx.vb" Inherits="ch3_6_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Button ID="Button1" runat="server" Text="一、單一選擇結構" 
        onclick="Button1_Click" Width="142px" />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="二、雙重選擇結構" Width="142px" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="三、多重選擇結構題目：多重選擇結構(If---Then---ElseIf)	" Width="352px" />
    <p>
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="四、多重選擇結構題目：多重選擇結構(Select Case)	" Width="323px" />
    </p>
    <p>
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="五、巢狀選擇結構" Width="142px" />
    </p>
    
    </div>
    </form>
</body>
</html>
