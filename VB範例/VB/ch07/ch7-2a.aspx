<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch7-2a.aspx.vb" Inherits="ch7_2a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/images/Critical.bmp" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/images/Question.bmp" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/images/Exclamation.bmp" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton4" runat="server" 
            ImageUrl="~/images/Information.bmp" />
    
    </div>
    </form>
</body>
</html>
