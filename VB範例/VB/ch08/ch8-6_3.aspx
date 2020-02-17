<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    Dim SelectCmd As String = "select * from 學生資料表"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not IsPostBack Then
            BindDataBase()
        End If
    End Sub
    
    Sub BindDataBase()
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        conn = New OleDbConnection(Source)
        conn.Open() ' 開啟資料庫連結
        Dim Cmd As OleDbCommand = New OleDbCommand("SELECT * FROM 學生資料表", conn)
        DataGrid1.DataSource = Cmd.ExecuteReader()
        DataGrid1.DataBind()
        conn.Close()
    End Sub

    Sub deleteBook(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        conn = New OleDbConnection(Source)
        ' 建立SQL敘述刪除資料庫記錄
        SelectCmd = "DELETE FROM 學生資料表 WHERE 學號 = '" & DataGrid1.DataKeys.Item(e.Item.ItemIndex).ToString() & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()
        DataGrid1.EditItemIndex = -1
        BindDataBase()
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>未命名頁面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <asp:DataGrid id="DataGrid1" HeaderStyle-BackColor="#000080"
      ItemStyle-BackColor="#EEEEEE"
      AlternatingItemStyle-BackColor="#EEEEEE"
      BorderColor="black" cellpadding=3
      AutoGenerateColumns="False" DataKeyField="學號"
      OnDeleteCommand="deleteBook"
       HeaderStyle-ForeColor=#FFFFFF
        HeaderStyle-Font-Bold
      runat="Server">
   <Columns>
  <asp:ButtonColumn HeaderText="刪除欄位" ButtonType="PushButton"
          Text="刪除" CommandName="delete"/>
       <asp:BoundColumn DataField="學號" HeaderText="學號" ReadOnly="True"/>  
       <asp:BoundColumn DataField="姓名" HeaderText="姓名" />  
       <asp:BoundColumn DataField="班級" HeaderText="班級" />  
       <asp:BoundColumn DataField="電話" HeaderText="電話" />  
  </Columns></asp:DataGrid>
     </div>
    </form>
</body>
</html>
