<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch5-10a.aspx.vb" Inherits="ch5_10a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
            DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <Items>
                <asp:MenuItem Selected="True" Text="項目1" Value="0"></asp:MenuItem>
                <asp:MenuItem Text="項目2" Value="1"></asp:MenuItem>
                <asp:MenuItem Text="項目3" Value="2"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
        <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    您點選了項目1
                </asp:View>
                <asp:View ID="View2" runat="server">
                    您點選了項目2
                </asp:View>
                <asp:View ID="View3" runat="server">
                    您點選了項目3
                </asp:View>
            </asp:MultiView>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
