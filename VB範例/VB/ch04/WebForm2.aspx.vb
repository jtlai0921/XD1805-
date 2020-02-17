
Partial Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label1.Text = "張三說：" & Request.Form("TextBox1")
    End Sub
End Class
