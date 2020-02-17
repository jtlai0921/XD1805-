<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch8-5_2a.aspx.vb" Inherits="ch8_5_2a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:DataList id="ds" runat="server"  OnItemCommand="show_detail" >
     <SelectedItemStyle BackColor="#FFFFCC" />
      
     <ItemTemplate>
        學號 : <%# Container.DataItem("學號") %> 
         <asp:Button id = "Bt01"  runat="server" text = "詳細資料" CommandName="show"/>
      <br><br>
     </ItemTemplate>
      <SelectedItemTemplate>
        姓名 : <%# Container.DataItem("姓名") %> <br>
        班級 : <%# Container.DataItem("班級") %> <br>
        電話 : <%#Container.DataItem("電話")%> <br>
          <asp:Button id = "Bt02"  runat="server" text = "關閉" CommandName = "close"/>
          <hr>
      </SelectedItemTemplate>     
     </asp:DataList>
    </div>
    </form>
</body>
</html>
