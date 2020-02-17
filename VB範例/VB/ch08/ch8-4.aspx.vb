Imports System.Data
Imports System.Data.OleDb
Partial Class ch8_4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        Dim SelectCmd As String
        SelectCmd = "select * from 學生資料表"
        '宣告物件
        Dim DtApter As OleDbDataAdapter = New OleDbDataAdapter(SelectCmd, conn)
        Dim DtSet As DataSet = New DataSet
        '讀取資料表
        DtApter.Fill(DtSet, "學生資料表")
        new_grid.DataSource = DtSet
        new_grid.DataBind()
        conn.Close()         '關閉資料庫
    End Sub
End Class
