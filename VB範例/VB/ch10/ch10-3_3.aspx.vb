
Partial Class ch10_3_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        AccessDataSource2.Insert()
    End Sub
End Class
