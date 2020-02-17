<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    Function get_table(ByVal SelectCmd As String) As Object
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        Dim DtApter As OleDbDataAdapter = New OleDbDataAdapter(SelectCmd, conn)
        Dim DtSet As DataSet = New DataSet
        DtApter.Fill(DtSet, "table01")
        Dim m_tb As DataTable
        m_tb = DtSet.Tables("table01")  '從暫存區讀取表格
        Return m_tb
        conn.Close()
    End Function

    Function edit_data(ByVal SelectCmd As String) As String
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Cmd.ExecuteNonQuery()
        conn.Close()
    End Function
</script>


