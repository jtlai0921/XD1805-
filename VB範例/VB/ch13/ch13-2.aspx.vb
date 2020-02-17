Imports System.IO
Partial Class ch13_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim path1, path2 As String
        path1 = Request.ServerVariables("PATH_INFO")
        path2 = Server.MapPath(path1)
        Response.Write("目前執行程式所在位置：<br>" & path2)
    End Sub
End Class
