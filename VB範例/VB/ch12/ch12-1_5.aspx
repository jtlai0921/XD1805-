﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch12-1_5.aspx.vb" Inherits="ch12_1_5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/TreeView.mdb" SelectCommand="SELECT * FROM [TreeView資料表]">
        </asp:AccessDataSource>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="XPFileExplorer" 
            NodeIndent="15">
            <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" 
                HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    
    </div>
    <p>
        顯示您的選項</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    </form>
</body>
</html>
