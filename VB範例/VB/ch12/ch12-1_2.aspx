<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch12-1_2.aspx.vb" Inherits="ch12_1_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/TreeView.xml">
        </asp:XmlDataSource>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="TreeNode" TextField="Name" 
                    ValueField="Value" />
            </DataBindings>
        </asp:TreeView>
        <br />
    
    </div>
    </form>
</body>
</html>
