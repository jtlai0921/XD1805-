
Partial Class ch4_4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String
        Username = TextBox1.Text
        Password = TextBox2.Text
        If Username = "Benson" And Password = "123456" Then
            MsgBox("您是合法使用者！")
        End If
    End Sub
End Class
