
Partial Class ch3_1_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim t, x, total As Short
        total = 1
        x = Val(TextBox1.Text)
        For t = 1 To x
            total = total * t
        Next t
        TextBox2.Text = total
    End Sub
End Class
