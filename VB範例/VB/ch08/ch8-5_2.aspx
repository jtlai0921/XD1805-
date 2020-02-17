<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch8-5_2.aspx.vb" Inherits="ch8_5_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList id = "ds"  runat="server" >
    <AlternatingItemStyle BackColor = "#CCFF99" />  
      <ItemTemplate>
        學號 : <%# Container.DataItem("學號") %> 
        姓名 : <%# Container.DataItem("姓名") %> 
        班級: <%#Container.DataItem("班級")%> 
        電話: <%#Container.DataItem("電話")%><br>
      </ItemTemplate>
    </asp:DataList>
    </div>
    </form>
</body>
</html>
