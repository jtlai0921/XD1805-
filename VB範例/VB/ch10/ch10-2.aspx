<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch10-2.aspx.vb" Inherits="ch10_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/學生資料庫.mdb" 
            DeleteCommand="DELETE FROM [學生成績表] WHERE [序號] = ?" 
            InsertCommand="INSERT INTO [學生成績表] ([序號], [學號], [姓名], [性別], [資料庫成績], [系統分析成績], [程式設計成績], [計算機概論成績]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" 
            SelectCommand="SELECT * FROM [學生成績表]" 
            UpdateCommand="UPDATE [學生成績表] SET [學號] = ?, [姓名] = ?, [性別] = ?, [資料庫成績] = ?, [系統分析成績] = ?, [程式設計成績] = ?, [計算機概論成績] = ? WHERE [序號] = ?">
            <DeleteParameters>
                <asp:Parameter Name="序號" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="序號" Type="Int32" />
                <asp:Parameter Name="學號" Type="String" />
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="性別" Type="String" />
                <asp:Parameter Name="資料庫成績" Type="Int32" />
                <asp:Parameter Name="系統分析成績" Type="Int32" />
                <asp:Parameter Name="程式設計成績" Type="Int32" />
                <asp:Parameter Name="計算機概論成績" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="學號" Type="String" />
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="性別" Type="String" />
                <asp:Parameter Name="資料庫成績" Type="Int32" />
                <asp:Parameter Name="系統分析成績" Type="Int32" />
                <asp:Parameter Name="程式設計成績" Type="Int32" />
                <asp:Parameter Name="計算機概論成績" Type="Int32" />
                <asp:Parameter Name="序號" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" CellPadding="4" DataKeyNames="序號" 
            DataSourceID="AccessDataSource1" ForeColor="#333333" GridLines="None" 
            Height="50px" Width="209px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="序號" HeaderText="序號" ReadOnly="True" 
                    SortExpression="序號" />
                <asp:BoundField DataField="學號" HeaderText="學號" SortExpression="學號" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="性別" HeaderText="性別" SortExpression="性別" />
                <asp:BoundField DataField="資料庫成績" HeaderText="資料庫成績" SortExpression="資料庫成績" />
                <asp:BoundField DataField="系統分析成績" HeaderText="系統分析成績" 
                    SortExpression="系統分析成績" />
                <asp:BoundField DataField="程式設計成績" HeaderText="程式設計成績" 
                    SortExpression="程式設計成績" />
                <asp:BoundField DataField="計算機概論成績" HeaderText="計算機概論成績" 
                    SortExpression="計算機概論成績" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <br />
    
    </div>
    </form>
</body>
</html>
