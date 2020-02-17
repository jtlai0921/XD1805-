Imports System.IO
Partial Class ch13_4_1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Path As String = Server.MapPath("FileSystem\text3文字檔.txt")
        ' 建立FileInfo物件
        Dim FileInfo As FileInfo = New FileInfo(Path)
        ' 建立文字檔案
        FileInfo.CreateText()
        Response.Write("您目前建立的檔案為：<br> " & Path)
    End Sub
End Class
