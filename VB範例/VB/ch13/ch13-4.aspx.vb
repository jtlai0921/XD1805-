Imports System.IO
Partial Class ch13_4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Path As String = Server.MapPath("FileSystem")
        Dim DirInfo As DirectoryInfo = New DirectoryInfo(Path)
        ' 取得檔案清單
        Dim GetSubFiles() As FileInfo = DirInfo.GetFiles()
        Response.Write("目前FileSystem目錄有下列的檔案：<br>")
        Dim GetSubFile As FileInfo
        For Each GetSubFile In GetSubFiles
            Response.Write(GetSubFile.Name & "<br/>")
        Next
    End Sub
End Class
