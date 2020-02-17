Imports System.IO
Partial Class ch13_3_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim OldDir As String = Server.MapPath("FileSystem\test3")
        Directory.Delete(OldDir)
        Response.Write("您已經刪除了test3資料夾")
    End Sub
End Class
