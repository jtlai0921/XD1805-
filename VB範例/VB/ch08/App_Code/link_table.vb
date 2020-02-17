Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Public Class link_table
    Inherits System.Web.UI.Page
    Public Function get_table(ByVal SelectCmd As String) As Object
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

    Public Function edit_data(ByVal SelectCmd As String) As String
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
End Class
