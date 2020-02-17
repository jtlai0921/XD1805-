Imports System.IO
Partial Class ch13_3_1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Path As String = Server.MapPath("FileSystem")
        Dim t As Integer
        Dim DirInfo As DirectoryInfo = New DirectoryInfo(Path)
        ' 取得資料夾清單
        Dim GetSubDirs() As DirectoryInfo = DirInfo.GetDirectories()
        Response.Write("目前FileSystem目錄有下列的資料夾子目錄：<br>")
        For t = 0 To GetSubDirs.Length - 1
            Response.Write(GetSubDirs(t).Name & "<br/>")
        Next t
    End Sub
End Class
