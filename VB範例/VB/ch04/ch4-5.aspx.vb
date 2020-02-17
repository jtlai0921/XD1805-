
Partial Class ch4_5
    Inherits System.Web.UI.Page

    Protected Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Num As Integer
        Num = Val(TextBox1.Text)
        If Num Mod 2 = 0 Then
            Label1.Text = Num & "是偶數"
        Else
            Label1.Text = Num & "是奇數"
        End If
    End Sub
End Class
