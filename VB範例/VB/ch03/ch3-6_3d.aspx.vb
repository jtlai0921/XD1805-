
Partial Class ch3_6_3d
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) 'Handles Button1.Click
        Dim x As Integer = 0
        Dim sum As Integer = 0
        Do Until x > 10
            sum = sum + x
            x = x + 1
        Loop
        MsgBox("Sum=" & sum)
    End Sub
End Class
