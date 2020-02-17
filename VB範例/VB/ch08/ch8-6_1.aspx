<!-- #Include File = "link_table.aspx" -->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    Dim SelectCmd As String = "select * from 學生資料表"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not IsPostBack Then
            new_grid.DataSource = get_table(SelectCmd)
            new_grid.DataBind()
        End If
    End Sub
    Sub edit_data(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        new_grid.EditItemIndex = e.Item.ItemIndex
        new_grid.DataSource = get_table(SelectCmd)
        new_grid.DataBind()
    End Sub
    Sub e_cancel(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        new_grid.EditItemIndex = -1
        new_grid.DataSource = get_table(SelectCmd)
        new_grid.DataBind()
    End Sub
    Sub e_update(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        Dim t1 As TextBox = e.Item.Cells(3).Controls(0)
        Dim UpdateCmd = "UPDATE 學生資料表 "
        UpdateCmd += "SET 電話 = " & t1.Text
        UpdateCmd += " WHERE 學號 = '" & new_grid.DataKeys(e.Item.ItemIndex) & "'"
        edit_data(UpdateCmd)
        new_grid.EditItemIndex = -1
        new_grid.DataSource = get_table(SelectCmd)
        new_grid.DataBind()
    End Sub

    '傳送資料副程式
    Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs)
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\ASPNET\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫                           
        Dim InsertCmd As String
        InsertCmd = "Insert Into 學生資料表(學號,姓名,班級,電話) Values('" & Student_ID.Text.Trim() & "','" & Student_Name.Text.Trim() & "','" & Student_ClassRoom.Text.Trim() & "','" & Student_Tel.Text.Trim() & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()                              ' 關閉資料庫
        Response.Redirect("ch8-6_1.aspx")
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>未命名頁面</title>
</head>
<body>
    <form id="form1" runat="server">
  <table border="1" id="table1">
    <tr><td colspan="2">新增學生基本資料</td></tr>
  	<tr>
  		<td>學號</td>
  		<td><asp:TextBox ID="Student_ID" runat="server"/></td>
  	</tr>
  	<tr>
  	    <td>姓名</td><td><asp:TextBox ID="Student_Name" runat="server"/></td>
  	</tr>
  	<tr>
  		<td>班級</td><td><asp:TextBox ID="Student_ClassRoom" runat="server"/></td>
  	</tr>
  	<tr>
  		<td>電話</td><td><asp:TextBox ID="Student_Tel" runat="server"/></td>
  	</tr>
  	<tr><td colspan="2">
       <asp:Button id="btnSend" runat="server" Text="確定新增" onClick="btnSend_Click"/></td>
  	</tr>
  </table> 
   <asp:datagrid id = "new_grid"  runat="server" 
        BorderWidth = "1"  CellPadding = "2" 
        AutoGenerateColumns = "False" 
        DataKeyField =  "學號"
        OnEditCommand = "edit_data" 
        OnCancelCommand = "e_cancel" 
        OnUpdateCommand = "e_update">
     <Columns>
       <asp:BoundColumn DataField="學號" HeaderText="學號" ReadOnly = "True"/>  
       <asp:BoundColumn DataField="姓名" HeaderText="姓名" ReadOnly = "True"/>  
       <asp:BoundColumn DataField="班級" HeaderText="班級" ReadOnly = "True"/>  
       <asp:BoundColumn DataField="電話" HeaderText="電話" />
       <asp:EditCommandColumn HeaderText = "修改欄位" 
             Buttontype = "PushButton" 
             Edittext = "編輯" CancelText = "取消" UpdateText = "儲存" />
    </Columns>
   </asp:datagrid>
    </form>
</body>
</html>
