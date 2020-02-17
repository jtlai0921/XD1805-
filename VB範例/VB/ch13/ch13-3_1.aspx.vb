Imports System.IO
Partial Class ch13_3_1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim NewDir As String = Server.MapPath("FileSystem\test3")
        Directory.CreateDirectory(NewDir)
        Response.Write("您目前建立的目錄為：<br> " & NewDir)
    End Sub
End Class
