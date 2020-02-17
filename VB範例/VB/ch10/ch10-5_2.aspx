<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ch10-5_2.aspx.vb" Inherits="ch10_5_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .style1
        {
            width: 100%;
            border-collapse: collapse;
        }
        .style2
        {
            width: 155px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/學生資料庫.mdb" SelectCommand="SELECT * FROM [學生成績表]">
        </asp:AccessDataSource>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="序號" 
            DataSourceID="AccessDataSource1">
            <ItemTemplate>
                <table class="style1">
                    <tr>
                        <td bgcolor="Yellow" colspan="2" style="text-align: center">
                            學生基本資料</td>
                    </tr>
                    <tr>
                        <td class="style2">
                            序號:<asp:Label ID="序號Label" runat="server" Text='<%# Eval("序號") %>' />
                        </td>
                        <td>
                            學號:<asp:Label ID="學號Label" runat="server" Text='<%# Eval("學號") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            姓名:<asp:Label ID="姓名Label" runat="server" Text='<%# Eval("姓名") %>' />
                        </td>
                        <td>
                            性別:<asp:Label ID="性別Label" runat="server" Text='<%# Eval("性別") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="Yellow" colspan="2" style="text-align: center">
                            成績單</td>
                    </tr>
                    <tr>
                        <td class="style2">
                            資料庫成績:</td>
                        <td>
                            <asp:Label ID="資料庫成績Label" runat="server" Text='<%# Eval("資料庫成績") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            系統分析成績:</td>
                        <td>
                            <asp:Label ID="系統分析成績Label" runat="server" Text='<%# Eval("系統分析成績") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            程式設計成績:</td>
                        <td>
                            <asp:Label ID="程式設計成績Label" runat="server" Text='<%# Eval("程式設計成績") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            計算機概論成績:</td>
                        <td>
                            <asp:Label ID="計算機概論成績Label" runat="server" Text='<%# Eval("計算機概論成績") %>' />
                        </td>
                    </tr>
                </table>
                ====================================<hr /> &nbsp;
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
