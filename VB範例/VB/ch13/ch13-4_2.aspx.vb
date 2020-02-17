Imports System.IO
Partial Class ch13_4_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Path As String = Server.MapPath("FileSystem\text3文字檔.txt ")
        ' 建立FileInfo物件
        Dim FileInfo As FileInfo = New FileInfo(Path)
        If FileInfo.Exists Then
            Response.Write("檔案：" & Path & "　已經存在!")
        Else
            Response.Write("檔案" & Path & "　不存在!")
        End If
    End Sub
End Class
