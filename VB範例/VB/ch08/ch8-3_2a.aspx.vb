Imports System.Data
Imports System.Data.OleDb
Partial Class ch8_3_2a
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
        Dim i As Integer
        SelectCmd = "select * from 學生資料表"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        Response.Write("<table border=1 align=center>")
        Response.Write("<tr>")
        '顯示資料表欄位名稱
        For i = 0 To reader.FieldCount - 1
            Response.Write("<td aling=center>" & reader.GetName(i) & "</td>")
        Next i
        Response.Write("</tr>")
        '顯示資料表欄位的所有資料
        While reader.Read()
            Response.Write("<tr align=center>")
            For i = 0 To reader.FieldCount - 1
                Response.Write("<td>" & reader.Item(i) & "</td>")
            Next i
            Response.Write("</tr>")
        End While
        Response.Write("</table>")
        conn.Close()         '關閉資料庫
    End Sub
End Class
