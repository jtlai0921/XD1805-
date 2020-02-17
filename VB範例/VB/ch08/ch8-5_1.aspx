<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch8-5_1.aspx.vb" Inherits="ch8_5_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
      <ItemTemplate>
        學號 : <%# Container.DataItem("學號") %> <br>
        姓名 : <%# Container.DataItem("姓名") %> <br>
        班級 : <%#Container.DataItem("班級")%> <br>
        電話 : <%#Container.DataItem("電話")%> <br>
       <hr Align = left width = 90% >
      </ItemTemplate>
    </asp:Repeater>
    <div>    
    </div>
    </form>
</body>
</html>
