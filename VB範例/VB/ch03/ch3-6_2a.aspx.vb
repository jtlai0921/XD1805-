
Partial Class ch3_6_2a
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim A As Integer
        A = Val(TextBox1.Text)
        If A Mod 2 = 0 Then
            TextBox2.Text = "偶數"
        Else
            TextBox2.Text = "奇數"
        End If
    End Sub
End Class
