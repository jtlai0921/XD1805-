
Partial Class ch7_4_1a
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim TeaName As String = Request.QueryString("name")
        Response.Write("老師姓名：" & TeaName)
    End Sub
End Class
