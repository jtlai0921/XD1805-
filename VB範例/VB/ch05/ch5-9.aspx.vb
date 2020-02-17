
Partial Class ch5_9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Panel1.Visible = "False"
        Panel2.Visible = "False"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = "True"
        Panel2.Visible = "False"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = "False"
        Panel2.Visible = "True"
    End Sub
End Class
