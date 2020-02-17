Imports System.Data
Imports System.Data.OleDb
Partial Class ch8_2_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim dbpath As String = "C:\Inetpub\wwwroot\VB\ch08\App_Data\DBMS.mdb"    '宣告資料庫所在的路徑變數
        Dim Source As String                 '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim conn As OleDbConnection          '宣告連線的物件
        conn = New OleDbConnection(Source)   '連線
        conn.Open()          '開啟資料庫
        Response.Write("<H2> ASP.NET 連線Access測試 </H2>")
        Response.Write("<HR>")
        Response.Write("<H3> 成功連結到Access的伺服器 </H3>")
        conn.Close()         '關閉資料庫
    End Sub
End Class
