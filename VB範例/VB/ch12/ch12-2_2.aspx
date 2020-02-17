<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch12-2_2.aspx.vb" Inherits="ch12_2_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Menu.xml">
        </asp:XmlDataSource>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:MenuItemBinding DataMember="TreeNode" TextField="Name" 
                    ValueField="Value" />
            </DataBindings>
        </asp:Menu>
        <br />
    
    </div>
    </form>
</body>
</html>
