<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch12-2_3v.aspx.vb" Inherits="ch12_2_3v" %>

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
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" 
            DataSourceID="XmlDataSource1" DynamicHorizontalOffset="2" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#990000" 
            StaticSubMenuIndent="10px">
            <DataBindings>
                <asp:MenuItemBinding DataMember="TreeNode" TextField="Name" 
                    ValueField="Value" />
            </DataBindings>
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#FFCC66" />
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
