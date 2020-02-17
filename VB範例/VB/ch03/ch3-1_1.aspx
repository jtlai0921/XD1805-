<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch3-1_1.aspx.vb" Inherits="ch3_1_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        <span style="font-size:12.0pt;font-family:新細明體;
mso-ascii-font-family:&quot;Times New Roman&quot;;mso-hansi-font-family:&quot;Times New Roman&quot;;
mso-bidi-font-family:&quot;Times New Roman&quot;;mso-font-kerning:1.0pt;mso-ansi-language:
EN-US;mso-fareast-language:ZH-TW;mso-bidi-language:AR-SA">題目：計算一個</span><span 
            lang="EN-US" style="font-size:12.0pt;font-family:&quot;Times New Roman&quot;;mso-fareast-font-family:
新細明體;mso-font-kerning:1.0pt;mso-ansi-language:EN-US;mso-fareast-language:ZH-TW;
mso-bidi-language:AR-SA">10!的總和<br />
        請輸入終值：<asp:TextBox ID="TextBox1" runat="server" 
            Width="114px"></asp:TextBox>
        <br />
        計 算&nbsp; 結 果：<asp:TextBox ID="TextBox2" runat="server" Width="113px"></asp:TextBox>
        <br />
        </span>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="計算" 
            Width="96px" />
    
    </div>
    </form>
</body>
</html>
