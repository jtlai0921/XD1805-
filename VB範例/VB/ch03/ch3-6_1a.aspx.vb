
Partial Class ch3_6_1a
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Score As Integer = 60
        If Score = 60 Then
            Response.Write(Score & "分剛好及格了")
        End If
    End Sub
End Class
