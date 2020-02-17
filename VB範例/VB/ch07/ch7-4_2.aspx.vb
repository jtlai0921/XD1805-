
Partial Class ch7_4_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Response.Write("您的電腦IP是：" & Request.ServerVariables("REMOTE_ADDR"))
    End Sub
End Class
